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

namespace databaseacesslib
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
                    List<MailInstitucijaView> mails = VratiMailInstitucije(n.ID_NII);


                    List<TelefonInstitucijaView> telefons = VratiBrojeviInstitucije(n.ID_NII);

                    List<NaucnaOblastView> oblasti = VratiOblastiInstitucije(n.ID_NII);


                    NaucnoIstrazivackaInstitucijaView tmp = new NaucnoIstrazivackaInstitucijaView
                    {
                        ID_NII = n.ID_NII,
                        Naziv = n.Naziv,
                        Adresa = n.Adresa,
                        Mailovi = mails,
                        Telefoni = telefons,
                        NaucneOblasti = oblasti,
                    };

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

        #endregion
    }
}