using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    class OstaliDokumentiMaps : SubclassMap<OstaliDokumenti>
    {
        public OstaliDokumentiMaps()
        {
            Table("OSTALI_DOKUMENTI");
            KeyColumn("ID_IR");
            Map(x => x.Opcije, "OPCIJE").Not.Nullable();
        }
    }
}
