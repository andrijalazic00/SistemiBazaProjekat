using FluentNHibernate.Mapping;
using databaseacesslib.Entiteti;

namespace databaseacesslib.Mapiranje
{
    internal class IstrazivackiRezultatiMapiranje : ClassMap<IstrazivackiRezultati>
    {
        public IstrazivackiRezultatiMapiranje()
        {
            Table("ISTRAZIVACKI_REZULTATI");

            Id( x=> x.Id, "ID_IR").GeneratedBy.TriggerIdentity();

            Map( x => x.Naslov, "NASLOV");
            Map( x => x.Apstrakt, "APSTRAKT");
            Map( x => x.DatumKreiranja, "DATUM_KREIRANJA");
            Map( x => x.DatumObjavljivanja, "DATUM_OBJAVLJIVANJA");
            Map( x => x.StatusIR, "STATUS_IR");
            Map( x => x.Vidljivost, "VIDLJIVOST");
        }
    }
}