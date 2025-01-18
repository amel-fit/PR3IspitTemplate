namespace FIT.WinForms.IB230046
{
    partial class frmStudentInfoIB230046
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
            pbSlika = new PictureBox();
            lblImePrezime = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(36, 22);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(187, 165);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 14F);
            lblImePrezime.Location = new Point(86, 225);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(78, 32);
            lblImePrezime.TabIndex = 1;
            lblImePrezime.Text = "label1";
            lblImePrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(99, 297);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(50, 20);
            lblProsjek.TabIndex = 1;
            lblProsjek.Text = "label1";
            lblProsjek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 450);
            Controls.Add(lblProsjek);
            Controls.Add(lblImePrezime);
            Controls.Add(pbSlika);
            Name = "frmStudentInfoIB230046";
            Text = "frmStudentInfo";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblImePrezime;
        private Label lblProsjek;
    }
}