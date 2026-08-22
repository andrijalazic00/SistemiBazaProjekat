using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
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
