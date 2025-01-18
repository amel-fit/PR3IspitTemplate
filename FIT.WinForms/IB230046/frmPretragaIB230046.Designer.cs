namespace FIT.WinForms.IB230046
{
    partial class frmPretragaIB230046
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
            cmbSpol = new ComboBox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            dgvStudenti = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnUvjerenja = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // cmbSpol
            // 
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(99, 12);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(151, 28);
            cmbSpol.TabIndex = 0;
            cmbSpol.SelectedIndexChanged += UslovChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(469, 10);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 1;
            dtpFrom.ValueChanged += UslovChanged;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(769, 10);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 1;
            dtpTo.ValueChanged += UslovChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, ImePrezime, Prosjek, DatumRodjenja, Aktivan, btnUvjerenja });
            dgvStudenti.Location = new Point(22, 74);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.Size = new Size(1029, 364);
            dgvStudenti.TabIndex = 2;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.DataPropertyName = "Indeks";
            BrojIndeksa.HeaderText = "Broj Indeksa";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            BrojIndeksa.Width = 125;
            // 
            // ImePrezime
            // 
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            ImePrezime.Width = 125;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            Prosjek.Width = 125;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            DatumRodjenja.Width = 125;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // btnUvjerenja
            // 
            btnUvjerenja.HeaderText = "";
            btnUvjerenja.MinimumWidth = 6;
            btnUvjerenja.Name = "btnUvjerenja";
            btnUvjerenja.ReadOnly = true;
            btnUvjerenja.Text = "Uvjerenja";
            btnUvjerenja.UseColumnTextForButtonValue = true;
            btnUvjerenja.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Spol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 15);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 3;
            label2.Text = "Rođen u periodu od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(725, 17);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 3;
            label3.Text = "do";
            // 
            // frmPretragaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 450);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvStudenti);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(cmbSpol);
            Name = "frmPretragaIB230046";
            Text = "frmPretragaIB230046";
            FormClosing += frmPretragaIB230046_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSpol;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private DataGridView dgvStudenti;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnUvjerenja;
    }
}