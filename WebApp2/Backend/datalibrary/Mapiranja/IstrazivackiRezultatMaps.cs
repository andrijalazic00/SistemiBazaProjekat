using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using datalibrary.Entiteti;

namespace datalibrary.Mapiranja
{
    public class IstrazivackiRezultatMaps : ClassMap<IstrazivackiRezultat>
    {
        public IstrazivackiRezultatMaps()
        {
            //Mapiranje tabele
            Table("ISTRAZIVACKI_REZULTAT");
            //Mapiranje PK
            Id(x => x.ID_IR, "ID_IR").GeneratedBy.Sequence("SEQ_ISTRAZIVACKI_REZULTAT");
            //Mapiranje prostih entiteta
            Map(x => x.Naslov, "NASLOV").Not.Nullable();
            Map(x => x.Apstrakt, "APSTRAKT").Not.Nullable();
            Map(x => x.DatumKreiranja, "DATUM_KREIRANJA").Not.Nullable();
            Map(x => x.DatumObjavljivanja, "DATUM_OBJAVLJIVANJA").Not.Nullable();
            Map(x => x.StatusIR, "STATUS_IR").Not.Nullable();
            Map(x => x.Vidljivost, "VIDLJIVOST").Not.Nullable();

            ///HasOne(x => x.Publikacija).PropertyRef(x => x.ID_IR);

            HasMany(x => x.KljucneReci).KeyColumn("ID_IR").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Verzije).KeyColumn("ID_IR").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.PripadajuciFajlovi).KeyColumn("ID_IR").LazyLoad().Cascade.All().Inverse();
        }
    }
}
