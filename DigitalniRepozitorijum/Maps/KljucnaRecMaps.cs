using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    public class KljucnaRecMaps:ClassMap<KljucnaRec>
    {
        public KljucnaRecMaps()
        {
            Table("KLJUCNE_RECI");
            //Mapiranje kompozitnog PK
            CompositeId()
                .KeyReference(x => x.ID_IR, "ID_IR")
                .KeyProperty(x => x.Rec, "KLJUCNA_REC");
        }

    }
}
