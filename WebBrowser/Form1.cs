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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            //webBrowser1.Document.Write("UUPPSS");
            webBrowser1.ObjectForScripting = "widgetj.js";
        }
        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }
        private void notifyIcon1_MouseSingleClick(object sender, MouseEventArgs e)
        {
            //Show();
            //WindowState = FormWindowState.Normal;
            base.SetVisibleCore(true);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                Hide();
            }
        }
        /*private void OnMinimize()
        {
            this.Hide();   // Do your stuff
        }
        protected override void WndProc(ref Message m)
        {
            // Trap WM_SYSCOMMAND, SC_MINIMIZE
            if (m.Msg == 0x112 && m.WParam.ToInt32() == 0xf020)
            {
                OnMinimize();
                return;        // NOTE: delete if you still want the default behavior
            }
            base.WndProc(ref m);
        }*/
    }
}
