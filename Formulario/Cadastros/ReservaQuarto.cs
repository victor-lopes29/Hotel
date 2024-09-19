using BLL;
using DAL.Classes;
using Modelo.Hospedagem;
using Modelo.Hospede;
using Modelo.Pessoas;
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
    public partial class ReservaQuarto : Form
    {
        private BLLQuarto bLLQuarto;
        private DALQuarto dALQuarto;
        private DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
        private PessoaFisica pessoaFisica;
        private BLLCliente bLLCliente;
        private Pessoa pessoa;
        private Cliente cliente;
        private Contato contato;
        private Reserva reserva;
        private Quarto quarto;
        private BLLReserva bLLReserva;
        public ReservaQuarto()
        {
            InitializeComponent();
        }

        private void ReservaQuarto_Load(object sender, EventArgs e)
        {
            PopularDataGrid();
        }

        private void btBuscarReservaQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                pessoaFisica = new PessoaFisica();
                pessoaFisica.CPF = tbCPFReservaQuarto.Text;

                BuscarCliente();

                tbEmail.Text = contato.Email;
                tbNome.Text = pessoaFisica.NomePesssoa;
                mkdCelular.Text = contato.Celular;
                mkdTelefone.Text = contato.Telefone;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BuscarCliente()
        {
            bLLCliente = new BLLCliente(cx);
            pessoa = new Pessoa();
            cliente = new Cliente(pessoa);
            contato = new Contato();
            bLLCliente.BuscarClienteFisico(pessoaFisica, pessoa, cliente, contato);
        }

        private void btReservarReservaQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                quarto = new Quarto();
                quarto.NumeroDoQuarto = Convert.ToInt32(tbQuartoReservaQuarto.Text);
                BuscarIDQuarto(quarto);
                reserva = new Reserva(cliente, quarto, dtpEntrada.Value, dtpSaida.Value);

                Cadastrar();

                MessageBox.Show("Cadastro realizado com sucesso", "Reserva");

                ReinicializarFormulario();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Cadastrar()
        {
            bLLReserva = new BLLReserva(cx);
            bLLReserva.InserirReserva(reserva);
        }

        private void BuscarIDQuarto(Quarto quarto)
        {
            bLLQuarto = new BLLQuarto(cx);
            bLLQuarto.BuscarIDQuarto(quarto);
        }

        private void PopularDataGrid()
        {
            DataSet ds = new DataSet();
            bLLQuarto = new BLLQuarto(cx);
            dALQuarto = new DALQuarto(cx);
            ds = bLLQuarto.ps_QuartosDisponiveis(dALQuarto);

            dgvQuartosDisponivels.DataSource = ds;
            dgvQuartosDisponivels.DataMember = "ps_QuartosDisponiveis";
        }

        private void ReinicializarFormulario()
        {
            tbCPFReservaQuarto.Clear();
            tbEmail.Clear();
            tbNome.Clear();
            tbQuartoReservaQuarto.Clear();
            mkdCelular.Clear();
            mkdTelefone.Clear();
            dtpEntrada.Value = DateTime.Now;
            dtpSaida.Value = DateTime.Now;

            PopularDataGrid();
        }
    }
}
