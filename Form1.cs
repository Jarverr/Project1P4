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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://webroad.pl/aspnet/6864-entity-framework-i-podejscie-code-first-w-asp-net-mvc-relacje
            using (var dbCreation = new TPCContextDBHitsList())
            {
                if (!dbCreation.Database.Exists())
                {
                    var utwory = new Tracks();
                    utwory.NazwaUtworu = "Example";
                    utwory.Długość = "3:30";
                    utwory.RokWykonania = 2008;
                    //utwory.AlbumId = 1;


                    var wykonawca = new Performers();
                    wykonawca.Wykonawca = "Wykonawca1";
                    var grade = new Grades();
                    grade.OcenaAdministratora = 10;
                    var genere = new Geners();
                    genere.NazwaGatunku = "Gatunek1";
                    var album = new Albums();
                    album.NazwaAlbumu = "album1";
                    album.RokWydania = 2009;
                    var awards = new Awards();
                    awards.NazwaNagrody = "Przykładowa";
                    awards.Kategoria = "Kategoria przykładowa";
                    awards.RokWreczeniaPierwszejNagrody = 2000;

                    utwory.Gatunki.Add(genere);
                    utwory.Nagrody.Add(awards);
                    utwory.Wykonawca = wykonawca;
                    utwory.Ocena = grade;
                    utwory.Album = album;

                    awards.Utwory.Add(utwory);
                    genere.Utwory.Add(utwory);
                    album.Utwory.Add(utwory);
                    wykonawca.Utwory.Add(utwory);
                    grade.Utwory.Add(utwory);

                    dbCreation.Wykonawcy.Add(wykonawca);
                    dbCreation.Gatunki.Add(genere);
                    dbCreation.Oceny.Add(grade);
                    dbCreation.Albumy.Add(album);
                    dbCreation.Utwory.Add(utwory);
                    dbCreation.Nagrody.Add(awards);
                    dbCreation.SaveChanges();
                    this.Hide();
                    var form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else
                {
                    ErrorCreation.Visible = true;
                    errorProvider1.SetError(ErrorCreation, "Baza Danych już istnieje");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new MainProgram();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ErrorCreation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
