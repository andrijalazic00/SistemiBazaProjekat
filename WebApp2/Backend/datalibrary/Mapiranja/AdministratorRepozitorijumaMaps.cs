
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalibrary.Entiteti;

namespace datalibrary.Mapiranja
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

