using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    public class NaucnaOblastMaps:ClassMap<NaucnaOblast>
    {
        public NaucnaOblastMaps()
        {
            Table("NAUCNA_OBLAST");
            CompositeId()
                .KeyReference(x => x.ID_NII, "ID_NII")
                .KeyProperty(x => x.Oblast, "NAUCNA_OBLAST");
        }
    }
}
