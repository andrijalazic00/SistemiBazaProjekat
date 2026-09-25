using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Recenzent:Uloga
    {
        public virtual IList<OblastiEkspertize> OblastiEkspertize { get; set; }
        public virtual IList<AngazovanjeRecenzent> RundeRecenzije {  get; set; }
        public Recenzent()
        {
            OblastiEkspertize =new List<OblastiEkspertize>();
            RundeRecenzije=new List<AngazovanjeRecenzent>();
        }
    }
}
