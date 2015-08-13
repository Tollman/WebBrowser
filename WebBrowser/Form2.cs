using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace WebBrowser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            //webBrowser2.Document.Write("UUPPSS");
            webBrowser2.ObjectForScripting = "widgetj.js";
        }
      
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                Hide();
            }
        }
    
    }
}
