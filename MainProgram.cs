namespace MissSportInfoUI
{
    internal static class MainProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Console.WriteLine("Hello World!");
            Console.WriteLine("Loading Info...");
            bool isInitialized = DataHandler.Initialization();
            
            if (isInitialized)
            {
                Console.WriteLine("Info loaded successfully!");
                ApplicationConfiguration.Initialize();
                Application.Run(new MainUI());
            }
            else
            {
                Console.WriteLine("Init failed...");
            }
        }
    }
}