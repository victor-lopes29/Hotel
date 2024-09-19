using BLL;
using DAL.Classes;
using Modelo.Funcionarios;
using Modelo.Hospede;
using Modelo.Pessoas;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel.Formulario
{
    public partial class CadastroFuncionarioCLT : Form
    {
        private Pessoa pessoa;
        private PessoaFisica pessoaFisica;
        private Funcionario funcionario;
        private FuncionarioCLT funcionarioCLT;
        private Contato contato;
        private Endereco endereco;
        private DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
        private BLLPessoa bLLPessoa;
        private BLLFuncionario bLLFuncionario;
        public CadastroFuncionarioCLT()
        {
            InitializeComponent();
        }

        private void btCancelarFuncionarioCLT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que quer cancelar?", "CANCELAR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ReinicializarFormulario();
            }
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

        private void btCadastrarFuncionarioCLT_Click(object sender, EventArgs e)
        {
            try
            {
                contato = new Contato(mkdTelefone.Text, mkdCelular.Text, tbEmail.Text);
                endereco = new Endereco(Convert.ToInt32(tbCEP.Text), tbLogradouro.Text, Convert.ToInt32(tbNumero.Text),
                    tbComplemento.Text, tbBairro.Text, tbCidade.Text, cbxUF.Text);
                pessoa = new Pessoa(contato, endereco);
                pessoaFisica = new PessoaFisica(pessoa, tbNome.Text + " " + tbSobrenome.Text, tbCPF.Text, tbRG.Text,
                    Convert.ToDateTime(dtNascimento.Value.Date), cbxGenero.Text);
                funcionario = new Funcionario(tbCargo.Text, tbUsuario.Text, tbSenha.Text);
                funcionarioCLT = new FuncionarioCLT(pessoaFisica, funcionario);

                Cadastrar();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Cadastrar()
        {
            bLLFuncionario = new BLLFuncionario(cx);
            bLLPessoa = new BLLPessoa(cx);
            bLLPessoa.InserirContato(pessoa);
            bLLPessoa.InserirEndereco(pessoa);
            bLLPessoa.InserirPessoa(pessoa, contato, endereco);
            bLLPessoa.InserirPessoaFisica(pessoa, pessoaFisica);
            bLLFuncionario.InserirFuncionario(funcionario);
            bLLFuncionario.InserirFuncionarioCLT(funcionario, pessoaFisica, funcionarioCLT);
        }

        private void tbConfirmaSenha_Leave(object sender, EventArgs e)
        {
            if(tbConfirmaSenha.Text != tbSenha.Text)
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
            tbCPF.Clear();
            tbEmail.Clear();
            tbLogradouro.Clear();
            tbNome.Clear();
            tbNumero.Clear();
            tbRG.Clear();
            tbSobrenome.Clear();
            tbCargo.Clear();
            tbConfirmaSenha.Clear();
            tbSenha.Clear();
            tbUsuario.Clear();
            mkdCelular.Clear();
            mkdTelefone.Clear();
            cbxGenero.Text = "";
            cbxUF.Text = "";
            dtNascimento.Value = DateTime.Now;
        }
    }
}
