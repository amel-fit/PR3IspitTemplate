using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB230046
{
    [Table("StudentiPorukeIB230046")]
    public class StudentPorukaIB230046
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
        public string Hitnost { get; set; }
        public DateTime Validnost { get; set; }

        public virtual Student Student { get; set; }
        public virtual PredmetIB230046 Predmet { get; set; }

        [NotMapped]
        public Image SlikaIMG { get; set; }
        [NotMapped]
        public string PredmetTXT { get; set; }

    }
}
