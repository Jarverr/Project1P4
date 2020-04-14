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
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var checkingDate = new CheckingDate();
            checkingDate.Closed += (s, args) => this.Close();
            checkingDate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var insertingDate = new InsertingDate2();
            insertingDate.Closed += (s, args) => this.Close();
            insertingDate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var editingDate = new EditingDate();
            editingDate.Closed += (s, args) => this.Close();
            editingDate.Show();
        }
    }
}
