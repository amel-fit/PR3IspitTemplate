using FIT.Data;
using FIT.Data.IspitIB230046;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB230046
{
    public partial class frmNovaPorukaIB230046 : Form
    {
        public Student student { get; set; }
        public DLWMSDbContext dbContext { get; set; } = new();
        public frmNovaPorukaIB230046(Student s)
        {
            InitializeComponent();
            student = s;
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            if (result != DialogResult.OK) return;
            var file = ofd.OpenFile();
            pbSlika.Image = Image.FromStream(file);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            return;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Uslov()) return;
            var msg = new StudentPorukaIB230046()
            {
                PredmetId = cmbPredmet.SelectedIndex + 1,
                StudentId = student.Id,
                Hitnost = cmbHitnost.Text,
                Slika = pbSlika.Image.ToByteArray(),
                Validnost = dtpValidnost.Value,
                Sadrzaj = rtSadrzaj.Text,
            };
            dbContext.StudentiPoruke.Add(msg);
            dbContext.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private bool Uslov()
        {
            return Helpers.Validator.ProvjeriUnos(cmbHitnost, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(cmbPredmet, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(pbSlika, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(rtSadrzaj, err, Kljucevi.ReqiredValue);
        }

        private void frmNovaPorukaIB230046_Load(object sender, EventArgs e)
        {
            cmbHitnost.SelectedIndex = 0;

            cmbPredmet.UcitajPodatke(dbContext.Predmeti.ToList());
            cmbPredmet.SelectedIndex = 0;
            
            dtpValidnost.Value = DateTime.Now;
        }
    }
}
