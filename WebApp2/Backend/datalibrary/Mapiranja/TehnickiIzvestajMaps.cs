using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    class TehnickiIzvestajMaps : SubclassMap<TehnickiIzvestaj>
    {
        public TehnickiIzvestajMaps()
        {
            Table("TEHNICKI_IZVESTAJ");
            KeyColumn("ID_IR");
            HasOne(x => x.Publikacija).PropertyRef(x => x.ID_IR);
        }
    }
}
