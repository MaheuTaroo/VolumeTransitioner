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
                int? max, min;
                bool? onMax;

                (max, min, onMax) = ExtraFunctions.LoadPreset(args[0]);

                Application.Run(new MainWindow(max ?? (int)AudioManager.GetMasterVolume(), min ?? 0, onMax ?? true));
            }
            else Application.Run(new MainWindow());
        }
    }
}