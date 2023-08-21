using Alat_za_praćenje_osobnih_financija.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alat_za_praćenje_osobnih_financija
{
    public partial class FrmUnesiPlaću : Form
    {
        public FrmUnesiPlaću()
        {
            InitializeComponent();
        }

        private void btnUneciPlacu_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            if (!string.IsNullOrWhiteSpace(txtIznos.Text))
            {
                Place place = new Place()
                {
                    Id_Korisnika = logiranKorisnik.Id,
                    Iznos = double.Parse(txtIznos.Text),
                    Datum = dtpDatum.Value
                };
                using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
                {
                    context.Places.Add(place);
                    context.SaveChanges();
                }
                MessageBox.Show("Plaća je uspješno dodana!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
