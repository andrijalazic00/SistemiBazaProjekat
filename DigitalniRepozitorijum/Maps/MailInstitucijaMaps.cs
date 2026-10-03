using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    public class MailInstitucijaMaps:ClassMap<MailInstitucija>
    {
        public MailInstitucijaMaps()
        {
            Table("MAIL_INSTITUCIJA");
            CompositeId()
                .KeyReference(x => x.ID_NII, "ID_NII")
                .KeyProperty(x => x.MailAdresa, "MAIL");
            //References(x=> x.PripadaInstituciji).Column("ID_NII").LazyLoad();
        }
    }
}
