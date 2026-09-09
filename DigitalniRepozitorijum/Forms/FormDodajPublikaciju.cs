using DigitalniRepozitorijum.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;

namespace DigitalniRepozitorijum.Forms
{
    public partial class FormDodajPublikaciju : Form
    {
        //private Publikacija _publikacija;
        private ISession _session;
        private Dictionary<int, Autor> _autorDict;
        private Dictionary<int, IstrazivackiRezultat> _istrazivackiRezultatDict;

        public FormDodajPublikaciju()
        {
            InitializeComponent();
            nudRedniBrojAutora.Minimum = 1;
            PopuniComboBox();
        }

        public void PopuniComboBox()
        {
            try
            {
                _session = DataLayer.GetSession();

                List<Autor>  autorList = _session.Query<Autor>().ToList();
                
                _autorDict = autorList.ToDictionary(i => i.ID_U);
                Dictionary<int, string> AutorKeyNameDict=autorList.ToDictionary(i => i.ID_U, i=>i.ID_I!=null? i.ID_I.Ime+" "+i.ID_I.Prezime+" "+i.Orcid:i.Orcid);
                comboBAutor.DataSource = new BindingSource(AutorKeyNameDict, null);
                comboBAutor.DisplayMember = "Value";
                comboBAutor.ValueMember = "Key";
                comboBAutor.DropDownStyle = ComboBoxStyle.DropDownList;

                List<Dataset> datasetList;
                datasetList =_session.Query<Dataset>().ToList();
                List<SoftverskiArtifakt> softverskiArtifaktList;
                softverskiArtifaktList = _session.Query<SoftverskiArtifakt>().ToList();
                List<TehnickiIzvestaj> tehnickiIzvestajList;
                tehnickiIzvestajList = _session.Query<TehnickiIzvestaj>().ToList();

                List<IstrazivackiRezultat> _istrazivackiRezultatList=new List<IstrazivackiRezultat>();
                _istrazivackiRezultatList.AddRange(datasetList);
                _istrazivackiRezultatList.AddRange(softverskiArtifaktList);
                _istrazivackiRezultatList.AddRange(tehnickiIzvestajList);


                _istrazivackiRezultatDict = _istrazivackiRezultatList.ToDictionary(i => i.ID_IR);
                Dictionary<int, string> IRKeyNameDict = _istrazivackiRezultatList.ToDictionary(i => i.ID_IR, i => i.Naslov + " " + i.DatumKreiranja);
                comboBZasnivaSeNa.DataSource = new BindingSource(IRKeyNameDict, null);
                comboBZasnivaSeNa.DisplayMember = "Value";
                comboBZasnivaSeNa.ValueMember = "Key";
                comboBZasnivaSeNa.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBZasnivaSeNa.SelectedIndex = -1;


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno prpbavljanje entiteta" + ex.Message.ToString());
                this.Close();
            }
        }


        private void btnSacuvajPublikaciju_Click(object sender, EventArgs e)
        {

            try 
            {
       
                if (tbTipDoprinosa.Text.Length>0 &&tbUlogaUPublikaciji.Text.Length>0)
                {
                    Publikacija publikacija=new Publikacija();
                    Autor autor = _autorDict[(int)comboBAutor.SelectedValue];
                    Autorstvo autrostvo=new Autorstvo(autor,publikacija);
                    autrostvo.TipDoprinosa=tbTipDoprinosa.Text;
                    autrostvo.RedniBrojAutora = (int)nudRedniBrojAutora.Value;
                    autrostvo.UlogaUPublikaciji = tbUlogaUPublikaciji.Text;
                    /*if (comboBZasnivaSeNa.SelectedValue != null)
                        publikacija.ID_IR = _istrazivackiRezultatDict[(int)comboBZasnivaSeNa.SelectedValue];*/
                    publikacija.Autorstva.Add(autrostvo);
                    autor.Autorstva.Add(autrostvo);

                    
                    _session.Save(publikacija);
                    _session.SaveOrUpdate(autor);
                    _session.Flush();
                    _session.Close();


                }
                else
                {
                    MessageBox.Show("Popunite prazna polja");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
                
        }
    }
}
