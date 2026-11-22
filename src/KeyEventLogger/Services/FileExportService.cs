using System.Text;
using KeyEventLogger.Models;

namespace KeyEventLogger.Services;

/// <summary>
/// Kayıtları StreamWriter kullanarak yerel bir .txt dosyasına güvenli şekilde
/// aktaran dosya yönetim servisi (File I/O).
/// </summary>
public class FileExportService
{
    /// <summary>
    /// Verilen olay kayıtlarını ve istatistik özetini belirtilen dosya yoluna UTF-8 formatında yazar.
    /// </summary>
    public (bool Success, string Message, string? FilePath) ExportToTextFile(string targetPath, IEnumerable<KeyEventRecord> records, KeyStatistics? stats = null)
    {
        try
        {
            var recordList = records.ToList();
            if (recordList.Count == 0)
            {
                return (false, "Dışa aktarılacak herhangi bir kayıt bulunmuyor.", null);
            }

            string? directory = Path.GetDirectoryName(targetPath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Föy gereksinimi: StreamWriter kullanarak dosya yazma
            using (var writer = new StreamWriter(targetPath, false, Encoding.UTF8))
            {
                writer.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                writer.WriteLine("║               YMH219 - KEY EVENT LOGGER (EĞİTSEL KLAVYE OLAY RAPORU)                     ║");
                writer.WriteLine("╠══════════════════════════════════════════════════════════════════════════════════════════╣");
                writer.WriteLine($"║ Dışa Aktarılma Tarihi: {DateTime.Now:yyyy-MM-dd HH:mm:ss}                                                 ║");
                writer.WriteLine($"║ Toplam Kayıt Sayısı:   {recordList.Count,-65} ║");
                writer.WriteLine("║ Kapsam: Yalnızca uygulama penceresi odaktayken üretilen eğitim amaçlı olaylar.           ║");
                writer.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════╝");
                writer.WriteLine();

                // Tablo başlıkları
                writer.WriteLine("SIRA | ZAMAN                   | OLAY    | TUŞ ADI              |  KOD | DEĞİŞTİRİCİLER | KATEGORİ");
                writer.WriteLine("─────┼─────────────────────────┼─────────┼──────────────────────┼──────┼────────────────┼──────────────────────");

                foreach (var r in recordList)
                {
                    writer.WriteLine(r.ToExportRow());
                }

                writer.WriteLine();
                if (stats != null)
                {
                    writer.WriteLine(stats.GenerateSummaryText());
                }
            }

            return (true, $"Kayıtlar başarıyla kaydedildi:\n{targetPath}", targetPath);
        }
        catch (UnauthorizedAccessException ex)
        {
            return (false, $"Dosya yazma izni reddedildi: {ex.Message}", null);
        }
        catch (IOException ex)
        {
            return (false, $"Giriş/Çıkış hatası oluştu: {ex.Message}", null);
        }
        catch (Exception ex)
        {
            return (false, $"Beklenmedik bir hata oluştu: {ex.Message}", null);
        }
    }
}
