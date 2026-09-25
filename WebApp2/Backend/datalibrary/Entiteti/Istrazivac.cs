using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class Istrazivac
    {

        public virtual int ID_I { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string NaucnaOblast { get; set; }
        public virtual string NaucnoZvanje { get; set; }
        public virtual string StatusNaucnika { get; set; }

        public virtual IList<Mail>? Mailovi { get; set; }
        public virtual IList<Telefon>? Telefoni { get; set; }
        public virtual IList<Uloga>? Uloge {  get; set; }
        public virtual IList<Angazovanje>? Institucije { get; set; }

        public Istrazivac()
        {
            Mailovi = new List<Mail>();
            Telefoni = new List<Telefon>();
            Uloge=new List<Uloga>();
            Institucije = new List<Angazovanje>();

        }
    }
}
