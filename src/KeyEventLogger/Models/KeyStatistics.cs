namespace KeyEventLogger.Models;

/// <summary>
/// İsteğe bağlı geliştirme: Toplam tuş sayısı ve en sık kullanılan tuşların istatistik modeli.
/// </summary>
public class KeyStatistics
{
    public int TotalEvents { get; set; }
    public int KeyDownCount { get; set; }
    public int KeyUpCount { get; set; }
    public DateTime? FirstRecordedAt { get; set; }
    public DateTime? LastRecordedAt { get; set; }
    public Dictionary<string, int> FrequencyByTuş { get; set; } = new();
    public Dictionary<string, int> DistributionByCategory { get; set; } = new();
    public List<KeyValuePair<string, int>> TopPressedKeys { get; set; } = new();

    /// <summary>
    /// İstatistik özetini kullanıcı dostu bir rapor metnine dönüştürür.
    /// </summary>
    public string GenerateSummaryText()
    {
        if (TotalEvents == 0)
        {
            return "Henüz kayıtlı bir klavye olayı bulunmamaktadır.";
        }

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("════════════════════════════════════════════════════════");
        sb.AppendLine("             KLAVYE OLAY İSTATİSTİK RAPORU             ");
        sb.AppendLine("════════════════════════════════════════════════════════");
        sb.AppendLine($"• Toplam Yakalanan Olay:  {TotalEvents} adet");
        sb.AppendLine($"• Tuşa Basma (KeyDown):   {KeyDownCount} adet");
        sb.AppendLine($"• Tuş Bırakma (KeyUp):    {KeyUpCount} adet");

        if (FirstRecordedAt.HasValue && LastRecordedAt.HasValue)
        {
            var duration = LastRecordedAt.Value - FirstRecordedAt.Value;
            sb.AppendLine($"• Kayıt Başlangıcı:       {FirstRecordedAt:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"• Son Kayıt:              {LastRecordedAt:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"• Toplam Etkinlik Süresi: {duration.TotalSeconds:F1} saniye");
        }

        sb.AppendLine();
        sb.AppendLine("─── EN ÇOK KULLANILAN İLK 5 TUŞ ───");
        int rank = 1;
        foreach (var pair in TopPressedKeys.Take(5))
        {
            double percentage = TotalEvents > 0 ? (pair.Value * 100.0 / TotalEvents) : 0;
            sb.AppendLine($"  {rank}. {pair.Key,-18} : {pair.Value,3} kez (%{percentage:F1})");
            rank++;
        }

        sb.AppendLine();
        sb.AppendLine("─── KATEGORİ DAĞILIMI ───");
        foreach (var cat in DistributionByCategory.OrderByDescending(c => c.Value))
        {
            double percentage = TotalEvents > 0 ? (cat.Value * 100.0 / TotalEvents) : 0;
            sb.AppendLine($"  • {cat.Key,-24} : {cat.Value,3} kez (%{percentage:F1})");
        }
        sb.AppendLine("════════════════════════════════════════════════════════");

        return sb.ToString();
    }
}
