namespace PcShutdownApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.tmStart = new System.Windows.Forms.Timer(this.components);
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.tmRetry = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışmaya devam edecek misiniz?";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(4, 177);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(343, 15);
            this.lblWarning.TabIndex = 31;
            this.lblWarning.Text = "Cevap verilmezse cihazınız 5 dk. sonra otomatik kapanacaktır.";
            // 
            // tmStart
            // 
            this.tmStart.Enabled = true;
            this.tmStart.Interval = 300000;
            this.tmStart.Tick += new System.EventHandler(this.tmStart_Tick);
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::PcShutdownApp.Properties.Resources.Esc_Muh;
            this.pBoxLogo.Location = new System.Drawing.Point(82, -11);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(187, 89);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo.TabIndex = 30;
            this.pBoxLogo.TabStop = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNo.Image = global::PcShutdownApp.Properties.Resources.No;
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.Location = new System.Drawing.Point(183, 120);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(97, 36);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "     Hayır";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.White;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYes.Image = global::PcShutdownApp.Properties.Resources.Yes;
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.Location = new System.Drawing.Point(70, 120);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(97, 36);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "     Evet";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // tmRetry
            // 
            this.tmRetry.Interval = 60000;
            this.tmRetry.Tick += new System.EventHandler(this.tmRetry_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(350, 209);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESC Mesajı";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Timer tmStart;
        private System.Windows.Forms.Timer tmRetry;
    }
}

