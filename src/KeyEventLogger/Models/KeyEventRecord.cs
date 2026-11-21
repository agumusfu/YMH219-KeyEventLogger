namespace KeyEventLogger.Models;

/// <summary>
/// Klavye üzerinde gerçekleşen tekil bir olayı temsil eden veri modeli (Data Model).
/// Nesne yönelimli programlama prensiplerine uygun olarak zaman, tuş bilgisi,
/// tuş kodu, olay türü ve değiştirici tuş durumlarını kapsüller (Encapsulation).
/// </summary>
public class KeyEventRecord
{
    public int Id { get; init; }
    public DateTime Timestamp { get; init; }
    public string EventType { get; init; } = "KeyDown";
    public string KeyName { get; init; } = string.Empty;
    public int KeyCode { get; init; }
    public string Modifiers { get; init; } = "Yok";
    public string Category { get; init; } = "Diğer";

    public KeyEventRecord(int id, DateTime timestamp, string eventType, Keys keys, Keys modifiers)
    {
        Id = id;
        Timestamp = timestamp;
        EventType = eventType;
        KeyCode = (int)keys;
        KeyName = DetermineFriendlyKeyName(keys);
        Modifiers = DetermineModifiersString(modifiers);
        Category = CategorizeKey(keys);
    }

    /// <summary>
    /// Tuşun daha anlaşılır ve kullanıcı dostu bir Türkçe/Evrensel adını üretir.
    /// </summary>
    private static string DetermineFriendlyKeyName(Keys key)
    {
        return key switch
        {
            Keys.Space => "Boşluk (Space)",
            Keys.Return => "Giriş (Enter)",
            Keys.Back => "Geri Silme (Backspace)",
            Keys.Tab => "Sekme (Tab)",
            Keys.Escape => "Çıkış (Esc)",
            Keys.Delete => "Sil (Delete)",
            Keys.Insert => "Araya Ekle (Insert)",
            Keys.Home => "Başa Git (Home)",
            Keys.End => "Sona Git (End)",
            Keys.PageUp => "Sayfa Yukarı (Page Up)",
            Keys.PageDown => "Sayfa Aşağı (Page Down)",
            Keys.Left => "Sol Yön (←)",
            Keys.Up => "Yukarı Yön (↑)",
            Keys.Right => "Sağ Yön (→)",
            Keys.Down => "Aşağı Yön (↓)",
            Keys.ShiftKey or Keys.LShiftKey or Keys.RShiftKey => "Shift Tuşu",
            Keys.ControlKey or Keys.LControlKey or Keys.RControlKey => "Ctrl Tuşu",
            Keys.Menu or Keys.LMenu or Keys.RMenu => "Alt Tuşu",
            Keys.Capital => "Büyük/Küçük Harf (Caps Lock)",
            Keys.D0 => "0",
            Keys.D1 => "1",
            Keys.D2 => "2",
            Keys.D3 => "3",
            Keys.D4 => "4",
            Keys.D5 => "5",
            Keys.D6 => "6",
            Keys.D7 => "7",
            Keys.D8 => "8",
            Keys.D9 => "9",
            _ => key.ToString()
        };
    }

    /// <summary>
    /// Aktif olan değiştirici (Ctrl, Alt, Shift) tuş kombinasyonunu metne döker.
    /// </summary>
    private static string DetermineModifiersString(Keys modifiers)
    {
        var list = new List<string>();
        if ((modifiers & Keys.Control) == Keys.Control) list.Add("Ctrl");
        if ((modifiers & Keys.Alt) == Keys.Alt) list.Add("Alt");
        if ((modifiers & Keys.Shift) == Keys.Shift) list.Add("Shift");

        return list.Count > 0 ? string.Join(" + ", list) : "Yok";
    }

    /// <summary>
    /// Tuşu işlevine göre kategorize eder (İstatistiksel analiz için).
    /// </summary>
    private static string CategorizeKey(Keys key)
    {
        if ((key >= Keys.A && key <= Keys.Z) || (key >= Keys.D0 && key <= Keys.D9) || (key >= Keys.NumPad0 && key <= Keys.NumPad9))
            return "Alfanümerik (Harf/Rakam)";

        if (key is Keys.Left or Keys.Right or Keys.Up or Keys.Down or Keys.PageUp or Keys.PageDown or Keys.Home or Keys.End)
            return "Gezinme / Yön";

        if (key >= Keys.F1 && key <= Keys.F24)
            return "Fonksiyon (F Tuşları)";

        if (key is Keys.ShiftKey or Keys.ControlKey or Keys.Menu or Keys.LWin or Keys.RWin or Keys.Capital)
            return "Değiştirici / Kilit";

        if (key is Keys.Return or Keys.Space or Keys.Back or Keys.Tab or Keys.Escape or Keys.Delete)
            return "Metin Denetimi";

        return "Özel / Sembol";
    }

    /// <summary>
    /// ListBox veya ekranda gösterim için formatlı metin.
    /// </summary>
    public string ToFormattedString()
    {
        return $"[{Timestamp:HH:mm:ss.fff}] [{EventType,-7}] Tuş: {KeyName,-18} | Kod: {KeyCode,-3} | Değiştirici: {Modifiers,-10} | Kategori: {Category}";
    }

    /// <summary>
    /// Dosyaya (.txt) kaydedilirken kullanılacak düzenli tablo satırı formatı.
    /// </summary>
    public string ToExportRow()
    {
        return $"{Id,4} | {Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {EventType,-7} | {KeyName,-20} | {KeyCode,5} | {Modifiers,-14} | {Category}";
    }
}
