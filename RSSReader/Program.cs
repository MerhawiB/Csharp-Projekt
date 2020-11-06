
using System;

namespace RSSReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
           
            System.Windows.Forms.Application.Run(new frmRss());
        }
    }

}
