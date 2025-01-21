using FIT.Data.IB230046;
using FIT.WinForms.Izvjestaji;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmDrzaveIB230046 : Form
    {
        public frmDrzaveIB230046()
        {
            InitializeComponent();
            lblVrijeme.Text = $"Trenutno Vrijeme: {DateTime.Now.ToLongTimeString()}";
            dgvDrzave.AutoGenerateColumns = false;
            RefreshDGV();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = $"Trenutno Vrijeme: {DateTime.Now.ToLongTimeString()}";
        }

        private void frmPretragaIB230046_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            if (new frmNovaDrzavaIB230046().ShowDialog() == DialogResult.OK)
            {
                RefreshDGV();
            }

        }

        private void RefreshDGV()
        {
            dgvDrzave.DataSource = null;
            dgvDrzave.DataSource = DataBase.dbContext.Drzave.Include(d => d.Gradovi).ToList();
        }

        private void dgvDrzave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnGradovi.Index)
            {
                var drzava = dgvDrzave.Rows[e.RowIndex].DataBoundItem as DrzavaIB230046;
                this.Hide();
                if (new frmGradoviIB230046(drzava).ShowDialog() == DialogResult.OK)
                    this.Show();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            new frmIzvjestaji(dgvDrzave.SelectedRows[0].DataBoundItem as DrzavaIB230046).Show();
        }
    }
}
