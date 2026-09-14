using NHibernate;
using datalibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using datalibrary.DTOs;
using datalibrary;
using System.Data.Common;
using FluentNHibernate.Conventions.AcceptanceCriteria;
using NHibernate.Linq;
using Microsoft.VisualBasic;
using System.Globalization;
using FluentNHibernate.Utils;
using NHibernate.Event;
using NHibernate.SqlCommand;
using System.Diagnostics;
using System.Data;
using NHibernate.Linq.Expressions;

namespace datalibrary
{
    public class DataProvider
    {
        #region  NaucnoIstrazivackaInstitucija


        public static List<MailInstitucijaView> VratiMailInstitucije(int ID_NII)
        {
            List<MailInstitucijaView> svimailoviinstitucije = [];

            try
            {
                ISession s = DataLayer.GetSession();
                
                IEnumerable<MailInstitucija> mailoviinstitucije = from o in s.Query<MailInstitucija>()
                                                        where o.ID_NII.ID_NII == ID_NII    select o;
                
                foreach( MailInstitucija m in mailoviinstitucije)
                {
                    svimailoviinstitucije.Add( new MailInstitucijaView(m));

                    
                }

                s.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Greska pri pristupu funkcije VratiMailInstitucije");
                throw;                
            }

            return svimailoviinstitucije;
        }     

        public static List<TelefonInstitucijaView> VratiBrojeviInstitucije(int ID_NII)
        {
            List<TelefonInstitucijaView> svitelefoniinstitucije = [];

            try
            {
                ISession s = DataLayer.GetSession();
                
                IEnumerable<TelefonInstitucija> telefoniinstitucije = from o in s.Query<TelefonInstitucija>()
                                                        where o.ID_NII.ID_NII == ID_NII    select o;
                
                foreach( TelefonInstitucija t in telefoniinstitucije)
                {
                    svitelefoniinstitucije.Add( new TelefonInstitucijaView(t));

                    
                }

                s.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Greska pri pristupu funkcije VratiTelefoniInstitucije");
                throw;                
            }

            return svitelefoniinstitucije;
        }

        public static List<NaucnaOblastView> VratiOblastiInstitucije(int ID_NII)
        {
            List<NaucnaOblastView> sveoblastiinstitucije = new List<NaucnaOblastView>();

            try
            {
                ISession s = DataLayer.GetSession();
                
                IEnumerable<NaucnaOblast> oblastiinstitucije = from o in s.Query<NaucnaOblast>()
                                                        where o.ID_NII.ID_NII == ID_NII    select o;
                
                foreach( NaucnaOblast no in oblastiinstitucije)
                {
                    sveoblastiinstitucije.Add( new NaucnaOblastView(no));
                }

                s.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Greska pri pristupu funkcije VratiOblastiInstitucije");
                throw;                
            }

            return sveoblastiinstitucije;
        }   

        public static NaucnoIstrazivackaInstitucijaView VratiNIInstituciju( int ID_NII)
        {
            NaucnoIstrazivackaInstitucijaView institucija;
            try
            {
                ISession s = DataLayer.GetSession();
                
                NaucnoIstrazivackaInstitucija i = s.Load<NaucnoIstrazivackaInstitucija>(ID_NII);

                List<MailInstitucijaView> mails = VratiMailInstitucije(i.ID_NII);

                List<TelefonInstitucijaView> telefons = VratiBrojeviInstitucije(i.ID_NII);

                List<NaucnaOblastView> oblasti = VratiOblastiInstitucije(i.ID_NII);

                 List<AngazovanjeView> angazovanji = VratiAngazovaneUInstituciji(i.ID_NII);              
                
                institucija = new ()
                {
                    ID_NII = i.ID_NII,
                    Naziv = i.Naziv,
                    Adresa = i.Adresa,
                    Mailovi = mails,
                    Telefoni = telefons,
                    NaucneOblasti = oblasti,
                    Angazovani = angazovanji
                };

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiNIInstituciju: "+ex);
                throw;
            }
            return institucija;
        }

        public static List<NaucnoIstrazivackaInstitucijaView> VratiInstitucije()
        {
            List<NaucnoIstrazivackaInstitucijaView> naucneinstitucije = new List<NaucnoIstrazivackaInstitucijaView>();

            try
            {
                ISession s = DataLayer.GetSession();
                
                IEnumerable<NaucnoIstrazivackaInstitucija> institucije = from o in s.Query<NaucnoIstrazivackaInstitucija>()
                                                                                select o;
                
                foreach( NaucnoIstrazivackaInstitucija n in institucije)
                {
                   NaucnoIstrazivackaInstitucijaView tmp = VratiNIInstituciju( n.ID_NII);
                    naucneinstitucije.Add(tmp);
                }

                s.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Greska pri pristupu funkcije VratiSveInstitucije");
                throw;                
            }

            return naucneinstitucije;
        }



        public static void DodajNaucnoIstrazivackuIstituciju( NaucnoIstrazivackaInstitucijaView n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NaucnoIstrazivackaInstitucija o = new ()
                {
                    Naziv = n.Naziv,
                    Adresa = n.Adresa
                };

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider, DodajNaucnoIstrazivackuInstituciju:\n "+ ex);
                throw;
            }
        }

        public static NaucnoIstrazivackaInstitucijaView AzurirajNaucnoIstrazivackuInstituciju(NaucnoIstrazivackaInstitucijaView n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NaucnoIstrazivackaInstitucija o = s.Load<NaucnoIstrazivackaInstitucija>(n.ID_NII);
                
                o.Naziv = n.Naziv;
                o.Adresa = n.Adresa;
            


                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Errot at DataProvider AzurirajNaucnoIstrazivackuInstituciju:\n"+ ex);
                throw;
            }

