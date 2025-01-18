namespace FIT.WinForms.IB230046
{
    partial class frmNovoUvjerenjeIB230046
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
            pbUplatnica = new PictureBox();
            cmbVrsta = new ComboBox();
            rtSvrha = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDodaj = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbUplatnica
            // 
            pbUplatnica.BorderStyle = BorderStyle.Fixed3D;
            pbUplatnica.Location = new Point(425, 33);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(349, 301);
            pbUplatnica.TabIndex = 0;
            pbUplatnica.TabStop = false;
            pbUplatnica.Click += pbUplatnica_Click;
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Location = new Point(31, 33);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(352, 28);
            cmbVrsta.TabIndex = 1;
            // 
            // rtSvrha
            // 
            rtSvrha.Location = new Point(31, 118);
            rtSvrha.Name = "rtSvrha";
            rtSvrha.Size = new Size(352, 216);
            rtSvrha.TabIndex = 2;
            rtSvrha.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 10);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 3;
            label1.Text = "Vrsta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 10);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Slika uplatnice:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 95);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 3;
            label3.Text = "Svrha doznake:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(612, 340);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(162, 36);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Sacuvaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovoUvjerenje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(pbUplatnica);
            Name = "frmNovoUvjerenje";
            Text = "frmNovoUvjerenje";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbUplatnica;
        private ComboBox cmbVrsta;
        private RichTextBox rtSvrha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDodaj;
        private ErrorProvider err;
    }
}