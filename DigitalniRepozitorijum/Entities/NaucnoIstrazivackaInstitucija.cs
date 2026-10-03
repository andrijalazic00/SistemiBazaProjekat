using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class NaucnoIstrazivackaInstitucija
    {
        public virtual int ID_NII { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual string Adresa {get;set;}
        public virtual IList<MailInstitucija> Mailovi {  get; set; }
        public virtual IList<TelefonInstitucija> Telefoni {  get; set; }
        public virtual IList<NaucnaOblast> NaucneOblasti {  get; set; }
        public virtual IList<Angazovanje> Istrazivaci {  get; set; }

        public NaucnoIstrazivackaInstitucija()
        {
            Mailovi = new List<MailInstitucija>();
            Telefoni = new List<TelefonInstitucija>();
            NaucneOblasti = new List<NaucnaOblast>();
            Istrazivaci=new List<Angazovanje>();
        }
        
    }
}