            return n;
        }

        public static void ObrisiNaucnoIstrazivackuInstituciju(int ID_NII)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NaucnoIstrazivackaInstitucija o = s.Load<NaucnoIstrazivackaInstitucija>(ID_NII);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiNaucnoIstrazivackuInstituciju: \n"+ex);
                throw;
            }
        }

        public static void DodajMailInstituciji(int ID_NII, string mail)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NaucnoIstrazivackaInstitucija n = s.Load<NaucnoIstrazivackaInstitucija>(ID_NII);

                MailInstitucija o = new ()
                {
                    ID_NII = n,
                    MailAdresa = mail
                };
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch( Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajMailIstituciji: "+ex);
                throw;
            }
        }

        public static void ObrisiMailIstituciji(int ID_NII, string mail)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var mailinstitucije = (from o in s.Query<MailInstitucija>()
                                        where  o.ID_NII.ID_NII == ID_NII && o.MailAdresa == mail select o).SingleOrDefault();

                if(mailinstitucije == null)
                {
                    Console.WriteLine("No mail");
                    return;
                }
                s.Delete(mailinstitucije);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiMailIstituciji: "+ex);
                throw;               
            }
        }

        public static void AzurirajMailInstituciji(int ID_NII, string starimail,string novimail)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ObrisiMailIstituciji(ID_NII, starimail);
                DodajMailInstituciji(ID_NII, novimail);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajMailInstituciji: "+ex);
                throw;               
            }
        }

        public static void DodajTelefonInstituciji(int ID_NII, string telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NaucnoIstrazivackaInstitucija n = s.Load<NaucnoIstrazivackaInstitucija>(ID_NII);

                TelefonInstitucija o = new()
                {
                    ID_NII = n,
                    Broj = telefon
                };
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch( Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajTelefonInstituciji: "+ex);
                throw;
            }
        }

        public static void ObrisiTelefonIstituciji(int ID_NII, string broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var brojeviinstitucje = (from o in s.Query<TelefonInstitucija>()
                                        where  o.ID_NII.ID_NII == ID_NII && o.Broj == broj select o).SingleOrDefault();

                if( brojeviinstitucje == null)
                {
                    Console.WriteLine("No Phone numbers");
                    return;
                }
                s.Delete(brojeviinstitucje);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiTelefonIstituciji: "+ex);
                throw;               
            }
        }

        public static void AzurirajTelefonInstituciji(int ID_NII, string straibroj,string novibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ObrisiTelefonIstituciji(ID_NII,straibroj);
                DodajTelefonInstituciji(ID_NII, novibroj);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajTelefonInstituciji: "+ex);
                throw;               
            }
        }

        #endregion
        #region  Istrazivaci

        public static List<MailView> VratiMailoveIstrazivaca(int ID_I)
        {

            List<MailView> svimailovi = [];
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Mail> mailovi = from o in s.Query<Mail>()
                                            where o.ID_I.ID_I == ID_I select o;

                foreach( Mail m in mailovi)
                {
                    svimailovi.Add( new MailView(m));
                }
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiMailoveIstrazivaca" +ex);
                throw;
            }

            return svimailovi;
        }



        public static List<TelefonView> VratiTelefoneIstrazivaca(int ID_I)
        {

            List<TelefonView> svitelefoni = [];
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Telefon> telefoni = from o in s.Query<Telefon>()
                                                    where o.ID_I.ID_I == ID_I select o;

                foreach( Telefon t in telefoni)
                {
                    svitelefoni.Add(new TelefonView(t));
                }
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiTelefoneIstrazivaca" +ex);
                throw;
            }

            return svitelefoni;
        }


        
        public static List<IstrazivacView> VratiSveIstrazivace()
        {
            
            List<IstrazivacView> sviistrazivaci = [];

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Istrazivac> istrazivaci = from o in s.Query<Istrazivac>()
                                                        select o;

                foreach( Istrazivac i in istrazivaci)
                {



                    IstrazivacView istrazivac  = VratiIstrazivaca( i.ID_I);
                    sviistrazivaci.Add(istrazivac);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiSveIstrazivace: "+ ex);
                throw;
            }

            return sviistrazivaci;
        }

        public static IstrazivacView VratiIstrazivaca(int Id)
        {
            IstrazivacView istrazivacView;

            try
            {
                ISession s = DataLayer.GetSession();

                Istrazivac i = s.Load<Istrazivac>(Id);
                istrazivacView = new(i);

                List<MailView> m = VratiMailoveIstrazivaca(i.ID_I);
                List<TelefonView> t = VratiTelefoneIstrazivaca( i.ID_I);
                List<AngazovanjeView> a = VratiAngazovanjeIstrazivaca( i.ID_I);
                List<UlogaView> u = VratiSveUlogeIstrazivaca(i.ID_I);
                istrazivacView.Mailovi = m;
                istrazivacView.Telefoni = t;
                istrazivacView.Institucije = a;
                istrazivacView.Uloge = u;

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiIstrazivaca: "+ ex);
                throw;
            }

            return istrazivacView;
        }

        public static void DodajIstrazivaca( IstrazivacView istrazivac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Istrazivac i = new ()
                {
                    Ime = istrazivac.Ime,
                    DatumRodjenja = istrazivac.DatumRodjenja,
                    Drzava = istrazivac.Drzava,
                    Prezime = istrazivac.Prezime,
                    NaucnaOblast = istrazivac.NaucnaOblast,
                    NaucnoZvanje = istrazivac.NaucnoZvanje,
                    StatusNaucnika = istrazivac.StatusNaucnika,
                };

                s.SaveOrUpdate(i);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajIstrazivaca:"+ ex);
                throw;
            }
        }


        public static void ObrisiIstrazivaca(int ID_I)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Istrazivac i = s.Load<Istrazivac>(ID_I);

                s.Delete(i);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiIstrazivaca:"+ ex);
                throw;
            }
        }

        public static void AzurirajIstrazivaca(IstrazivacView istrazivacView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Istrazivac i = s.Load<Istrazivac>(istrazivacView.ID_I);

                if(istrazivacView.Ime != "") i.Ime = istrazivacView.Ime;
                if(istrazivacView.Prezime != "") i.Prezime = istrazivacView.Prezime;
                if(istrazivacView.DatumRodjenja != i.DatumRodjenja) i.DatumRodjenja = istrazivacView.DatumRodjenja;
                if(istrazivacView.NaucnaOblast != "") i.NaucnaOblast= istrazivacView.NaucnaOblast;
                if(istrazivacView.NaucnoZvanje != "") i.NaucnaOblast = istrazivacView.NaucnoZvanje;
                if(istrazivacView.StatusNaucnika != i.StatusNaucnika ) i.StatusNaucnika = istrazivacView.StatusNaucnika;

                s.Update(i);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiIstrazivaca:"+ ex);
                throw;
            }
        }

                public static void DodajMailIstrazivacu(int ID_I, string mail)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Mail n = s.Load<Mail>(ID_I);

                Mail o = new Mail
                {
                    ID_I = n.ID_I,
                    MailAdresa = mail
                };
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch( Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajMailIstrazivacu: "+ex);
                throw;
            }
        }

        public static void ObrisiMailIstrazivacu(int ID_I, string mail)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var mailistrazivaca = (from o in s.Query<Mail>()
                                        where  o.ID_I.ID_I == ID_I && o.MailAdresa == mail select o).SingleOrDefault();

                if(mailistrazivaca == null)
                {
                    Console.WriteLine("No mail");
                    return;
                }
                s.Delete(mailistrazivaca);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiMailIstituciji: "+ex);
                throw;               
            }
        }

        public static void AzurirajMailIstrazivacu(int ID_I, string starimail,string novimail)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ObrisiMailIstrazivacu(ID_I, starimail);
                DodajMailIstrazivacu(ID_I, novimail);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajMailInstituciji: "+ex);
                throw;               
            }
        }

        public static void DodajTelefonIstrazivacu(int ID_I, string telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Istrazivac n = s.Load<Istrazivac>(ID_I);

                Telefon o = new Telefon
                {
                    ID_I = n,
                    Broj = telefon
                };
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch( Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajTelefonIstrazivacu: "+ex);
                throw;
            }
        }

        public static void ObrisiTelefonIstrazivacu(int ID_I, string broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var brojeviistrazivaca = (from o in s.Query<Telefon>()
                                        where  o.ID_I.ID_I == ID_I && o.Broj == broj select o).SingleOrDefault();

                if( brojeviistrazivaca == null)
                {
                    Console.WriteLine("No Phone numbers");
                    return;
                }
                s.Delete(brojeviistrazivaca);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiTelefonIstrazivacu: "+ex);
                throw;               
            }
        }

        public static void AzurirajTelefonIstrazivacu(int ID_I, string straibroj,string novibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ObrisiTelefonIstrazivacu(ID_I,straibroj);
                DodajTelefonIstrazivacu(ID_I, novibroj);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajTelefonInstituciji: "+ex);
                throw;               
            }
        }
                
        #endregion

        #region  Angazovanja

        public static List<AngazovanjeView> VratiAngazovanjeIstrazivaca(int ID_I)
        {   
            List<AngazovanjeView> svaAngazovanja = new List<AngazovanjeView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Angazovanje> angazovanja = from o in s.Query<Angazovanje>()
                                                        where o.ID_I.ID_I == ID_I select o;
                
                foreach ( Angazovanje a in angazovanja )
                {
                    AngazovanjeView v = new (a);
                    svaAngazovanja.Add(v);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiAngazovanjeIstrazivaca: "+ ex);
                throw;
            }

            return svaAngazovanja;
        }

        public static List<AngazovanjeView> VratiAngazovaneUInstituciji(int ID_NII)
        {   
            List<AngazovanjeView> sviAngazovani = [];
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Angazovanje> angazovani = from o in s.Query<Angazovanje>()
                                                    where o.ID_NII.ID_NII == ID_NII select o;
                
                foreach(Angazovanje a in angazovani)
                {
                    AngazovanjeView v = new (a);
                    sviAngazovani.Add(v);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiAngazovanjeIstrazivaca: "+ ex);
                throw;
            }

            return sviAngazovani;
        }


        public static void AngazujIstrazivacaUInstituciju( AngazovanjeView angazovano)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                List<AngazovanjeView> angazovanja = VratiAngazovanjeIstrazivaca(angazovano.ID_I.ID_I);
                foreach( AngazovanjeView a in angazovanja)
                {
                    if( a.ID_NII.ID_NII == angazovano.ID_NII.ID_NII)
                    {
                        Console.WriteLine("Istrazivac je vec Angazovan u ovoj Instituciji");
                        s.Close();
                        return;
                    }
                }

                Istrazivac istrazivac = s.Load<Istrazivac>(angazovano.ID_I);
                NaucnoIstrazivackaInstitucija institucija = s.Load<NaucnoIstrazivackaInstitucija>(angazovano.ID_NII);

                Angazovanje angazovanje = new ()
                {
                    ID_I = istrazivac,
                    ID_NII = institucija,
                    DatumAngazovanja = angazovano.DatumAngazovanja,
                    DatumZavrsetka = angazovano.DatumZavrsetka,
                    OrganizacionaJedinica = angazovano.OrganizacionaJedinica,
                    NazivPozicije = angazovano.NazivPozicije,
                    TipAngazovanja = angazovano.TipAngazovanja,

                };


                s.SaveOrUpdate(angazovanja);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AngazujIstrazivacaUInstituciju: "+ex);
                throw;
            }
        }



        #endregion
        #region  Uloge
        
        public static List<UlogaView> VratiSveUlogeIstrazivaca(int ID_I)
        {
            List<UlogaView> sveuloge = [];
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Uloga> uloge = from o in s.Query<Uloga>()
                                            where o.ID_I.ID_I == ID_I select o;

                foreach(Uloga u in uloge)
                { 
                    UlogaView uloga = VratiUlogu( u.ID_U);
                    sveuloge.Add(uloga);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider SveUloge: "+ ex);
                throw;
            }
            return sveuloge;
        }

        public static UlogaView VratiUlogu(int ID_U)
        {
            UlogaView uloga = new ();
            try
            {
                ISession s = DataLayer.GetSession();

                Uloga u = s.Load<Uloga>(ID_U);

                uloga = new UlogaView(u);

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiUlogu: "+ ex);
                throw;
            }
            return uloga;
        }

        #region Uloga-Rukovodilac
        public static void DodajRukovodioca(int ID_I)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Istrazivac i = s.Load<Istrazivac>(ID_I);

                RukovodilacProjekta rukovodilac = new ()
                {
                    ID_I = i
                };
                s.SaveOrUpdate( rukovodilac);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajRukovodioca: "+ ex);    
                throw;
            }
        }

       public static void ObrisiRukovodioca(int ID_U)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                RukovodilacProjekta r = s.Load<RukovodilacProjekta>(ID_U);


                s.Delete(r);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiRukovodioca: "+ ex);    
                throw;
            }
        }

        public static RukovodilacProjektaView VratiRukovodioca(int ID_U)
        {

            RukovodilacProjektaView rukovodilacProjektaView;
            try
            {
                ISession s = DataLayer.GetSession();
                
                RukovodilacProjekta r = s.Load<RukovodilacProjekta>(ID_U);

                rukovodilacProjektaView = new(r);
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiRukovodioca: "+ ex);    
                throw;
            }

            return rukovodilacProjektaView;
        }
        #endregion



        #region  Uloga- Administrator Repozitorijuma
        public static void DodajAdministratoraRepozitorijuma(int ID_I)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Istrazivac i = s.Load<Istrazivac>(ID_I);

                AdministratorRepozitorijuma admin = new ()
                {
                    ID_I = i
                };
                s.SaveOrUpdate(admin);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajAdministratoraRepozitorijuma: "+ ex);    
                throw;
            }        
        }
       public static void ObrisiAdministratoraRepozitorijuma(int ID_U)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                AdministratorRepozitorijuma a = s.Load<AdministratorRepozitorijuma>(ID_U);


                s.Delete(a);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiAdministratoraRepozitorijuma: "+ ex);    
                throw;
            }
        }


        public static AdministratorRepozitorijumaView VratiAdministratoraRepozitorijuma(int ID_U)
        {

            AdministratorRepozitorijumaView administratorRepozitorijumaView;
            try
            {
                ISession s = DataLayer.GetSession();
                
                AdministratorRepozitorijuma a = s.Load<AdministratorRepozitorijuma>(ID_U);

                administratorRepozitorijumaView = new(a);
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiAdministratoraRepozitorijuma: "+ ex);    
                throw;
            }

            return administratorRepozitorijumaView;
        }
        #endregion

        public static void DodajAdministratorskaOvlascenja(int ID_U, string ovlascenje)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                AdministratorRepozitorijuma a = s.Load<AdministratorRepozitorijuma>(ID_U);
                AdministratorOvlascenja o = new ()
                {
                    ID_U = a,
                    Ovlascenje = ovlascenje
                };
                
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajAdministratorskaOvlascenja: "+ ex);    
                throw;
            }        
        }

       public static void ObrisiAdministratoruOvlascenje(AdministratorOvlascenjaView admin)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                var a = s.Load<AdministratorOvlascenja>(admin);
                s.Delete(a);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiOvlascenje: "+ ex);    
                throw;
            }
        }


        #region  Uloga- Urednik
        public static void DodajUrednika(int ID_I, string uredjivacaSekcija)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Istrazivac i = s.Load<Istrazivac>(ID_I);

                Urednik urednik = new ()
                {
                    ID_I = i,
                    UredjivackaSekcija = uredjivacaSekcija
                };
                s.SaveOrUpdate(urednik);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajUrednika: "+ ex);    
                throw;
            }        
        }

       public static void ObrisiUrednika(int ID_U)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Urednik u = s.Load<Urednik>(ID_U);


                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiUrednika: "+ ex);    
                throw;
            }
        }
        public static UrednikView VratiUrednika(int ID_U)
        {

            UrednikView urednikView;
            try
            {
                ISession s = DataLayer.GetSession();
                
                Urednik u = s.Load<Urednik>(ID_U);

                urednikView = new(u);
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiUrednika: "+ ex);    
                throw;
            }

            return urednikView;
        }
        #endregion

        #region  Uloga- Recenzent
        public static void DodajRecenzenta(int ID_I)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Istrazivac i = s.Load<Istrazivac>(ID_I);

                Recenzent recenzent = new ()
                {
                    ID_I = i,
                };
                s.SaveOrUpdate(recenzent);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajRecenzenta: "+ ex);    
                throw;
            }        
        }

       public static void ObrisiRecenzenta(int ID_U)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Recenzent r = s.Load<Recenzent>(ID_U);


                s.Delete(r);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiRecenzenta: "+ ex);    
                throw;
            }
        }

        public static RecenzentView VratiRecenzenta(int ID_U)
        {

            RecenzentView recenzentView;
            try
            {
                ISession s = DataLayer.GetSession();
                
                Recenzent r = s.Load<Recenzent>(ID_U);

                recenzentView = new(r);
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiRecenzenta: "+ ex);    
                throw;
            }

            return recenzentView;
        }
        public static void DodajOblastiEkspertize(int ID_U, string oblastEkspertize)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Recenzent r = s.Load<Recenzent>(ID_U);

                OblastiEkspertize o = new ()
                {   
                    ID_U = r,
                    Oblast = oblastEkspertize
                };

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajOblastiEkspertize: "+ ex);    
                throw;
            }        
        }

        public static void ObrisiOblastiEkspertize(int ID_U, string oblastEkspertize)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                
                var oblast = (from o in s.Query<OblastiEkspertize>()
                                            where ( o.ID_U.ID_U == ID_U && o.Oblast == oblastEkspertize)
                                             select o).SingleOrDefault();

                s.Delete(oblast);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiOblastiEkspertize: "+ ex);    
                throw;
            }
        }  

        #endregion

        #region  Uloga- Autor
        public static void DodajAutora(int ID_I, string ORCID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Istrazivac i = s.Load<Istrazivac>(ID_I);

                Autor autor = new Autor
                {
                    ID_I = i,
                    Orcid = ORCID
                };
                s.SaveOrUpdate(autor);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajAutora: "+ ex);    
                throw;
            }        
        }

        public static void ObrisiAutora(int ID_U)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Autor a = s.Load<Autor>(ID_U);

                s.Delete(a);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiOblastiEkspertize: "+ ex);    
                throw;
            }
        } 

        public static AutorView VratiAutora(int ID_U)
        {

            AutorView autorView;
            try
            {
                ISession s = DataLayer.GetSession();
                
                Autor a = s.Load<Autor>(ID_U);

                autorView = new(a);
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiAutora: "+ ex);    
                throw;
            }

            return autorView;
        }
        #endregion

        #endregion

        #region  Istrazivacki Radovi


        public static IstrazivackiRezultatView VratiIstrazivackiRezultat(int ID_IR)
        {
            IstrazivackiRezultatView istrazivackiRezultat = new();
            try
            {
                ISession s = DataLayer.GetSession();

                IstrazivackiRezultat i = s.Load<IstrazivackiRezultat>(ID_IR);

                istrazivackiRezultat = new IstrazivackiRezultatView(i);

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiUIstrazivackiRezultat: "+ ex);
                 throw;
            }
            return istrazivackiRezultat;
        }

        public static List<IstrazivackiRezultatView> VratiSveIstrazivackeRezultate()
        {
            List<IstrazivackiRezultatView> sviIstrazivackiRezultati = new List<IstrazivackiRezultatView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<IstrazivackiRezultat> istrazivackiRezultati = from o in s.Query<IstrazivackiRezultat>()
                                                select o;

                foreach(IstrazivackiRezultat i in istrazivackiRezultati)
                { 
                    IstrazivackiRezultatView istrazivackiRezultat = VratiIstrazivackiRezultat( i.ID_IR );
                    sviIstrazivackiRezultati.Add(istrazivackiRezultat);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiSveIstrazivackeRezultate: "+ ex);
                throw;
            }
            return sviIstrazivackiRezultati;
        }

        public static void DodajKljucneReci(int ID_IR, string kljucnaRec)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IstrazivackiRezultat i = s.Load<IstrazivackiRezultat>(ID_IR);

                KljucnaRec k = new ()
                {
                    Rec = kljucnaRec,
                    ID_IR = i
                };
                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
               Console.WriteLine("Error at DataProvider DodajKljucneReci: "+ ex);    
                throw;
            }
        }

        public static void ObrisiKljucnuRec(int ID_IR, string kljucnaRec)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var k = (from o in s.Query<KljucnaRec>() 
                                        where (o.ID_IR.ID_IR == ID_IR && o.Rec == kljucnaRec) select o).SingleOrDefault();

                s.Delete(k);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajKljucneReci: "+ ex);
                throw;
            }
        }

        public static void DodajVerzijuIR(VerzijaView verzija)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                IstrazivackiRezultat istrazivackiRezultat = s.Load<IstrazivackiRezultat>(verzija.ID_IR.ID_IR);

                Verzija v = new()
                {
                    ID_IR = istrazivackiRezultat,
                    BrojVerzije = verzija.BrojVerzije,
                    DatumPostavljanja = verzija.DatumPostavljanja,
                    OpisIzmena = verzija.OpisIzmena,
                    OdgovornaOsoba = verzija.OdgovornaOsoba
                };

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajVerzijuIR: "+ ex);
                throw;
            }
        }

        public static void DodajPripadajuciFajl(PripadajuciFajlView pripadajuciFajlView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IstrazivackiRezultat i= s.Load<IstrazivackiRezultat>(pripadajuciFajlView.ID_IR.ID_IR);

                Verzija v = new ()
                {
                    ID_IR = i,
                    BrojVerzije  = pripadajuciFajlView.BrojVerzije,
                };
                
                Verzija verzija = s.Load<Verzija>(v);

                PripadajuciFajl p = new (i,pripadajuciFajlView.BrojVerzije,pripadajuciFajlView.NazivFajla,v);

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajPripadajuciFajl: "+ ex);
                throw;
            }
        }

        #region  IR- Ostali Dokumenti
        public static void DodajOstaliDokument(OstaliDokumentiView ostaliDokument)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                OstaliDokumenti o = new ()
                {
                    Naslov = ostaliDokument.Naslov,
                    Apstrakt = ostaliDokument.Apstrakt,
                    DatumKreiranja = ostaliDokument.DatumKreiranja,
                    DatumObjavljivanja = ostaliDokument.DatumObjavljivanja,
                    StatusIR = ostaliDokument.StatusIR,
                    Vidljivost = ostaliDokument.Vidljivost,
                };

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajOstaliDokument: "+ ex);    
                throw;
            }        
        }

        public static void ObrisiOstaliDokument(int ID_IR)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                OstaliDokumenti o = s.Load<OstaliDokumenti>(ID_IR);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiOstaliDokument: "+ ex);    
                throw;
            }
        }   
        public static OstaliDokumentiView VratiOstaliDokument(int ID_IR)
        {

            OstaliDokumentiView ostaliDokumentiView;
            try
            {
                ISession s = DataLayer.GetSession();
                
                OstaliDokumenti o = s.Load<OstaliDokumenti>(ID_IR);

                ostaliDokumentiView = new (o);
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiOstaliDokument: "+ ex);    
                throw;
            }
            return ostaliDokumentiView;
        }

        public static void AzurirajOstaliDokument(OstaliDokumentiView ostaliDokumentiView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OstaliDokumenti o = s.Load<OstaliDokumenti>(ostaliDokumentiView.ID_IR);

                if(ostaliDokumentiView.Naslov != "") o.Naslov = ostaliDokumentiView.Naslov;
                if(ostaliDokumentiView.Apstrakt != "") o.Apstrakt = ostaliDokumentiView.Apstrakt;
                if(o.DatumKreiranja != ostaliDokumentiView.DatumKreiranja) o.DatumKreiranja = ostaliDokumentiView.DatumKreiranja;
                if(o.DatumObjavljivanja != ostaliDokumentiView.DatumObjavljivanja) o.DatumObjavljivanja = ostaliDokumentiView.DatumObjavljivanja;
                if(o.StatusIR != ostaliDokumentiView.StatusIR) o.StatusIR = ostaliDokumentiView.StatusIR;
                if(o.Vidljivost != ostaliDokumentiView.Vidljivost) o.Vidljivost = ostaliDokumentiView.Vidljivost;
                
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajOstaliDokument: "+ ex);    
                throw;
            }

        }
        #endregion
        
        #region  IR- So ftverski Artifakt
        public static void DodajSoftverskiArtifakt(SoftverskiArtifaktView softverskiArtifakt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                SoftverskiArtifakt sa = new ()
                {
                    Naslov = softverskiArtifakt.Naslov,
                    Apstrakt = softverskiArtifakt.Apstrakt,
                    DatumKreiranja = softverskiArtifakt.DatumKreiranja,
                    DatumObjavljivanja = softverskiArtifakt.DatumObjavljivanja,
                    StatusIR = softverskiArtifakt.StatusIR,
                    Vidljivost = softverskiArtifakt.Vidljivost,
                    ProgramskiJezik = softverskiArtifakt.ProgramskiJezik,
                    RepoLink = softverskiArtifakt.RepoLink,
                    NacinLicenciranja = softverskiArtifakt.NacinLicenciranja,
                    Dokumentacija = softverskiArtifakt.Dokumentacija
                };

                s.SaveOrUpdate(sa);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajSoftverskiArtifakt: "+ ex);    
                throw;
            }        
        }

        public static void ObrisiSoftverskiArtifakt(int ID_IR)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                SoftverskiArtifakt sa = s.Load<SoftverskiArtifakt>(ID_IR);

                s.Delete(sa);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiSoftverskiArtifakt: "+ ex);    
                throw;
            }
        }

        public static SoftverskiArtifaktView VratiSoftverskiArtifakt(int ID_IR)
        {
            SoftverskiArtifaktView softverskiArtifaktView;
            try
            {
                ISession s = DataLayer.GetSession();
                
                SoftverskiArtifakt sa = s.Load<SoftverskiArtifakt>(ID_IR);

                softverskiArtifaktView = new (sa);
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiSoftverskiArtifakt: "+ ex);    
                throw;
            }
            return softverskiArtifaktView;
        }
        public static void AzurirajSoftverskiArtifakt(SoftverskiArtifakt softverskiArtifakt)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SoftverskiArtifakt sa = s.Load<SoftverskiArtifakt>(softverskiArtifakt.ID_IR);

                if(softverskiArtifakt.Naslov != "") sa.Naslov = softverskiArtifakt.Naslov;
                if(softverskiArtifakt.Apstrakt != "") sa.Apstrakt = softverskiArtifakt.Apstrakt;
                if(sa.DatumKreiranja != softverskiArtifakt.DatumKreiranja) sa.DatumKreiranja = softverskiArtifakt.DatumKreiranja;
                if(sa.DatumObjavljivanja != softverskiArtifakt.DatumObjavljivanja) sa.DatumObjavljivanja = softverskiArtifakt.DatumObjavljivanja;
                if(sa.StatusIR != softverskiArtifakt.StatusIR) sa.StatusIR = softverskiArtifakt.StatusIR;
                if(sa.Vidljivost != softverskiArtifakt.Vidljivost) sa.Vidljivost = softverskiArtifakt.Vidljivost;
                if(softverskiArtifakt.ProgramskiJezik != "") sa.ProgramskiJezik = softverskiArtifakt.ProgramskiJezik;
                if(softverskiArtifakt.RepoLink != "") sa.RepoLink = softverskiArtifakt.RepoLink;
                if(softverskiArtifakt.NacinLicenciranja != "") sa.NacinLicenciranja = softverskiArtifakt.NacinLicenciranja;
                if(softverskiArtifakt.Dokumentacija != "") sa.Dokumentacija = softverskiArtifakt.Dokumentacija;
                
                s.Update(sa);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajSoftverskiArtifakt: "+ ex);    
                throw;
            }

        }

        public static void DodajPodrzanuPlatformu(int ID_IR, string platfoma)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SoftverskiArtifakt sa = s.Load<SoftverskiArtifakt>(ID_IR);

                PodrzanaPlatforma p = new ()
                {
                    Platforma = platfoma,
                    ID_IR = sa,
                };

                s.SaveOrUpdate(sa);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajPodrzanuPlatformu: "+ ex);
                throw;
            }
        }

        public static void ObrisiPodrzanuPlatformu(int ID_IR, string platfoma)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var sa = (from o in s.Query<PodrzanaPlatforma>()
                                    where (o.ID_IR.ID_IR == ID_IR && o.Platforma == platfoma) select o).SingleOrDefault();

                s.Delete(sa);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrsisPodrzanuPlatformu: "+ ex);
                throw;
            }
        }
        #endregion

        #region  IR- Dataset
        public static void DodajDataset(DatasetView dataSet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dataset d = new ()
                {
                    Naslov = dataSet.Naslov,
                    Apstrakt = dataSet.Apstrakt,
                    DatumKreiranja = dataSet.DatumKreiranja,
                    DatumObjavljivanja = dataSet.DatumObjavljivanja,
                    StatusIR = dataSet.StatusIR,
                    Vidljivost = dataSet.Vidljivost, 
                    Format = dataSet.Format,
                    Velicina = dataSet.Velicina,
                    BrojZapisa = dataSet.BrojZapisa,
                    OpisStrukture = dataSet.OpisStrukture,
                    PeriodObuhvataPodataka = dataSet.PeriodObuhvataPodataka,
                    LicencaKoriscenja = dataSet.LicencaKoriscenja,
                    OgranicenjaPristupa = dataSet.OgranicenjaPristupa
                };

                s.SaveOrUpdate(d);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajDataset: "+ ex);
                throw;
            }
        }

        public static void ObrisiDataset(int ID_IR)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dataset sa = s.Load<Dataset>(ID_IR);

                s.Delete(sa);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrsisDataset: "+ ex);
                throw;
            }
        }     
        public static DatasetView VratiDataset(int ID_IR)
        {
            DatasetView datasetView;
            try
            {
                ISession s = DataLayer.GetSession();

                datasetView = new (s.Load<Dataset>(ID_IR));
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiDataset: "+ ex);
                throw;
            }
            return  datasetView;
        }     

        public static void AzurirajDataset(DatasetView datasetView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dataset d = s.Load<Dataset>(datasetView.ID_IR);

                if(datasetView.Naslov != "") d.Naslov = datasetView.Naslov;
                if(datasetView.Apstrakt != "") d.Apstrakt = datasetView.Apstrakt;
                if(d.DatumKreiranja != datasetView.DatumKreiranja) d.DatumKreiranja = datasetView.DatumKreiranja;
                if(d.DatumObjavljivanja != datasetView.DatumObjavljivanja) d.DatumObjavljivanja = datasetView.DatumObjavljivanja;
                if(d.StatusIR != datasetView.StatusIR) d.StatusIR = datasetView.StatusIR;
                if(d.Vidljivost != datasetView.Vidljivost) d.Vidljivost = datasetView.Vidljivost;
                if(datasetView.Format != "") d.Format = datasetView.Format;
                if(datasetView.Velicina != 0) d.Velicina = datasetView.Velicina;
                if(datasetView.BrojZapisa != 0) d.BrojZapisa = datasetView.BrojZapisa;
                if(datasetView.OpisStrukture != "") d.OpisStrukture = datasetView.OpisStrukture;
                if(datasetView.PeriodObuhvataPodataka != "") d.PeriodObuhvataPodataka = datasetView.PeriodObuhvataPodataka;
                if(datasetView.LicencaKoriscenja != "") d.LicencaKoriscenja = datasetView.LicencaKoriscenja;
                if(datasetView.OgranicenjaPristupa != "") d.OgranicenjaPristupa = datasetView.OgranicenjaPristupa;
                
                s.Update(d);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajDataset: "+ ex);    
                throw;
            }
        }
        #endregion
        #region  IR- TehnickiIzvestaj
        public static void DodajTehnickiIzvestaj(TehnickiIzvestaj tehnickiIzvestaj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickiIzvestaj t = new ()
                {
                    Naslov = tehnickiIzvestaj.Naslov,
                    Apstrakt = tehnickiIzvestaj.Apstrakt,
                    DatumKreiranja = tehnickiIzvestaj.DatumKreiranja,
                    DatumObjavljivanja = tehnickiIzvestaj.DatumObjavljivanja,
                    StatusIR = tehnickiIzvestaj.StatusIR,
                    Vidljivost = tehnickiIzvestaj.Vidljivost,
                };

                s.SaveOrUpdate(t);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajTehnickiIzvestaj: "+ ex);
                throw;
            }
        }

        public static void ObrisiTehnickiIzvestaj(int ID_IR)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var d = s.Load<TehnickiIzvestaj>(ID_IR);

                s.Delete(d);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrsisTehnickiIzvestaj: "+ ex);
                throw;
            }
        }   
        public static TehnickiIzvestajView VratiTehnickiIzvestaj(int ID_IR)
        {

            TehnickiIzvestajView tehnickiIzvestajView;
            try
            {
                ISession s = DataLayer.GetSession();

                tehnickiIzvestajView = new(s.Load<TehnickiIzvestaj>(ID_IR));

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiTehnickiIzvestaj: "+ ex);
                throw;
            }
            return tehnickiIzvestajView;
        }   

        public static void AzurirajTehnickiIzvestaj(TehnickiIzvestajView tehnickiIzvestajView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickiIzvestaj t = s.Load<TehnickiIzvestaj>(tehnickiIzvestajView.ID_IR);

                if(tehnickiIzvestajView.Naslov != "") t.Naslov = tehnickiIzvestajView.Naslov;
                if(tehnickiIzvestajView.Apstrakt != "") t.Apstrakt = tehnickiIzvestajView.Apstrakt;
                if(t.DatumKreiranja != tehnickiIzvestajView.DatumKreiranja) t.DatumKreiranja = tehnickiIzvestajView.DatumKreiranja;
                if(t.DatumObjavljivanja != tehnickiIzvestajView.DatumObjavljivanja) t.DatumObjavljivanja = tehnickiIzvestajView.DatumObjavljivanja;
                if(t.StatusIR != tehnickiIzvestajView.StatusIR) t.StatusIR = tehnickiIzvestajView.StatusIR;
                if(t.Vidljivost != tehnickiIzvestajView.Vidljivost) t.Vidljivost = tehnickiIzvestajView.Vidljivost;
                
                s.Update(t);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajTehnickiIzvestaj: "+ ex);    
                throw;
            }

        }
        #endregion
        
        #region  IR- Knjige ili Poglavlja
        public static void DodajKnjigeIliPoglavlja(KnjigaIliPoglavljaView knjigaIliPoglavljaView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KnjigaIliPoglavlja k = new ()
                {
                    Naslov = knjigaIliPoglavljaView.Naslov,
                    Apstrakt = knjigaIliPoglavljaView.Apstrakt,
                    DatumKreiranja = knjigaIliPoglavljaView.DatumKreiranja,
                    DatumObjavljivanja = knjigaIliPoglavljaView.DatumObjavljivanja,
                    StatusIR = knjigaIliPoglavljaView.StatusIR,
                    Vidljivost = knjigaIliPoglavljaView.Vidljivost,
                    Izdavac = knjigaIliPoglavljaView.Izdavac,
                    MestoIzdavanja = knjigaIliPoglavljaView.MestoIzdavanja
                };

                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajKnjigeIliPoglavlja: "+ ex);
                throw;
            }
        }

        public static void DodajUrednikaKnjizi(int ID_U, int ID_IR)
        {
            try
            {
                
                ISession s = DataLayer.GetSession();

                Urednik urednik = s.Load<Urednik>(ID_U);
                KnjigaIliPoglavlja knjigaIliPoglavlja = s.Load<KnjigaIliPoglavlja>(ID_IR);

                Uredjuje u = new(knjigaIliPoglavlja,urednik);

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajUrednikaKnjizi: "+ ex);
                throw;
            }
        }

        public static void ObrsiKnjigeIliPoglavlja(int ID_IR)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var k = s.Load<KnjigaIliPoglavlja>(ID_IR);

                s.Delete(k);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrsisKnjigeIliPoglavlja: "+ ex);
                throw;
            }
        }

        public static KnjigaIliPoglavljaView VratiKnjigeIliPoglavlja(int ID_IR)
        {   
            KnjigaIliPoglavljaView knjigaIliPoglavljaView;
            try
            {
                ISession s = DataLayer.GetSession();

                knjigaIliPoglavljaView = new (s.Load<KnjigaIliPoglavlja>(ID_IR));
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiKnjigeIliPoglavlja: "+ ex);
                throw;
            }
            return knjigaIliPoglavljaView;
        }

        public static void AzurirajKnjigeIliPoglavlje(KnjigaIliPoglavlja knjigaIliPoglavlja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KnjigaIliPoglavlja k = s.Load<KnjigaIliPoglavlja>(knjigaIliPoglavlja.ID_IR);

                if(knjigaIliPoglavlja.Naslov != "") k.Naslov = knjigaIliPoglavlja.Naslov;
                if(knjigaIliPoglavlja.Apstrakt != "") k.Apstrakt = knjigaIliPoglavlja.Apstrakt;
                if(k.DatumKreiranja != knjigaIliPoglavlja.DatumKreiranja) k.DatumKreiranja = knjigaIliPoglavlja.DatumKreiranja;
                if(k.DatumObjavljivanja != knjigaIliPoglavlja.DatumObjavljivanja) k.DatumObjavljivanja = knjigaIliPoglavlja.DatumObjavljivanja;
                if(k.StatusIR != knjigaIliPoglavlja.StatusIR) k.StatusIR = knjigaIliPoglavlja.StatusIR;
                if(k.Vidljivost != knjigaIliPoglavlja.Vidljivost) k.Vidljivost = knjigaIliPoglavlja.Vidljivost;
                if(knjigaIliPoglavlja.Izdavac != "") k.Izdavac = knjigaIliPoglavlja.Izdavac;
                if(knjigaIliPoglavlja.MestoIzdavanja != "") k.MestoIzdavanja = knjigaIliPoglavlja.MestoIzdavanja;
                
                s.Update(k);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider AzurirajKnjigeIliPoglavlje: "+ ex);    
                throw;
            }

        }
        #endregion

        #region  IR- Naucni Rad
        public static void DodajNaucniRad(NaucniRadView naucniRadView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NaucniRad n = new ()
                {
                    Naslov = naucniRadView.Naslov,
                    Apstrakt = naucniRadView.Apstrakt,
                    DatumKreiranja = naucniRadView.DatumKreiranja,
                    DatumObjavljivanja = naucniRadView.DatumObjavljivanja,
                    StatusIR = naucniRadView.StatusIR,
                    Vidljivost = naucniRadView.Vidljivost,
                    TipRada = naucniRadView.TipRada,
                    NazivCasKon = naucniRadView.NazivCasKon,
                    Doi = naucniRadView.Doi,
                    IssnIliIsbn = naucniRadView.IssnIliIsbn,
                    BrojSveske = naucniRadView.BrojSveske,
                    BrojIzdanja = naucniRadView.BrojIzdanja,
                    BrojStranice = naucniRadView.BrojStranice
                };

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajNaucniRad: "+ ex);
                throw;
            }
        }

        public static void ObrisiNaucniRad(int ID_IR)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var n = s.Load<NaucniRad>(ID_IR);

                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider ObrisiNaucniRad: "+ ex);
                throw;
            }
        } 

        public static NaucniRadView VratiNaucniRad(int ID_IR)
        {
            NaucniRadView naucniRadView;
            try
            {
                ISession s = DataLayer.GetSession();

                naucniRadView = new (s.Load<NaucniRad>(ID_IR));
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiNaucniRad: "+ ex);
                throw;
            }
            return naucniRadView;
        } 

        public static void AzurirajNaucniRad(NaucniRadView naucniRadView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NaucniRad n = s.Load<NaucniRad>(naucniRadView.ID_IR);


                if(naucniRadView.Naslov != "") n.Naslov = naucniRadView.Naslov;
                if(naucniRadView.Apstrakt != "") n.Apstrakt = naucniRadView.Apstrakt;
                if(n.DatumKreiranja != naucniRadView.DatumKreiranja) n.DatumKreiranja = naucniRadView.DatumKreiranja;
                if(n.DatumObjavljivanja != naucniRadView.DatumObjavljivanja) n.DatumObjavljivanja = naucniRadView.DatumObjavljivanja;
                if(n.StatusIR != naucniRadView.StatusIR) n.StatusIR = naucniRadView.StatusIR;
                if(n.Vidljivost != naucniRadView.Vidljivost) n.Vidljivost = naucniRadView.Vidljivost;
                if(naucniRadView.TipRada != "") n.TipRada = naucniRadView.TipRada;
                if(naucniRadView.NazivCasKon != "") n.NazivCasKon = naucniRadView.NazivCasKon;
                if(naucniRadView.Doi != "") n.Doi = naucniRadView.Doi;
                if(naucniRadView.BrojSveske != 0) n.BrojSveske  = naucniRadView.BrojSveske;
                if(naucniRadView.BrojIzdanja != 0) n.BrojIzdanja = naucniRadView.BrojIzdanja;
                if(naucniRadView.BrojStranice != 0) n.BrojStranice = naucniRadView.BrojStranice;

                s.Update(n);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiNaucniRad: "+ ex);
            }
        }
        #endregion

        #endregion

        #region  Publikacija

        public static void DodajPublikaciju(AutorstvoView autorstvoView)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Publikacija p = new ();
                PublikacijaView publikacijaView = new (p);

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
                autorstvoView.ID_P = publikacijaView;
                DodajAutorstvo(autorstvoView);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajPublikaciju: "+ ex);
                throw;
            }
        }

        public static void DodajAutorstvo(AutorstvoView autorstvoView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Autor autor = s.Load<Autor>(autorstvoView.ID_U.ID_U);
                Publikacija publikacija = s.Load<Publikacija>(autorstvoView.ID_P.ID_P);

                Autorstvo a = new(
                    autor,
                    publikacija,
                    autorstvoView.RedniBrojAutora,
                    autorstvoView.TipDoprinosa,
                    autorstvoView.UlogaUPublikaciji
                    );

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajAutorstvo: "+ ex);
                throw;
            }
        }

        public static void DodajCitat(Citat citat)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Publikacija citirajuca = s.Load<Publikacija>(citat.ID_P1.ID_P);
                Publikacija citirana = s.Load<Publikacija>(citat.ID_P2.ID_P);

                Citat c = new(citirajuca, citirana, citat.TipCitata,citat.MestoCitiranja,citat.KontekstCitiranja);

                s.SaveOrUpdate(c);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajCitat: "+ ex);
                throw;
            }
        }

        public static PublikacijaView VratiPublikaciju(int ID_P)
        {
            PublikacijaView p = new ();

            try
            {
                ISession s = DataLayer.GetSession();

                Publikacija publikacija = s.Load<Publikacija>(ID_P);

                p = new PublikacijaView(publikacija);

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiPublikaciju: "+ ex);
                throw;
            }

            return p;
        }
        #endregion
        #region  Runda Recenzije

        public static void DodajRunduRecenzije(RundaRecenzijeView rundaRecenzijeView)
        {
            try
            {
               ISession s = DataLayer.GetSession();

               Publikacija publikacija = s.Load<Publikacija>(rundaRecenzijeView.ID_P.ID_P);
               Urednik urednik = s.Load<Urednik>(rundaRecenzijeView.ID_Urednika.ID_U);

               RundaRecenzije r = new()
               {
                   BrojRunde = rundaRecenzijeView.BrojRunde,
                   ID_P = publikacija,
                   ID_Urednika = urednik,
                   DatumOdluke = rundaRecenzijeView.DatumOdluke,
                   KonacnaOdluka = rundaRecenzijeView.KonacnaOdluka
               };

               s.SaveOrUpdate(r);
               s.Flush();
               s.Close(); 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajRunduRecenzije: "+ ex);
                throw;
            }
        }

        public static void DodajAngazovaneRecenzente(AngazovanjeRecenzentView angazovanjeRecenzentView)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Recenzent recenzent = s.Load<Recenzent>(angazovanjeRecenzentView.ID_Recenzenta.ID_U);
                Publikacija publikacija = s.Load<Publikacija>(angazovanjeRecenzentView.ID_P.ID_P);

                RundaRecenzije r = new ()
                {
                    ID_P = publikacija,
                    BrojRunde = angazovanjeRecenzentView.BrojRunde
                };
                RundaRecenzije rundaRecenzije = s.Load<RundaRecenzije>(r);
                AngazovanjeRecenzent a = new()
                {
                    ID_P = publikacija,
                    ID_Recenzenta = recenzent,
                    Preporuka = angazovanjeRecenzentView.Preporuka,
                    ID_RR = rundaRecenzije
                };

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch( Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajAngazovaneRecenzente: "+ ex);
                throw;
            }
        }

        public static void DodajOceneAngazovanomRecenzentu(int ID_AR, int ocena)
        {
            try
            {
                
                ISession s = DataLayer.GetSession();

                AngazovanjeRecenzent ar = s.Load<AngazovanjeRecenzent>(ID_AR);


                OcenaRecenzenta o = new()
                {
                    Ocena = ocena,
                    AngazovanjeRecenzent = ar
                };

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider DodajOceneAngazovanomRecenzentu: "+ ex);
                throw;
            }
        }
        #endregion
    }
}