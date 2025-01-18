using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB230046
{
    public partial class frmPretragaIB230046 : Form
    {
        public bool doRefresh = false;
        public frmPretragaIB230046()
        {
            InitializeComponent();
            cmbSpol.UcitajPodatke(DBClassIB230046.dbContext.Spolovi.ToList(), "Opis");
            dtpFrom.Value = new DateTime(1900, 1, 1);
            dgvStudenti.AutoGenerateColumns = false;
            SetSource();
            doRefresh = true;
        }

        private void frmPretragaIB230046_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void UslovChanged(object sender, EventArgs e)
        {
            if (doRefresh)
                SetSource();
        }

        private void SetSource()
        {
            dgvStudenti.DataSource = null;

            var lstStudenti = DBClassIB230046.dbContext.Studenti
                .Include(s => s.Spol)
                .Include(s => s.PolozeniPredmeti)
                .Include(s => s.Uvjerenja)
                .ToList()
                .Where(student => Uslov(student)).ToList();

            dgvStudenti.DataSource = lstStudenti;
        }

        private bool Uslov(Student student)
        {
            var spolId = cmbSpol.SelectedIndex + 1;
            var datumOd = dtpFrom.Value;
            var datumDo = dtpTo.Value;

            return student.Spol.Id == spolId
                && datumOd < student.DatumRodjenja
                && student.DatumRodjenja < datumDo;
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnUvjerenja.Index)
                new frmUvjerenjaIB230046(dgvStudenti.Rows[e.RowIndex].DataBoundItem as Student).Show();
            else
            {
                new frmStudentInfoIB230046(dgvStudenti.Rows[e.RowIndex].DataBoundItem as Student).Show();
            }

        }
    }
}
