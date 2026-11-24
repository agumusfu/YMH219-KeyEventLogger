using System.Data;
using KeyEventLogger.Models;
using KeyEventLogger.Services;

namespace KeyEventLogger;

public partial class MainForm : Form
{
    private readonly KeyLogService _logService;
    private readonly FileExportService _exportService;
    private readonly DataTable _table;
    private bool _isFilterActive;

    public MainForm()
    {
        InitializeComponent();

        _logService = new KeyLogService();
        _exportService = new FileExportService();

        // 1. DataGridView Veri Tablosu Kurulumu
        _table = new DataTable();
        _table.Columns.Add("Id", typeof(int));
        _table.Columns.Add("Zaman", typeof(string));
        _table.Columns.Add("Olay", typeof(string));
        _table.Columns.Add("TusAdi", typeof(string));
        _table.Columns.Add("TusKodu", typeof(int));
        _table.Columns.Add("Degistiriciler", typeof(string));
        _table.Columns.Add("Kategori", typeof(string));

        dgvLogs.DataSource = _table;
        SetupGridColumns();

        // 2. Servis Olaylarına Abone Ol
        _logService.KeyRecorded += OnKeyRecorded;
        _logService.LogsCleared += OnLogsCleared;
        _logService.LoggingStateChanged += OnLoggingStateChanged;

        // 3. İlk Kontrol Durumları
        cmbFilterType.SelectedIndex = 0; // "Tümü"
        dtpFilterFrom.Value = DateTime.Today;
        dtpFilterTo.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
        UpdateControlsState(true);
    }

    private void SetupGridColumns()
    {
        if (dgvLogs.Columns["Id"] != null)
        {
            dgvLogs.Columns["Id"]!.HeaderText = "#";
            dgvLogs.Columns["Id"]!.FillWeight = 35;
        }
        if (dgvLogs.Columns["Zaman"] != null)
        {
            dgvLogs.Columns["Zaman"]!.HeaderText = "Zaman";
            dgvLogs.Columns["Zaman"]!.FillWeight = 80;
        }
        if (dgvLogs.Columns["Olay"] != null)
        {
            dgvLogs.Columns["Olay"]!.HeaderText = "Olay Türü";
            dgvLogs.Columns["Olay"]!.FillWeight = 65;
        }
        if (dgvLogs.Columns["TusAdi"] != null)
        {
            dgvLogs.Columns["TusAdi"]!.HeaderText = "Tuş Adı";
            dgvLogs.Columns["TusAdi"]!.FillWeight = 110;
        }
        if (dgvLogs.Columns["TusKodu"] != null)
        {
            dgvLogs.Columns["TusKodu"]!.HeaderText = "Sanal Kod";
            dgvLogs.Columns["TusKodu"]!.FillWeight = 55;
        }
        if (dgvLogs.Columns["Degistiriciler"] != null)
        {
            dgvLogs.Columns["Degistiriciler"]!.HeaderText = "Değiştirici";
            dgvLogs.Columns["Degistiriciler"]!.FillWeight = 75;
        }
        if (dgvLogs.Columns["Kategori"] != null)
        {
            dgvLogs.Columns["Kategori"]!.HeaderText = "Kategori";
            dgvLogs.Columns["Kategori"]!.FillWeight = 100;
        }
    }

    #region Klavye Olay Dinleyicileri (Form Seviyesinde - KeyPreview = true)

    private void MainForm_KeyDown(object? sender, KeyEventArgs e)
    {
        // Hızlı Yönetim Kısayolları (Shortcuts)
        if (e.KeyCode == Keys.F5)
        {
            _logService.StartLogging();
            e.Handled = true;
            return;
        }
        if (e.KeyCode == Keys.F6)
        {
            _logService.StopLogging();
            e.Handled = true;
            return;
        }
        if (e.KeyCode == Keys.F7)
        {
            BtnClear_Click(sender, e);
            e.Handled = true;
            return;
        }
        if (e.Control && e.KeyCode == Keys.S)
        {
            BtnExport_Click(sender, e);
            e.Handled = true;
            return;
        }
        if (e.Control && e.KeyCode == Keys.F)
        {
            txtFilterSearch.Focus();
            txtFilterSearch.SelectAll();
            e.Handled = true;
            return;
        }

        // Yalnızca form açık ve odaktayken yakalanır (Güvenlik Kapsamı)
        var record = _logService.RecordEvent("KeyDown", e.KeyCode, e.Modifiers);
        if (record != null)
        {
            UpdateVisualKeyBadge(record);
        }
    }

