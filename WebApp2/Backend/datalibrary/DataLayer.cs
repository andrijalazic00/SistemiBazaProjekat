using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using datalibrary.Mapiranja;

namespace datalibrary
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object(); 

        public static ISession GetSession()
        {
            if(_factory == null)
            {
                lock( objLock )
                {
                    if(_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ConnectionString( c => 
                        c.Is("DATA SOURCE=link;PERSIST SECURITY INFO=True; USER ID=Username;Password=Password"));
                
                return Fluently.Configure()
                .Database(cfg.ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NaucnoIstrazivackaInstitucijaMaps>())
                .BuildSessionFactory();
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
