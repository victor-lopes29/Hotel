using BLL;
using DAL.Classes;
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
    public partial class CadastroFuncionarioPJ : Form
    {
        private Pessoa pessoa;
        private PessoaJuridica pessoaJuridica;
        private Funcionario funcionario;
        private FuncionarioPJ funcionarioPJ;
        private Contato contato;
        private Endereco endereco;
        private DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
        private BLLPessoa bLLPessoa;
        private BLLFuncionario bLLFuncionario;
        public CadastroFuncionarioPJ()
        {
            InitializeComponent();
        }

        private void tbCEP_Leave(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", tbCEP.Text);

            ds.ReadXml(xml);

            tbLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
            tbBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
            tbCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
            cbxUF.Text = ds.Tables[0].Rows[0]["uf"].ToString();
        }

        private void tbConfirmaSenha_Leave(object sender, EventArgs e)
        {
            if (tbConfirmaSenha.Text != tbSenha.Text)
            {
                MessageBox.Show("AS SENHAS NÃO SÃO IGUAIS", "SENHA INCORRETA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSenha.BackColor = Color.Red;
                tbConfirmaSenha.BackColor = Color.Red;
            }

            else
            {
                tbSenha.BackColor = Color.White;
                tbConfirmaSenha.BackColor = Color.White;
            }
        }

        private void ReinicializarFormulario()
        {
            tbBairro.Clear();
            tbCEP.Clear();
            tbCidade.Clear();
            tbComplemento.Clear();
            tbCNPJ.Clear();
            tbRazaoSocial.Clear();
            tbLogradouro.Clear();
            tbNome.Clear();
            tbNumero.Clear();
            tbInscricaoEstadual.Clear();
            tbSobrenome.Clear();
            tbCargo.Clear();
            tbConfirmaSenha.Clear();
            tbSenha.Clear();
            tbUsuario.Clear();
            tbConfirmaSenha.Clear();
            cbxUF.Text = "";
        }

        private void Cadastrar()
        {
            bLLFuncionario = new BLLFuncionario(cx);
            bLLPessoa = new BLLPessoa(cx);
            bLLPessoa.InserirContato(pessoa);
            bLLPessoa.InserirEndereco(pessoa);
            bLLPessoa.InserirPessoa(pessoa, contato, endereco);
            bLLPessoa.InserirPessoaJuridica(pessoa, pessoaJuridica);
            bLLFuncionario.InserirFuncionario(funcionario);
            bLLFuncionario.InserirFuncionarioPJ(funcionario, pessoaJuridica, funcionarioPJ);
        }

        private void btCadastrarFuncionarioPJ_Click(object sender, EventArgs e)
        {
            try
            {
                contato = new Contato(mkdTelefone.Text, mkdCelular.Text, tbEmail.Text);
                endereco = new Endereco(Convert.ToInt32(tbCEP.Text), tbLogradouro.Text, Convert.ToInt32(tbNumero.Text),
                    tbComplemento.Text, tbBairro.Text, tbCidade.Text, cbxUF.Text);
                pessoa = new Pessoa(contato, endereco);
                pessoaJuridica = new PessoaJuridica(pessoa, tbCNPJ.Text, tbRazaoSocial.Text, tbInscricaoEstadual.Text);
                funcionario = new Funcionario(tbCargo.Text, tbUsuario.Text, tbSenha.Text);
                funcionarioPJ = new FuncionarioPJ(pessoaJuridica, funcionario, tbNome.Text);

                Cadastrar();

                MessageBox.Show("Cadastro realizado com sucesso!");

                ReinicializarFormulario();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btCancelarFuncionarioPJ_Click(object sender, EventArgs e)
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
