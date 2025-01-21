namespace FIT.WinForms.IB230046
{
    partial class frmGradoviIB230046
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
            pbZastava = new PictureBox();
            lblDrzava = new Label();
            txtNaziv = new TextBox();
            label2 = new Label();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnPromijeniStatus = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            txtBrojGradova = new TextBox();
            cbAktivni = new CheckBox();
            btnGenerisi = new Button();
            label1 = new Label();
            rtInfo = new RichTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(28, 25);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(176, 116);
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Font = new Font("Segoe UI", 20F);
            lblDrzava.Location = new Point(250, 68);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(109, 46);
            lblDrzava.TabIndex = 1;
            lblDrzava.Text = "label1";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(234, 164);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(264, 27);
            txtNaziv.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 167);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 3;
            label2.Text = "Unesite naziv novog grada:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(520, 163);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(116, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Aktivan, btnPromijeniStatus });
            dgvGradovi.Location = new Point(28, 206);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.Size = new Size(608, 188);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellClick += dgvGradovi_CellClick;
            // 
            // Naziv
            // 
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            Naziv.Width = 125;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // btnPromijeniStatus
            // 
            btnPromijeniStatus.HeaderText = "";
            btnPromijeniStatus.MinimumWidth = 6;
            btnPromijeniStatus.Name = "btnPromijeniStatus";
            btnPromijeniStatus.ReadOnly = true;
            btnPromijeniStatus.Text = "Promijeni Status";
            btnPromijeniStatus.UseColumnTextForButtonValue = true;
            btnPromijeniStatus.Width = 125;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(152, 502);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(125, 27);
            txtBrojGradova.TabIndex = 6;
            // 
            // cbAktivni
            // 
            cbAktivni.AutoSize = true;
            cbAktivni.Location = new Point(297, 504);
            cbAktivni.Name = "cbAktivni";
            cbAktivni.Size = new Size(76, 24);
            cbAktivni.TabIndex = 7;
            cbAktivni.Text = "Aktivni";
            cbAktivni.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(393, 502);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 8;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 506);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 9;
            label1.Text = "Broj gradova: ";
            // 
            // rtInfo
            // 
            rtInfo.Location = new Point(46, 557);
            rtInfo.Name = "rtInfo";
            rtInfo.Size = new Size(590, 120);
            rtInfo.TabIndex = 10;
            rtInfo.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 534);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 9;
            label3.Text = "Info";
            // 
            // frmGradoviIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 689);
            Controls.Add(rtInfo);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnGenerisi);
            Controls.Add(cbAktivni);
            Controls.Add(txtBrojGradova);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodaj);
            Controls.Add(label2);
            Controls.Add(txtNaziv);
            Controls.Add(lblDrzava);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB230046";
            Text = "frmGradoviIB230046";
            FormClosing += frmGradoviIB230046_FormClosing;
            Load += frmGradoviIB230046_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblDrzava;
        private TextBox txtNaziv;
        private Label label2;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnPromijeniStatus;
        private CheckBox cbAktivni;
        private TextBox txtBrojGradova;
        private Button btnGenerisi;
        private RichTextBox rtInfo;
        private Label label3;
        private Label label1;
    }
}