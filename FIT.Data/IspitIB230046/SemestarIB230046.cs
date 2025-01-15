using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB230046
{
    [Table("Semestri")]
    public class SemestarIB230046
    {
        public int Id { get; set; }
        public string Oznaka { get; set; }
        public string Opis { get; set; }
        public bool Aktivan { get; set; }

        public override string ToString()
        {
            return $"{Id}. Semestar";
        }
    }
}
