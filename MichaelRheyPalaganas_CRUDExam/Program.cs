using MichaelRheyPalaganas_CRUDExam.Data;

namespace MichaelRheyPalaganas_CRUDExam
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDbContext context = new AppDbContext();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(context));
        }
    }
}