using FIT.Data;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB230046
{
    public partial class frmNovaDrzavaIB230046 : Form
    {
        public frmNovaDrzavaIB230046()
        {
            InitializeComponent();
        }

        private void pbZastava_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromStream(ofd.OpenFile());
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos()) return;
            string naziv = txtNaziv.Text;
            var zastava = pbZastava.Image.ToByteArray();
            bool status = cbAktivna.Checked;
            DataBase.dbContext.Drzave.Add(new Data.IB230046.DrzavaIB230046()
            {
                Naziv = naziv,
                Status = status,
                Zastava = zastava
            });
            DataBase.dbContext.SaveChanges();

            this.DialogResult = DialogResult.OK;
        }

        private bool ValidanUnos()
        {
            return Helpers.Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue);
                
        }
    }
}
