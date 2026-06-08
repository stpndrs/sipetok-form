using sipetok_form.Views;
using sipetok_form.Views.Transactions;
using sipetok_form.Views.Users;

namespace sipetok_form
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginView());
            //Application.Run(new DashboardView());
        }
    }
}