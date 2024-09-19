using Modelo.Funcionarios;
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
    public partial class ExcluirAtualizarCadastroFuncionarioPJ : Form
    {
        private Contato contato;
        private Endereco endereco;
        private Pessoa pessoa;
        private PessoaJuridica pessoaJuridica;
        private Funcionario funcionario;
        private FuncionarioPJ funcionarioPJ;

        public ExcluirAtualizarCadastroFuncionarioPJ()
        {
            InitializeComponent();
        }

        private void ExcluirAtualizarCadastroFuncionarioPJ_Load(object sender, EventArgs e)
        {

        }

        private void btAtualizarFuncionarioPJExcluirAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                contato = new Contato(mskdCelular.Text, mskdTelefone.Text, tbEmail.Text);
                endereco = new Endereco(Convert.ToInt32(tbCEP.Text), tbRua.Text, tbLogradouro.Text, Convert.ToInt32(tbNumero.Text),
                    tbComplemento.Text, tbBairro.Text, tbCidade, cbxUF.Text);
                pessoa = new Pessoa(contato, endereco);
                pessoaJuridica = new PessoaJuridica(pessoa, tbNome.Text + "" + tbSobrenome.Text);
                funcionario = new Funcionario(tbRazaoSocial.Text, tbCargo.Text, tbUsuario.Text, tbSenha, tbConfirmaSenha);
                funcionarioPJ = new FuncionarioPJ(pessoaJuridica, funcionario);

                Atualizar();

                MessageBox.Show("Atualização realizada com sucesso!");

                ReinicializarFormulario();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void ReiniciarFormulario()
        {
            tbBairro.Clear();
            tbCargo.Clear();
            tbCEP.Clear();
            tbCidade.Clear();
            tbComplemento.Clear();
            tbConfirmaSenha.Clear();
            tbEmail.Clear();
            tbLogradouro.Clear();
            tbNome.Clear();
            tbNumero.Clear();
            tbRazaoSocial.Clear();
            tbRua.Clear();
            tbSenha.Clear();
            tbSobrenome.Clear();
            tbUsuario.Clear();
            mskdCelular.Clear();
            mskdTelefone.Clear();
            cbxUF.Text = "";
        }
    }
}
