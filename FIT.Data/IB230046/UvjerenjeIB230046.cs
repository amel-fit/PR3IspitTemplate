using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230046
{
    [Table("StudentiUvjerenjaIB230046")]
    public class UvjerenjeIB230046
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
        public UvjerenjeIB230046()
        {
            
        }
    }
}
