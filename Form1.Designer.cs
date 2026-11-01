namespace plane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pbLight = new PictureBox();
            pbPlane = new PictureBox();
            btnEnis = new Button();
            btnTurbulans = new Button();
            btnTesekkurler = new Button();
            btnKemerler = new Button();
            btnBeep = new Button();
            btnOnOff = new Button();
            btnGas = new Button();
            btnBreak = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlane).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pbLight);
            panel1.Controls.Add(pbPlane);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 552);
            panel1.TabIndex = 0;
            // 
            // pbLight
            // 
            pbLight.Image = Properties.Resources.isiq;
            pbLight.Location = new Point(93, 279);
            pbLight.Name = "pbLight";
            pbLight.Size = new Size(93, 42);
            pbLight.SizeMode = PictureBoxSizeMode.Zoom;
            pbLight.TabIndex = 1;
            pbLight.TabStop = false;
            // 
            // pbPlane
            // 
            pbPlane.Image = Properties.Resources.təyyarə;
            pbPlane.Location = new Point(44, 327);
            pbPlane.Name = "pbPlane";
            pbPlane.Size = new Size(199, 183);
            pbPlane.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlane.TabIndex = 0;
            pbPlane.TabStop = false;
            // 
            // btnEnis
            // 
            btnEnis.BackColor = Color.FromArgb(255, 128, 0);
            btnEnis.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEnis.Location = new Point(307, 12);
            btnEnis.Name = "btnEnis";
            btnEnis.Size = new Size(487, 59);
            btnEnis.TabIndex = 1;
            btnEnis.Text = "Eniş hazırlığı";
            btnEnis.UseVisualStyleBackColor = false;
            btnEnis.Click += btnEnis_Click;
            // 
            // btnTurbulans
            // 
            btnTurbulans.BackColor = Color.FromArgb(255, 128, 0);
            btnTurbulans.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnTurbulans.Location = new Point(307, 87);
            btnTurbulans.Name = "btnTurbulans";
            btnTurbulans.Size = new Size(487, 59);
            btnTurbulans.TabIndex = 2;
            btnTurbulans.Text = "Turbulans";
            btnTurbulans.UseVisualStyleBackColor = false;
            btnTurbulans.Click += btnTurbulans_Click;
            // 
            // btnTesekkurler
            // 
            btnTesekkurler.BackColor = Color.FromArgb(255, 128, 0);
            btnTesekkurler.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnTesekkurler.Location = new Point(307, 235);
            btnTesekkurler.Name = "btnTesekkurler";
            btnTesekkurler.Size = new Size(487, 59);
            btnTesekkurler.TabIndex = 4;
            btnTesekkurler.Text = "Təşəkkürlər";
            btnTesekkurler.UseVisualStyleBackColor = false;
            btnTesekkurler.Click += btnTesekkurler_Click;
            // 
            // btnKemerler
            // 
            btnKemerler.BackColor = Color.FromArgb(255, 128, 0);
            btnKemerler.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnKemerler.Location = new Point(307, 161);
            btnKemerler.Name = "btnKemerler";
            btnKemerler.Size = new Size(487, 59);
            btnKemerler.TabIndex = 3;
            btnKemerler.Text = "Kəmərlər";
            btnKemerler.UseVisualStyleBackColor = false;
            btnKemerler.Click += btnKemerler_Click;
            // 
            // btnBeep
            // 
            btnBeep.BackColor = Color.FromArgb(255, 128, 0);
            btnBeep.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnBeep.Location = new Point(307, 310);
            btnBeep.Name = "btnBeep";
            btnBeep.Size = new Size(487, 59);
            btnBeep.TabIndex = 5;
            btnBeep.Text = "Beep";
            btnBeep.UseVisualStyleBackColor = false;
            btnBeep.Click += btnBeep_Click;
            // 
            // btnOnOff
            // 
            btnOnOff.BackColor = Color.FromArgb(0, 0, 192);
            btnOnOff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnOnOff.ForeColor = SystemColors.ButtonHighlight;
            btnOnOff.Location = new Point(307, 494);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(487, 59);
            btnOnOff.TabIndex = 6;
            btnOnOff.Text = "ON/OFF";
            btnOnOff.UseVisualStyleBackColor = false;
            btnOnOff.Click += btnOnOff_Click;
            // 
            // btnGas
            // 
            btnGas.BackColor = Color.Green;
            btnGas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnGas.ForeColor = SystemColors.ButtonHighlight;
            btnGas.Location = new Point(352, 400);
            btnGas.Name = "btnGas";
            btnGas.Size = new Size(156, 88);
            btnGas.TabIndex = 7;
            btnGas.Text = "GAS";
            btnGas.UseVisualStyleBackColor = false;
            btnGas.Click += btnGas_Click;
            // 
            // btnBreak
            // 
            btnBreak.BackColor = Color.Red;
            btnBreak.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnBreak.ForeColor = SystemColors.ButtonHighlight;
            btnBreak.Location = new Point(590, 400);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(156, 88);
            btnBreak.TabIndex = 8;
            btnBreak.Text = "Break";
            btnBreak.UseVisualStyleBackColor = false;
            btnBreak.Click += btnBreak_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(btnBreak);
            Controls.Add(btnGas);
            Controls.Add(btnOnOff);
            Controls.Add(btnBeep);
            Controls.Add(btnTesekkurler);
            Controls.Add(btnKemerler);
            Controls.Add(btnTurbulans);
            Controls.Add(btnEnis);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Plane";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlane).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbLight;
        private PictureBox pbPlane;
        private Button btnEnis;
        private Button btnTurbulans;
        private Button btnTesekkurler;
        private Button btnKemerler;
        private Button btnBeep;
        private Button btnOnOff;
        private Button btnGas;
        private Button btnBreak;
    }
}
