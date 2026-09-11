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
    public partial class FormUnos : Form
    {
        public FormUnos()
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
                Form dodajUlogu=new FormDodajUlogu();
                dodajUlogu.ShowDialog();
                /*
                ISession s = DataLayer.GetSession();


                Autor autor = new Autor();
                autor.Orcid = "1233-1212-2112-123X";
                
                s.Save(autor);
                s.Flush();
                s.Close();*/
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
                /*
                ISession s=DataLayer.GetSession();
                List<Urednik> urednikList=s.Query<Urednik>().ToList();
                foreach(Urednik u in urednikList)
                {
                    foreach (RundaRecenzije rr in u.RundeRecenzije)
                    {
                        MessageBox.Show(rr.BrojRunde.ToString() + rr.DatumOdluke.ToString() + rr.KonacnaOdluka);
                    }
                }*/

                Form angazovanje = new FormAngazovanje();
                angazovanje.ShowDialog();
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
                Form publikacija = new FormDodajPublikaciju();
                publikacija.ShowDialog();

               
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

       

        

        private void btnDodajCitat_Click(object sender, EventArgs e)
        {
            Form dodajICitat = new FormDodajCitat();
            dodajICitat.ShowDialog();
        }

        private void btnDodajRundu_Click(object sender, EventArgs e)
        {
            Form rundaRecenzije = new FormDodajRunduRecenzije();
            rundaRecenzije.ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s=DataLayer.GetSession();
                List<Recenzent> rec = s.Query<Recenzent>().ToList();
                foreach(Recenzent r in rec)
                {
                    Console.WriteLine(r.ToString());
                }
                List<Urednik> ur = s.Query<Urednik>().ToList();
                foreach (Urednik u in ur)
                {
                    Console.WriteLine(u.ToString());
                }

            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
