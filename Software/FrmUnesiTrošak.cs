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
    public partial class FrmUnesiTrošak : Form
    {
        public FrmUnesiTrošak()
        {
            InitializeComponent();
        }

        private void btnDodajŠifru_Click(object sender, EventArgs e)
        {
            FrmNovaŠifra frmNovaŠifra = new FrmNovaŠifra();  //stvaranje objekta nove forme za unos nove šifre kategorije
            frmNovaŠifra.ShowDialog();                       //otvaranje forme za unos nove šifre kategorije
        }
    }
}
