using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.WinForms.IB230046
{
    public static class DataBase
    {
        public static DLWMSDbContext dbContext { get; set; } = new();
    }
}
