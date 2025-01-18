namespace FIT.WinForms.IB230046
{
    partial class frmUvjerenjaIB230046
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
            btnNoviZahtjev = new Button();
            dgvUvjerenja = new DataGridView();
            Datum = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            btnBrisi = new DataGridViewButtonColumn();
            btnPrintaj = new DataGridViewButtonColumn();
            cmbVrsta = new ComboBox();
            txtSvrha = new TextBox();
            txtBroj = new TextBox();
            btnDodaj = new Button();
            rtInfo = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(863, 29);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(168, 29);
            btnNoviZahtjev.TabIndex = 0;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { Datum, Vrsta, Svrha, Uplatnica, Printano, btnBrisi, btnPrintaj });
            dgvUvjerenja.Location = new Point(12, 64);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowHeadersWidth = 51;
            dgvUvjerenja.RowTemplate.Height = 29;
            dgvUvjerenja.Size = new Size(1019, 287);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellClick += dgvUvjerenja_CellClick;
            // 
            // Datum
            // 
            Datum.DataPropertyName = "DatumKreiranja";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            Datum.Width = 125;
            // 
            // Vrsta
            // 
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            Vrsta.Width = 125;
            // 
            // Svrha
            // 
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            Svrha.Width = 125;
            // 
            // Uplatnica
            // 
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Width = 125;
            // 
            // Printano
            // 
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            Printano.Width = 125;
            // 
            // btnBrisi
            // 
            btnBrisi.HeaderText = "";
            btnBrisi.MinimumWidth = 6;
            btnBrisi.Name = "btnBrisi";
            btnBrisi.ReadOnly = true;
            btnBrisi.Text = "Briši";
            btnBrisi.UseColumnTextForButtonValue = true;
            btnBrisi.Width = 125;
            // 
            // btnPrintaj
            // 
            btnPrintaj.HeaderText = "";
            btnPrintaj.MinimumWidth = 6;
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.ReadOnly = true;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseColumnTextForButtonValue = true;
            btnPrintaj.Width = 125;
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Location = new Point(50, 423);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(274, 28);
            cmbVrsta.TabIndex = 2;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(347, 423);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(383, 27);
            txtSvrha.TabIndex = 3;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(749, 424);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(77, 27);
            txtBroj.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(848, 423);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(159, 29);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // rtInfo
            // 
            rtInfo.Location = new Point(50, 488);
            rtInfo.Name = "rtInfo";
            rtInfo.Size = new Size(957, 154);
            rtInfo.TabIndex = 6;
            rtInfo.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 400);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 7;
            label1.Text = "Vrsta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 400);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 7;
            label2.Text = "Svrha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(749, 401);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "Broj:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 465);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "Info";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 357);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1019, 297);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmUvjerenjaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 654);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtInfo);
            Controls.Add(btnDodaj);
            Controls.Add(txtBroj);
            Controls.Add(txtSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnNoviZahtjev);
            Controls.Add(groupBox1);
            Name = "frmUvjerenjaIB230046";
            Text = "frmUvjerenjaIB230046";
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNoviZahtjev;
        private DataGridView dgvUvjerenja;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn btnBrisi;
        private DataGridViewButtonColumn btnPrintaj;
        private ComboBox cmbVrsta;
        private TextBox txtSvrha;
        private TextBox txtBroj;
        private Button btnDodaj;
        private RichTextBox rtInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private ErrorProvider err;
    }
}