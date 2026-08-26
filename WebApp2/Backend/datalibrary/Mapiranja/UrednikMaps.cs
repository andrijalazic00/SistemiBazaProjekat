
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalibrary.Entiteti;

namespace datalibrary.Mapiranja
{
    public class UrednikMaps:SubclassMap<Urednik>
    {
        public UrednikMaps() 
        {
            Table("UREDNIK");
            KeyColumn("ID_U");
            Map(x => x.UredjivackaSekcija, "UREDJIVACKA_SEKCIJA");
        }
        
    }
}
