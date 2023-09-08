using Alat_za_praćenje_osobnih_financija.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alat_za_praćenje_osobnih_financija.Upiti
{
    public class UpitiTroskovi
    {
        public List<Troskovi> PrikazSvihTroskova()
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
            return troskovis;
        }

        public List<Troskovi> PrikazTroskovaOdNajstarijeg()
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
            return troskovis;
        }

        public List<Troskovi> PrikazTroskovaOdNajnovijeg()
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
            return troskovis;
        }

        public List<Troskovi> PrikazTroskovaPoKategorijama(string kategorija)
        {
            Korisnici logiranKorisnik = FrmPrijava.LogiranKorisnik;
            List<Troskovi> troskovis;
            using (var context = new AlatZaPraćenjeOsobnihFinancijaEntities())
            {
                var query = from t in context.Troskovis
                            where t.Id_Korisnika == logiranKorisnik.Id && t.Kategorija_troska.StartsWith(kategorija)
                            select t;
                troskovis = query.ToList();
            }
            return troskovis;
        }
    }

}
