using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BdKitSala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Comunicação com o banco de dados
            SqlConnection conexao = new SqlConnection(Conexao.Conectar());
            SqlCommand comando = new SqlCommand("pCadastrarFuncionario", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nome", textBox1.Text);
                comando.Parameters.AddWithValue("@email", textBox2.Text);
                comando.Parameters.AddWithValue("@chapa", textBox3.Text);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                

                var resposta = MessageBox.Show("Funcionário Cadastrado com Sucesso! Deseja Cadastrar outro Funcionário ou Sair?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Funcionário não Cadastrado!", "Atenção");
            }
            finally
            {
                if(conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }
    }
}
