using NHibernate;
using datalibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using datalibrary.DTOs;
using datalibrary;
using System.Data.Common;

namespace databaseacesslib
{
    public class DataProvider
    {
        #region  NaucnoIstrazivackaInstitucija


        public static List<NaucnoIstrazivackaInstitucijaView> VratiInstitucije()
        {
            List<NaucnoIstrazivackaInstitucijaView> naucneinstitucije = new List<NaucnoIstrazivackaInstitucijaView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NaucnoIstrazivackaInstitucija> sveInstitucije = from o in s.Query<NaucnoIstrazivackaInstitucija>()
                    select o;

                foreach( NaucnoIstrazivackaInstitucija n in sveInstitucije)
                {
                    naucneinstitucije.Add( new NaucnoIstrazivackaInstitucijaView(n));
                }

                s.Close();

            }
            catch(Exception)
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
        #endregion
    }
}