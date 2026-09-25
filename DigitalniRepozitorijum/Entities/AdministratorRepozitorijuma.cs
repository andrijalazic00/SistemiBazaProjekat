using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class AdministratorRepozitorijuma:Uloga
    {
        public virtual IList<AdministratorOvlascenja> Ovlascenja {  get; set; }

        public AdministratorRepozitorijuma()
        {
            Ovlascenja=new List<AdministratorOvlascenja>();
        }
    }
}
