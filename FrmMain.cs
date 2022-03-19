using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PcShutdownApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int count = 0;
        DateTime dt;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ++count;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //21:45 ten sonra çalışmaya devam edilecekse uygulama kapatılacak
            if (count == 2)
                Application.Exit();
            else
            {
                tmStart.Enabled = false;
                this.Visible = false;
                count += 1;
                dt = DateTime.Now.AddMinutes(210);
                tmRetry.Enabled = true;
            }
        }

        private void shutDownPc()
        {
            Process.Start("shutdown", "/s /f /t 0");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            shutDownPc();
        }

        private void tmStart_Tick(object sender, EventArgs e)
        {
            shutDownPc();
        }

        private void tmRetry_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Subtract(dt).TotalMinutes > 0)
            {
                tmRetry.Enabled = false;
                tmStart.Enabled = true;
                this.Visible = true;
            }
        }
    }
}
