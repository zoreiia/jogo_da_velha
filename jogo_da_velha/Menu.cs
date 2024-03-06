using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jogo_da_velha
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telavelhagame = new velha();
            telavelhagame.Closed += (s, args) => this.Close();
            telavelhagame.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telamemorygame = new memoria();
            telamemorygame.Closed += (s, args) => this.Close();
            telamemorygame.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telaforcag = new forca();
            telaforcag.Closed += (s, args) => this.Close();
            telaforcag.Show();
        }
    }
}
