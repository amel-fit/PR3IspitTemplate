using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB230046
{
    public class UlogaIB230046
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
