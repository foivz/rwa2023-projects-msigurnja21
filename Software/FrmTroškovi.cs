using Alat_za_praćenje_osobnih_financija.Models;
using Alat_za_praćenje_osobnih_financija.Upiti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            FrmUnesiTrošak frmUnesiTrošak = new FrmUnesiTrošak();   
            frmUnesiTrošak.ShowDialog();
            PrikazStatistike();
        }

        private void FrmTroškovi_Load(object sender, EventArgs e)
        {
            UpitiTroskovi upit = new UpitiTroskovi();
            List<Troskovi> troskovi = upit.PrikazSvihTroskova();
            dgvPrikazTroškova.DataSource = troskovi;
            dgvPrikazTroškova.Columns["Komentar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;

            //prikat statistike
            PrikazStatistike();

        }

        private void PrikazStatistike()
        {
            Series series = new Series("Troškovi");
            series.ChartType = SeriesChartType.SplineArea;

            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var troskovi = context.Troskovis.OrderBy(Troskovi => Troskovi.Datum).ToList();
                var place = context.Places.OrderBy(Place => Place.Datum).ToList();

                DateTime minDate = troskovi.Any() ? troskovi.First().Datum : DateTime.MaxValue;
                if (place.Any() && place.First().Datum < minDate)
                {
                    minDate = place.First().Datum;
                }

                double stanje = 0;
                DateTime danas = DateTime.Now;


                while (minDate <= DateTime.Today)
                {
                    double iznosTroska = troskovi.Where(Troskovi => Troskovi.Datum == minDate).Sum(Troskovi => Troskovi.Iznos);
                    double iznosPlace = place.Where(Place => Place.Datum == minDate).Sum(Place => Place.Iznos);

                    stanje += iznosPlace - iznosTroska;

                    if (minDate.Year == danas.Year && minDate.Month == danas.Month)
                    {
                        series.Points.AddXY(minDate, stanje);
                    }
                    minDate = minDate.AddDays(1);

                }


            }

            chStatistika.Series.Clear();
            chStatistika.Series.Add(series);
            chStatistika.ChartAreas[0].AxisX.Title = "Datum";
            chStatistika.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MMM";
            chStatistika.ChartAreas[0].AxisY.Title = "Iznos";
            chStatistika.Invalidate();
        }

        private void odNajstarijegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpitiTroskovi upit = new UpitiTroskovi();
            List<Troskovi> troskovi = upit.PrikazTroskovaOdNajstarijeg();
            dgvPrikazTroškova.DataSource = troskovi;
            dgvPrikazTroškova.Columns["Komentar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void odNajnovijegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpitiTroskovi upit = new UpitiTroskovi();
            List<Troskovi> troskovi = upit.PrikazTroskovaOdNajnovijeg();
            dgvPrikazTroškova.DataSource = troskovi;
            dgvPrikazTroškova.Columns["Komentar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void hranaIPićeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpitiTroskovi upit = new UpitiTroskovi();
            List<Troskovi> troskovi = upit.PrikazTroskovaPoKategorijama("1");
            dgvPrikazTroškova.DataSource = troskovi;
            dgvPrikazTroškova.Columns["Komentar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void kupovineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpitiTroskovi upit = new UpitiTroskovi();
            List<Troskovi> troskovi = upit.PrikazTroskovaPoKategorijama("2");
            dgvPrikazTroškova.DataSource = troskovi;
            dgvPrikazTroškova.Columns["Komentar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void dugovanjaIPotraživanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpitiTroskovi upit = new UpitiTroskovi();
            List<Troskovi> troskovi = upit.PrikazTroskovaPoKategorijama("3");
            dgvPrikazTroškova.DataSource = troskovi;
            dgvPrikazTroškova.Columns["Komentar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void mjesečnaČlanstvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpitiTroskovi upit = new UpitiTroskovi();
            List<Troskovi> troskovi = upit.PrikazTroskovaPoKategorijama("4");
            dgvPrikazTroškova.DataSource = troskovi;
            dgvPrikazTroškova.Columns["Komentar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void nezgodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpitiTroskovi upit = new UpitiTroskovi();
            List<Troskovi> troskovi = upit.PrikazTroskovaPoKategorijama("5");
            dgvPrikazTroškova.DataSource = troskovi;
            dgvPrikazTroškova.Columns["Komentar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void btnUnesiPlaću_Click(object sender, EventArgs e)
        {
            FrmUnesiPlaću frmUnesiPlaću = new FrmUnesiPlaću();
            frmUnesiPlaću.ShowDialog();
            PrikazStatistike();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            FrmIzvjestaj frmIzvjestaj = new FrmIzvjestaj();
            frmIzvjestaj.ShowDialog();
        }
    }
    
}
