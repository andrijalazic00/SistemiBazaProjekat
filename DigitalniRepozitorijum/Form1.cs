using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using DigitalniRepozitorijum.Entities;

namespace DigitalniRepozitorijum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajIstrazivaca_Click(object sender, EventArgs e)
        {
            try
            {


                ISession s = DataLayer.GetSession();

                Istrazivac I = new Istrazivac();

                Mail mail = new Mail();
                Mail mail2 = new Mail();
                mail.MailAdresa = "znalac6@gmail.com";
                mail2.MailAdresa = "znalac7@gmail.com";
                mail.ID_I = I;
                mail2.ID_I = I;

                Telefon telefon = new Telefon();
                Telefon telefon2 = new Telefon();
                telefon.Broj = "0621114355";
                telefon2.Broj = "066103200";
                telefon.ID_I = I;
                telefon2.ID_I = I;

                Autor autor = new Autor();
                //Uloga uloga2= new Uloga();
                autor.Orcid = "1111-2222-3333-555X";
                autor.ID_I = I;

                OblastiEkspertize oe=new OblastiEkspertize();
                oe.Oblast = "Lednici";
                OblastiEkspertize oe2 = new OblastiEkspertize();
                oe2.Oblast = "Vuklani";

                Recezent recezent = new Recezent();
                recezent.ID_I = I;
                recezent.OblastiEkspertize.Add(oe);
                recezent.OblastiEkspertize.Add(oe2);

                oe.ID_U = recezent;
                oe2.ID_U = recezent;

                Urednik urednik = new Urednik();
                urednik.UredjivackaSekcija = "neka uredjivacka sekcija";
                urednik.ID_I = I;
                
                RukovodilacProjekta rp=new RukovodilacProjekta();
                rp.ID_I = I;
                
                AdministratorOvlascenja ovlascenje=new AdministratorOvlascenja();
                AdministratorOvlascenja ovlascenje2 = new AdministratorOvlascenja();
                ovlascenje.Ovlascenje = "Citanje";
                ovlascenje2.Ovlascenje = "Upis";


                AdministratorRepozitorijuma ar=new AdministratorRepozitorijuma();
                
                ovlascenje.ID_U = ar;
                ovlascenje2.ID_U = ar;

                ar.Ovlascenja.Add(ovlascenje);
                ar.Ovlascenja.Add(ovlascenje2);
                ar.ID_I = I;

               

                I.Mailovi.Add(mail);
                I.Mailovi.Add(mail2);
                I.Telefoni.Add(telefon);
                I.Telefoni.Add(telefon2);
                I.Uloge.Add(autor);
                I.Uloge.Add(recezent);
                I.Uloge.Add(urednik);
                I.Uloge.Add(rp);
                I.Uloge.Add(ar);


                I.DatumRodjenja = new DateTime(2000, 4, 25);
                I.Ime = "Pametan";
                I.Prezime = "Pametnjakovic";
                I.Drzava = "Srbija";
                I.NaucnaOblast = "Prirodne Nauke";
                I.NaucnoZvanje = "Doktor geografije";
                I.StatusNaucnika = "AKTIVAN";


                s.SaveOrUpdate(I);

                s.Flush();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnDodajNII_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                /*NaucnoIstrazivackaInstitucija n2 = s.Load<NaucnoIstrazivackaInstitucija>(1);
                NaucnoIstrazivackaInstitucija n = new NaucnoIstrazivackaInstitucija();
                n.Naziv = "Institut Podvodnih Istrazivanja";
                n.Adresa = "Nikole Tesle 32";
                s.SaveOrUpdate(n);*/


                NaucnoIstrazivackaInstitucija n = new NaucnoIstrazivackaInstitucija();

                MailInstitucija mail = new MailInstitucija();
                MailInstitucija mail2 = new MailInstitucija();
                mail.MailAdresa = "nekaNI@gmail.com";
                mail2.MailAdresa = "DrugiMail@gmail.com";
                mail.ID_NII = n;
                mail2.ID_NII = n;


                TelefonInstitucija telefon = new TelefonInstitucija();
                TelefonInstitucija telefon2 = new TelefonInstitucija();
                telefon.Broj = "062113555";
                telefon2.Broj = "069993444";
                telefon.ID_NII = n;
                telefon2.ID_NII = n;

                NaucnaOblast no=new NaucnaOblast();
                NaucnaOblast no2 = new NaucnaOblast();
                no.Oblast = "Nacionalni parkovi";
                no2.Oblast = "Organska Hemija";
                no.ID_NII = n;
                no2.ID_NII = n;


                n.Adresa = "Belog Galeba 25";
                n.Naziv = "Institucija NI2";

                n.Mailovi.Add(mail);
                n.Mailovi.Add(mail2);

                n.Telefoni.Add(telefon);
                n.Telefoni.Add(telefon2);

                n.NaucneOblasti.Add(no);
                n.NaucneOblasti.Add(no2);

                s.SaveOrUpdate(n);

                s.Flush();



                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Autor autor = new Autor();
                autor.Orcid = "1233-1212-2112-123X";
                
                s.Save(autor);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString() ); 
            }
        }

        private void btnDodajIR_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Dataset ds = new Dataset();
                ds.Naslov = "Neki dataset";
                ds.Apstrakt = "Dataset za testiranje mapiranja";
                ds.DatumKreiranja= new DateTime(2024, 2, 25);
                ds.DatumObjavljivanja = new DateTime(2026, 5, 30);
                ds.StatusIR = "OBJAVLJEN";
                ds.Vidljivost = 1;
                ds.Format = "Json";
                ds.Velicina = 1000;
                ds.BrojZapisa = 25000;
                ds.OpisStrukture = "Neka struktura";
                ds.PeriodObuhvataPodataka = "12.3.2010-12.3.2020";
                ds.LicencaKoriscenja = "Neka licenca";
                ds.OgranicenjaPristupa = "Neka ogranicenja pristupa";

                Verzija v=new Verzija();
                v.ID_IR = ds;
                v.BrojVerzije = 1;
                v.DatumPostavljanja = new DateTime(2024, 2, 3);
                v.OpisIzmena = "Neke izmene";
                v.OdgovornaOsoba = "Grof Drakula";

                Verzija v2 = new Verzija();
                v2.ID_IR = ds;
                v2.BrojVerzije = 2;
                v2.DatumPostavljanja = new DateTime(2024, 4, 3);
                v2.OpisIzmena = "Neke izmene druga verzija";
                v2.OdgovornaOsoba = "Grof Drakula";

                KljucnaRec kr=new KljucnaRec();
                kr.ID_IR = ds;
                kr.Rec = "Zelenilo";
                
                KljucnaRec kr2 = new KljucnaRec();
                kr2.ID_IR = ds;
                kr2.Rec = "Drvo";

                ds.KljucneReci.Add(kr);
                ds.KljucneReci.Add(kr2);
                ds.Verzije.Add(v);
                ds.Verzije.Add(v2);
                /////////////////////////////
                
                SoftverskiArtifakt sa=new SoftverskiArtifakt();
                sa.Naslov = "Neki softverski artifakt";
                sa.Apstrakt = "Softverski artifakt za testiranje mapiranja";
                sa.DatumKreiranja = new DateTime(2022, 2, 25);
                sa.DatumObjavljivanja = new DateTime(2023, 5, 30);
                sa.StatusIR = "U_PRIPREMI";
                sa.ProgramskiJezik = "C#";
                sa.RepoLink = "www.neikrepo.com";
                sa.NacinLicenciranja = "Perpetulal Licence";
                sa.Dokumentacija = "Neka dokumentacija";

                PodrzanaPlatforma pp=new PodrzanaPlatforma();
                pp.ID_IR = sa;
                pp.Platforma = "LINUX";

                PodrzanaPlatforma pp2 = new PodrzanaPlatforma();
                pp2.ID_IR = sa;
                pp2.Platforma = "WINDOWS";

                Verzija v3 = new Verzija();
                v3.ID_IR = sa;
                v3.BrojVerzije = 1;
                v3.DatumPostavljanja = new DateTime(2024, 4, 3);
                v3.OpisIzmena = "Neke izmene";
                v3.OdgovornaOsoba = "Pavle Pavlovic";

                Verzija v4 = new Verzija();
                v4.ID_IR = sa;
                v4.BrojVerzije = 2;
                v4.DatumPostavljanja = new DateTime(2025, 4, 3);
                v4.OpisIzmena = "Neke izmene druga verzija";
                v4.OdgovornaOsoba = "Pavle Pavlovic";

                KljucnaRec kr3 = new KljucnaRec();
                kr3.ID_IR = sa;
                kr3.Rec = "Trotoar";

                KljucnaRec kr4 = new KljucnaRec();
                kr4.ID_IR = sa;
                kr4.Rec = "Pesak";

                sa.PodrzanePlatforme.Add(pp);
                sa.PodrzanePlatforme.Add(pp2);
                sa.Verzije.Add(v3);
                sa.Verzije.Add(v4);
                sa.KljucneReci.Add(kr3);
                sa.KljucneReci.Add(kr4);


                s.Save(ds);
                s.Save(sa);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
