using BLL;
using DAL.Classes;
using Modelo.Quartos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Formulario
{
    public partial class CadastroQuarto : Form
    {
        private Quarto quarto;
        private BLLQuarto bLLQuarto;
        private DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
        public CadastroQuarto()
        {
            InitializeComponent();
        }

        private void btCadastrarCadastroQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                quarto = new Quarto(Convert.ToInt32(tbNumeroQuarto.Text), Convert.ToInt32(tbQuantidadeCamaCasal.Text),
                    Convert.ToInt32(tbQuantidadeCamaSolteiro.Text), Convert.ToInt32(tbAndar.Text),
                    Convert.ToInt32(tbNumeroPessoa.Text), "s");

                Cadastrar();

                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro de quarto");

                ReinicializarFormulario();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void ReinicializarFormulario()
        {
            tbAndar.Clear();
            tbNumeroPessoa.Clear();
            tbNumeroQuarto.Clear();
            tbQuantidadeCamaCasal.Clear();
            tbQuantidadeCamaSolteiro.Clear();
        }

        private void Cadastrar()
        {
            bLLQuarto = new BLLQuarto(cx);
            bLLQuarto.InserirQuarto(quarto);
        }

        private void btCancelarCadastroQuarto_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que quer cancelar?", "CANCELAR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ReinicializarFormulario();
            }
        }
    }
}
