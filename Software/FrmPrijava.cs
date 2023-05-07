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
        public FrmPrijava()
        {
            InitializeComponent();
        }

       
        private void btnPrijava_Click(object sender, EventArgs e)  // Prijava u sustav 
        {
            if(txtKorisnickoIme.Text == "test" && txtLozinka.Text == "test")    //ako su uneseni dobri korisnički podaci
            {
                FrmTroškovi frmtroškovi = new FrmTroškovi();            //stvaranje objekta nove forme za prikaz troškova
                Hide();                                                 //skrivanje forme za prijavu
                frmtroškovi.ShowDialog();                               //otvaranje forme troškova    
                Close();                                                //zatvaranje forme za prijavu
            }
            else                                                                        //ako su uneseni pogrešni korisnički podaci
            {
                MessageBox.Show("Pogrešni korisnički podaci", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
