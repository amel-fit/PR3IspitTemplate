using FIT.Data;
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
    public partial class frmStudentInfoIB230046 : Form
    {
        public Student Student { get; set; }
        public frmStudentInfoIB230046(Student student)
        {
            InitializeComponent();
            Student = student;
            pbSlika.Image = Image.FromStream(new MemoryStream(student.Slika));
            lblImePrezime.Text = student.ImePrezime;
            lblProsjek.Text = $"Prosjek: {student.Prosjek}";
            this.Text = student.Indeks;
        }
    }
}
