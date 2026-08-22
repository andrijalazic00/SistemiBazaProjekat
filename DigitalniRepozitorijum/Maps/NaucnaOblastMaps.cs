using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
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
