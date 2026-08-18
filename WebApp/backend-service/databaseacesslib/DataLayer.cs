using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using databaseacesslib;
using System;
using NHibernate.Engine;
using databaseacesslib.Mapiranje;

namespace databaseacesslib
{
    internal class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static readonly object objLock = new object();

        public static ISession GetSession()
        {
            if( _factory == null)
            {
                lock(objLock)
                {
                    if( _factory == null)
                    {
                        _factory = CreateSessionFactory();
                    }
                }
            }

            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                            .ShowSql()
                            .ConnectionString( c =>
                                c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=user;Password=password"));

                return Fluently.Configure()
                        .Database(cfg)
                        .Mappings( m => m.FluentMappings.AddFromAssemblyOf<Entiteti.IstrazivackiRezultati>())
                        .BuildSessionFactory();
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}