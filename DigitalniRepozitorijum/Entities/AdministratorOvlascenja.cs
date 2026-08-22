using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{

        public class AdministratorOvlascenja
        {
            //public virtual int ID_U { get; protected set; }
            public virtual string Ovlascenje { get; set; }
            public virtual AdministratorRepozitorijuma ID_U {  get; set; }
            public AdministratorOvlascenja()
            {
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AdministratorOvlascenja other)) return false;
                return ID_U == other.ID_U && Ovlascenje == other.Ovlascenje;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
    }
    
}
