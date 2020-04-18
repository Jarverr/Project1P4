using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1ListaPrzebojów
{
    public partial class CheckingDate : Form
    {
        public string TrackToCheck { get; set; }
        public CheckingDate()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var checkingDate = new MainProgram();
            checkingDate.Closed += (s, args) => this.Close();
            checkingDate.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TrackToCheck = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var baza = new TPCContextDBHitsList())
            {
                if (textBox1.Text == "")
                {
                    if (baza.Database.Exists())
                    {
                        InfoBox1.Text = "";
                        InfoBox2.Text = "";
                        InfoBox3.Text = "";
                        InfoBox4.Text = "";
                        InfoBox5.Text = "";
                        InfoBox6.Text = "";
                        foreach (var item in baza.Utwory)
                        {

                            var INFO = item;
                            var INFO2 = INFO.Gatunki;
                            var INFO3 = INFO.Nagrody;
                            var INFO4 = INFO.Ocena;
                            var INFO5 = INFO.Wykonawca;
                            var INFO6 = INFO.Album;

                            InfoBox1.Text += $"Id piosenki:{item.IdUtworu}\r\nNazwa utworu: {item.NazwaUtworu}\r\nRok Wydania: {item.RokWykonania}\r\nOpis Utworu: { item.OpisUtworu}\r\nDługość: {item.Długość}\r\nWykonawca: {item.Wykonawca.Wykonawca}.\r\n\r\n";
                            foreach (var item2 in INFO2)
                            {
                                InfoBox2.Text += $"Id piosenki:{item.IdUtworu}\r\nId Gatunku: {item2.IdGatunku}\r\nNazwa gatunku: {item2.NazwaGatunku}\r\nRok powstania: {item2.RokPowstania}\r\nMiejsce Powstania: {item2.MiejscePowstania}\r\n\r\n";
                            }

                            foreach (var item2 in INFO3)
                            {
                                InfoBox3.Text += $"Id piosenki:{item.IdUtworu}\r\nId Nagrody: {item2.IdNagrody}\r\nNazwa nagrody: {item2.NazwaNagrody}\r\nKategoria: {item2.Kategoria}\r\nPierwszy rok wręczenia: {item2.RokWreczeniaPierwszejNagrody}\r\n\r\n";
                            }
                            InfoBox4.Text += $"Id piosenki:{item.IdUtworu}\r\nOcena Administratora: {INFO4.OcenaAdministratora}\r\nOcena Administratorki: {INFO4.OcenaAdministratorki}\r\n\r\n";


                            InfoBox5.Text += $"Id piosenki:{item.IdUtworu}\r\nId Wykonawcy: {INFO5.IdWykonawcy}\r\nWykonawca: {INFO5.Wykonawca}\r\nPoczątek wykonawcy: {INFO5.RokPowstania}\r\n\r\n";


                            InfoBox6.Text += $"Id piosenki:{item.IdUtworu}\r\nId Albumu: {INFO6.IdAlbumu}\r\nNazwa albumu: {INFO6.NazwaAlbumu}\r\nRok wydania: {INFO6.RokWydania}\r\nRok rozpoczecie nagrań: {INFO6.RokRozpoczecieNagrań}\r\nWydawnictwo:{INFO6.Wydawnictwo}\r\n\r\n";

                        }
                        //var INFO2 = INFO.SelectMany(x => x.Gatunki);
                        //var INFO3 = INFO.SelectMany(x => x.Nagrody);
                        //var INFO4 = INFO.Select(x => x.Ocena);
                        //var INFO5 = INFO.Select(x => x.Wykonawca);
                        //var INFO6 = INFO.Select(x => x.Album);
                        //var IdUtworu = trackInfo.Select(x => x.IdUtworu);

                        //var trackInfo2 = from gatunki in baza.Gatunki join utwory in INFO2 on gatunki.IdGatunku equals utwory.IdGatunku select new  { NazwaGatunku = gatunki.NazwaGatunku, RokPowstania = gatunki.RokPowstania, MiejscePowstania = gatunki.MiejscePowstania };

                        //var trackInfo3 = baza.Oceny.Where(x => baza.Oceny.Select(z => z.IdOceny) == trackInfo.Select(y => y.OcenaId)); //tutaj musialem selectem  pobrac bo typ mi sie nie zgadzał
                        //var trackInfo4 = baza.Albumy.Where(x => baza.Albumy.Select(z => z.IdAlbumu) == trackInfo.Select(y => y.AlbumId)); ; //tutaj musialem selectem  pobrac bo typ mi sie nie zgadzał
                        //var trackInfo5 = baza.Nagrody.Where(x => baza.Nagrody.Select(z => z.Utwory.Select(w => w.IdUtworu)) == trackInfo.Select(y => y.IdUtworu)); ; //tutaj musialem selectem  pobrac bo typ mi sie nie zgadzał
                        //var trackInfo6 = baza.Wykonawca.Where(x => baza.Wykonawca.Select(z => z.IdWykonawcy) == trackInfo.Select(y => y.WykonawcaId)); ; //tutaj musialem selectem  pobrac bo typ mi sie nie zgadzał
                        //var trackInfo4 = baza.Albumy.Where(x => x.IdAlbumu == IdUtworu);


                        //InfoBox3.Text = $"Ocena Administratora: {trackInfo3.Select(x => x.OcenaAdministratora)}\r\nOcena Administratorki: {trackInfo3.Select(x => x.OcenaAdministratora)}\r\nKomentarz: {trackInfo3.Select(x => x.Komentarz)}.";
                        //InfoBox4.Text = $"Nazwa Albumu: {trackInfo4.Select(x => x.NazwaAlbumu)}\r\nData Wydania: {trackInfo4.Select(x => x.RokWydania)}\r\nRok Rozpoczęcia Nagrań: {trackInfo4.Select(x => x.RokRozpoczecieNagrań)}\r\nWydawnictwo: {trackInfo4.Select(x => x.Wydawnictwo)}.";
                        //InfoBox5.Text = $"Nazwa Nagrody: {trackInfo5.Select(x => x.NazwaNagrody)}\r\nKategoria: {trackInfo5.Select(x => x.Kategoria)}\r\nPierwsze Wręczenie: {trackInfo5.Select(x => x.RokWreczeniaPierwszejNagrody)}.";
                        //InfoBox6.Text = $"Wykonawca: {trackInfo6.Select(x => x.Wykonawca)}.";

                        InfoBox1.Visible = true;
                        InfoBox2.Visible = true;
                        InfoBox3.Visible = true;
                        InfoBox4.Visible = true;
                        InfoBox5.Visible = true;
                        InfoBox6.Visible = true;
                    }
                }
                else 
                {
                    InfoBox1.Text = "";
                    InfoBox2.Text = "";
                    InfoBox3.Text = "";
                    InfoBox4.Text = "";
                    InfoBox5.Text = "";
                    InfoBox6.Text = "";
                    foreach (var item in baza.Utwory)
                    {
                        if (item.NazwaUtworu == textBox1.Text)
                        {

                            var INFO = item;
                            var INFO2 = INFO.Gatunki;
                            var INFO3 = INFO.Nagrody;
                            var INFO4 = INFO.Ocena;
                            var INFO5 = INFO.Wykonawca;
                            var INFO6 = INFO.Album;

                            InfoBox1.Text += $"Id piosenki:{item.IdUtworu}\r\nNazwa utworu: {item.NazwaUtworu}\r\nRok Wydania: {item.RokWykonania}\r\nOpis Utworu: { item.OpisUtworu}\r\nDługość: {item.Długość}\r\nWykonawca: {item.Wykonawca.Wykonawca}.\r\n\r\n";
                            foreach (var item2 in INFO2)
                            {
                                InfoBox2.Text += $"Id piosenki:{item.IdUtworu}\r\nNazwa gatunku: {item2.NazwaGatunku}\r\nRok powstania: {item2.RokPowstania}\r\nMiejsce Powstania: {item2.MiejscePowstania}\r\n\r\n";
                            }

                            foreach (var item2 in INFO3)
                            {
                                InfoBox3.Text += $"Id piosenki:{item.IdUtworu}\r\nNazwa nagrody: {item2.NazwaNagrody}\r\nKategoria: {item2.Kategoria}\r\nPierwszy rok wręczenia: {item2.RokWreczeniaPierwszejNagrody}\r\n\r\n";
                            }
                            InfoBox4.Text += $"Id piosenki:{item.IdUtworu}\r\nOcena Administratora: {INFO4.OcenaAdministratora}\r\nOcena Administratorki: {INFO4.OcenaAdministratorki}\r\n\r\n";


                            InfoBox5.Text += $"Id piosenki:{item.IdUtworu}\r\nWykonawca: {INFO5.Wykonawca}\r\nPoczątek wykonawcy: {INFO5.RokPowstania}\r\n\r\n";


                            InfoBox6.Text += $"Id piosenki:{item.IdUtworu}\r\nNazwa albumu: {INFO6.NazwaAlbumu}\r\nRok wydania: {INFO6.RokWydania}\r\nRok rozpoczecie nagrań: {INFO6.RokRozpoczecieNagrań}\r\nWydawnictwo:{INFO6.Wydawnictwo}\r\n\r\n";

                        }
                    }
                    InfoBox1.Visible = true;
                    InfoBox2.Visible = true;
                    InfoBox3.Visible = true;
                    InfoBox4.Visible = true;
                    InfoBox5.Visible = true;
                    InfoBox6.Visible = true;
                }
            }
           
        }

        private void InfoBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
