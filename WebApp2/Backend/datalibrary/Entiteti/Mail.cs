using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class Mail
    {

        public virtual Istrazivac ID_I { get; set; }
        public virtual string MailAdresa { get; set; }


        public Mail()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Mail other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_I.ID_I == other.ID_I.ID_I && MailAdresa == other.MailAdresa;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
