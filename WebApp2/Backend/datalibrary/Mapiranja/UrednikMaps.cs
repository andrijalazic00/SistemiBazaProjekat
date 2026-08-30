using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    public class UrednikMaps:SubclassMap<Urednik>
    {
        public UrednikMaps() 
        {
            Table("UREDNIK");
            KeyColumn("ID_U");
            Map(x => x.UredjivackaSekcija, "UREDJIVACKA_SEKCIJA");

            HasMany(x => x.RundeRecenzije).KeyColumn("ID_U").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Knjige).KeyColumn("ID_UREDNIKA").LazyLoad().Cascade.All();
        }
        
    }
}
