using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    public class AdministratorRepozitorijumaMaps:SubclassMap<AdministratorRepozitorijuma>
    {
        public AdministratorRepozitorijumaMaps()
        {
            Table("ADMINISTRATOR_REPOZITORIJUMA");
            KeyColumn("ID_U");
            HasMany(x => x.Ovlascenja).KeyColumn("ID_U").LazyLoad().Cascade.All().Inverse();
        }
        
    }
}

