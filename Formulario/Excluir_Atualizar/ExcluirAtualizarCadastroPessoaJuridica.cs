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
    public partial class ExcluirAtualizarCadastroPessoaJuridica : Form
    {
        private Contato contato;
        private Endereco endereco;
        private Pessoa pessoa;
        private PessoaJuridica pessoaJuridica;
        private Cliente cliente;

        public ExcluirAtualizarCadastroPessoaJuridica()
        {
            InitializeComponent();
        }

        private void btAtualizarPessoaJuridica_Click(object sender, EventArgs e)
        {
            try
            {
                contato = new Contato(mskdCelular.Text, mskdTelefone.Text, tbEmail.Text);
                endereco = new Endereco(Convert.ToInt32(tbCEP.Text), tbRua.Text, tbLogradouro.Text, Convert.ToInt32(tbNumero.Text),
                    tbComplemento.Text, tbBairro.Text, tbCidade.Text, cbxUF.Text);
                pessoa = new Pessoa(contato, endereco);
                pessoaJuridica = new PessoaJuridica(pessoa, tbRazaoSocial.Text);
                cliente = new Cliente(pessoa);

                Atualizar();

                MessageBox.Show("Atualização realizada com sucesso!");

                ReinicializarFormulario();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void ReinicializarFormulario()
        {
            tbBairro.Clear();
            tbCEP.Clear();
            tbCidade.Clear();
            tbComplemento.Clear();
            tbEmail.Clear();
            tbLogradouro.Clear();
            tbNumero.Clear();
            tbRazaoSocial.Clear();
            tbRua.Clear();
            mskdCelular.Clear();
            mskdTelefone.Clear();
            cbxUF.Text = "";            
        }
    }
}
