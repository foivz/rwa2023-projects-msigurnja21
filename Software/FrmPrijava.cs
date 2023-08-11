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
    public partial class FrmPrijava : Form
    {
        public static Korisnici LogiranKorisnik { get; set; }
        public FrmPrijava()
        {
            InitializeComponent();
        }

       
        private void btnPrijava_Click(object sender, EventArgs e)  
        {
            if(txtKorisnickoIme.Text == "" || txtLozinka.Text == "")    
            {
                MessageBox.Show("Unesite korisničke podatke!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);                                         //zatvaranje forme za prijavu
            }
            else                                                                    
            {
                using (var context = new RWA23_msigurnja21_DBEntities())
                {
                    var korisnik = from k in context.Korisnicis
                                     where k.Korisnicko_ime == txtKorisnickoIme.Text
                                     select k;
                     LogiranKorisnik = korisnik.FirstOrDefault();
                }
               if (LogiranKorisnik != null && LogiranKorisnik.ProvjeriLozinku(txtLozinka.Text))
                {
                    Hide();
                    var form = new FrmTroškovi();
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Neispravni korisnički podaci!");
                }
            }
        }
    }
}
