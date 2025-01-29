namespace FIT.WinForms.IspitIB230046
{
    partial class frmPorukeIB230046
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
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Hitnost = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            cmbPredmet = new ComboBox();
            btnDodaj = new Button();
            rtInfo = new RichTextBox();
            dtpValidnost = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txtBrojPoruka = new TextBox();
            label1 = new Label();
            lblStudent = new Label();
            btnPrint = new Button();
            btnNovaPoruka = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Hitnost, Validnost, Brisi });
            dgvPoruke.Location = new Point(12, 35);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowHeadersWidth = 51;
            dgvPoruke.RowTemplate.Height = 29;
            dgvPoruke.Size = new Size(1101, 231);
            dgvPoruke.TabIndex = 0;
            dgvPoruke.CellClick += dgvPoruke_CellClick;
            // 
            // Predmet
            // 
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            Predmet.Width = 125;
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadržaj";
            Sadrzaj.MinimumWidth = 6;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.DataPropertyName = "SlikaIMG";
            Slika.HeaderText = "Slika";
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            Slika.Width = 125;
            // 
            // Hitnost
            // 
            Hitnost.DataPropertyName = "Hitnost";
            Hitnost.HeaderText = "Hitnost";
            Hitnost.MinimumWidth = 6;
            Hitnost.Name = "Hitnost";
            Hitnost.ReadOnly = true;
            Hitnost.Width = 125;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.MinimumWidth = 6;
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPredmet);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(rtInfo);
            groupBox1.Controls.Add(dtpValidnost);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBrojPoruka);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1101, 244);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(6, 104);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(151, 28);
            cmbPredmet.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(0, 197);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(264, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // rtInfo
            // 
            rtInfo.Location = new Point(276, 46);
            rtInfo.Name = "rtInfo";
            rtInfo.Size = new Size(819, 181);
            rtInfo.TabIndex = 3;
            rtInfo.Text = "";
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(6, 164);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(250, 27);
            dtpValidnost.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 141);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Validnost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Predmet:";
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(6, 46);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(125, 27);
            txtBrojPoruka.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Broj poruka:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 9);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(70, 20);
            lblStudent.TabIndex = 2;
            lblStudent.Text = "[Student]";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1019, 272);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(1013, 5);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(94, 29);
            btnNovaPoruka.TabIndex = 3;
            btnNovaPoruka.Text = "Nova Poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // frmPorukeIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 595);
            Controls.Add(btnNovaPoruka);
            Controls.Add(btnPrint);
            Controls.Add(lblStudent);
            Controls.Add(groupBox1);
            Controls.Add(dgvPoruke);
            Name = "frmPorukeIB230046";
            Text = "frmPoruke";
            Load += frmPorukeIB230046_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPoruke;
        private GroupBox groupBox1;
        private DateTimePicker dtpValidnost;
        private Label label2;
        private TextBox txtBrojPoruka;
        private Label label1;
        private Button btnDodaj;
        private RichTextBox rtInfo;
        private Label label3;
        private ComboBox cmbPredmet;
        private Label lblStudent;
        private Button btnPrint;
        private Button btnNovaPoruka;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Hitnost;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
    }
}