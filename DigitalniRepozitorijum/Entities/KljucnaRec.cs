using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class KljucnaRec
    {
        public virtual IstrazivackiRezultat ID_IR { get;  set; }
        public virtual string Rec { get; set; }

        public KljucnaRec()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is KljucnaRec other)) return false;
            return ID_IR == other.ID_IR && Rec == other.Rec;
        }
        public override int GetHashCode()
        {
               return base.GetHashCode();
        }
    }
}
