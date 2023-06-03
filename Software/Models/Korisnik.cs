using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alat_za_praćenje_osobnih_financija.Models
{
    public abstract class Korisnik
    {
        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Lozinka { get; set; }
    }
}
