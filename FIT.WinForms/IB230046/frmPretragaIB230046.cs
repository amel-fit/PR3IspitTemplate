using FIT.Data.IB230046;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
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
    public partial class frmPretragaIB230046 : Form
    {
        bool doRefresh = false;
        int OdabranaDrzavaId { get; set; }
        int OdabraniGradId { get; set; }
        public frmPretragaIB230046()
        {
            InitializeComponent();
        }

        private void frmPretragaIB230046_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            UcitajDrzave();
            UcitajGradove();
            DGVRefresh();
            doRefresh = true;
        }

        private void UcitajGradove()
        {
            doRefresh = false;
            cmbGrad.UcitajPodatke(DataBase.dbContext.Gradovi.Include(g => g.Drzava).Where(g => g.Drzava.Id == OdabranaDrzavaId).ToList());
            cmbGrad.SelectedIndex = 0;
            OdabraniGradId = (cmbGrad.SelectedItem as GradIB230046).Id;
            doRefresh = true;
        }

        private void UcitajDrzave()
        {
            cmbDrzava.UcitajPodatke(DataBase.dbContext.Drzave.ToList());
            cmbDrzava.SelectedIndex = 0;
            OdabranaDrzavaId = (cmbDrzava.SelectedItem as DrzavaIB230046).Id;
            UcitajGradove();
        }

        private void DGVRefresh()
        {
            dgvStudenti.DataSource = null;
            var lstStudenti = DataBase.dbContext.Studenti
                                                                .Include(s => s.PolozeniPredmeti)
                                                                .Include(s => s.Drzava)
                                                                .Include(s => s.Grad)
                                                                .ToList();
            lstStudenti = lstStudenti
                                    .Where(
                                        s =>
                                        s.Drzava.Id == (cmbDrzava.SelectedItem as DrzavaIB230046).Id &&
                                        s.Grad.Id == (cmbGrad.SelectedItem as GradIB230046).Id
                                    ).ToList();
            dgvStudenti.DataSource = lstStudenti;
            if (!lstStudenti.Any())
                MessageBox.Show($"Nema studenata iz {cmbDrzava.Text} iz {cmbGrad.Text}");
        }

        private void frmPretragaIB230046_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doRefresh)
                DGVRefresh();
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdabranaDrzavaId = (cmbDrzava.SelectedItem as DrzavaIB230046).Id;
            UcitajGradove();
            if (doRefresh)
                DGVRefresh();
        }
    }
}
