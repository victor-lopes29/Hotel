using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Pessoas;
using Modelo.Hospede;
using System.Drawing.Printing;
using DAL.Classes;
using BLL;

namespace Hotel.Formulario
{
    public partial class CadastroPessoaFisica : Form
    {
        private Pessoa pessoa;
        private PessoaFisica pessoaFisica;
        private Cliente cliente;
        private Contato contato;
        private Endereco endereco;
        private DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
        private BLLCliente bLLCliente;
        private BLLPessoa bLLPessoa;
        public CadastroPessoaFisica()
        {
            InitializeComponent();
        }

        private void tbCEPPessoaFisica_Leave(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", tbCEP.Text);

            ds.ReadXml(xml);

            tbLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
            tbBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
            tbCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
            cbxUF.Text = ds.Tables[0].Rows[0]["uf"].ToString();
        }

        private void btCadastrarPessoaFisica_Click(object sender, EventArgs e)
        {
            try
            {
                contato = new Contato(mkdTelefone.Text, mkdCelular.Text, tbEmail.Text);
                endereco = new Endereco(Convert.ToInt32(tbCEP.Text), tbLogradouro.Text, Convert.ToInt32(tbNumero.Text),
                    tbComplemento.Text, tbBairro.Text, tbCidade.Text, cbxUF.Text);
                pessoa = new Pessoa(contato, endereco);
                pessoaFisica = new PessoaFisica(pessoa, tbNome.Text + " " + tbSobrenome.Text, tbCPF.Text, tbRG.Text,
                    Convert.ToDateTime(dtNascimento.Value.Date), cbxGenero.Text);
                cliente = new Cliente(pessoa);

                Cadastrar();

                MessageBox.Show("Cadastro realizado com sucesso!");

                ReinicializarFormulario();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Cadastrar()
        {
            bLLCliente = new BLLCliente(cx);
            bLLPessoa = new BLLPessoa(cx);
            bLLPessoa.InserirContato(pessoa);
            bLLPessoa.InserirEndereco(pessoa);
            bLLPessoa.InserirPessoa(pessoa, contato, endereco);
            bLLPessoa.InserirPessoaFisica(pessoa, pessoaFisica);
            bLLCliente.InserirCliente(pessoa, cliente);
        }

        private void btCancelarPessoaFisica_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que quer cancelar?", "CANCELAR", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                ReinicializarFormulario();
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
            mkdCelular.Clear();
            mkdTelefone.Clear();
            cbxGenero.Text = "";
            cbxUF.Text = "";
            dtNascimento.Value = DateTime.Now;
        }
    }
}
