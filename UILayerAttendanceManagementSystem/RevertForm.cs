using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace UILayerAttendanceManagementSystem
{
    public partial class RevertForm : Form
    {
        int xLocation = 9;
        int yLocation = 265;
        int formWidth = Screen.PrimaryScreen.WorkingArea.Width - 18;
        int formHeight = Screen.PrimaryScreen.WorkingArea.Height - 234;

      
        
        public RevertForm()
        {
            InitializeComponent();
            int xButtonLocation = (formWidth - okButton.Size.Width) / 2;
            int yButtonLocation = (formHeight - okButton.Size.Height)-5;

            okButton.SetBounds(xButtonLocation, yButtonLocation, okButton.Size.Width, okButton.Size.Height);
        }

        private void RevertForm_Load(object sender, EventArgs e)
        {
            this.SetDesktopBounds(xLocation, yLocation, formWidth, formHeight);
          
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
