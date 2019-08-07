using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP125_S2019_Lesson13B_Part3.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabCount)
            {
                MainTabControl.SelectedIndex++;
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex > 0)
            {
                MainTabControl.SelectedIndex--;
            }
            
        }
    }
}
