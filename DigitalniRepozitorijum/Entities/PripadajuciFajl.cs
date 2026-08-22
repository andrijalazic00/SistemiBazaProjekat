using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class PripadajuciFajl
    {
        public virtual IstrazivackiRezultat ID_R { get; protected set; }
        public virtual int BrojVerzije { get; protected set; }
        public virtual string NazivFajla { get; protected set; }

        public PripadajuciFajl()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PripadajuciFajl other)) return false;
            return ID_R == other.ID_R && BrojVerzije == other.BrojVerzije && NazivFajla == other.NazivFajla;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
