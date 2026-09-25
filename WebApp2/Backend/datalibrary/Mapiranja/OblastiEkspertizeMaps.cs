using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalibrary.Entiteti;

namespace datalibrary.Mapiranja
{
    public class OblastiEkspertizeMaps:ClassMap<OblastiEkspertize>
    {
        public OblastiEkspertizeMaps()
        {
            Table("OBLASTI_EKSPERTIZE");
            CompositeId()
                .KeyReference(x => x.ID_U, "ID_U")
                .KeyProperty(x => x.Oblast, "OBLAST_EKSPERTIZE");
        }
    }
}
