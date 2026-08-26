using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class NaucnaOblast
    {
        public virtual NaucnoIstrazivackaInstitucija ID_NII { get; set; }
        public virtual string Oblast { get; set; }

        public NaucnaOblast()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NaucnaOblast other)) return false;
            return ID_NII == other.ID_NII && Oblast == other.Oblast;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
