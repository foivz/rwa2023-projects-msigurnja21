using Alat_za_praćenje_osobnih_financija.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alat_za_praćenje_osobnih_financija
{
    public partial class FrmUnesiTrošak : Form
    {
        public FrmUnesiTrošak()
        {
            InitializeComponent();
        }

        private void btnUnesiTrošak_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            if (!string.IsNullOrWhiteSpace(txtŠifra.Text) && !string.IsNullOrWhiteSpace(txtIznos.Text) && !string.IsNullOrWhiteSpace(txtIznos.Text))
            {
                Troskovi troskovi = new Troskovi()
                {
                    Kategorija_troska = txtŠifra.Text,
                    Id_Korisnika = logiranKorisnik.Id,
                    Datum = dtpDatum.Value,
                    Iznos = double.Parse(txtIznos.Text),
                    Komentar = txtKomentar.Text,
                };
                using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
                {
                    context.Troskovis.Add(troskovi);
                    context.SaveChanges();
                }
                MessageBox.Show("Trošak uspješno dodan!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
