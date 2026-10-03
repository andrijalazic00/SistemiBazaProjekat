using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class PripadajuciFajl
    {
        public virtual IstrazivackiRezultat ID_IR { get;  set; }
        public virtual int BrojVerzije { get;  set; }
        public virtual string NazivFajla { get; set; }

        public PripadajuciFajl()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PripadajuciFajl other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_IR.ID_IR == other.ID_IR.ID_IR && BrojVerzije == other.BrojVerzije && NazivFajla == other.NazivFajla;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
