using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdKitSala
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 funcionario = new Form1();
            funcionario.Show();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaFuncionarioPesquisaCodigo pesquisafuncionario = new TelaFuncionarioPesquisaCodigo();
            pesquisafuncionario.Show();
        }

        private void kitSalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaControle controle = new TelaControle();
            controle.Show();

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaKitSala telaKit = new TelaKitSala();
            telaKit.Show();
        }

      

        private void pesquisaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaKitSalaPesquisaCodigo pesquisaKitSala = new TelaKitSalaPesquisaCodigo();
            pesquisaKitSala.Show();
        }
    }
}
