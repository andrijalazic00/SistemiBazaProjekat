using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalniRepozitorijum.Entities;
namespace DigitalniRepozitorijum.Maps
{
    class DatasetMaps : SubclassMap<Dataset>
    {
        public DatasetMaps()
        {
            Table("DATASET");
            KeyColumn("ID_IR");
            Map(x => x.Format, "FORMAT").Not.Nullable();
            Map(x => x.Velicina, "VELICINA").Not.Nullable();
            Map(x => x.BrojZapisa, "BROJ_ZAPISA").Not.Nullable();
            Map(x => x.OpisStrukture, "OPIS_STRUKTURE").Not.Nullable();
            Map(x => x.PeriodObuhvataPodataka, "PERIOD_OBUHVATA_PODATAKA").Not.Nullable();
            Map(x => x.LicencaKoriscenja, "LICENCA_KORISCENJA").Not.Nullable();
            Map(x => x.OgranicenjaPristupa, "OGRANICENJA_PRISTUPA").Not.Nullable();
        }
    }
}
