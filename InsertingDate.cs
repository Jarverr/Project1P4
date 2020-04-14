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
    public partial class InsertingDate2 : Form
    {
        public InsertingDate2()
        {
            InitializeComponent();
        }

        private void InsertingDate2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var insertingDate = new InsertingDiffrent();
            insertingDate.Closed += (s, args) => this.Close();
            insertingDate.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new MainProgram();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new TPCContextDBHitsList())
            {
                var track = new Tracks();
                var grade = new Grades();

                track.NazwaUtworu = textBox1.Text;
                int temp;
                if (Int32.TryParse(textBox2.Text, out temp))
                {
                    track.RokWykonania = temp;
                }
                else
                {

                }
                track.OpisUtworu = textBox3.Text;
                track.Długość = textBox4.Text;
                if (Int32.TryParse(textBox5.Text, out temp))
                {
                    track.AlbumId = temp;
                    foreach (var item in context.Albumy)
                    {
                        if (temp == item.IdAlbumu)
                        {
                            track.Album = item;
                        }
                    }
                }
                else
                {
                }

                if (Int32.TryParse(textBox6.Text, out temp))
                {
                    foreach (var item in context.Gatunki)
                    {
                        if (temp == item.IdGatunku)
                        {
                            track.Gatunki.Add(item);
                        }
                    }
                }

                if (Int32.TryParse(textBox16.Text, out temp))
                {
                    foreach (var item in context.Gatunki)
                    {
                        if (temp == item.IdGatunku)
                        {
                            track.Gatunki.Add(item);
                        }
                    }
                }
                if (Int32.TryParse(textBox17.Text, out temp))
                {
                    foreach (var item in context.Gatunki)
                    {
                        if (temp == item.IdGatunku)
                        {
                            track.Gatunki.Add(item);
                        }
                    }
                }
                if (Int32.TryParse(textBox18.Text, out temp))
                {
                    foreach (var item in context.Gatunki)
                    {
                        if (temp == item.IdGatunku)
                        {
                            track.Gatunki.Add(item);
                        }
                    }
                }
                if (Int32.TryParse(textBox19.Text, out temp))
                {
                    foreach (var item in context.Gatunki)
                    {
                        if (temp == item.IdGatunku)
                        {
                            track.Gatunki.Add(item);
                        }
                    }
                }



                if (Int32.TryParse(textBox7.Text, out temp))
                {
                    foreach (var item in context.Nagrody)
                    {
                        if (temp == item.IdNagrody)
                            track.Nagrody.Add(item);
                    }
                }
                if (Int32.TryParse(textBox12.Text, out temp))
                {
                    foreach (var item in context.Nagrody)
                    {
                        if (temp == item.IdNagrody)
                            track.Nagrody.Add(item);
                    }
                }
                if (Int32.TryParse(textBox13.Text, out temp))
                {
                    foreach (var item in context.Nagrody)
                    {
                        if (temp == item.IdNagrody)
                            track.Nagrody.Add(item);
                    }
                }
                if (Int32.TryParse(textBox14.Text, out temp))
                {
                    foreach (var item in context.Nagrody)
                    {
                        if (temp == item.IdNagrody)
                            track.Nagrody.Add(item);
                    }
                }
                if (Int32.TryParse(textBox15.Text, out temp))
                {
                    foreach (var item in context.Nagrody)
                    {
                        if (temp == item.IdNagrody)
                            track.Nagrody.Add(item);
                    }
                }


                if (Int32.TryParse(textBox8.Text, out temp))
                {
                    grade.OcenaAdministratora = temp;
                }
                else
                { }
                if (Int32.TryParse(textBox9.Text, out temp))
                {
                    grade.OcenaAdministratorki = temp;
                }
                else
                { }
                if (Int32.TryParse(textBox11.Text, out temp))
                {
                    track.WykonawcaId = temp;
                    foreach (var item in context.Wykonawcy)
                    {
                        if (temp == item.IdWykonawcy)
                        {
                            track.Wykonawca = item;
                        }
                    }
                }

                context.Utwory.Add(track);
                context.Oceny.Add(grade);
                context.SaveChanges();

                textBox10.Visible = true;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
