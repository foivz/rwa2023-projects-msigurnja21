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
    public partial class FrmIzvjestaj : Form
    {
        public FrmIzvjestaj()
        {
            InitializeComponent();
        }

        private void FrmIzvjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'troskoviDataSet.Troskovi' table. You can move, or remove it, as needed.
            this.troskoviTableAdapter.Fill(this.troskoviDataSet.Troskovi);

            this.rpvTroskovi.RefreshReport();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
