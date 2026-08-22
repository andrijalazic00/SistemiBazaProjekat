using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DigitalniRepozitorijum.Entities;

namespace DigitalniRepozitorijum.Maps
{
    public class TelefonInstitucijaMaps:ClassMap<TelefonInstitucija>
    {
        public TelefonInstitucijaMaps()
        {
            Table("TELEFON_INSTITUCIJA");
            CompositeId()
                .KeyReference(x => x.ID_NII, "ID_NII")
                .KeyProperty(x => x.Broj, "TELEFON");
        }
    }
}
