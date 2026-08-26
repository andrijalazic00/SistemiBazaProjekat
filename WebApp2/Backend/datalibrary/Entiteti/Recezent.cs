using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class Recezent:Uloga
    {
        //public virtual int ID_U { get; protected set; }
        public virtual IList<OblastiEkspertize> OblastiEkspertize { get; set; }
        public Recezent()
        {
            OblastiEkspertize =new List<OblastiEkspertize>();
        }
    }
}
