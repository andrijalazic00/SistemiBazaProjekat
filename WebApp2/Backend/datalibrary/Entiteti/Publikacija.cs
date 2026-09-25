using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class Publikacija
    {
        public virtual int ID_P { get; protected set; }
        public virtual Dataset ID_D { get; set; }
        public virtual TehnickiIzvestaj ID_TI { get; set; }
        public virtual SoftverskiArtifakt ID_SA { get; set;}


        public virtual IList <Citat> CitirajucePublikacije {  get; set; }
        public virtual IList<Citat> CitiranePublikacije { get; set; }
        public virtual IList<RundaRecenzije> RundeRecenzije { get; set; }
        public virtual IList<Autorstvo> Autorstva {  get; set; }

        //public virtual IList <Angazovanje> CitiranePublikacije { get; set; }

        public Publikacija()
        {
            CitirajucePublikacije=[];
            CitiranePublikacije=[];
            RundeRecenzije=[];
            Autorstva=[];    
        }
    }
}
