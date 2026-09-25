using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Dataset:IstrazivackiRezultat
    {
        public virtual string Format { get; set; }
        public virtual int Velicina { get; set; }
        public virtual int BrojZapisa { get; set; }
        public virtual string OpisStrukture { get; set; }
        public virtual string PeriodObuhvataPodataka { get; set; }
        public virtual string LicencaKoriscenja { get; set; }
        public virtual string OgranicenjaPristupa { get; set; }
        
        public virtual Publikacija Publikacija { get; set; }

        public Dataset()
        {
        }
    }
}
