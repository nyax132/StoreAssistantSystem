namespace StoreServerSystem
{
    internal static class Program
    {
        public static SASServerWIndow form { get; private set; }
        public const string DataBaseName = "DataBase";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(form = new SASServerWIndow());
        }
    }
}