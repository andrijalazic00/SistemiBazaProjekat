using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
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
