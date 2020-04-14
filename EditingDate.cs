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
            using (var context = new TPCContextDBHitsList())
            {
                int number;
                int number2;
                Int32.TryParse(EditMeTextBox.Text, out number);
                foreach (var item in context.Oceny)
                {
                    if (item.IdOceny == number)
                    {
                        Int32.TryParse(GradeAdm.Text, out number2);
                        item.OcenaAdministratora = number2;
                        Int32.TryParse(GradeAdm2.Text, out number2);
                        item.OcenaAdministratorki = number2;
                    }
                }
                foreach (var item in context.Utwory)
                {
                    if (item.IdUtworu == number)
                    {
                        item.NazwaUtworu = NameTrack.Text;
                        Int32.TryParse(CreationYear.Text, out number2);
                        item.RokWykonania = number2;
                        item.OpisUtworu = DescTrack.Text;
                        item.Długość = DuratTrack.Text;
                        Int32.TryParse(textBox5.Text, out number2);
                        foreach (var item2 in context.Albumy)
                        {
                            if (item2.IdAlbumu == number2)
                            {
                                item.AlbumId = number2;
                                item.Album = item2;

                            }
                        }
                        if (Int32.TryParse(textBox6.Text, out number2))
                        {
                            foreach (var item2 in context.Gatunki)
                            {
                                if (item2.IdGatunku == number2)
                                {
                                    item.Gatunki.Clear();
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
                                    item.Gatunki.Clear();
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
                                    item.Gatunki.Clear();
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
                                    item.Gatunki.Clear();
                                    item.Gatunki.Add(item2);
                                }
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
                                }
                            }
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
                                    item.Nagrody.Clear();
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
                                    item.Nagrody.Clear();
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
                                    item.Nagrody.Clear();
                                    item.Nagrody.Add(item2);
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
                            }
                        }
                    }
                }
                context.SaveChanges();
                label14.Visible = true;
            }
        }
    }
}
