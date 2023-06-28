namespace StoreAssistantSystem
{
    internal static class Program
    {
        public static SASWindow SasWindow { get; private set; }
        public static string IpAddress { get; } = Properties.Settings1.Default.IPaddress;
        public static int Port { get; } = Properties.Settings1.Default.Port;
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
            Application.Run(SasWindow = new SASWindow());

        }
    }
}