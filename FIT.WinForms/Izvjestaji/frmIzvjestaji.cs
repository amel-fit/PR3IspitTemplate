using FIT.Data.IB230046;
using FIT.WinForms.IB230046.Datasets;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(DrzavaIB230046 drzava) : this()
        {
            UcitajPodatke(drzava);
        }

        private void UcitajPodatke(DrzavaIB230046 drzava)
        {
            int brojGradova = drzava.BrojGradova;
            var pBrG = new ReportParameter("pBrojGradova", brojGradova.ToString());
            
            var dataTable = new DataSet1.GradoviDataTable();
            for (int i = 0; i< brojGradova; i++)
            {
                var row = dataTable.NewGradoviRow();
                row.Rb = (i + 1).ToString();
                row.Drzava = drzava.Naziv;
                row.Grad = drzava.Gradovi.ElementAt(i).Naziv;
                row.Aktivan = drzava.Gradovi.ElementAt(i).Status ? "DA" : "NE";
                dataTable.AddGradoviRow(row);
            }

            var dataSource = new ReportDataSource();
            dataSource.Name = "dsGradovi";
            dataSource.Value = dataTable;
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            var pCollection = new ReportParameterCollection();
            pCollection.Add(pBrG);
            reportViewer1.LocalReport.SetParameters(pCollection);
            
            
                
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            
            reportViewer1.RefreshReport();
        }
    }
}
