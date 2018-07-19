namespace Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox12 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox13 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton28 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 505);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bunifuThinButton28);
            this.panel5.Controls.Add(this.bunifuCustomLabel17);
            this.panel5.Controls.Add(this.bunifuCustomLabel18);
            this.panel5.Controls.Add(this.bunifuMaterialTextbox12);
            this.panel5.Controls.Add(this.bunifuMaterialTextbox13);
            this.panel5.Location = new System.Drawing.Point(249, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 360);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(5, 129);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(78, 20);
            this.bunifuCustomLabel17.TabIndex = 10;
            this.bunifuCustomLabel17.Text = "Password";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(5, 33);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(89, 20);
            this.bunifuCustomLabel18.TabIndex = 9;
            this.bunifuCustomLabel18.Text = "User Name";
            // 
            // bunifuMaterialTextbox12
            // 
            this.bunifuMaterialTextbox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox12.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox12.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox12.HintText = "";
            this.bunifuMaterialTextbox12.isPassword = false;
            this.bunifuMaterialTextbox12.LineFocusedColor = System.Drawing.Color.Azure;
            this.bunifuMaterialTextbox12.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox12.LineMouseHoverColor = System.Drawing.Color.Azure;
            this.bunifuMaterialTextbox12.LineThickness = 3;
            this.bunifuMaterialTextbox12.Location = new System.Drawing.Point(9, 158);
            this.bunifuMaterialTextbox12.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox12.Name = "bunifuMaterialTextbox12";
            this.bunifuMaterialTextbox12.Size = new System.Drawing.Size(311, 33);
            this.bunifuMaterialTextbox12.TabIndex = 8;
            this.bunifuMaterialTextbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox13
            // 
            this.bunifuMaterialTextbox13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox13.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox13.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox13.HintText = "";
            this.bunifuMaterialTextbox13.isPassword = false;
            this.bunifuMaterialTextbox13.LineFocusedColor = System.Drawing.Color.Azure;
            this.bunifuMaterialTextbox13.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox13.LineMouseHoverColor = System.Drawing.Color.Azure;
            this.bunifuMaterialTextbox13.LineThickness = 3;
            this.bunifuMaterialTextbox13.Location = new System.Drawing.Point(9, 57);
            this.bunifuMaterialTextbox13.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox13.Name = "bunifuMaterialTextbox13";
            this.bunifuMaterialTextbox13.Size = new System.Drawing.Size(311, 33);
            this.bunifuMaterialTextbox13.TabIndex = 7;
            this.bunifuMaterialTextbox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton28
            // 
            this.bunifuThinButton28.ActiveBorderThickness = 1;
            this.bunifuThinButton28.ActiveCornerRadius = 20;
            this.bunifuThinButton28.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton28.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton28.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.bunifuThinButton28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton28.BackgroundImage")));
            this.bunifuThinButton28.ButtonText = "Login";
            this.bunifuThinButton28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuThinButton28.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton28.IdleBorderThickness = 1;
            this.bunifuThinButton28.IdleCornerRadius = 20;
            this.bunifuThinButton28.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton28.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton28.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton28.Location = new System.Drawing.Point(86, 265);
            this.bunifuThinButton28.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton28.Name = "bunifuThinButton28";
            this.bunifuThinButton28.Size = new System.Drawing.Size(150, 41);
            this.bunifuThinButton28.TabIndex = 6;
            this.bunifuThinButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton28.Click += new System.EventHandler(this.bunifuThinButton28_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.Shutdown_25px;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(778, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project.Properties.Resources.esd_logo_retina;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(23, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 133);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(816, 505);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton28;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox13;
    }
}

