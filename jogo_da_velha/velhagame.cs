using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jogo_da_velha
{
    public partial class velha : Form
    {
        string jogadas = "X";
        string p1 = "X";
        string p2 = "O";


        public velha()
        {
            InitializeComponent();

        }


        private void atualiza_lista()
        {
            try
            {

                conexao.Open();

                comando.CommandText = "SELECT * FROM tbl_pets;";
                MySqlDataAdapter adaptadorpets = new MySqlDataAdapter(comando);
                DataTable tabelarank = new DataTable();
                adaptadorpets.Fill(tabelarank);
                dataGridView1.DataSource = tabelarank;



            }
            catch (Exception erro_mysql)
            {

                //MessageBox.Show(erro_mysql.Message);
                MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {

                conexao.Close();
            }

        }


        private void ganhador()
        {
            if (label1.Text == "X" && label2.Text == "X" && label3.Text == "X" ||
                label1.Text == "O" && label2.Text == "O" && label3.Text == "O" ||
                label7.Text == "X" && label8.Text == "X" && label9.Text == "X" ||
                label7.Text == "O" && label8.Text == "O" && label9.Text == "O" ||
                label4.Text == "X" && label5.Text == "X" && label6.Text == "X" ||
                label4.Text == "O" && label5.Text == "O" && label6.Text == "O")
            {
                MessageBox.Show("Jogador: " + jogadas + " Ganhou o Jogo!!","Vencedor!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                atualiza_lista();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label1.Text = "X";
                ganhador();
                jogadas = "O";
                
            }
            else
            {
                label1.Text = "O";
                ganhador();
                jogadas ="X";
            }
            label1.Enabled = false;
        } 


        private void label2_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label2.Text = "X";
                ganhador();
                jogadas = "O";

            }
            else
            {
                label2.Text = "O";
                ganhador();
                jogadas = "X";
            }
            label2.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label3.Text = "X";
                ganhador();
                jogadas = "O";

            }
            else
            {
                label3.Text = "O";
                ganhador();
                jogadas = "X";
            }
            label3.Enabled = false;
  
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label7.Text = "X";
                ganhador();
                jogadas = "O";

            }
            else
            {
                label7.Text = "O";
                ganhador();
                jogadas = "X";
            }
            label7.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label8.Text = "X";
                ganhador();
                jogadas = "O";

            }
            else
            {
                label8.Text = "O";
                ganhador();
                jogadas = "X";
            }
            label8.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label9.Text = "X";
                ganhador();
                jogadas = "O";

            }
            else
            {
                label9.Text = "O";
                ganhador();
                jogadas = "X";
            }
            label9.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label4.Text = "X";
                ganhador();
                jogadas = "O";

            }
            else
            {
                label4.Text = "O";
                ganhador();
                jogadas = "X";
            }
            label4.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label5.Text = "X";
                ganhador();
                jogadas = "O";

            }
            else
            {
                label5.Text = "O";
                ganhador();
                jogadas = "X";
            }
            label5.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (jogadas == "X")
            {
                label6.Text = "X";
                ganhador();
                jogadas = "O";

            }
            else
            {
                label6.Text = "O";
                ganhador();
                jogadas = "X";
            }
            label6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telamenu = new Menu();
            telamenu.Closed += (s, args) => this.Close();
            telamenu.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
