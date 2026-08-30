using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalibrary.Entiteti;

namespace datalibrary.Mapiranja
{
    
    class NaucniRadMaps : SubclassMap<NaucniRad>
    {
        public NaucniRadMaps()
        {
            Table("NAUCNI_RAD");
            KeyColumn("ID_IR");
            Map(x => x.TipRada, "TIP_RADA").Not.Nullable();
            Map(x => x.NazivCasKon, "NAZIV_CAS_KON").Not.Nullable();
            Map(x => x.Doi, "DOI").Nullable();
            Map(x => x.IssnIliIsbn, "ISSN_ILI_ISBN").Nullable();
            Map(x => x.BrojSveske, "BROJ_SVESKE").Not.Nullable();
            Map(x => x.BrojIzdanja, "BROJ_IZDANJA").Not.Nullable();
            Map(x => x.BrojStranice, "BROJ_STRANICE").Not.Nullable();
        }
    }
    
}
