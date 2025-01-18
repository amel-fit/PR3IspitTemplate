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

        public virtual SpolIB230046 Spol {  get; set; }
        public virtual SemestarIB230046 Semestar { get; set; }
        public virtual List<PolozeniPredmetIB230046> PolozeniPredmeti { get; set; } = new();
        public virtual List<UvjerenjeIB230046> Uvjerenja { get; set; } = new();
        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";

        [NotMapped]
        public double Prosjek => PolozeniPredmeti.Count == 0 ? 5 : PolozeniPredmeti.Average(pp => pp.Ocjena);   


    }
}
