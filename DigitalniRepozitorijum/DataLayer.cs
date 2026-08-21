using DigitalniRepozitorijum.Maps;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DigitalniRepozitorijum
{
    class DataLayer
    {
        //private ISession _session;
        private  static ISessionFactory _sessionFactory=null;
        private static object objLock=new object();
        
        //otvaranje sesije
        public static ISession GetSession()
        {
            if (_sessionFactory==null)
            {
                lock (objLock)
                {
                    if (_sessionFactory == null)
                        _sessionFactory = CreateSessionFactory();
                }
            }
            return _sessionFactory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try 
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ConnectionString(c =>
                    c.Is("DATA SOURCE=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;USER ID=S17311;Password=17311"));
                //var config=new NHibernate.Cfg.Configuration();
                return Fluently.Configure()
                    .Database(cfg.ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NaucnoIstrazivackaInstitucijaMaps>())
                    .BuildSessionFactory();

                
                
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return null; 
            }
        }

    }
}
