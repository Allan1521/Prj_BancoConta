using Prj_BancoConta.Demo;
namespace Prj_BancoConta
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
            //Application.Run(new Form_GestãodeContas());

            Application.Run(new FrmDemo());
        }
    }

    }
