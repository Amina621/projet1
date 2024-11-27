namespace projet1
{
    partial class delivery
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
            this.label2 = new System.Windows.Forms.Label();
            this.LProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VProgressBar = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(123, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobisoft Version 1.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LProgressBar
            // 
            this.LProgressBar.FillColor = System.Drawing.Color.Violet;
            this.LProgressBar.Location = new System.Drawing.Point(-1, 243);
            this.LProgressBar.Name = "LProgressBar";
            this.LProgressBar.ProgressColor = System.Drawing.Color.White;
            this.LProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.LProgressBar.Size = new System.Drawing.Size(500, 10);
            this.LProgressBar.TabIndex = 6;
            this.LProgressBar.Text = "guna2ProgressBar1";
            this.LProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VProgressBar
            // 
            this.VProgressBar.FillColor = System.Drawing.Color.Violet;
            this.VProgressBar.Location = new System.Drawing.Point(36, -2);
            this.VProgressBar.Name = "VProgressBar";
            this.VProgressBar.ProgressColor = System.Drawing.Color.White;
            this.VProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.VProgressBar.Size = new System.Drawing.Size(10, 300);
            this.VProgressBar.TabIndex = 9;
            this.VProgressBar.Text = "guna2VProgressBar1";
            this.VProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projet1.Properties.Resources.icons8_shopping_trolley_641;
            this.pictureBox1.Location = new System.Drawing.Point(220, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 65);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(498, 279);
            this.Controls.Add(this.VProgressBar);
            this.Controls.Add(this.LProgressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Violet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delivery";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar LProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2VProgressBar VProgressBar;
    }
}

