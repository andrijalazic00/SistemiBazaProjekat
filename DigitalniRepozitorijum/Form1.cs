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
using DigitalniRepozitorijum.Entities;

namespace DigitalniRepozitorijum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajIstrazivaca_Click(object sender, EventArgs e)
        {
            try
            {


                ISession s = DataLayer.GetSession();

                Istrazivac I = new Istrazivac();

                Mail mail = new Mail();
                Mail mail2 = new Mail();
                mail.MailAdresa = "znalac6@gmail.com";
                mail2.MailAdresa = "znalac7@gmail.com";
                mail.ID_I = I;
                mail2.ID_I = I;

                Telefon telefon = new Telefon();
                Telefon telefon2 = new Telefon();
                telefon.Broj = "0621114355";
                telefon2.Broj = "066103200";
                telefon.ID_I = I;
                telefon2.ID_I = I;

                Autor autor = new Autor();
                //Uloga uloga2= new Uloga();
                autor.Orcid = "1111-2222-3333-555X";
                autor.ID_I = I;

                OblastiEkspertize oe=new OblastiEkspertize();
                oe.Oblast = "Lednici";
                OblastiEkspertize oe2 = new OblastiEkspertize();
                oe2.Oblast = "Vuklani";

                Recezent recezent = new Recezent();
                recezent.ID_I = I;
                recezent.OblastiEkspertize.Add(oe);
                recezent.OblastiEkspertize.Add(oe2);

                oe.ID_U = recezent;
                oe2.ID_U = recezent;

                Urednik urednik = new Urednik();
                urednik.UredjivackaSekcija = "neka uredjivacka sekcija";
                urednik.ID_I = I;
                
                RukovodilacProjekta rp=new RukovodilacProjekta();
                rp.ID_I = I;
                
                AdministratorOvlascenja ovlascenje=new AdministratorOvlascenja();
                AdministratorOvlascenja ovlascenje2 = new AdministratorOvlascenja();
                ovlascenje.Ovlascenje = "Citanje";
                ovlascenje2.Ovlascenje = "Upis";


                AdministratorRepozitorijuma ar=new AdministratorRepozitorijuma();
                
                ovlascenje.ID_U = ar;
                ovlascenje2.ID_U = ar;

                ar.Ovlascenja.Add(ovlascenje);
                ar.Ovlascenja.Add(ovlascenje2);
                ar.ID_I = I;

               

                I.Mailovi.Add(mail);
                I.Mailovi.Add(mail2);
                I.Telefoni.Add(telefon);
                I.Telefoni.Add(telefon2);
                I.Uloge.Add(autor);
                I.Uloge.Add(recezent);
                I.Uloge.Add(urednik);
                I.Uloge.Add(rp);
                I.Uloge.Add(ar);


                I.DatumRodjenja = new DateTime(2000, 4, 25);
                I.Ime = "Pametan";
                I.Prezime = "Pametnjakovic";
                I.Drzava = "Srbija";
                I.NaucnaOblast = "Prirodne Nauke";
                I.NaucnoZvanje = "Doktor geografije";
                I.StatusNaucnika = "AKTIVAN";


                s.SaveOrUpdate(I);

                s.Flush();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnDodajNII_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                /*NaucnoIstrazivackaInstitucija n2 = s.Load<NaucnoIstrazivackaInstitucija>(1);
                NaucnoIstrazivackaInstitucija n = new NaucnoIstrazivackaInstitucija();
                n.Naziv = "Institut Podvodnih Istrazivanja";
                n.Adresa = "Nikole Tesle 32";
                s.SaveOrUpdate(n);*/


                NaucnoIstrazivackaInstitucija n = new NaucnoIstrazivackaInstitucija();

                MailInstitucija mail = new MailInstitucija();
                MailInstitucija mail2 = new MailInstitucija();
                mail.MailAdresa = "nekaNI@gmail.com";
                mail2.MailAdresa = "DrugiMail@gmail.com";
                mail.ID_NII = n;
                mail2.ID_NII = n;


                TelefonInstitucija telefon = new TelefonInstitucija();
                TelefonInstitucija telefon2 = new TelefonInstitucija();
                telefon.Broj = "062113555";
                telefon2.Broj = "069993444";
                telefon.ID_NII = n;
                telefon2.ID_NII = n;

                NaucnaOblast no=new NaucnaOblast();
                NaucnaOblast no2 = new NaucnaOblast();
                no.Oblast = "Nacionalni parkovi";
                no2.Oblast = "Organska Hemija";
                no.ID_NII = n;
                no2.ID_NII = n;


                n.Adresa = "Belog Galeba 25";
                n.Naziv = "Institucija NI2";

                n.Mailovi.Add(mail);
                n.Mailovi.Add(mail2);

                n.Telefoni.Add(telefon);
                n.Telefoni.Add(telefon2);

                n.NaucneOblasti.Add(no);
                n.NaucneOblasti.Add(no2);

                s.SaveOrUpdate(n);

                s.Flush();



                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Autor autor = new Autor();
                autor.Orcid = "1233-1212-2112-123X";
                
                s.Save(autor);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString() ); 
            }
        }
    }
}
