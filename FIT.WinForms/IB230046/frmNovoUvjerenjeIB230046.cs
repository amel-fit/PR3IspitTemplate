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
    public partial class frmNovoUvjerenjeIB230046 : Form
    {
        public Student Student { get; set; }
        public frmNovoUvjerenjeIB230046(Student student)
        {
            InitializeComponent();
            var lstVrste = new List<string>()
            {
                "Potvrda o statusu studenta",
                "Potvrda o položenim ispitima"
            };
            cmbVrsta.DataSource = lstVrste;
            Student = student;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Uslov()) return;
            var vrsta = cmbVrsta.Text;
            var svrha = rtSvrha.Text;
            var uplatnica = pbUplatnica.Image;
            Student.Uvjerenja.Add(new Data.IB230046.UvjerenjeIB230046()
            {
                Student = Student,
                DatumKreiranja = DateTime.Now,
                Printano = false,
                Svrha = svrha,
                Vrsta = vrsta,
                Uplatnica = uplatnica.ToByteArray()
            });
            DBClassIB230046.dbContext.SaveChanges();
            this.DialogResult = DialogResult.OK;
            
        }

        private bool Uslov()
        {
            return Helpers.Validator.ProvjeriUnos(cmbVrsta, err, Kljucevi.NevalidanUnos)
                && Helpers.Validator.ProvjeriUnos(rtSvrha, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(pbUplatnica, err, Kljucevi.ReqiredValue);
        }

        private void pbUplatnica_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromStream(fd.OpenFile());
            }
        }
    }
}
