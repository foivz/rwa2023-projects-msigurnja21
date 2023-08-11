using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alat_za_praćenje_osobnih_financija.Models
{
    public partial class Korisnici
    {
        public bool ProvjeriLozinku(string lozinka)
        {
            return Lozinka == lozinka;
        }
    }
}
