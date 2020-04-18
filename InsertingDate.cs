using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!(textBox1.Text == "" || textBox8.Text == ""))
            {
                using (var context = new TPCContextDBHitsList())
                {
                    var track = new Tracks();
                    var grade = new Grades();
                    var rgx = new Regex(@"^[0-9]{2}:[0-6][0-9]$");
                    var rgx2 = new Regex(@"^[0-9]:[0-6][0-9]$");
                    var rgx3 = new Regex(@"^[0-9]:$");
                    var rgx4 = new Regex(@"^[0-9]{2}:$");
                    var rgx5 = new Regex(@"^[0-9]{2}:[0-6]$");
                    var rgx6 = new Regex(@"^\s[0-9]:[0-6]$");
                    var rgx7 = new Regex(@"^[0-9]\s:$");

                    track.NazwaUtworu = textBox1.Text;
                    if (textBox1.Text == "")
                    {
                        button1.Validating += new System.ComponentModel.CancelEventHandler(textBox1_Validating);
                        //ale to chyba nie działa 
                    }
                    int temp;
                    if (Int32.TryParse(textBox2.Text, out temp))
                    {
                        track.RokWykonania = temp;
                    }
                    else
                    {
                        toolTip1.ToolTipTitle = "Nie podałeś roku";
                        toolTip1.Show("Jako, że nie wpisałeś roku, zostanie on ustawiony automatycznie na 0", textBox2, 0, -20, 5000);
                    }
                    track.OpisUtworu = textBox3.Text;
                    if (rgx.IsMatch(textBox4.Text))
                    {
                        track.Długość = textBox4.Text;

                    }
                    else if (rgx2.IsMatch(textBox4.Text))
                    {
                        track.Długość = $"0{textBox4.Text}";
                    }
                    else if (rgx3.IsMatch(textBox4.Text))
                    {
                        track.Długość = $"0{textBox4.Text}00";
                    }
                    else if (rgx4.IsMatch(textBox4.Text))
                    {
                        track.Długość = $"{textBox4.Text}00";
                    }
                    else if (rgx5.IsMatch(textBox4.Text))
                    {
                        track.Długość = $"{textBox4.Text}0";
                    }
                    else if (rgx6.IsMatch(textBox4.Text))
                    {
                        track.Długość = $"{textBox4.Text.Replace(' ','0')}0";
                    }
                    else if (rgx7.IsMatch(textBox4.Text))
                    {
                        track.Długość = $"{textBox4.Text.Replace(' ','0')}00";
                    }
                    else
                        track.Długość = textBox4.Text;
                    if (Int32.TryParse(textBox5.Text, out temp)&&temp!=0)
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
                    else if(temp==0)
                    {
                        track.Album = context.Albumy.Find(1);
                    }

                    if (Int32.TryParse(textBox6.Text, out temp)&&temp != 0)
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
                    else
                    {
                        track.Gatunki.Add(context.Gatunki.Find(1));
                    }



                    if (Int32.TryParse(textBox7.Text, out temp) && temp != 0)
                    {
                        foreach (var item in context.Nagrody)
                        {
                            if (temp == item.IdNagrody)
                                track.Nagrody.Add(item);
                        }
                    }
                    else if (temp == 0)
                    {
                        track.Nagrody.Add(context.Nagrody.Find(1));
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
                    {

                    }
                    if (Int32.TryParse(textBox9.Text, out temp))
                    {
                        grade.OcenaAdministratorki = temp;
                    }

                    if (Int32.TryParse(textBox11.Text, out temp) && temp != 0)
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
                    else
                    {
                        track.Wykonawca = context.Wykonawcy.Find(1);
                    }

                    context.Utwory.Add(track);  
                    context.Oceny.Add(grade);
                    context.SaveChanges();

                    textBox10.Visible = true;
                }
            }
            else if (textBox1.Text == "")
            {
                toolTip1.ToolTipTitle = "Uzupełnij dane";
                //toolTip2.ToolTipTitle = "Uzupełnij dane";
                toolTip1.Show("Aby dodać do bazy danych utwór należy uzupełnić te pole.", textBox1, 0, -20, 5000);
                //toolTip2.Show("Aby dodać do bazy danych utwór należy uzupełnić te pole.", textBox8,0,-20,5000);
                //toolTip1.Show("", textBox1);
                errorProvider1.SetError(textBox1, "Uzupełnij");
            }
            else
            {
                toolTip1.ToolTipTitle = "Uzupełnij dane";
                toolTip1.Show("Aby dodać do bazy danych utwór należy uzupełnić te pole.", textBox8, 0, -20, 5000);
                errorProvider1.SetError(textBox8, "Uzupełnij");

            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (textBox4.MaskFull || e.Position == textBox4.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Nieprawidłowa operacja";
                toolTip1.Show("Pole uzupełniające jest pełne", textBox4, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Nieprawidłowa operacja";
                toolTip1.Show("Dane które wprowadzasz nie są liczbami", textBox4, 0, -20, 5000);

            }
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }
        private void textBox8_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
