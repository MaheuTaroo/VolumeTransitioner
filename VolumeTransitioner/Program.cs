using VolumeTransitioner.Audio;

namespace VolumeTransitioner
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (args.Length > 0) 
            {
                (decimal max, decimal min, bool onMax) = ExtraFunctions.LoadPreset(args[0]);
                Application.Run(new MainWindow(max, min, onMax));
            }
            else Application.Run(new MainWindow());
        }
    }
}