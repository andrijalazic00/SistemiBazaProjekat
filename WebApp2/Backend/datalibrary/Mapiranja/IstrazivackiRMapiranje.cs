 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 using FluentNHibernate.Mapping;
 using datalibrary.Entiteti;

 namespace datalibrary.Mapiranja
{
    class IstrazivackiRMapiranje: ClassMap<IstrazivackiRezultati>
    {
        public IstrazivackiRMapiranje()
        {   
            //Mapiranje Tabele
            Table("ISTRAZIVACKI_REZULTATI");

            //Mapiranje primarnog kljuca
            Id( x=> x.Id, "ID_IR").GeneratedBy.Increment();

            //mapiranje svojstva
            Map( x => x.Naslov, "NASLOV");
            Map( x => x.Apstrakt, "APSTRAKT");
            Map( x => x.DatumKreiranja, "DATUM_KREIRANJA");
            Map( x => x.DatumObjavljivanja, "DATUM_OBJAVLJIVANJA");
            Map( x => x.StatusIR, "STATUS_IR");
            Map( x => x.Vidljivost, "VIDLJIVOST");
        }
        }
}
