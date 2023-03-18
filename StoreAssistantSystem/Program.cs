namespace StoreAssistantSystem
{
    internal static class Program
    {
        public static SASWindow SasWindow { get; } = new SASWindow();
        public static string IpAddress { get; set; } = "127.0.0.1";
        public static int Port { get; set; } = 55555;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();

            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(SasWindow);

        }
    }
}