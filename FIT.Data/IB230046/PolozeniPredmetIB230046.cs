using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230046
{

    [Table("PolozeniPredmeti")]
    public class PolozeniPredmetIB230046
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public PredmetIB230046 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }

    }
}
