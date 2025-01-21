using FIT.Data;
using FIT.Data.IB230046;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB230046
{
    public partial class frmGradoviIB230046 : Form
    {
        public DrzavaIB230046 Drzava { get; set; }
        public frmGradoviIB230046(DrzavaIB230046 drzava)
        {
            InitializeComponent();
            Drzava = drzava;
        }

        private void frmGradoviIB230046_Load(object sender, EventArgs e)
        {
            lblDrzava.Text = Drzava.Naziv;
            pbZastava.Image = Image.FromStream(new MemoryStream(Drzava.Zastava));

            dgvGradovi.AutoGenerateColumns = false;
            DGVRefresh();
        }

        private void DGVRefresh()
        {
            dgvGradovi.DataSource = null;
            dgvGradovi.DataSource = Drzava.Gradovi;
        }

        private void frmGradoviIB230046_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos()) return;
            string nazivGrada = txtNaziv.Text;
            DataBase.dbContext.Gradovi.Add(new GradIB230046()
            {
                Naziv = nazivGrada,
                Status = true,
                Drzava = this.Drzava
            });
            DataBase.dbContext.SaveChanges();
            DGVRefresh();
        }

        private bool ValidanUnos()
        {
            return Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue);
        }

        private void dgvGradovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnPromijeniStatus.Index && e.RowIndex >= 0)
            {
                var grad = dgvGradovi.Rows[e.RowIndex].DataBoundItem as GradIB230046;
                grad.Status = !grad.Status;
                DataBase.dbContext.Update(grad);
                DataBase.dbContext.SaveChanges();
                DGVRefresh();
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (!ValidanBrojGradova()) return;

            await Task.Run(() =>
            {
                int brojGradova = int.Parse(txtBrojGradova.Text);
                for (int i = 0; i < brojGradova; i++)
                {
                    Invoke(() =>
                    {
                        GradIB230046 grad = new()
                        {
                            Drzava = this.Drzava,
                            Naziv = $"Grad{i}.",
                            Status = cbAktivni.Checked
                        };
                        Drzava.Gradovi.Add(grad);
                        DataBase.dbContext.Update(Drzava);
                        DataBase.dbContext.SaveChanges();

                        string info = $"{DateTime.Now.ToString("dd.MM HH.mm.ss")} -> dodat grad {grad.Naziv} za državu {Drzava.Naziv}\n";
                        rtInfo.Text += info;
                        rtInfo.SelectionStart = rtInfo.Text.Length;
                        rtInfo.ScrollToCaret();
                    });
                    Thread.Sleep(300);
                }
            });
            DGVRefresh();
            MessageBox.Show("Dodani gradovi");

        }

        private bool ValidanBrojGradova()
        {
            return Helpers.Validator.ProvjeriUnos(txtBrojGradova, err, Kljucevi.ReqiredValue);
        }
    }
}
