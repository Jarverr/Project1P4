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
    public partial class EditingDate : Form
    {
        public EditingDate()
        {
            InitializeComponent();
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
            if (EditMeTextBox.Text != "")
            {
                using (var context = new TPCContextDBHitsList())
                {
                    var rgx = new Regex(@"^[0-9]{2}:[0-6][0-9]$");
                    var rgx2 = new Regex(@"^[0-9]:[0-6][0-9]$");
                    var rgx3 = new Regex(@"^[0-9]:$");
                    var rgx4 = new Regex(@"^[0-9]{2}:$");
                    var rgx5 = new Regex(@"^[0-9]{2}:[0-6]$");
                    var rgx6 = new Regex(@"^\s[0-9]:[0-6]$");
                    var rgx7 = new Regex(@"^[0-9]\s:$");
                    bool toStop = true;
                    int number;
                    int number2;
                    Int32.TryParse(EditMeTextBox.Text, out number);

                    if (NameTrack.Text != "")
                    {
                        foreach (var item in context.Oceny)
                        {
                            if (item.IdOceny == number)
                            {
                                Int32.TryParse(GradeAdm.Text, out number2);
                                if (number2 != 0)
                                {
                                    item.OcenaAdministratora = number2;
                                }
                                Int32.TryParse(GradeAdm2.Text, out number2);
                                if (number2 != 0)
                                {
                                    item.OcenaAdministratorki = number2;
                                }
                                toStop = true;
                                break;
                            }
                            else
                            {
                                toStop = false;
                            }

                        }
                        if (toStop)
                        {
                            foreach (var item in context.Utwory)
                            {
                                if (item.IdUtworu == number)
                                {
                                    if (NameTrack.Text != "")
                                    {
                                        item.NazwaUtworu = NameTrack.Text;
                                    }
                                    Int32.TryParse(CreationYear.Text, out number2);
                                    if (number2 != 0)
                                    {
                                        item.RokWykonania = number2;
                                    }
                                    if (DescTrack.Text != "")
                                        item.OpisUtworu = DescTrack.Text;
                                    if (DuratTrack.Text != "")
                                    {

                                        if (rgx.IsMatch(DuratTrack.Text))
                                        {
                                            item.Długość = DuratTrack.Text;

                                        }
                                        else if (rgx2.IsMatch(DuratTrack.Text))
                                        {
                                            item.Długość = $"0{DuratTrack.Text}";
                                        }
                                        else if (rgx3.IsMatch(DuratTrack.Text))
                                        {
                                            item.Długość = $"0{DuratTrack.Text}00";
                                        }
                                        else if (rgx4.IsMatch(DuratTrack.Text))
                                        {
                                            item.Długość = $"{DuratTrack.Text}00";
                                        }
                                        else if (rgx5.IsMatch(DuratTrack.Text))
                                        {
                                            item.Długość = $"{DuratTrack.Text}0";
                                        }
                                        else if (rgx6.IsMatch(DuratTrack.Text))
                                        {
                                            item.Długość = $"{DuratTrack.Text.Replace(' ', '0')}0";
                                        }
                                        else if (rgx7.IsMatch(DuratTrack.Text))
                                        {
                                            item.Długość = $"{DuratTrack.Text.Replace(' ', '0')}00";
                                        }
                                        else
                                            item.Długość = DuratTrack.Text;
                                    }
                                    Int32.TryParse(textBox5.Text, out number2);
                                    foreach (var item2 in context.Albumy)
                                    {
                                        if (item2.IdAlbumu == number2)
                                        {
                                            item.AlbumId = number2;
                                            item.Album = item2;
                                            break;
                                        }
                                        else
                                        {
                                            item.AlbumId = 1;
                                            item.Album = context.Albumy.Find(1);
                                        }
                                    }
                                    if (Int32.TryParse(textBox19.Text, out number2))
                                    {
                                        foreach (var item2 in context.Gatunki)
                                        {
                                            if (item2.IdGatunku == number2)
                                            {
                                                item.Gatunki.Clear();
                                                item.Gatunki.Add(item2);
                                                break;
                                            }

                                        }
                                    }
                                    else
                                    {
                                        item.Gatunki.Clear();
                                        item.Gatunki.Add(context.Gatunki.Find(1));
                                    }
                                    if (Int32.TryParse(textBox6.Text, out number2))
                                    {
                                        foreach (var item2 in context.Gatunki)
                                        {
                                            if (item2.IdGatunku == number2)
                                            {
                                                item.Gatunki.Add(item2);
                                            }

                                        }
                                    }
                                    if (Int32.TryParse(textBox16.Text, out number2))
                                    {
                                        foreach (var item2 in context.Gatunki)
                                        {
                                            if (item2.IdGatunku == number2)
                                            {
                                                item.Gatunki.Add(item2);
                                            }

                                        }
                                    }
                                    if (Int32.TryParse(textBox17.Text, out number2))
                                    {
                                        foreach (var item2 in context.Gatunki)
                                        {
                                            if (item2.IdGatunku == number2)
                                            {
                                                item.Gatunki.Add(item2);
                                            }
                                        }
                                    }
                                    if (Int32.TryParse(textBox18.Text, out number2))
                                    {
                                        foreach (var item2 in context.Gatunki)
                                        {
                                            if (item2.IdGatunku == number2)
                                            {
                                                item.Gatunki.Add(item2);
                                            }
                                        }
                                    }



                                    if (Int32.TryParse(textBox12.Text, out number2))
                                    {
                                        foreach (var item2 in context.Nagrody)
                                        {
                                            if (item2.IdNagrody == number2)
                                            {
                                                item.Nagrody.Clear();
                                                item.Nagrody.Add(item2);
                                                break;
                                            }

                                        }
                                    }
                                    else
                                    {
                                        item.Nagrody.Clear();
                                        item.Nagrody.Add(context.Nagrody.Find(1));
                                    }
                                    if (Int32.TryParse(textBox7.Text, out number2))
                                    {
                                        foreach (var item2 in context.Nagrody)
                                        {
                                            if (item2.IdNagrody == number2)
                                            {
                                                item.Nagrody.Clear();
                                                item.Nagrody.Add(item2);
                                            }
                                        }
                                    }
                                    if (Int32.TryParse(textBox8.Text, out number2))
                                    {
                                        foreach (var item2 in context.Nagrody)
                                        {
                                            if (item2.IdNagrody == number2)
                                            {
                                                item.Nagrody.Add(item2);
                                            }
                                        }
                                    }
                                    if (Int32.TryParse(textBox9.Text, out number2))
                                    {
                                        foreach (var item2 in context.Nagrody)
                                        {
                                            if (item2.IdNagrody == number2)
                                            {
                                                item.Nagrody.Add(item2);
                                            }
                                        }
                                    }
                                    if (Int32.TryParse(textBox11.Text, out number2))
                                    {
                                        foreach (var item2 in context.Nagrody)
                                        {
                                            if (item2.IdNagrody == number2)
                                            {
                                                item.Nagrody.Add(item2);
                                            }
                                        }
                                    }


                                    Int32.TryParse(PerfId.Text, out number2);
                                    foreach (var item2 in context.Wykonawcy)
                                    {
                                        if (item2.IdWykonawcy == number2)
                                        {
                                            item.WykonawcaId = number2;
                                            item.Wykonawca = item2;
                                            break;
                                        }
                                        else
                                        {
                                            item.WykonawcaId = 1;
                                            item.Wykonawca = context.Wykonawcy.Find(1);
                                        }
                                    }
                                }
                            }
                            context.SaveChanges();
                            label14.Text = "Success";
                            label14.ForeColor = Color.Green;
                            label14.Visible = true;
                        }
                        else
                        {
                            label14.Text = "Nie znaleziono utworu o takim ID";
                            label14.ForeColor = Color.Red;
                            label14.Visible = true;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(NameTrack, "Wpisz nową nazwę utworu!");
                    }

                }
            }
            else
            {
                errorProvider1.SetError(EditMeTextBox, "Podaj ID utworu do edycji");
            }
        }

        private void textBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
