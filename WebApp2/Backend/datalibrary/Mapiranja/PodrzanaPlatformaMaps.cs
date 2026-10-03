using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    
        class PodrzanaPlatformaMaps : ClassMap<PodrzanaPlatforma>
        {
            public PodrzanaPlatformaMaps()
            {
                Table("PODRZANE_PLATFORME");
                CompositeId()
                    .KeyReference(x => x.ID_IR, "ID_IR")
                    .KeyProperty(x => x.Platforma, "PLATFORMA");
            }
        }
    
}
