using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DigitalniRepozitorijum.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using NHibernate.Mapping;

namespace DigitalniRepozitorijum.Maps
{
    class NaucnoIstrazivackaInstitucijaMaps:ClassMap<NaucnoIstrazivackaInstitucija>
    {
        public NaucnoIstrazivackaInstitucijaMaps()
        {
            //Mapiranje tabele
            Table("NI_INSTITUCIJA");
            //Mapiranje PK
            Id(x => x.ID_NII, "ID_NII").GeneratedBy.Native();
            //Mapiranje prostih entiteta
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Adresa, "ADRESA");
            
        }
    }
}
