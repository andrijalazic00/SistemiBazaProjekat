using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class SoftverskiArtifakt:IstrazivackiRezultat
    {
        //public virtual int ID_IR { get; protected set; }
        public virtual string ProgramskiJezik { get; set; }
        public virtual string RepoLink { get; set; }
        public virtual string NacinLicenciranja { get; set; }
        public virtual string Dokumentacija { get; set; }
        
        public virtual Publikacija Publikacija { get; set; }

        public virtual IList<PodrzanaPlatforma> PodrzanePlatforme {  get; set; }
        
        public SoftverskiArtifakt()
        {
            PodrzanePlatforme=new List<PodrzanaPlatforma>();
        }
    }

}
