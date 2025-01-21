using FIT.Data.IB230046;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public int SemestarId { get; set; }
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
        public virtual DrzavaIB230046 Drzava{ get; set; }
        public virtual GradIB230046 Grad { get; set; }
        public virtual List<PolozeniPredmetiIB230046> PolozeniPredmeti { get; set; }

        [NotMapped]
        public double Prosjek => PolozeniPredmeti.Count == 0 ? 5 : PolozeniPredmeti.Average(pp => pp.Ocjena);
        [NotMapped]
        public string GradTXT => Grad.Naziv;
        [NotMapped]
        public string DrzavaTXT => Drzava.Naziv;
    }
}
