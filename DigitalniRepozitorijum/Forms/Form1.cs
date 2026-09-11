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
using DigitalniRepozitorijum.Forms;

namespace DigitalniRepozitorijum
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            PoveziMapiranja();
        }

        private void PoveziMapiranja()
        {
            try 
            {
                ISession s=DataLayer.GetSession();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno povezivanje mapiranja\n" + ex.Message.ToString() + ex.InnerException.ToString());
            }
        }

        private void btnDodajIstrazivaca_Click(object sender, EventArgs e)
        {
            try
            {

                Form form = new FormDodajIstrazivaca();
                form.ShowDialog();
                /*
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

                Recenzent recezent = new Recenzent();
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
                */
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

                Form form = new FormDodajNII();
                form.ShowDialog();
                /*ISession s = DataLayer.GetSession();

                NaucnoIstrazivackaInstitucija n2 = s.Load<NaucnoIstrazivackaInstitucija>(1);
                NaucnoIstrazivackaInstitucija n = new NaucnoIstrazivackaInstitucija();
                n.Naziv = "Institut Podvodnih Istrazivanja";
                n.Adresa = "Nikole Tesle 32";
                s.SaveOrUpdate(n);


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



                s.Close();*/
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
            {/*
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
                s.Close();*/
                Form f = new FormDodajIstrazivackiRezultat();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnPoveziIstrazivacNII_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s=DataLayer.GetSession();
                List<Urednik> urednikList=s.Query<Urednik>().ToList();
                foreach(Urednik u in urednikList)
                {
                    foreach (RundaRecenzije rr in u.RundeRecenzije)
                    {
                        MessageBox.Show(rr.BrojRunde.ToString() + rr.DatumOdluke.ToString() + rr.KonacnaOdluka);
                    }
                }
                /*
                ISession s = DataLayer.GetSession();

                Istrazivac i = s.Load<Istrazivac>(5);
                NaucnoIstrazivackaInstitucija n = s.Load<NaucnoIstrazivackaInstitucija>(1);
                Angazovanje a = new Angazovanje();
                a.ID_I = i;
                a.ID_NII = n;
                a.TipAngazovanja = "STALNI";
                a.DatumAngazovanja = new DateTime(2005, 5, 5);
                a.OrganizacionaJedinica = "Katedra za biologiju";
                a.NazivPozicije = "Profesor";

                s.Save(a);
                s.Flush();
                s.Close();*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnDodajPublikaciju_Click(object sender, EventArgs e)
        {
            try
            {
                Form dodajICitat =new FormDodajCitat();
                dodajICitat.ShowDialog();
                /*
                ISession s = DataLayer.GetSession();
                Publikacija p = new Publikacija();
                p.ID_IR = s.Load<Dataset>(2);
                Publikacija p2 = new Publikacija();
                p2.ID_IR = s.Load<SoftverskiArtifakt>(3);
                s.Save(p);
                s.Save(p2);

                Citat c = new Citat(p, p2);
                c.KontekstCitiranja = "Neki kontekst citiranja";
                c.MestoCitiranja = "25 str. 5 paragraf";
                c.TipCitata = "DIREKTAN";
                
                p.CitiranePublikacije.Add(c);
                p2.CitirajucePublikacije.Add(c);

                s.Save(c);
                s.Flush();
                s.Close();*/
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            

        }

        private void btnAutorstvo_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                ISession s = DataLayer.GetSession();
               
                Autor autor =s.Load<Autor>(8);
                Publikacija p=s.Load<Publikacija>(1);
                Autorstvo a = new Autorstvo(autor,p);
                a.UlogaUPublikaciji = "Glavni autor";
                a.TipDoprinosa = "Izvrsio  istrazivanje i napisa prvi draft";
                a.RedniBrojAutora = 1;
                autor.Autorstva.Add(a);
                p.Autorstva.Add(a);

                s.Save(a);
                s.Flush();
                s.Close();*/
                Form angazovanje = new FormAngazovanje();
                angazovanje.ShowDialog();
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
        }

        private void btnUredjuje_Click(object sender, EventArgs e)
        {
            /*
            ISession s= DataLayer.GetSession();
            KnjigaIliPoglavlja k = new KnjigaIliPoglavlja();
            k.Apstrakt = "neka knjiga";
            k.DatumObjavljivanja = new DateTime(2000, 2, 23);
            k.DatumKreiranja = new DateTime(1992, 2, 22);
            k.Naslov = "Naslov prve knjige";
            k.StatusIR = "OBJAVLJEN";
            k.Vidljivost = 1;
            k.Izdavac = "Laguna";
            k.MestoIzdavanja = "Nis";

            s.Save(k);
            Urednik u = s.Load<Urednik>(5);

            Uredjuje uredjuje = new Uredjuje(k, u);

            k.Urednici.Add(uredjuje);
            u.Knjige.Add(uredjuje);


            s.Save(uredjuje);
            s.Flush();
            s.Close();*/
            Form rundaRecenzije = new FormDodajRunduRecenzije();
            rundaRecenzije.ShowDialog();
        }

        private void btnPublikacijaVeze_Click(object sender, EventArgs e)
        {
            Form publikacija = new FormDodajPublikaciju();
            publikacija.ShowDialog();
            /*
            ISession s=DataLayer.GetSession();
            Publikacija p=new Publikacija();
            s.Save(p);
            RundaRecenzije rr=new RundaRecenzije();
            Urednik u = s.Load<Urednik>(5);
            Recenzent r=s.Load<Recenzent>(2);
            Recenzent r2 = s.Load<Recenzent>(4);
            AngazovanjeRecenzent ar=new AngazovanjeRecenzent();
            AngazovanjeRecenzent ar2 = new AngazovanjeRecenzent();
            OcenaRecenzenta o=new OcenaRecenzenta();
            OcenaRecenzenta o2 = new OcenaRecenzenta();
            OcenaRecenzenta o3 = new OcenaRecenzenta();
            OcenaRecenzenta o4 = new OcenaRecenzenta();

            u.RundeRecenzije.Add(rr);
            p.RundeRecenzije.Add(rr);
            r.RundeRecenzije.Add(ar);
            r2.RundeRecenzije.Add(ar2);
            rr.Recenzenti.Add(ar);
            rr.Recenzenti.Add(ar2);
            ar.Ocene.Add(o);
            ar.Ocene.Add(o2);
            ar2.Ocene.Add(o3);
            ar2.Ocene.Add(o4);
            

            ar.Preporuka = "DA";
            ar.BrojRunde = 1;
            ar.ID_P = p;
            ar.ID_Recenzenta = r;


            ar2.Preporuka = "NE";
            ar2.BrojRunde = 1;
            ar2.ID_P = p;
            ar2.ID_Recenzenta = r2;
            

            rr.KonacnaOdluka = "POTREBNA_REVIZIJA";
            rr.DatumOdluke = new DateTime(2022, 2, 2);
            rr.BrojRunde = 1;
            rr.ID_P = p;
            rr.ID_Urednika = u;
            

            o.Ocena = 5;
            o.AngazovanjeRecenzent = ar;
            o2.Ocena = 3;
            o2.AngazovanjeRecenzent = ar;
           

            o3.Ocena = 1;
            o3.AngazovanjeRecenzent = ar2;
            o4.Ocena = 4;
            o4.AngazovanjeRecenzent = ar2;
            
            
            
            s.Save(rr);
            s.Save(ar);
            s.Save(ar2);
            s.Save(o);
            s.Save(o2);
            s.Save(o3);
            s.Save(o4);

            s.Flush();
            s.Close();*/
        }
    }
}
