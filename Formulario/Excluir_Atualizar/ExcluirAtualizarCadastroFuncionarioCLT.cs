using Modelo.Funcionarios;
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
    public partial class ExcluirAtualizarCadastroFuncionarioCLT : Form
    {
        private Pessoa pessoa;
        private Endereco endereco;
        private Funcionario funcionario;
        private FuncionarioCLT funcionarioCLT;
        private PessoaFisica pessoaFisica;
        private Contato contato;

        public ExcluirAtualizarCadastroFuncionarioCLT()
        {
            InitializeComponent();
        }

        private void btAtualizarFuncionarioCLTExcluirAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                contato = new Contato(mskdCelular.Text, mskdTelefone.Text, tbEmail.Text);
                endereco = new Endereco(Convert.ToInt32(tbCEP.Text),tbRua.Text, tbLogradouro.Text, Convert.ToInt32(tbNumero.Text),
                    tbComplemento.Text, tbBairro.Text, tbCidade.Text, cbxUF.Text);
                pessoa = new Pessoa(contato, endereco);
                pessoaFisica = new PessoaFisica(pessoa, tbNome.Text + "" + tbSobrenome.Text, cbxGenero.Text);                    
                funcionario = new Funcionario(tbCargo.Text, tbUsuario.Text, tbSenha.Text, tbConfirmaSenha.Text);
                funcionarioCLT = new FuncionarioCLT(pessoaFisica, funcionario);

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
            tbCargo.Clear();
            tbCEP.Clear();
            tbCidade.Clear();
            tbComplemento.Clear();
            tbConfirmaSenha.Clear();
            tbEmail.Clear();
            tbLogradouro.Clear();
            tbNome.Clear();
            tbNumero.Clear();
            tbRua.Clear();
            tbSenha.Clear();
            tbSobrenome.Clear();
            tbUsuario.Clear();
            mskdCelular.Clear();
            mskdTelefone.Clear();
            cbxGenero.Text = "";
            cbxUF.Text = "";
        }
    }
}
