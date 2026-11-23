namespace KeyEventLogger;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Panel topBarPanel;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnExport;
    private System.Windows.Forms.Label lblStatusBadge;
    private System.Windows.Forms.Panel noticePanel;
    private System.Windows.Forms.Label lblNotice;
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.GroupBox grpVisualKey;
    private System.Windows.Forms.Panel pnlKeyBadge;
    private System.Windows.Forms.Label lblKeyDisplay;
    private System.Windows.Forms.Label lblKeyCodeDisplay;
    private System.Windows.Forms.Label lblKeyModifiersDisplay;
    private System.Windows.Forms.Label lblKeyEventTypeBadge;
    private System.Windows.Forms.GroupBox grpQuickStats;
    private System.Windows.Forms.Label lblStatTotal;
    private System.Windows.Forms.Label lblStatTopKey;
    private System.Windows.Forms.Label lblStatRatio;
    private System.Windows.Forms.GroupBox grpFilter;
    private System.Windows.Forms.Label lblFilterSearch;
    private System.Windows.Forms.TextBox txtFilterSearch;
    private System.Windows.Forms.Label lblFilterType;
    private System.Windows.Forms.ComboBox cmbFilterType;
    private System.Windows.Forms.DateTimePicker dtpFilterFrom;
    private System.Windows.Forms.DateTimePicker dtpFilterTo;
    private System.Windows.Forms.Label lblFilterFrom;
    private System.Windows.Forms.Label lblFilterTo;
    private System.Windows.Forms.Button btnApplyFilter;
    private System.Windows.Forms.Button btnResetFilter;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabLogs;
    private System.Windows.Forms.DataGridView dgvLogs;
    private System.Windows.Forms.Panel pnlLogTools;
    private System.Windows.Forms.CheckBox chkAutoScroll;
    private System.Windows.Forms.Label lblLogCount;
    private System.Windows.Forms.TabPage tabStats;
    private System.Windows.Forms.RichTextBox rtbStats;
    private System.Windows.Forms.Button btnRefreshStats;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusLabelState;
    private System.Windows.Forms.ToolStripStatusLabel statusLabelCount;
    private System.Windows.Forms.ToolStripStatusLabel statusLabelTips;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dgvRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
        topBarPanel = new System.Windows.Forms.Panel();
        btnStart = new System.Windows.Forms.Button();
        btnStop = new System.Windows.Forms.Button();
        btnClear = new System.Windows.Forms.Button();
        btnExport = new System.Windows.Forms.Button();
        lblStatusBadge = new System.Windows.Forms.Label();
        noticePanel = new System.Windows.Forms.Panel();
        lblNotice = new System.Windows.Forms.Label();
        splitContainer = new System.Windows.Forms.SplitContainer();
        grpVisualKey = new System.Windows.Forms.GroupBox();
        pnlKeyBadge = new System.Windows.Forms.Panel();
        lblKeyDisplay = new System.Windows.Forms.Label();
        lblKeyCodeDisplay = new System.Windows.Forms.Label();
        lblKeyModifiersDisplay = new System.Windows.Forms.Label();
        lblKeyEventTypeBadge = new System.Windows.Forms.Label();
        grpQuickStats = new System.Windows.Forms.GroupBox();
        lblStatTotal = new System.Windows.Forms.Label();
        lblStatTopKey = new System.Windows.Forms.Label();
        lblStatRatio = new System.Windows.Forms.Label();
        grpFilter = new System.Windows.Forms.GroupBox();
        lblFilterSearch = new System.Windows.Forms.Label();
        txtFilterSearch = new System.Windows.Forms.TextBox();
        lblFilterType = new System.Windows.Forms.Label();
        cmbFilterType = new System.Windows.Forms.ComboBox();
        lblFilterFrom = new System.Windows.Forms.Label();
        dtpFilterFrom = new System.Windows.Forms.DateTimePicker();
        lblFilterTo = new System.Windows.Forms.Label();
        dtpFilterTo = new System.Windows.Forms.DateTimePicker();
        btnApplyFilter = new System.Windows.Forms.Button();
        btnResetFilter = new System.Windows.Forms.Button();
        tabControl = new System.Windows.Forms.TabControl();
        tabLogs = new System.Windows.Forms.TabPage();
        dgvLogs = new System.Windows.Forms.DataGridView();
        pnlLogTools = new System.Windows.Forms.Panel();
        chkAutoScroll = new System.Windows.Forms.CheckBox();
        lblLogCount = new System.Windows.Forms.Label();
        tabStats = new System.Windows.Forms.TabPage();
        rtbStats = new System.Windows.Forms.RichTextBox();
        btnRefreshStats = new System.Windows.Forms.Button();
        statusStrip = new System.Windows.Forms.StatusStrip();
        statusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
        statusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
        statusLabelTips = new System.Windows.Forms.ToolStripStatusLabel();
        topBarPanel.SuspendLayout();
        noticePanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
        splitContainer.Panel1.SuspendLayout();
        splitContainer.Panel2.SuspendLayout();
        splitContainer.SuspendLayout();
        grpVisualKey.SuspendLayout();
        pnlKeyBadge.SuspendLayout();
        grpQuickStats.SuspendLayout();
        grpFilter.SuspendLayout();
        tabControl.SuspendLayout();
        tabLogs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
        pnlLogTools.SuspendLayout();
        tabStats.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // topBarPanel
        // 
        topBarPanel.BackColor = System.Drawing.Color.FromArgb(47, 53, 66);
        topBarPanel.Controls.Add(btnStart);
        topBarPanel.Controls.Add(btnStop);
        topBarPanel.Controls.Add(btnClear);
        topBarPanel.Controls.Add(btnExport);
        topBarPanel.Controls.Add(lblStatusBadge);
        topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
        topBarPanel.Location = new System.Drawing.Point(0, 0);
        topBarPanel.Name = "topBarPanel";
        topBarPanel.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
        topBarPanel.Size = new System.Drawing.Size(964, 52);
        topBarPanel.TabIndex = 0;
        // 
        // btnStart
        // 
        btnStart.BackColor = System.Drawing.Color.FromArgb(46, 213, 115);
        btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
        btnStart.FlatAppearance.BorderSize = 0;
        btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
        btnStart.ForeColor = System.Drawing.Color.White;
        btnStart.Location = new System.Drawing.Point(12, 10);
        btnStart.Name = "btnStart";
        btnStart.Size = new System.Drawing.Size(120, 32);
        btnStart.TabIndex = 0;
        btnStart.TabStop = false;
        btnStart.Text = "▶ Kaydı Başlat";
        btnStart.UseVisualStyleBackColor = false;
        btnStart.Click += BtnStart_Click;
        // 
        // btnStop
        // 
        btnStop.BackColor = System.Drawing.Color.FromArgb(255, 71, 87);
        btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnStop.FlatAppearance.BorderSize = 0;
        btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnStop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
        btnStop.ForeColor = System.Drawing.Color.White;
        btnStop.Location = new System.Drawing.Point(140, 10);
        btnStop.Name = "btnStop";
        btnStop.Size = new System.Drawing.Size(120, 32);
        btnStop.TabIndex = 1;
        btnStop.TabStop = false;
        btnStop.Text = "⏹ Kaydı Durdur";
        btnStop.UseVisualStyleBackColor = false;
        btnStop.Click += BtnStop_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = System.Drawing.Color.FromArgb(116, 125, 140);
        btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClear.FlatAppearance.BorderSize = 0;
        btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
        btnClear.ForeColor = System.Drawing.Color.White;
        btnClear.Location = new System.Drawing.Point(268, 10);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(95, 32);
        btnClear.TabIndex = 2;
        btnClear.TabStop = false;
        btnClear.Text = "🗑 Temizle";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += BtnClear_Click;
        // 
        // btnExport
        // 
        btnExport.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExport.FlatAppearance.BorderSize = 0;
        btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
        btnExport.ForeColor = System.Drawing.Color.White;
        btnExport.Location = new System.Drawing.Point(371, 10);
        btnExport.Name = "btnExport";
        btnExport.Size = new System.Drawing.Size(145, 32);
        btnExport.TabIndex = 3;
        btnExport.TabStop = false;
        btnExport.Text = "💾 .txt Olarak Kaydet";
        btnExport.UseVisualStyleBackColor = false;
        btnExport.Click += BtnExport_Click;
        // 
        // lblStatusBadge
        // 
        lblStatusBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(46, 213, 115);
        lblStatusBadge.Font = new System.Drawing.Font("Segoe UI Bold", 9.5F);
        lblStatusBadge.ForeColor = System.Drawing.Color.White;
        lblStatusBadge.Location = new System.Drawing.Point(744, 11);
        lblStatusBadge.Name = "lblStatusBadge";
        lblStatusBadge.Size = new System.Drawing.Size(208, 30);
        lblStatusBadge.TabIndex = 4;
        lblStatusBadge.Text = "● KAYIT AKTİF (DİNLENİYOR)";
        lblStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // noticePanel
        // 
        noticePanel.BackColor = System.Drawing.Color.FromArgb(254, 249, 231);
        noticePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        noticePanel.Controls.Add(lblNotice);
        noticePanel.Dock = System.Windows.Forms.DockStyle.Top;
        noticePanel.Location = new System.Drawing.Point(0, 52);
        noticePanel.Name = "noticePanel";
        noticePanel.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
        noticePanel.Size = new System.Drawing.Size(964, 34);
        noticePanel.TabIndex = 1;
        // 
        // lblNotice
        // 
        lblNotice.AutoSize = true;
        lblNotice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
        lblNotice.ForeColor = System.Drawing.Color.FromArgb(125, 102, 8);
        lblNotice.Location = new System.Drawing.Point(8, 8);
        lblNotice.Name = "lblNotice";
        lblNotice.Size = new System.Drawing.Size(780, 15);
        lblNotice.TabIndex = 0;
        lblNotice.Text = "🛡️ Güvenlik Sınırı: Bu uygulama eğitsel amaçlıdır. Yalnızca bu pencere odaktayken Windows Forms klavye olaylarını yakalar; sistem geneli dinleme yapmaz.";
        // 
        // splitContainer
        // 
        splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
        splitContainer.Location = new System.Drawing.Point(0, 86);
        splitContainer.Name = "splitContainer";
        // 
        // splitContainer.Panel1
        // 
        splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(241, 242, 246);
        splitContainer.Panel1.Controls.Add(grpFilter);
        splitContainer.Panel1.Controls.Add(grpQuickStats);
        splitContainer.Panel1.Controls.Add(grpVisualKey);
        splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(8);
        // 
        // splitContainer.Panel2
        // 
        splitContainer.Panel2.Controls.Add(tabControl);
        splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(8);
        splitContainer.Size = new System.Drawing.Size(964, 528);
        splitContainer.SplitterDistance = 295;
        splitContainer.TabIndex = 2;
        // 
        // grpVisualKey
        // 
        grpVisualKey.Controls.Add(pnlKeyBadge);
        grpVisualKey.Dock = System.Windows.Forms.DockStyle.Top;
        grpVisualKey.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
        grpVisualKey.ForeColor = System.Drawing.Color.FromArgb(47, 53, 66);
        grpVisualKey.Location = new System.Drawing.Point(8, 8);
        grpVisualKey.Name = "grpVisualKey";
        grpVisualKey.Size = new System.Drawing.Size(279, 155);
        grpVisualKey.TabIndex = 0;
        grpVisualKey.TabStop = false;
        grpVisualKey.Text = "Son Basılan Tuş Göstergesi";
        // 
        // pnlKeyBadge
        // 
        pnlKeyBadge.BackColor = System.Drawing.Color.FromArgb(223, 228, 234);
        pnlKeyBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlKeyBadge.Controls.Add(lblKeyDisplay);
        pnlKeyBadge.Controls.Add(lblKeyCodeDisplay);
        pnlKeyBadge.Controls.Add(lblKeyModifiersDisplay);
        pnlKeyBadge.Controls.Add(lblKeyEventTypeBadge);
        pnlKeyBadge.Location = new System.Drawing.Point(12, 22);
        pnlKeyBadge.Name = "pnlKeyBadge";
        pnlKeyBadge.Size = new System.Drawing.Size(255, 120);
        pnlKeyBadge.TabIndex = 0;
        // 
        // lblKeyDisplay
        // 
        lblKeyDisplay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblKeyDisplay.ForeColor = System.Drawing.Color.FromArgb(47, 53, 66);
        lblKeyDisplay.Location = new System.Drawing.Point(6, 6);
        lblKeyDisplay.Name = "lblKeyDisplay";
        lblKeyDisplay.Size = new System.Drawing.Size(241, 35);
        lblKeyDisplay.TabIndex = 0;
        lblKeyDisplay.Text = "Tuş Bekleniyor...";
        lblKeyDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblKeyCodeDisplay
        // 
        lblKeyCodeDisplay.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblKeyCodeDisplay.ForeColor = System.Drawing.Color.FromArgb(87, 96, 111);
        lblKeyCodeDisplay.Location = new System.Drawing.Point(6, 44);
        lblKeyCodeDisplay.Name = "lblKeyCodeDisplay";
        lblKeyCodeDisplay.Size = new System.Drawing.Size(241, 20);
        lblKeyCodeDisplay.TabIndex = 1;
        lblKeyCodeDisplay.Text = "Sanal Tuş Kodu: -";
        lblKeyCodeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblKeyModifiersDisplay
        // 
        lblKeyModifiersDisplay.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblKeyModifiersDisplay.ForeColor = System.Drawing.Color.FromArgb(87, 96, 111);
        lblKeyModifiersDisplay.Location = new System.Drawing.Point(6, 66);
        lblKeyModifiersDisplay.Name = "lblKeyModifiersDisplay";
        lblKeyModifiersDisplay.Size = new System.Drawing.Size(241, 20);
        lblKeyModifiersDisplay.TabIndex = 2;
        lblKeyModifiersDisplay.Text = "Değiştirici: Yok";
        lblKeyModifiersDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblKeyEventTypeBadge
        // 
        lblKeyEventTypeBadge.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        lblKeyEventTypeBadge.Font = new System.Drawing.Font("Segoe UI Bold", 8F);
        lblKeyEventTypeBadge.ForeColor = System.Drawing.Color.White;
        lblKeyEventTypeBadge.Location = new System.Drawing.Point(55, 90);
        lblKeyEventTypeBadge.Name = "lblKeyEventTypeBadge";
        lblKeyEventTypeBadge.Size = new System.Drawing.Size(145, 20);
        lblKeyEventTypeBadge.TabIndex = 3;
        lblKeyEventTypeBadge.Text = "BEKLEMEDE";
        lblKeyEventTypeBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // grpQuickStats
        // 
        grpQuickStats.Controls.Add(lblStatTotal);
        grpQuickStats.Controls.Add(lblStatTopKey);
        grpQuickStats.Controls.Add(lblStatRatio);
        grpQuickStats.Dock = System.Windows.Forms.DockStyle.Top;
        grpQuickStats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
        grpQuickStats.ForeColor = System.Drawing.Color.FromArgb(47, 53, 66);
        grpQuickStats.Location = new System.Drawing.Point(8, 163);
        grpQuickStats.Name = "grpQuickStats";
        grpQuickStats.Size = new System.Drawing.Size(279, 105);
        grpQuickStats.TabIndex = 1;
        grpQuickStats.TabStop = false;
        grpQuickStats.Text = "Hızlı İstatistikler";
        // 
        // lblStatTotal
        // 
        lblStatTotal.AutoSize = true;
        lblStatTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStatTotal.Location = new System.Drawing.Point(12, 24);
        lblStatTotal.Name = "lblStatTotal";
        lblStatTotal.Size = new System.Drawing.Size(130, 15);
        lblStatTotal.TabIndex = 0;
        lblStatTotal.Text = "Toplam Olay Sayısı: 0";
        // 
        // lblStatRatio
        // 
        lblStatRatio.AutoSize = true;
        lblStatRatio.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatRatio.Location = new System.Drawing.Point(12, 48);
        lblStatRatio.Name = "lblStatRatio";
        lblStatRatio.Size = new System.Drawing.Size(147, 15);
        lblStatRatio.TabIndex = 1;
        lblStatRatio.Text = "KeyDown: 0 | KeyUp: 0";
        // 
        // lblStatTopKey
        // 
        lblStatTopKey.AutoSize = true;
        lblStatTopKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatTopKey.Location = new System.Drawing.Point(12, 73);
        lblStatTopKey.Name = "lblStatTopKey";
        lblStatTopKey.Size = new System.Drawing.Size(134, 15);
        lblStatTopKey.TabIndex = 2;
        lblStatTopKey.Text = "En Sık Basılan Tuş: -";
        // 
        // grpFilter
        // 
        grpFilter.Controls.Add(lblFilterSearch);
        grpFilter.Controls.Add(txtFilterSearch);
        grpFilter.Controls.Add(lblFilterType);
        grpFilter.Controls.Add(cmbFilterType);
        grpFilter.Controls.Add(lblFilterFrom);
        grpFilter.Controls.Add(dtpFilterFrom);
        grpFilter.Controls.Add(lblFilterTo);
        grpFilter.Controls.Add(dtpFilterTo);
        grpFilter.Controls.Add(btnApplyFilter);
        grpFilter.Controls.Add(btnResetFilter);
        grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
        grpFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
        grpFilter.ForeColor = System.Drawing.Color.FromArgb(47, 53, 66);
        grpFilter.Location = new System.Drawing.Point(8, 268);
        grpFilter.Name = "grpFilter";
        grpFilter.Size = new System.Drawing.Size(279, 252);
        grpFilter.TabIndex = 2;
        grpFilter.TabStop = false;
        grpFilter.Text = "Kayıt Filtreleme Paneli";
        // 
        // lblFilterSearch
        // 
        lblFilterSearch.AutoSize = true;
        lblFilterSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblFilterSearch.Location = new System.Drawing.Point(12, 22);
        lblFilterSearch.Name = "lblFilterSearch";
        lblFilterSearch.Size = new System.Drawing.Size(89, 15);
        lblFilterSearch.TabIndex = 0;
        lblFilterSearch.Text = "Tuş Adı / Kodu:";
        // 
        // txtFilterSearch
        // 
        txtFilterSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtFilterSearch.Location = new System.Drawing.Point(12, 39);
        txtFilterSearch.Name = "txtFilterSearch";
        txtFilterSearch.PlaceholderText = "Örn: Space, A, Enter...";
        txtFilterSearch.Size = new System.Drawing.Size(255, 23);
        txtFilterSearch.TabIndex = 1;
        txtFilterSearch.TabStop = false;
        // 
        // lblFilterType
        // 
        lblFilterType.AutoSize = true;
        lblFilterType.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblFilterType.Location = new System.Drawing.Point(12, 69);
        lblFilterType.Name = "lblFilterType";
        lblFilterType.Size = new System.Drawing.Size(65, 15);
        lblFilterType.TabIndex = 2;
        lblFilterType.Text = "Olay Türü:";
        // 
        // cmbFilterType
        // 
        cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbFilterType.Font = new System.Drawing.Font("Segoe UI", 9F);
        cmbFilterType.FormattingEnabled = true;
        cmbFilterType.Items.AddRange(new object[] { "Tümü", "KeyDown", "KeyUp" });
        cmbFilterType.Location = new System.Drawing.Point(12, 86);
        cmbFilterType.Name = "cmbFilterType";
        cmbFilterType.Size = new System.Drawing.Size(255, 23);
        cmbFilterType.TabIndex = 3;
        cmbFilterType.TabStop = false;
        // 
        // lblFilterFrom
        // 
        lblFilterFrom.AutoSize = true;
        lblFilterFrom.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblFilterFrom.Location = new System.Drawing.Point(12, 116);
        lblFilterFrom.Name = "lblFilterFrom";
        lblFilterFrom.Size = new System.Drawing.Size(91, 15);
        lblFilterFrom.TabIndex = 4;
        lblFilterFrom.Text = "Başlangıç Saati:";
        // 
        // dtpFilterFrom
        // 
        dtpFilterFrom.CustomFormat = "HH:mm:ss";
        dtpFilterFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
        dtpFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpFilterFrom.Location = new System.Drawing.Point(12, 133);
        dtpFilterFrom.Name = "dtpFilterFrom";
        dtpFilterFrom.ShowUpDown = true;
        dtpFilterFrom.Size = new System.Drawing.Size(255, 23);
        dtpFilterFrom.TabIndex = 5;
        dtpFilterFrom.TabStop = false;
        // 
        // lblFilterTo
        // 
        lblFilterTo.AutoSize = true;
        lblFilterTo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblFilterTo.Location = new System.Drawing.Point(12, 163);
        lblFilterTo.Name = "lblFilterTo";
        lblFilterTo.Size = new System.Drawing.Size(64, 15);
        lblFilterTo.TabIndex = 6;
        lblFilterTo.Text = "Bitiş Saati:";
        // 
        // dtpFilterTo
        // 
        dtpFilterTo.CustomFormat = "HH:mm:ss";
        dtpFilterTo.Font = new System.Drawing.Font("Segoe UI", 9F);
        dtpFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpFilterTo.Location = new System.Drawing.Point(12, 180);
        dtpFilterTo.Name = "dtpFilterTo";
        dtpFilterTo.ShowUpDown = true;
        dtpFilterTo.Size = new System.Drawing.Size(255, 23);
        dtpFilterTo.TabIndex = 7;
        dtpFilterTo.TabStop = false;
        // 
        // btnApplyFilter
        // 
        btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(74, 105, 189);
        btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
        btnApplyFilter.FlatAppearance.BorderSize = 0;
        btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnApplyFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
        btnApplyFilter.ForeColor = System.Drawing.Color.White;
        btnApplyFilter.Location = new System.Drawing.Point(12, 214);
        btnApplyFilter.Name = "btnApplyFilter";
        btnApplyFilter.Size = new System.Drawing.Size(122, 28);
        btnApplyFilter.TabIndex = 8;
        btnApplyFilter.TabStop = false;
        btnApplyFilter.Text = "🔍 Filtrele";
        btnApplyFilter.UseVisualStyleBackColor = false;
        btnApplyFilter.Click += BtnApplyFilter_Click;
        // 
        // btnResetFilter
        // 
        btnResetFilter.BackColor = System.Drawing.Color.FromArgb(164, 176, 190);
        btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
        btnResetFilter.FlatAppearance.BorderSize = 0;
        btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnResetFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
        btnResetFilter.ForeColor = System.Drawing.Color.White;
        btnResetFilter.Location = new System.Drawing.Point(145, 214);
        btnResetFilter.Name = "btnResetFilter";
        btnResetFilter.Size = new System.Drawing.Size(122, 28);
        btnResetFilter.TabIndex = 9;
        btnResetFilter.TabStop = false;
        btnResetFilter.Text = "🔄 Sıfırla";
        btnResetFilter.UseVisualStyleBackColor = false;
        btnResetFilter.Click += BtnResetFilter_Click;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabLogs);
        tabControl.Controls.Add(tabStats);
        tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabControl.Location = new System.Drawing.Point(8, 8);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new System.Drawing.Size(649, 512);
        tabControl.TabIndex = 0;
        tabControl.TabStop = false;
        tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
        // 
        // tabLogs
        // 
        tabLogs.Controls.Add(dgvLogs);
        tabLogs.Controls.Add(pnlLogTools);
        tabLogs.Location = new System.Drawing.Point(4, 25);
        tabLogs.Name = "tabLogs";
        tabLogs.Padding = new System.Windows.Forms.Padding(6);
        tabLogs.Size = new System.Drawing.Size(641, 483);
        tabLogs.TabIndex = 0;
        tabLogs.Text = "📋 Canlı Olay Günlüğü";
        tabLogs.UseVisualStyleBackColor = true;
        // 
        // dgvLogs
        // 
        dgvLogs.AllowUserToAddRows = false;
        dgvLogs.AllowUserToDeleteRows = false;
        dgvLogs.AllowUserToResizeRows = false;
        dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvLogs.BackgroundColor = System.Drawing.Color.White;
        dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(47, 53, 66);
        dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
        dgvHeaderStyle.ForeColor = System.Drawing.Color.White;
        dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(47, 53, 66);
        dgvHeaderStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dgvLogs.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvLogs.ColumnHeadersHeight = 32;
        dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvRowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dgvRowStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        dgvRowStyle.ForeColor = System.Drawing.Color.Black;
        dgvRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 252);
        dgvRowStyle.SelectionForeColor = System.Drawing.Color.Black;
        dgvLogs.DefaultCellStyle = dgvRowStyle;
        dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvLogs.EnableHeadersVisualStyles = false;
        dgvLogs.Location = new System.Drawing.Point(6, 6);
        dgvLogs.Name = "dgvLogs";
        dgvLogs.ReadOnly = true;
        dgvLogs.RowHeadersVisible = false;
        dgvLogs.RowTemplate.Height = 26;
        dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvLogs.Size = new System.Drawing.Size(629, 440);
        dgvLogs.TabIndex = 0;
        dgvLogs.TabStop = false;
        // 
        // pnlLogTools
        // 
        pnlLogTools.Controls.Add(chkAutoScroll);
        pnlLogTools.Controls.Add(lblLogCount);
        pnlLogTools.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlLogTools.Location = new System.Drawing.Point(6, 446);
        pnlLogTools.Name = "pnlLogTools";
        pnlLogTools.Size = new System.Drawing.Size(629, 31);
        pnlLogTools.TabIndex = 1;
        // 
        // chkAutoScroll
        // 
        chkAutoScroll.AutoSize = true;
        chkAutoScroll.Checked = true;
        chkAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
        chkAutoScroll.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        chkAutoScroll.ForeColor = System.Drawing.Color.FromArgb(47, 53, 66);
        chkAutoScroll.Location = new System.Drawing.Point(4, 8);
        chkAutoScroll.Name = "chkAutoScroll";
        chkAutoScroll.Size = new System.Drawing.Size(193, 19);
        chkAutoScroll.TabIndex = 0;
        chkAutoScroll.TabStop = false;
        chkAutoScroll.Text = "Son Olayı Otomatik Göster (Kaydır)";
        chkAutoScroll.UseVisualStyleBackColor = true;
        // 
        // lblLogCount
        // 
        lblLogCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        lblLogCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblLogCount.ForeColor = System.Drawing.Color.FromArgb(87, 96, 111);
        lblLogCount.Location = new System.Drawing.Point(389, 7);
        lblLogCount.Name = "lblLogCount";
        lblLogCount.Size = new System.Drawing.Size(236, 18);
        lblLogCount.TabIndex = 1;
        lblLogCount.Text = "Gösterilen: 0 olay";
        lblLogCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tabStats
        // 
        tabStats.Controls.Add(rtbStats);
        tabStats.Controls.Add(btnRefreshStats);
        tabStats.Location = new System.Drawing.Point(4, 25);
        tabStats.Name = "tabStats";
        tabStats.Padding = new System.Windows.Forms.Padding(8);
        tabStats.Size = new System.Drawing.Size(641, 483);
        tabStats.TabIndex = 1;
        tabStats.Text = "📊 Detaylı İstatistikler & Rapor";
        tabStats.UseVisualStyleBackColor = true;
        // 
        // rtbStats
        // 
        rtbStats.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
        rtbStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
        rtbStats.Dock = System.Windows.Forms.DockStyle.Fill;
        rtbStats.Font = new System.Drawing.Font("Consolas", 10F);
        rtbStats.ForeColor = System.Drawing.Color.FromArgb(47, 53, 66);
        rtbStats.Location = new System.Drawing.Point(8, 8);
        rtbStats.Name = "rtbStats";
        rtbStats.ReadOnly = true;
        rtbStats.Size = new System.Drawing.Size(625, 431);
        rtbStats.TabIndex = 0;
        rtbStats.TabStop = false;
        rtbStats.Text = "";
        // 
        // btnRefreshStats
        // 
        btnRefreshStats.BackColor = System.Drawing.Color.FromArgb(74, 105, 189);
        btnRefreshStats.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRefreshStats.Dock = System.Windows.Forms.DockStyle.Bottom;
        btnRefreshStats.FlatAppearance.BorderSize = 0;
        btnRefreshStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRefreshStats.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
        btnRefreshStats.ForeColor = System.Drawing.Color.White;
        btnRefreshStats.Location = new System.Drawing.Point(8, 439);
        btnRefreshStats.Name = "btnRefreshStats";
        btnRefreshStats.Size = new System.Drawing.Size(625, 36);
        btnRefreshStats.TabIndex = 1;
        btnRefreshStats.TabStop = false;
        btnRefreshStats.Text = "🔄 İstatistikleri Yenile";
        btnRefreshStats.UseVisualStyleBackColor = false;
        btnRefreshStats.Click += BtnRefreshStats_Click;
        // 
        // statusStrip
        // 
        statusStrip.BackColor = System.Drawing.Color.FromArgb(47, 53, 66);
        statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
        statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            statusLabelState,
            statusLabelCount,
            statusLabelTips
        });
        statusStrip.Location = new System.Drawing.Point(0, 614);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new System.Drawing.Size(964, 24);
        statusStrip.TabIndex = 3;
        // 
        // statusLabelState
        // 
        statusLabelState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
        statusLabelState.ForeColor = System.Drawing.Color.FromArgb(46, 213, 115);
        statusLabelState.Name = "statusLabelState";
        statusLabelState.Size = new System.Drawing.Size(120, 19);
        statusLabelState.Text = "Kayıt Durumu: Aktif";
        // 
        // statusLabelCount
        // 
        statusLabelCount.ForeColor = System.Drawing.Color.FromArgb(223, 228, 234);
        statusLabelCount.Margin = new System.Windows.Forms.Padding(15, 3, 0, 2);
        statusLabelCount.Name = "statusLabelCount";
        statusLabelCount.Size = new System.Drawing.Size(107, 19);
        statusLabelCount.Text = "Toplam Kayıt: 0 adet";
        // 
        // statusLabelTips
        // 
        statusLabelTips.ForeColor = System.Drawing.Color.FromArgb(164, 176, 190);
        statusLabelTips.Name = "statusLabelTips";
        statusLabelTips.Size = new System.Drawing.Size(707, 19);
        statusLabelTips.Spring = true;
        statusLabelTips.Text = "Klavye olaylarını test etmek için form penceresine tıklayıp tuşlara basınız.";
        statusLabelTips.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(964, 638);
        Controls.Add(splitContainer);
        Controls.Add(statusStrip);
        Controls.Add(noticePanel);
        Controls.Add(topBarPanel);
        KeyPreview = true;
        MinimumSize = new System.Drawing.Size(820, 560);
        Name = "MainForm";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "YMH219 - Key Event Logger (Eğitsel Klavye Olay Kaydedici)";
        KeyDown += MainForm_KeyDown;
        KeyUp += MainForm_KeyUp;
        topBarPanel.ResumeLayout(false);
        noticePanel.ResumeLayout(false);
        noticePanel.PerformLayout();
        splitContainer.Panel1.ResumeLayout(false);
        splitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
        splitContainer.ResumeLayout(false);
        grpVisualKey.ResumeLayout(false);
        pnlKeyBadge.ResumeLayout(false);
        grpQuickStats.ResumeLayout(false);
        grpQuickStats.PerformLayout();
        grpFilter.ResumeLayout(false);
        grpFilter.PerformLayout();
        tabControl.ResumeLayout(false);
        tabLogs.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
        pnlLogTools.ResumeLayout(false);
        pnlLogTools.PerformLayout();
        tabStats.ResumeLayout(false);
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
