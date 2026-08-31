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

namespace datalibrary
{
    public class DataProvider
    {
        #region  NaucnoIstrazivackaInstitucija


        public static List<MailInstitucijaView> VratiMailInstitucije(int ID_NII)
        {
            List<MailInstitucijaView> svimailoviinstitucije = new List<MailInstitucijaView>();

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
            List<TelefonInstitucijaView> svitelefoniinstitucije = new List<TelefonInstitucijaView>();

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
                
                institucija = new NaucnoIstrazivackaInstitucijaView
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

                NaucnoIstrazivackaInstitucija o = new NaucnoIstrazivackaInstitucija
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

        public static NaucnoIstrazivackaInstitucijaView AnzurirajNaucnoIstrazivackuInstituciju(NaucnoIstrazivackaInstitucijaView n)
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
                Console.WriteLine("Errot at DataProvider AnzurirajNaucnoIstrazivackuInstituciju:\n"+ ex);
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

                MailInstitucija o = new MailInstitucija
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

        public static void AnzurirajMailInstituciji(int ID_NII, string starimail,string novimail)
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
                Console.WriteLine("Error at DataProvider AnzurirajMailInstituciji: "+ex);
                throw;               
            }
        }

        public static void DodajTelefonInstituciji(int ID_NII, string telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NaucnoIstrazivackaInstitucija n = s.Load<NaucnoIstrazivackaInstitucija>(ID_NII);

                TelefonInstitucija o = new TelefonInstitucija
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

        public static void AnzurirajTelefonInstituciji(int ID_NII, string straibroj,string novibroj)
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
                Console.WriteLine("Error at DataProvider AnzurirajTelefonInstituciji: "+ex);
                throw;               
            }
        }

        #endregion
        #region  Istrazivaci

        public static List<MailView> VratiMailoveIstrazivaca(int ID_I)
        {

            List<MailView> svimailovi = new List<MailView>();
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
            }

            return svimailovi;
        }



        public static List<TelefonView> VratiTelefoneIstrazivaca(int ID_I)
        {

            List<TelefonView> svitelefoni = new List<TelefonView>();
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
            }

            return svitelefoni;
        }


        
        public static List<IstrazivacView> VratiSveIstrazivace()
        {
            
            List<IstrazivacView> sviistrazivaci = new List<IstrazivacView>();

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
                istrazivacView = new IstrazivacView(i);

                List<MailView> m = VratiMailoveIstrazivaca(i.ID_I);
                List<TelefonView> t = VratiTelefoneIstrazivaca( i.ID_I);
                List<AngazovanjeView> a = VratiAngazovanjeIstrazivaca( i.ID_I);
                istrazivacView.Mailovi = m;
                istrazivacView.Telefoni = t;
                istrazivacView.Institucije = a;

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiIstrazivaca: "+ ex);
                throw;
            }

            return istrazivacView;
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

        public static void AnzurirajMailIstrazivacu(int ID_I, string starimail,string novimail)
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
                Console.WriteLine("Error at DataProvider AnzurirajMailInstituciji: "+ex);
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

        public static void AnzurirajTelefonIstrazivacu(int ID_I, string straibroj,string novibroj)
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
                Console.WriteLine("Error at DataProvider AnzurirajTelefonInstituciji: "+ex);
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
                    AngazovanjeView v = new AngazovanjeView(a);
                    svaAngazovanja.Add(v);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiAngazovanjeIstrazivaca: "+ ex);
            }

            return svaAngazovanja;
        }

        public static List<AngazovanjeView> VratiAngazovaneUInstituciji(int ID_NII)
        {   
            List<AngazovanjeView> sviAngazovani = new List<AngazovanjeView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Angazovanje> angazovani = from o in s.Query<Angazovanje>()
                                                    where o.ID_NII.ID_NII == ID_NII select o;
                
                foreach(Angazovanje a in angazovani)
                {
                    AngazovanjeView v = new AngazovanjeView(a);
                    sviAngazovani.Add(v);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error at DataProvider VratiAngazovanjeIstrazivaca: "+ ex);
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

                Angazovanje angazovanje = new Angazovanje
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
        
        public static List<UlogaView> VratiSveUloge()
        {
            List<UlogaView> sveuloge = new List<UlogaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Uloga> uloge = from o in s.Query<Uloga>()
                                                select o;

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
            }
            return sveuloge;
        }

        public static UlogaView VratiUlogu(int ID_U)
        {
            UlogaView uloga = new UlogaView();
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
            }
            return uloga;
        }

        #endregion
    }
}