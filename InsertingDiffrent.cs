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
    public partial class InsertingDiffrent : Form
    {
        public InsertingDiffrent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var insert = new InsertingDate2();
            insert.Closed += (s, args) => this.Close();
            insert.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                using (var context = new TPCContextDBHitsList())
                {
                    var album = new Albums();
                    album.NazwaAlbumu = textBox1.Text;
                    int temp;
                    if (Int32.TryParse(textBox2.Text, out temp))
                    {
                        album.RokWydania = temp;
                    }
                    if (Int32.TryParse(textBox3.Text, out temp))
                    {
                        album.RokRozpoczecieNagrań = temp;
                    }
                    album.Wydawnictwo = textBox4.Text;
                    context.Albumy.Add(album);
                    context.SaveChanges();
                    textBox5.Visible = true;
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Uzupełnij pole nazwa albumu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                using (var context = new TPCContextDBHitsList())
                {
                    var genere = new Geners();
                    genere.NazwaGatunku = textBox8.Text;
                    int temp;
                    if (Int32.TryParse(textBox7.Text, out temp))
                    {
                        genere.RokPowstania = temp;
                    }
                    genere.MiejscePowstania = textBox6.Text;
                    context.Gatunki.Add(genere);
                    context.SaveChanges();
                    textBox11.Visible = true;

                }
            }else
            {
                errorProvider1.SetError(textBox8, "Uzupełnij pole nazwa gatunku.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {


                using (var context = new TPCContextDBHitsList())
                {
                    var award = new Awards();
                    award.NazwaNagrody = textBox14.Text;
                    int temp;
                    if (Int32.TryParse(textBox12.Text, out temp))
                    {
                        award.RokWreczeniaPierwszejNagrody = temp;
                    }
                    award.Kategoria = textBox13.Text;
                    context.Nagrody.Add(award);
                    context.SaveChanges();
                    textBox15.Visible = true;

                }
            }
            else
            {
                errorProvider1.SetError(textBox14, "Uzupełnij pole nazwa nagrody");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {


                using (var context = new TPCContextDBHitsList())
                {
                    var perfom = new Performers();
                    perfom.Wykonawca = textBox10.Text;
                    int temp;
                    if (Int32.TryParse(textBox9.Text, out temp))
                    {
                        perfom.RokPowstania = temp;

                    }
                    context.Wykonawcy.Add(perfom);
                    context.SaveChanges();
                    textBox16.Visible = true;
                }
            }
            else
            {
                errorProvider1.SetError(textBox10, "Uzupełnij pole wykonawca.");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
