namespace FIT.WinForms.IspitIB230046
{
    partial class frmNovaPorukaIB230046
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
            components = new System.ComponentModel.Container();
            cmbPredmet = new ComboBox();
            dtpValidnost = new DateTimePicker();
            cmbHitnost = new ComboBox();
            rtSadrzaj = new RichTextBox();
            pbSlika = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(53, 64);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(300, 28);
            cmbPredmet.TabIndex = 0;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(53, 130);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(300, 27);
            dtpValidnost.TabIndex = 1;
            // 
            // cmbHitnost
            // 
            cmbHitnost.FormattingEnabled = true;
            cmbHitnost.Items.AddRange(new object[] { "Visoka", "Srednja", "Niska" });
            cmbHitnost.Location = new Point(53, 207);
            cmbHitnost.Name = "cmbHitnost";
            cmbHitnost.Size = new Size(300, 28);
            cmbHitnost.TabIndex = 0;
            // 
            // rtSadrzaj
            // 
            rtSadrzaj.Location = new Point(53, 270);
            rtSadrzaj.Name = "rtSadrzaj";
            rtSadrzaj.Size = new Size(300, 168);
            rtSadrzaj.TabIndex = 2;
            rtSadrzaj.Text = "";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.Fixed3D;
            pbSlika.Location = new Point(384, 41);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(395, 397);
            pbSlika.TabIndex = 3;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 247);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 184);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 107);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "label1";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(685, 448);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(570, 448);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(94, 29);
            btnOdustani.TabIndex = 5;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaPorukaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pbSlika);
            Controls.Add(rtSadrzaj);
            Controls.Add(dtpValidnost);
            Controls.Add(cmbHitnost);
            Controls.Add(cmbPredmet);
            Name = "frmNovaPorukaIB230046";
            Text = "frmNovaPorukaIB230046";
            Load += frmNovaPorukaIB230046_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPredmet;
        private DateTimePicker dtpValidnost;
        private ComboBox cmbHitnost;
        private RichTextBox rtSadrzaj;
        private PictureBox pbSlika;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSacuvaj;
        private Button btnOdustani;
        private ErrorProvider err;
    }
}