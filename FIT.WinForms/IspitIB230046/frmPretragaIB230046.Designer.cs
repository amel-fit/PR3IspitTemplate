namespace FIT.WinForms.IspitIB230046
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
            dtpDatumOd = new DateTimePicker();
            dtpDatumDo = new DateTimePicker();
            dgvStudenti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            Uloga = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbSemestar = new ComboBox();
            cmbUloga = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(628, 18);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(250, 27);
            dtpDatumOd.TabIndex = 2;
            dtpDatumOd.ValueChanged += UslovChanged;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(917, 18);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(250, 27);
            dtpDatumDo.TabIndex = 2;
            dtpDatumDo.ValueChanged += UslovChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, DatumRodjenja, Prosjek, Uloga, Aktivan, Poruke });
            dgvStudenti.Location = new Point(12, 72);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.Size = new Size(1155, 366);
            dgvStudenti.TabIndex = 3;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            Indeks.Width = 125;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i Prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum Rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosječna Ocjena";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            Prosjek.Width = 138;
            // 
            // Uloga
            // 
            Uloga.DataPropertyName = "Uloga";
            Uloga.HeaderText = "Uloga";
            Uloga.MinimumWidth = 6;
            Uloga.Name = "Uloga";
            Uloga.ReadOnly = true;
            Uloga.Width = 125;
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
            // Poruke
            // 
            Poruke.HeaderText = "";
            Poruke.MinimumWidth = 6;
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Resizable = DataGridViewTriState.True;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            Poruke.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Semestar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 23);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "uloga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 23);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 6;
            label3.Text = "rođen u periodu od";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(884, 23);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 7;
            label4.Text = "do";
            // 
            // cmbSemestar
            // 
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(88, 18);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(151, 28);
            cmbSemestar.TabIndex = 8;
            cmbSemestar.SelectedIndexChanged += UslovChanged;
            // 
            // cmbUloga
            // 
            cmbUloga.FormattingEnabled = true;
            cmbUloga.Location = new Point(317, 18);
            cmbUloga.Name = "cmbUloga";
            cmbUloga.Size = new Size(151, 28);
            cmbUloga.TabIndex = 9;
            cmbUloga.SelectedIndexChanged += UslovChanged;
            // 
            // frmPretragaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 450);
            Controls.Add(cmbUloga);
            Controls.Add(cmbSemestar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudenti);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Name = "frmPretragaIB230046";
            Text = "Pretraga Studenata";
            Load += frmPretragaIB230046_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtS;
        private TextBox textBox2;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private DataGridView dgvStudenti;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbSemestar;
        private ComboBox cmbUloga;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn Uloga;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Poruke;
    }
}