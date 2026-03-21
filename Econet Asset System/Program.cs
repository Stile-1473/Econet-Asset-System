// Program.cs
// Purpose: Application entry point. Sets up Visual Styles and starts the app
// 
// - Main() is where Windows hands control to  application
// - ApplicationConfiguration.Initialize() sets defaults (DPI awareness, default fonts) for modern WinForms apps.
// - Instead of passing a Form to Application.Run, we use an ApplicationContext (AppContext) that
//   controls which forms are shown and when the application should exit.

namespace Econet_Asset_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize application configuration (DPI, default fonts, etc.).
            ApplicationConfiguration.Initialize();

            // Run the application with a custom ApplicationContext that handles the splash and login forms.
            Application.Run(new AppContext());
        }
    }
}
