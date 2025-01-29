using FIT.Data._2202IB230046;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        public Prostorija prostorija { get; set; }
        public frmIzvjestaji()
        {
            InitializeComponent();
        }
        public frmIzvjestaji(Prostorija p) : this()
        {
            prostorija = p;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            
            var tblStudenti = new FIT.WinForms._2202IB230046.DataSet1.tblNastavaDataTable();
            int rb = 1;
            for (int i = 0; i < prostorija.Nastave.Count; i++)
            {
                foreach(var p in prostorija.Nastave.ElementAt(i).Prisustva)
                {
                    var studentiRow = tblStudenti.NewtblNastavaRow();
                    studentiRow.rb = rb.ToString();
                    studentiRow.Predmet = prostorija.Nastave.ElementAt(i).PredmetTXT;
                    studentiRow.Vrijeme = prostorija.Nastave.ElementAt(i).VrijemeOdrzavanja;
                    studentiRow.BrojIndeksa = p.Student.Indeks;
                    studentiRow.ImePrezime = $"{p.Student.Ime} {p.Student.Prezime}";

                    tblStudenti.AddtblNastavaRow(studentiRow);
                    rb++;
                }
                i++;
            }

            var ds = new ReportDataSource();
            ds.Name = "pdsNastave";
            ds.Value = tblStudenti;

            reportViewer1.LocalReport.DataSources.Add(ds);

            var parameters = new ReportParameterCollection();

            var pProstorijaIme = new ReportParameter("pProstorijaIme", prostorija.Naziv);
            parameters.Add(pProstorijaIme);

            int brojStudenata = rb - 1;
            var pBrojStudenata = new ReportParameter("pBrojStudenata", brojStudenata.ToString());
            parameters.Add(pBrojStudenata);


            reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.RefreshReport();
        }
    }
}