    private void MainForm_KeyUp(object? sender, KeyEventArgs e)
    {
        var record = _logService.RecordEvent("KeyUp", e.KeyCode, e.Modifiers);
        if (record != null)
        {
            UpdateVisualKeyBadge(record);
        }
    }

    #endregion

    #region Olay Dinleme ve Görsel Güncellemeler

    private void OnKeyRecorded(KeyEventRecord record)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<KeyEventRecord>(OnKeyRecorded), record);
            return;
        }

        // Eğer filtreleme aktif değilse tabloya doğrudan satır ekle
        if (!_isFilterActive)
        {
            _table.Rows.Add(
                record.Id,
                record.Timestamp.ToString("HH:mm:ss.fff"),
                record.EventType,
                record.KeyName,
                record.KeyCode,
                record.Modifiers,
                record.Category
            );

            if (chkAutoScroll.Checked && dgvLogs.Rows.Count > 0)
            {
                dgvLogs.FirstDisplayedScrollingRowIndex = dgvLogs.Rows.Count - 1;
            }

            lblLogCount.Text = $"Gösterilen: {_table.Rows.Count} olay";
        }

        UpdateQuickStats();
    }

    private void OnLogsCleared()
    {
        if (InvokeRequired)
        {
            Invoke(new Action(OnLogsCleared));
            return;
        }

        _table.Rows.Clear();
        lblLogCount.Text = "Gösterilen: 0 olay";
        lblStatTotal.Text = "Toplam Olay Sayısı: 0";
        lblStatRatio.Text = "KeyDown: 0 | KeyUp: 0";
        lblStatTopKey.Text = "En Sık Basılan Tuş: -";
        statusLabelCount.Text = "Toplam Kayıt: 0 adet";
        rtbStats.Clear();

        lblKeyDisplay.Text = "Tuş Bekleniyor...";
        lblKeyCodeDisplay.Text = "Sanal Tuş Kodu: -";
        lblKeyModifiersDisplay.Text = "Değiştirici: Yok";
        lblKeyEventTypeBadge.Text = "BEKLEMEDE";
        lblKeyEventTypeBadge.BackColor = Color.FromArgb(116, 125, 140);
        pnlKeyBadge.BackColor = Color.FromArgb(223, 228, 234);
    }

    private void OnLoggingStateChanged(bool isLogging)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<bool>(OnLoggingStateChanged), isLogging);
            return;
        }

        UpdateControlsState(isLogging);
    }

    private void UpdateControlsState(bool isLogging)
    {
        btnStart.Enabled = !isLogging;
        btnStop.Enabled = isLogging;

        if (isLogging)
        {
            lblStatusBadge.Text = "● KAYIT AKTİF (DİNLENİYOR)";
            lblStatusBadge.BackColor = Color.FromArgb(46, 213, 115);
            statusLabelState.Text = "Kayıt Durumu: Aktif";
            statusLabelState.ForeColor = Color.FromArgb(46, 213, 115);
        }
        else
        {
            lblStatusBadge.Text = "○ KAYIT DURDURULDU";
            lblStatusBadge.BackColor = Color.FromArgb(255, 71, 87);
            statusLabelState.Text = "Kayıt Durumu: Durduruldu";
            statusLabelState.ForeColor = Color.FromArgb(255, 71, 87);
        }
    }

    private void UpdateVisualKeyBadge(KeyEventRecord record)
    {
        lblKeyDisplay.Text = record.KeyName;
        lblKeyCodeDisplay.Text = $"Sanal Tuş Kodu: {record.KeyCode}";
        lblKeyModifiersDisplay.Text = $"Değiştirici: {record.Modifiers}";
        lblKeyEventTypeBadge.Text = record.EventType.ToUpperInvariant();

        if (record.EventType == "KeyDown")
        {
            lblKeyEventTypeBadge.BackColor = Color.FromArgb(46, 213, 115); // Yeşil
            pnlKeyBadge.BackColor = Color.FromArgb(240, 255, 244);
        }
        else
        {
            lblKeyEventTypeBadge.BackColor = Color.FromArgb(30, 144, 255); // Mavi
            pnlKeyBadge.BackColor = Color.FromArgb(240, 248, 255);
        }
    }

    private void UpdateQuickStats()
    {
        int total = _logService.Records.Count;
        statusLabelCount.Text = $"Toplam Kayıt: {total} adet";
        lblStatTotal.Text = $"Toplam Olay Sayısı: {total}";

        var stats = _logService.CalculateStatistics();
        lblStatRatio.Text = $"KeyDown: {stats.KeyDownCount} | KeyUp: {stats.KeyUpCount}";

        if (stats.TopPressedKeys.Count > 0)
        {
            var top = stats.TopPressedKeys[0];
            lblStatTopKey.Text = $"En Sık Tuş: {top.Key} ({top.Value} kez)";
        }
    }

    #endregion

    #region Üst Bar Butonları

    private void BtnStart_Click(object? sender, EventArgs e)
    {
        _logService.StartLogging();
    }

    private void BtnStop_Click(object? sender, EventArgs e)
    {
        _logService.StopLogging();
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Tüm klavye olay kayıtlarını silmek istediğinize emin misiniz?",
            "Kayıtları Temizle",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _logService.ClearLogs();
        }
    }

    private void BtnExport_Click(object? sender, EventArgs e)
    {
        if (_logService.Records.Count == 0)
        {
            MessageBox.Show(
                "Dışa aktarmak için önce klavyeden bazı tuşlara basarak kayıt oluşturmalısınız.",
                "Kayıt Bulunamadı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        using var sfd = new SaveFileDialog
        {
            Title = "Klavye Kayıtlarını .txt Dosyası Olarak Kaydet",
            Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*",
            FileName = $"KeyEventLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt"
        };

        if (sfd.ShowDialog(this) == DialogResult.OK)
        {
            var stats = _logService.CalculateStatistics();
            var (success, message, _) = _exportService.ExportToTextFile(sfd.FileName, _logService.Records, stats);

            if (success)
            {
                MessageBox.Show(message, "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    #endregion

    #region Filtreleme Paneli (İsteğe Bağlı Geliştirme)

    private void BtnApplyFilter_Click(object? sender, EventArgs e)
    {
        string search = txtFilterSearch.Text.Trim();
        string type = cmbFilterType.SelectedItem?.ToString() ?? "Tümü";
        DateTime from = dtpFilterFrom.Value;
        DateTime to = dtpFilterTo.Value;

        if (from > to)
        {
            MessageBox.Show("Başlangıç saati bitiş saatinden büyük olamaz.", "Geçersiz Zaman Aralığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var filtered = _logService.FilterRecords(from, to, search, type);
        _isFilterActive = true;

        _table.Rows.Clear();
        foreach (var r in filtered)
        {
            _table.Rows.Add(
                r.Id,
                r.Timestamp.ToString("HH:mm:ss.fff"),
                r.EventType,
                r.KeyName,
                r.KeyCode,
                r.Modifiers,
                r.Category
            );
        }

        lblLogCount.Text = $"Filtrelenen: {filtered.Count} / {_logService.Records.Count} olay";
    }

    private void BtnResetFilter_Click(object? sender, EventArgs e)
    {
        txtFilterSearch.Clear();
        cmbFilterType.SelectedIndex = 0;
        dtpFilterFrom.Value = DateTime.Today;
        dtpFilterTo.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
        _isFilterActive = false;

        _table.Rows.Clear();
        foreach (var r in _logService.Records)
        {
            _table.Rows.Add(
                r.Id,
                r.Timestamp.ToString("HH:mm:ss.fff"),
                r.EventType,
                r.KeyName,
                r.KeyCode,
                r.Modifiers,
                r.Category
            );
        }

        lblLogCount.Text = $"Gösterilen: {_logService.Records.Count} olay";
    }

    #endregion

    #region Sekmeler ve İstatistik Ekranı

    private void TabControl_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (tabControl.SelectedTab == tabStats)
        {
            RefreshStatsReport();
        }
    }

    private void BtnRefreshStats_Click(object? sender, EventArgs e)
    {
        RefreshStatsReport();
    }

    private void RefreshStatsReport()
    {
        var stats = _logService.CalculateStatistics();
        rtbStats.Text = stats.GenerateSummaryText();
    }

    #endregion
}
