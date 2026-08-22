using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DigitalniRepozitorijum.Entities;

namespace DigitalniRepozitorijum.Maps
{
    public class AdministratorOvlascenjaMaps:ClassMap<AdministratorOvlascenja>
    {
        public AdministratorOvlascenjaMaps()
        {
            Table("ADMINISTRATOR_OVLASCENJA");
            CompositeId()
                .KeyReference(x => x.ID_U, "ID_U")
                .KeyProperty(x => x.Ovlascenje, "OVLASCENJE");
        }
    }
}
