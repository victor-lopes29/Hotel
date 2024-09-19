using Modelo.Quartos;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Hotel.Formulario
{
    public partial class ExcluirAtualizarQuarto : Form
    {
        private Quarto quarto;
        public ExcluirAtualizarQuarto()
        {
            InitializeComponent();
        }

        private void btAtualizarCadastroQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                quarto = new Quarto(Convert.ToInt32(tbAndar.Text), Convert.ToInt32(tbNumeroPessoa.Text), Convert.ToInt32(tbQuantidadeCamaCasal.Text),
                    Convert.ToInt32(tbQuantidadeCamaSolteiro.Text), "s");

                Atualizar();

                MessageBox.Show("Atualização realizada com sucesso!");

                ReiniciarFormulario();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }            
        }
        private void ReiniciarFormulario()
        {
            tbAndar.Clear();
            tbNumeroPessoa.Clear();
            tbQuantidadeCamaCasal.Clear();
            tbQuantidadeCamaSolteiro.Clear();
        }
    }
}
