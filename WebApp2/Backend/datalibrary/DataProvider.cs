using NHibernate;
using datalibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using DigitalniRepozitorijum.Entities;
using datalibrary.DTOs;
using datalibrary;

namespace databaseacesslib
{
    public class DataProvider
    {
        #region  NaucnoIstrazivackaInstitucija

        public static List<NaucnoIInstitucijaView> VratiSveInstitucije()
        {

            List<NaucnoIInstitucijaView> naucneinstitucije = new List<NaucnoIInstitucijaView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NaucnoIInstitucija> sveInstitucije = from o in s.Query<NaucnoIInstitucija>()
                    select o;

                foreach( NaucnoIInstitucija n in sveInstitucije)
                {
                    naucneinstitucije.Add( new NaucnoIInstitucijaView(n));
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

        #endregion
    }
}