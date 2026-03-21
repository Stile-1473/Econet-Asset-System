// AppContext.cs
// Purpose: Manages the application's top-level forms and lifetime

// - ApplicationContext is a way to run a WinForms application without tying the message loop to a single Form
// - This class shows the splash screen first, and when the splash closes it creates and shows the login form
//   and sets it as the MainForm so the application remains running until the login form closes.
// - Using an ApplicationContext avoids the problem where closing the first form passed to Application.Run
//   would exit the app immediately.

using System;
using System.Windows.Forms;

namespace Econet_Asset_System
{
    internal class AppContext : ApplicationContext
    {
        public AppContext()
        {
            // Create the splash and keep it as the current MainForm so the app stays alive.
            var splash = new SplashLoader();
            MainForm = splash;

            // When the splash closes, construct and show the login form and make it the new MainForm.
            // Exiting the login form will call ExitThread() and terminate the application.
            splash.FormClosed += (s, e) =>
            {
                var login = new Forms.Authentication.AuthLoginForm();
                login.FormClosed += (s2, e2) => ExitThread();

                MainForm = login;
                login.Show();
            };

            // Show the splash non-modally; the ApplicationContext keeps the app alive.
            splash.Show();
        }
    }
}
