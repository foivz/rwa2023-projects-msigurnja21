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
        }

        private void FrmTroškovi_Load(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis 
                            where t.Id_Korisnika == logiranKorisnik.Id
                            select t;
                troskovis = query.ToList();
            }
            dgvPrikazTroškova.DataSource = troskovis;
            dgvPrikazTroškova.Columns["Komentar"].Width = 368;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;

        }

        private void odNajstarijegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis
                            where t.Id_Korisnika == logiranKorisnik.Id
                            orderby t.Datum ascending
                            select t;
                troskovis = query.ToList();
            }
            dgvPrikazTroškova.DataSource = troskovis;
            dgvPrikazTroškova.Columns["Komentar"].Width = 368;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void odNajnovijegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis
                            where t.Id_Korisnika == logiranKorisnik.Id
                            orderby t.Datum descending
                            select t;
                troskovis = query.ToList();
            }
            dgvPrikazTroškova.DataSource = troskovis;
            dgvPrikazTroškova.Columns["Komentar"].Width = 368;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void hranaIPićeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis
                            where t.Id_Korisnika == logiranKorisnik.Id && t.Kategorija_troska.StartsWith("1")
                            select t;
                troskovis = query.ToList();
            }
            dgvPrikazTroškova.DataSource = troskovis;
            dgvPrikazTroškova.Columns["Komentar"].Width = 368;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void kupovineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis
                            where t.Id_Korisnika == logiranKorisnik.Id && t.Kategorija_troska.StartsWith("2")
                            select t;
                troskovis = query.ToList();
            }
            dgvPrikazTroškova.DataSource = troskovis;
            dgvPrikazTroškova.Columns["Komentar"].Width = 368;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void dugovanjaIPotraživanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis
                            where t.Id_Korisnika == logiranKorisnik.Id && t.Kategorija_troska.StartsWith("3")
                            select t;
                troskovis = query.ToList();
            }
            dgvPrikazTroškova.DataSource = troskovis;
            dgvPrikazTroškova.Columns["Komentar"].Width = 368;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void mjesečnaČlanstvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis
                            where t.Id_Korisnika == logiranKorisnik.Id && t.Kategorija_troska.StartsWith("4")
                            select t;
                troskovis = query.ToList();
            }
            dgvPrikazTroškova.DataSource = troskovis;
            dgvPrikazTroškova.Columns["Komentar"].Width = 368;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }

        private void nezgodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis
                            where t.Id_Korisnika == logiranKorisnik.Id && t.Kategorija_troska.StartsWith("5")
                            select t;
                troskovis = query.ToList();
            }
            dgvPrikazTroškova.DataSource = troskovis;
            dgvPrikazTroškova.Columns["Komentar"].Width = 368;
            dgvPrikazTroškova.Columns["Korisnici"].Visible = false;
            dgvPrikazTroškova.Columns["Id"].Visible = false;
            dgvPrikazTroškova.Columns["Id_Korisnika"].Visible = false;
        }
    }
    
}
