namespace KeyEventLogger;

static class Program
{
    /// <summary>
    /// Uygulamanın ana giriş noktası.
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        catch (Exception ex)
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "startup_error.log");
            File.WriteAllText(logPath, ex.ToString());
            MessageBox.Show(ex.Message, "Başlatma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }    
}
