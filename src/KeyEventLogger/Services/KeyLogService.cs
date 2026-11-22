using KeyEventLogger.Models;

namespace KeyEventLogger.Services;

/// <summary>
/// Klavye olaylarının yakalanmasını, hafızada saklanmasını, filtrelenmesini
/// ve istatistiklerinin çıkarılmasını yöneten servis sınıfı (Single Responsibility).
/// </summary>
public class KeyLogService
{
    private readonly List<KeyEventRecord> _records = new();
    private int _nextId = 1;

    public bool IsLogging { get; private set; } = true; // Varsayılan: Açılışta aktif
    public IReadOnlyList<KeyEventRecord> Records => _records.AsReadOnly();

    public event Action<KeyEventRecord>? KeyRecorded;
    public event Action? LogsCleared;
    public event Action<bool>? LoggingStateChanged;

    public void StartLogging()
    {
        if (IsLogging) return;
        IsLogging = true;
        LoggingStateChanged?.Invoke(true);
    }

    public void StopLogging()
    {
        if (!IsLogging) return;
        IsLogging = false;
        LoggingStateChanged?.Invoke(false);
    }

    public void ClearLogs()
    {
        _records.Clear();
        _nextId = 1;
        LogsCleared?.Invoke();
    }

    /// <summary>
    /// Sadece form odaklandığında Form olayları (KeyDown / KeyUp) üzerinden çağrılır.
    /// Güvenlik sınırlarına tam uygundur (Global hook içermez).
    /// </summary>
    public KeyEventRecord? RecordEvent(string eventType, Keys keys, Keys modifiers)
    {
        if (!IsLogging)
            return null;

        var record = new KeyEventRecord(_nextId++, DateTime.Now, eventType, keys, modifiers);
        _records.Add(record);
        KeyRecorded?.Invoke(record);
        return record;
    }

    /// <summary>
    /// Kayıtlı klavye verilerinden kapsamlı istatistikler üretir.
    /// </summary>
    public KeyStatistics CalculateStatistics()
    {
        var stats = new KeyStatistics
        {
            TotalEvents = _records.Count,
            KeyDownCount = _records.Count(r => r.EventType == "KeyDown"),
            KeyUpCount = _records.Count(r => r.EventType == "KeyUp"),
            FirstRecordedAt = _records.FirstOrDefault()?.Timestamp,
            LastRecordedAt = _records.LastOrDefault()?.Timestamp
        };

        // Tuş sıklığı haritası (KeyDown bazlı değerlendirilir)
        var keyDowns = _records.Where(r => r.EventType == "KeyDown").ToList();
        foreach (var r in keyDowns)
        {
            if (stats.FrequencyByTuş.ContainsKey(r.KeyName))
                stats.FrequencyByTuş[r.KeyName]++;
            else
                stats.FrequencyByTuş[r.KeyName] = 1;

            if (stats.DistributionByCategory.ContainsKey(r.Category))
                stats.DistributionByCategory[r.Category]++;
            else
                stats.DistributionByCategory[r.Category] = 1;
        }

        stats.TopPressedKeys = stats.FrequencyByTuş
            .OrderByDescending(kv => kv.Value)
            .Take(10)
            .ToList();

        return stats;
    }

    /// <summary>
    /// İsteğe bağlı geliştirme: Tarih/saat aralığı, tuş adı veya olay türüne göre filtreleme.
    /// </summary>
    public List<KeyEventRecord> FilterRecords(DateTime? from, DateTime? to, string? searchKey, string? eventType)
    {
        var query = _records.AsEnumerable();

        if (from.HasValue)
            query = query.Where(r => r.Timestamp >= from.Value);

        if (to.HasValue)
            query = query.Where(r => r.Timestamp <= to.Value);

        if (!string.IsNullOrWhiteSpace(searchKey))
            query = query.Where(r => r.KeyName.Contains(searchKey, StringComparison.OrdinalIgnoreCase) ||
                                     r.KeyCode.ToString().Contains(searchKey));

        if (!string.IsNullOrWhiteSpace(eventType) && eventType != "Tümü")
            query = query.Where(r => r.EventType.Equals(eventType, StringComparison.OrdinalIgnoreCase));

        return query.ToList();
    }
}
