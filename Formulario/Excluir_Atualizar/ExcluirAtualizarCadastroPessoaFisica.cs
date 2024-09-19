using Modelo.Hospede;
using Modelo.Pessoas;
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
    public partial class ExcluirAtualizarCadastroPessoaFisica : Form
    {
        private Contato contato;
        private Endereco endereco;
        private Pessoa pessoa;
        private PessoaFisica pessoaFisica;
        private Cliente cliente;

        public ExcluirAtualizarCadastroPessoaFisica()
        {
            InitializeComponent();
        }

        private void btAtualizarPessoaFisicaExcluirAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                contato = new Contato(mskdCelular.Text, mskdTelefone.Text, tbEmail.Text);
                endereco = new Endereco(Convert.ToInt32(tbCEP.Text), tbRua.Text, tbLogradouro.Text, Convert.ToInt32(tbNumero.Text),
                    tbComplemento.Text, tbBairro.Text, tbCidade.Text, cbxUF.Text);
                pessoa = new Pessoa(contato, endereco);
                pessoaFisica = new PessoaFisica(pessoa, tbNome.Text + "" + tbSobrenome.Text, cbxGenero.Text);
                cliente = new Cliente(pessoa);

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
            tbBairro.Clear();
            tbCEP.Clear();
            tbCidade.Clear();
            tbComplemento.Clear();
            tbEmail.Clear();
            tbLogradouro.Clear();
            tbNome.Clear();
            tbNumero.Clear();
            tbRua.Clear();
            mskdCelular.Clear();
            mskdTelefone.Clear();
            cbxGenero.Text = "";
            cbxUF.Text = "";           
        }
    }
}
