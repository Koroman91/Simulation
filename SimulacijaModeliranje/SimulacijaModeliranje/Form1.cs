using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimulacijaModeliranje
{
    public partial class Form1 : Form

    {
       

        public Form1()
        {
            InitializeComponent();
        }

      

        private void bStart_Click(object sender, EventArgs e)
        {


            int trenutnoVreme, zaustavnoVreme, brzina, redniBrojKupca, vremeDolaskaSledecegKupca, redniBrojKupcaKojiJeNaKasi;
            Kupac[] kupac = new Kupac[1000];
            List<int> redNaSporojKasi = new List<int>();
            List<int> redNaBrzojKasi = new List<int>();

            //for (int i = 0; i < 1000; i++) kupac[i] = new Kupac();
            redniBrojKupcaKojiJeNaKasi = 0;
            trenutnoVreme = 0;
            redniBrojKupca = 0;
            vremeDolaskaSledecegKupca = 1;

            zaustavnoVreme = Convert.ToInt32(tbZaustavnoVremeSati.Text) * 3600 + Convert.ToInt32(tbZaustavnoVremeMinuti.Text) * 60 + Convert.ToInt32(tbZaustavnoVremeSekunde.Text);
            brzina = Convert.ToInt32(tbBrzina.Text);
            //Kupac kupac = new Kupac();

            //kupac.redniBrojKupca = redniBrojKupca;
            ////kupacStefan.brojArtikala = 20;
            //kupac.brojArtikala = kupac.GenerisiBrojArtikala(Convert.ToInt32(tbMaxArtikala.Text));
            //kupac.vremeObradeKupovineKupca = kupac.brojArtikala * Convert.ToInt32(tbVremePoArtiklu.Text);





            for (trenutnoVreme = 0; trenutnoVreme <= zaustavnoVreme; trenutnoVreme++)
            {

                //PROVERAVA DA LI JE DOSLO VREME DA SE POJAVE NOVI KUPAC
                if (vremeDolaskaSledecegKupca == trenutnoVreme)
                {
                    //vremeDolaskaSledecegKupca = trenutnoVreme + GenerisiVremeDolaskaSledecegKupca(Convert.ToInt32(tbMaxVremeIzmedjuDvaKupca.Text));

                    //Kupac kupac = new Kupac();
                    //NAPRAVI NOVOG KUPCA I GENERISI PODATKE
                    kupac[redniBrojKupca] = new Kupac();
                    kupac[redniBrojKupca].redniBrojKupca = redniBrojKupca;
                    //kupacStefan.brojArtikala = 20;
                    kupac[redniBrojKupca].brojArtikala = kupac[redniBrojKupca].GenerisiBrojArtikala(Convert.ToInt32(tbMaxArtikala.Text));
                    kupac[redniBrojKupca].vremeObradeKupovineKupca = kupac[redniBrojKupca].brojArtikala * Convert.ToInt32(tbVremePoArtiklu.Text);
                    kupac[redniBrojKupca].vremeUlaskaURed = trenutnoVreme;
                    kupac[redniBrojKupca].izasao = 0;

                    int limitBrzeKase = Convert.ToInt32(tbLimitBrzeKase.Text);
                    //ako je broj artikala kupca  <= limit brze kase onda dodaj brzi red else dodaj u spori red
                    if (kupac[redniBrojKupca].brojArtikala <= limitBrzeKase) redNaBrzojKasi.Add(redniBrojKupca); else redNaSporojKasi.Add(redniBrojKupca);
                    //redNaSporojKasi.Add(redniBrojKupca);

                    if (redNaSporojKasi.Count == 1)
                    {
                        int br = redNaSporojKasi[0];
                        kupac[br].vremeDolaskaNaKasu = trenutnoVreme;
                        kupac[br].vremeOdlaskaSaKase = trenutnoVreme + kupac[br].vremeObradeKupovineKupca;
                    }

                    if (redNaBrzojKasi.Count == 1)
                    {
                        int br = redNaBrzojKasi[0];
                        kupac[br].vremeDolaskaNaKasu = trenutnoVreme;
                        kupac[br].vremeOdlaskaSaKase = trenutnoVreme + kupac[br].vremeObradeKupovineKupca;
                    }
                    //MessageBox.Show("Pojavio se novi kupac broj " + kupac[redniBrojKupca].redniBrojKupca + ", koji ima " + kupac[redniBrojKupca].brojArtikala + ", vreme pojave sledeceg kupca je " + vremeDolaskaSledecegKupca);

                    vremeDolaskaSledecegKupca = trenutnoVreme + GenerisiVremeDolaskaSledecegKupca(Convert.ToInt32(tbMaxVremeIzmedjuDvaKupca.Text));
                    redniBrojKupca = redniBrojKupca + 1;
                }


                //PROVERA DA LI JE KUPAC KOJI SE OBRADJUJE NA Sporoj KASI ZAVRSIO SA OBRADOM - AKO JESTE IZBACI GA IZ REDA
                if (redNaSporojKasi.Count != 0)
                {
                    redniBrojKupcaKojiJeNaKasi = redNaSporojKasi[0];
                    if (kupac[redniBrojKupcaKojiJeNaKasi].vremeOdlaskaSaKase == trenutnoVreme)
                    {

                        kupac[redniBrojKupcaKojiJeNaKasi].izasao = 1;
                        redNaSporojKasi.RemoveAt(0);//izbaci kupca sa kase

                        if (redNaSporojKasi.Count != 0)
                        {
                            redniBrojKupcaKojiJeNaKasi = redNaSporojKasi[0];//procitaj redni broj kupca koji je sada dosao na kasu
                            kupac[redniBrojKupcaKojiJeNaKasi].vremeDolaskaNaKasu = trenutnoVreme;
                            kupac[redniBrojKupcaKojiJeNaKasi].vremeOdlaskaSaKase = trenutnoVreme + kupac[redniBrojKupcaKojiJeNaKasi].vremeObradeKupovineKupca;
                        }
                        }
                }
                //PROVERA DA LI JE KUPAC KOJI SE OBRADJUJE NA BRZOJ KASI ZAVRSIO SA OBRADOM - AKO JESTE IZBACI GA IZ REDA
                if (redNaBrzojKasi.Count != 0)
                {
                    redniBrojKupcaKojiJeNaKasi = redNaBrzojKasi[0];
                    if (kupac[redniBrojKupcaKojiJeNaKasi].vremeOdlaskaSaKase == trenutnoVreme)
                    {

                        kupac[redniBrojKupcaKojiJeNaKasi].izasao = 1;
                        redNaBrzojKasi.RemoveAt(0);//izbaci kupca sa kase
                        if (redNaBrzojKasi.Count != 0)
                        {
                            redniBrojKupcaKojiJeNaKasi = redNaBrzojKasi[0];//procitaj redni broj kupca koji je sada dosao na kasu
                            kupac[redniBrojKupcaKojiJeNaKasi].vremeDolaskaNaKasu = trenutnoVreme;
                            kupac[redniBrojKupcaKojiJeNaKasi].vremeOdlaskaSaKase = trenutnoVreme + kupac[redniBrojKupcaKojiJeNaKasi].vremeObradeKupovineKupca;
                        }
                        }
                }





                //PRIKAZUJE STOPERICU U REALNOM VREMENU 
                //lKupac.Text = "Redni broj je " + kupac.redniBrojKupca + ", broj artikala je " + kupac.brojArtikala + ", vreme obrade korpe je " + kupac.vremeObradeKupovineKupca;
                lStoperica.Text = trenutnoVreme / 3600 + ":" + (trenutnoVreme % 3600) / 60 + ":" + (trenutnoVreme % 3600) % 60;
                lBrojKupacaUSporomRedu.Text = " Broj kupaca u redu spore kase je " + redNaSporojKasi.Count;
                
                //ISPIS STANJA REDA SPORE KASE
                String redSporeKase = "";

                for (int i = 0; i < redNaSporojKasi.Count; i++) if (redNaSporojKasi[i] != 0)
                    {
                        if (redNaSporojKasi[i] >= 10) redSporeKase = redSporeKase + redNaSporojKasi[i] + "   "; else redSporeKase = redSporeKase + redNaSporojKasi[i] + "    ";
                    }
                lRedSporeKase.Text = redSporeKase;

                //ISPIS STANJA REDA BRZE KASE
                String redBrzeKase = "";

                for (int i = 0; i < redNaBrzojKasi.Count; i++) if (redNaBrzojKasi[i] != 0)
                    {
                        if (redNaBrzojKasi[i] >= 10) redBrzeKase = redBrzeKase + redNaBrzojKasi[i] + "   "; else redBrzeKase = redBrzeKase + redNaBrzojKasi[i] + "    ";
                    }
                lRedBrzeKase.Text = redBrzeKase;
                

                System.Threading.Thread.Sleep(1000 / brzina);
                this.Refresh();

            }

            //NA KRAJU SIMULACIJE IZRACUNAJ STATISTIKU
            int prosecanBrojArtikala = 0;
            int prosecnoVremeObradeKorpe = 0;
            int prosecnoVremeURedu = 0;
            for (int i = 0; i < redniBrojKupca; i++)
            {
                prosecanBrojArtikala = prosecanBrojArtikala + kupac[i].brojArtikala;
                prosecnoVremeObradeKorpe = prosecnoVremeObradeKorpe + kupac[i].vremeObradeKupovineKupca;
                if(kupac[i].izasao==1) prosecnoVremeURedu = prosecnoVremeURedu + (kupac[i].vremeOdlaskaSaKase - kupac[i].vremeUlaskaURed);
            }
            prosecanBrojArtikala = prosecanBrojArtikala / redniBrojKupca;
            prosecnoVremeObradeKorpe = prosecnoVremeObradeKorpe / redniBrojKupca;
            prosecnoVremeURedu = prosecnoVremeURedu / redniBrojKupca;

            lProsecanBrojArtikala.Text = "Prosecan broj artikala je " + Convert.ToString(prosecanBrojArtikala);
            lProsecnoVremeObradeKupca.Text = "Prosecno vreme obrade kupca je " + Convert.ToString(prosecnoVremeObradeKorpe);
            lProsecnoVremeURedu.Text = "Prosecno vreme u redu je " + Convert.ToString(prosecnoVremeURedu);
        }

        public int GenerisiVremeDolaskaSledecegKupca(int maxVremeIzmedjuDvaKupca)
        {
            int vreme = 0;

            Random randInt = new Random();
            vreme = randInt.Next(1, maxVremeIzmedjuDvaKupca);

            return vreme;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lStoperica_Click(object sender, EventArgs e)
        {

        }

        private void tbZaustavnoVremeMinuti_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class Kupac
    {
        public int redniBrojKupca;
        public int brojArtikala;
        public int vremeObradeKupovineKupca;
        public int vremeDolaskaNaKasu;
        public int vremeOdlaskaSaKase;
        public int fiksnoVremeObradeJednogArtikla;
        public int prosecanBrojArtikalaPoKupcu;
        public int vremeUlaskaURed;
        public int izasao;
        public String ime;


        public int GenerisiBrojArtikala(int maxArtikala)
        {

            int broj=0;

            Random randInt = new Random();
            broj = randInt.Next(1, maxArtikala);

            return broj;
        }


    }

    
}
