using FIT.Data;
using FIT.Data.IspitIB230046;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        public Student Student { get; set; }
        public DLWMSDbContext DB { get; set; } = new();
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(dtoStudent dtoStudent) :this()
        {
            Student = DB.Studenti.Include(s => s.Poruke).ThenInclude(sp => sp.Predmet).First(s => s.Id == dtoStudent.student.Id);
        }


        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            int rb = 1;
            double ukupnoZnakova = 0;
            var tblStudentiPoruke = new IspitIB230046.dsPorukeStudenta.tblPorukaDataTable();
            for (int i = 0; i < Student.Poruke.Count; i++, rb++)
            {
                var row = tblStudentiPoruke.NewtblPorukaRow();
                row.Rb = rb.ToString();
                row.Predmet = Student.Poruke.ElementAt(i).Predmet.ToString();
                row.Poruka = Student.Poruke.ElementAt(i).Sadrzaj;
                row.BrojZnakova = Student.Poruke.ElementAt(i).Sadrzaj.Count().ToString();
                row.Validnost = Student.Poruke.ElementAt(i).Validnost.ToString();

                tblStudentiPoruke.AddtblPorukaRow(row);

                ukupnoZnakova += Student.Poruke.ElementAt(i).Sadrzaj.Count();
            }
            rb--;
            ReportDataSource ds = new ReportDataSource();
            ds.Name = "dsPoruke";
            ds.Value = tblStudentiPoruke;

            var parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pStudentImePrezime", $"{Student.Ime} {Student.Prezime}"));
            parameters.Add(new ReportParameter("pBrojPoruka", rb.ToString()));
            parameters.Add(new ReportParameter("pProsjekKaraktera", (ukupnoZnakova/rb).ToString()));

            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.RefreshReport();
        }
    }
}
