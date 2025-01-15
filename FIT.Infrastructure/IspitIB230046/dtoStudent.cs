using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB230046
{
    
    public class dtoStudent
    {
        private DLWMSDbContext dbContext { get; set; } = new();
        public string Indeks { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public UlogaIB230046 Uloga { get; set; }
        public bool Aktivan { get; set; }
        public float Prosjek {  get; set; }

        public Student student { get; set; }
        public dtoStudent(Student s)
        {
            student = s;
            Indeks = s.Indeks;
            DatumRodjenja = s.DatumRodjenja;
            ImePrezime = $"{s.Ime} {s.Prezime} ({DateTime.Now.Year - DatumRodjenja.Year})";
            Aktivan = s.Aktivan;
            Prosjek = GetProsjek(s);
            Uloga = GetUloga(s);
        }

        private UlogaIB230046? GetUloga(Student s)
        {

            var result = dbContext.StudentiUloge.Where(su => su.StudentId == s.Id).Include(su => su.Uloga).FirstOrDefault();
            UlogaIB230046? uloga = null;
            if (result != null)
                uloga = dbContext.Uloge.FirstOrDefault(u => u.Id == result.UlogaId);
            return uloga;
        }

        private float GetProsjek(Student s)
        {
            float prosjek = 0;
            int counter = 0;
            var lstPredmeti = dbContext.PolozeniPredmeti.Where(pp => pp.StudentId == s.Id).ToList();
            foreach(var pp in lstPredmeti)
            {
                prosjek += pp.Ocjena;
                counter++;
            }
            return prosjek / MathF.Max(1, counter);
        }
    }
}
