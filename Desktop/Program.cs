using System;
using System.Windows.Forms;

namespace ModalTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new ModalTesterForm());
            }
            catch (Exception e)
            {
                MessageBox.Show("There was a fatal error in the program! please screenshot this and send it to the developers!" + Environment.NewLine + Environment.NewLine + e.ToString());
            }
        }
    }
}
