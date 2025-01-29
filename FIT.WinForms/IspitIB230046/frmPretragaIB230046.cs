using FIT.Data;
using FIT.Data.IspitIB230046;
using FIT.Infrastructure;
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
    public partial class frmPretragaIB230046 : Form
    {
        public DLWMSDbContext dbContext { get; set; } = new();
        private bool showReloadMessage = false;
        private bool doRefresh = false;
        public frmPretragaIB230046()
        {
            InitializeComponent();
            //FillData();
        }

        private void FillData()
        {


            for (int i = 1; i < 10; i++)
            {
                dbContext.StudentiUloge.Add(new StudentUlogaIB230046()
                {
                    StudentId = i,
                    UlogaId = i % 3 + 1,
                });
                dbContext.SaveChanges();
            }



        }

        private void frmPretragaIB230046_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;

            cmbSemestar.DataSource = dbContext.Semestri.ToArray();
            cmbSemestar.SelectedIndex = 0;

            cmbUloga.DataSource = dbContext.Uloge.ToArray();
            cmbUloga.SelectedIndex = 0;

            dtpDatumOd.Value = new DateTime(1900, 1, 1);

            doRefresh = true;
            ReloadData();
            showReloadMessage = true;
        }

        private void ReloadData()
        {
            if (doRefresh != true) return;
            dgvStudenti.DataSource = null;
            var lstSource = GetData();
            if (!lstSource.Any() && showReloadMessage)
                MessageBox.Show("Ne postoje takvi");
            dgvStudenti.DataSource = lstSource;
        }

        private List<dtoStudent> GetData()
        {
            var lstDTOStudent = new List<dtoStudent>();
            foreach (var student in dbContext.Studenti.ToArray())
                if (Uslov(student))
                    lstDTOStudent.Add(new dtoStudent(student));

            return lstDTOStudent;
        }

        private bool Uslov(Student student)
        {
            var semstar = dbContext.Semestri.First(s => s.Id == cmbSemestar.SelectedIndex + 1);
            var uloga = cmbUloga.SelectedItem as UlogaIB230046;
            DateTime DateOd = dtpDatumOd.Value;
            DateTime DateDo = dtpDatumDo.Value;
            var studentUloga = dbContext.StudentiUloge.Where(su => su.StudentId == student.Id).ToArray();
            bool studentImaUlogu = false;
            foreach (var su in studentUloga)
            {
                if (su.UlogaId == uloga.Id)
                {
                    studentImaUlogu |= true;
                    break;
                }
            }
            return DateOd < student.DatumRodjenja && student.DatumRodjenja < DateDo
                && student.SemestarId == semstar.Id
                && studentImaUlogu;
        }

        private void UslovChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvStudenti.Columns["Poruke"].Index) return;
            new frmPorukeIB230046(dgvStudenti.Rows[e.RowIndex].DataBoundItem as dtoStudent).Show();
        }
    }
}
