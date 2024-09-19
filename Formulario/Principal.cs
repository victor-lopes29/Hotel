using Hotel.Formulario;
using Hotel.Formulario.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void excluirAtualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroPessoaFisica().ShowDialog();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroPessoaJuridica().ShowDialog();
        }

        private void funcionárioCLTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroFuncionarioCLT().ShowDialog();
        }

        private void funcionárioPJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroFuncionarioPJ().ShowDialog();
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new CadastroQuarto().ShowDialog();
        }

        private void visualizarCadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new VisualizarQuartos().ShowDialog();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CheckIn().ShowDialog();
        }

        private void visualisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConferirReservaCheckIn().ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CheckOut().ShowDialog();
        }

        private void visualisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConferirReservaCheckOut().ShowDialog();
        }

        private void pessoaFísicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ExcluirAtualizarCadastroPessoaFisica().ShowDialog();
        }

        private void funcionárioCLTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ExcluirAtualizarCadastroFuncionarioCLT().ShowDialog();
        }

        private void funcionárioPJToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ExcluirAtualizarCadastroFuncionarioPJ().ShowDialog();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void visualizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VisualisarCadastroHospede().ShowDialog();
        }

        private void visualizarCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new VisualizarCadastroFuncionario().ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExcluirAtualizarQuarto().ShowDialog();
        }

        private void pessoaJurídicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ExcluirAtualizarCadastroPessoaJuridica().ShowDialog();
        }

        private void reservaPessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReservaQuarto().ShowDialog();
        }

        private void reservaPessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReservaQuartoPJ().ShowDialog();
        }
    }
}
