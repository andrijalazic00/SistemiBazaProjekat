using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class PodrzanaPlatforma
    {
        public virtual IstrazivackiRezultat ID_IR { get; set; }
        public virtual string Platforma { get;  set; }

        public PodrzanaPlatforma()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PodrzanaPlatforma other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_IR.ID_IR == other.ID_IR.ID_IR && Platforma == other.Platforma;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
