using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalniRepozitorijum.Entities;
namespace DigitalniRepozitorijum.Entities
{
    public class NaucniRad:IstrazivackiRezultat
    {
        //public virtual int ID_IR { get; protected set; }
        public virtual string TipRada { get; set; }
        public virtual string NazivCasKon { get; set; }
        public virtual string Doi { get; set; }
        public virtual string IssnIliIsbn { get; set; }
        public virtual int BrojSveske { get; set; }
        public virtual int BrojIzdanja { get; set; }
        public virtual int BrojStranice { get; set; }

        public NaucniRad()
        {
        }
    }

}
