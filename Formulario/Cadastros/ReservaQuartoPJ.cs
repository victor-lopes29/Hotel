using BLL;
using DAL.Classes;
using Modelo.Classes.Hospedagem;
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

namespace Hotel.Formulario.Cadastros
{
    public partial class ReservaQuartoPJ : Form
    {
        private BLLQuarto bLLQuarto;
        private DALQuarto dALQuarto;
        private DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
        private PessoaJuridica pessoaJuridica;
        private BLLCliente bLLCliente;
        private Pessoa pessoa;
        private Cliente cliente;
        private Contato contato;
        private ReservaPJ reservaPJ;
        private Reserva reserva;
        private Quarto quarto;
        private BLLReserva bLLReserva;
        public ReservaQuartoPJ()
        {
            InitializeComponent();
            PopularDataGrid();
        }

        private void btBuscarReservaQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                pessoaJuridica = new PessoaJuridica();
                pessoaJuridica.CNPJ = tbCNPJ.Text;

                BuscarCliente();

                tbEmail.Text = contato.Email;
                tbNome.Text = pessoaJuridica.RazaoSocial;
                mkdCelular.Text = contato.Celular;
                mkdTelefone.Text = contato.Telefone;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void ReinicializarFormulario()
        {
            tbCNPJ.Clear();
            tbEmail.Clear();
            tbNome.Clear();
            tbQuartoReservaQuarto.Clear();
            mkdCelular.Clear();
            mkdTelefone.Clear();
            dtpEntrada.Value = DateTime.Now;
            dtpSaida.Value = DateTime.Now;

            PopularDataGrid();
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

        private void BuscarCliente()
        {
            bLLCliente = new BLLCliente(cx);
            pessoa = new Pessoa();
            cliente = new Cliente(pessoa);
            contato = new Contato();
            bLLCliente.BuscarClienteJuridico(pessoaJuridica, pessoa, cliente, contato);
        }

        private void btReservarReservaQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                quarto = new Quarto();
                quarto.NumeroDoQuarto = Convert.ToInt32(tbQuartoReservaQuarto.Text);
                BuscarIDQuarto(quarto);
                reserva = new Reserva(cliente, quarto, dtpEntrada.Value, dtpSaida.Value);
                reservaPJ = new ReservaPJ(reserva, tbNomeRepresentante.Text);

                Cadastrar();

                MessageBox.Show("Cadastro realizado com sucesso", "Reserva");

                ReinicializarFormulario();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BuscarIDQuarto(Quarto quarto)
        {
            bLLQuarto = new BLLQuarto(cx);
            bLLQuarto.BuscarIDQuarto(quarto);
        }

        private void Cadastrar()
        {
            bLLReserva = new BLLReserva(cx);
            bLLReserva.InserirReserva(reserva);
            bLLReserva.InserirReservaPJ(reservaPJ, reserva);
        }
    }
}
