using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alat_za_praćenje_osobnih_financija.Models
{
    public abstract class Placa
    {
        public double Iznos { get; set; }   
        public string Datum { get; set; }
    }
}
