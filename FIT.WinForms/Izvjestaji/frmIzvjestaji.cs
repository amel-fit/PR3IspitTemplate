using FIT.Data;
using FIT.Data.IB230046;
using FIT.WinForms.IB230046;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System.Text;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        public UvjerenjeIB230046 uvjerenje { get; set; }
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(UvjerenjeIB230046 u) : this()
        {
            uvjerenje = DBClassIB230046.dbContext.StudentiUvjerenja
                .Include(su => su.Student)
                    .ThenInclude(s => s.PolozeniPredmeti)
                        .ThenInclude(pp => pp.Predmet)
                .First(su => su.Id == u.Id);
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            string Student = $"{uvjerenje.Student.ImePrezime}({uvjerenje.Student.Indeks})";
            string svrha = uvjerenje.Svrha;
            string aktivan = uvjerenje.Student.Aktivan ? "AKTIVAN" : "NEAKTIVAN";
            int brojPredmeta = uvjerenje.Student.PolozeniPredmeti.Count;
            StringBuilder predmetiBuilder = new();
            foreach (var pp in uvjerenje.Student.PolozeniPredmeti)
            {
                predmetiBuilder.Append(pp.ToString() + ",");
            }
            double prosjek = uvjerenje.Student.Prosjek;

            var pStudent = new ReportParameter("pStudentImePrezimeIndeks", Student);
            var pSvrha = new ReportParameter("pSvrhaUvjerenja", svrha);
            var pAktivan = new ReportParameter("pAktivan", aktivan);
            var pBrojPredmeta = new ReportParameter("pBrojIspita", brojPredmeta.ToString());
            var pIspitiOcjene = new ReportParameter("pIspitiOcjene", predmetiBuilder.ToString());
            var pProsjek = new ReportParameter("pProsjek", prosjek.ToString());
            var pDatum = new ReportParameter("pDatum", DateTime.Now.ToShortDateString());

            var parameters = new ReportParameterCollection();
            parameters.Add(pStudent);
            parameters.Add(pSvrha);
            parameters.Add(pAktivan);
            parameters.Add(pBrojPredmeta);
            parameters.Add(pIspitiOcjene);
            parameters.Add(pProsjek);
            parameters.Add(pDatum);

            reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.RefreshReport();
        }

        private void frmIzvjestaji_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
