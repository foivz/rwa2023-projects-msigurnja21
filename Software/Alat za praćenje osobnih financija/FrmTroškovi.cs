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
    public partial class FrmTroškovi : Form
    {
        public FrmTroškovi()
        {
            InitializeComponent();
        }


        private void bntUnesiTrošak_Click(object sender, EventArgs e)
        {
            FrmUnesiTrošak frmUnesiTrošak = new FrmUnesiTrošak();    //kreiranje objekta nove forme za unos troška
            frmUnesiTrošak.ShowDialog();                             //otvaranje forme za unos troška
        }
    }
}
