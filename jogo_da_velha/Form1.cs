using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        int jogadas = 0;
        public Form1()
        {
            InitializeComponent();

        }
        private void ganhador()
        {
            if (label1.Text == label2.Text && label2.Text == label3.Text)
            {
                MessageBox.Show("Jogador: " + label1.Text + " Ganhou o Jogo!!","Vencedor!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label1.Text = "X";
                jogadas=1;
                
            }
            else
            {
                label1.Text = "O";
                jogadas=0;
            }
            label1.Enabled = false;
            ganhador();
        } 


        private void label2_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label2.Text = "X";
                jogadas = 1;

            }
            else
            {
                label2.Text = "O";
                jogadas = 0;
            }
            label2.Enabled = false;
            ganhador();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label3.Text = "X";
                jogadas = 1;

            }
            else
            {
                label3.Text = "O";
                jogadas = 0;
            }
            label3.Enabled = false;
            ganhador();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label7.Text = "X";
                jogadas = 1;

            }
            else
            {
                label7.Text = "O";
                jogadas = 0;
            }
            label7.Enabled = false;
            ganhador();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label8.Text = "X";
                jogadas = 1;

            }
            else
            {
                label8.Text = "O";
                jogadas = 0;
            }
            label8.Enabled = false;
            ganhador();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label9.Text = "X";
                jogadas = 1;

            }
            else
            {
                label9.Text = "O";
                jogadas = 0;
            }
            label9.Enabled = false;
            ganhador();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label4.Text = "X";
                jogadas = 1;

            }
            else
            {
                label4.Text = "O";
                jogadas = 0;
            }
            label4.Enabled = false;
            ganhador();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label5.Text = "X";
                jogadas = 1;

            }
            else
            {
                label5.Text = "O";
                jogadas = 0;
            }
            label5.Enabled = false;
            ganhador();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (jogadas == 0)
            {
                label6.Text = "X";
                jogadas = 1;

            }
            else
            {
                label6.Text = "O";
                jogadas = 0;
            }
            label6.Enabled = false;
            ganhador();
        }
    }
}
