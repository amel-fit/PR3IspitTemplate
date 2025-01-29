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
    public partial class frmPorukeIB230046 : Form
    {
        public DLWMSDbContext dbContext { get; set; } = new();
        public dtoStudent dtoStudent { get; set; }
        public frmPorukeIB230046(dtoStudent DTOstudent)
        {
            InitializeComponent();

            dgvPoruke.AutoGenerateColumns = false;
            lblStudent.Text = $"Poruke studenta: {DTOstudent.student.Ime} {DTOstudent.student.Prezime}";
            dtoStudent = DTOstudent;

            cmbPredmet.UcitajPodatke(dbContext.Predmeti.ToList());
            ReloadPoruke();

        }

        private void ReloadPoruke()
        {
            dgvPoruke.DataSource = null;
            var lstValidnePoruke = dbContext.StudentiPoruke.ToArray().Where(sp => sp.Validnost > DateTime.Now && sp.StudentId == dtoStudent.student.Id);
            foreach (var msg in lstValidnePoruke)
            {
                msg.SlikaIMG = Image.FromStream(new MemoryStream(msg.Slika));
                msg.PredmetTXT = dbContext.Predmeti.First(p => p.Id == msg.PredmetId).Naziv;
            }
            var arrMSG = lstValidnePoruke.ToArray();
            dgvPoruke.DataSource = arrMSG;
            this.Text = $"Broj poruka: arrMSG.Count().ToString()";
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var result = new frmNovaPorukaIB230046(dtoStudent.student).ShowDialog();
            if (result != DialogResult.OK) return;
            MessageBox.Show("Uspješno ste snimili poruku");
            ReloadPoruke();
        }

        private void dgvPoruke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvPoruke.Columns["Brisi"].Index) return;
            var msgToRemove = dgvPoruke.Rows[e.RowIndex].DataBoundItem as StudentPorukaIB230046;
            dbContext.StudentiPoruke.Remove(msgToRemove);
            dbContext.SaveChanges();
            ReloadPoruke();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            int BrojPoruka = int.Parse(txtBrojPoruka.Text);
            int PredmetId = cmbPredmet.SelectedIndex + 1;
            DateTime Validnost = dtpValidnost.Value;
            StudentPorukaIB230046 prvaPoruka = dgvPoruke.Rows[0].DataBoundItem as StudentPorukaIB230046;
            await Task.Run(() =>
            {
                for (int i = 0; i < BrojPoruka; i++)
                {
                    dbContext.StudentiPoruke.Add(new StudentPorukaIB230046()
                    {
                        Hitnost = prvaPoruka.Hitnost,
                        PredmetId = PredmetId,
                        Sadrzaj = prvaPoruka.Sadrzaj,
                        Validnost = Validnost,
                        Slika = prvaPoruka.Slika,
                        StudentId = this.dtoStudent.student.Id,
                    });
                    Thread.Sleep(300);
                    rtInfo.Invoke(() =>
                    {
                        string info = $"{DateTime.Now} -> generisana poruka za {this.dtoStudent.student.Ime} {this.dtoStudent.student.Prezime} na predmetu {cmbPredmet.Text}\n";
                        rtInfo.Text += info;
                    });
                }
            });
            dbContext.SaveChanges();
            ReloadPoruke();
        }

        private void frmPorukeIB230046_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new Izvjestaji.frmIzvjestaji(dtoStudent).Show();
        }
    }
}
