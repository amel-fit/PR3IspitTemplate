using FIT.Data;
using FIT.Data.IB230046;
using FIT.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB230046
{
    public partial class frmUvjerenjaIB230046 : Form
    {
        public Student Student { get; set; }
        
        public frmUvjerenjaIB230046(Data.Student student)
        {
            InitializeComponent();
            Student = student;
            dgvUvjerenja.AutoGenerateColumns = false;
            var lstVrste = new List<string>()
            {
                "Potvrda o statusu studenta",
                "Potvrda o položenim ispitima"
            };
            cmbVrsta.DataSource = lstVrste;
            SetSource();

        }

        private void SetSource()
        {
            this.Text = $"Broj uvjerenja -> {Student.Uvjerenja.Count}";
            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = Student.Uvjerenja.ToList();
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            if (new frmNovoUvjerenjeIB230046(Student).ShowDialog() == DialogResult.OK)
            {
                SetSource();
            }
        }

        private void dgvUvjerenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnBrisi.Index)
            {
                Brisi(e);
                SetSource();
            }
            else if (e.ColumnIndex == btnPrintaj.Index)
            {
                Prinaj(e);
                SetSource();
            }
        }

        private void Prinaj(DataGridViewCellEventArgs e)
        {
           
            var uvjerenje = dgvUvjerenja.Rows[e.RowIndex].DataBoundItem as UvjerenjeIB230046;

            new frmIzvjestaji(uvjerenje).Show();
                
            uvjerenje.Printano = true;
            DBClassIB230046.dbContext.SaveChanges();
                
            
        }

        private void Brisi(DataGridViewCellEventArgs e)
        {
            var uvjerenje = dgvUvjerenja.Rows[e.RowIndex].DataBoundItem as UvjerenjeIB230046;
            DBClassIB230046.dbContext.Remove(uvjerenje);
            DBClassIB230046.dbContext.SaveChanges();

        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Student.Uvjerenja.Count == 0) return;   
            if (!Uslov()) return;
            await Task.Run(() =>
            {
                var prva = dgvUvjerenja.Rows[0].DataBoundItem as UvjerenjeIB230046;
                int brojPonavljanja = int.Parse(txtBroj.Text);
                for (int i = 0; i < brojPonavljanja; i++)
                {
                    Invoke(() =>
                    {
                    string svrha = txtSvrha.Text;
                    string vrsta = cmbVrsta.Text;
                    Student.Uvjerenja.Add(
                    new UvjerenjeIB230046()
                    {
                        DatumKreiranja = DateTime.Now,
                        Student = Student,
                        Printano = false,
                        Svrha = svrha,
                        Vrsta = vrsta,
                        Uplatnica = prva.Uplatnica
                    });
                    DBClassIB230046.dbContext.SaveChanges();
                    string toAdd = $"{DateTime.Now} -> {vrsta} ({Student.Indeks}) - {Student.ImePrezime} u svrhu {svrha}\n";
                        rtInfo.Text += toAdd;
                        rtInfo.SelectionStart = rtInfo.Text.Length;
                        rtInfo.ScrollToCaret();
                    });
                    Thread.Sleep(300);
                }
            });
            MessageBox.Show("Dodavanje završeno");
            SetSource();
        }

        private bool Uslov()
        {
            return Helpers.Validator.ProvjeriUnos(cmbVrsta, err, Kljucevi.NevalidanUnos)
                && Helpers.Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(txtBroj, err, Kljucevi.NevalidanUnos, true);
                
        }
    }
}
