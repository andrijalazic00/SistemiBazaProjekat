using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
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
