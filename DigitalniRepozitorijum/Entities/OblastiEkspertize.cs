using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class OblastiEkspertize
    {
        public virtual Recezent ID_U { get;  set; }
        public virtual string Oblast { get;  set; }

        public OblastiEkspertize()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is OblastiEkspertize other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_U.ID_U == other.ID_U.ID_U && Oblast == other.Oblast;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
