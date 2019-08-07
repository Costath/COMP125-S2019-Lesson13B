using COMP125_S2019_Lesson13B_Part2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP125_S2019_Lesson13B_Part2
{
    public static class Program
    {
        public static MyMDIParent parentForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            parentForm = new MyMDIParent();

            Application.Run(parentForm);
        }
    }
}
