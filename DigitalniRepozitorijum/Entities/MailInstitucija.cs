using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class MailInstitucija
    {
        
        public virtual NaucnoIstrazivackaInstitucija ID_NII { get;  set; }
        public virtual string MailAdresa { get;  set; }
        

        public MailInstitucija()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is MailInstitucija other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_NII.ID_NII == other.ID_NII.ID_NII && MailAdresa == other.MailAdresa;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
