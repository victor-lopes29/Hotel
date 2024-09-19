using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Classes;
using Modelo.Quartos;

namespace Hotel.Formulario
{
    public partial class VisualizarQuartos : Form
    {
        private BLLQuarto bLLQuarto;
        private DALQuarto dALQuarto;
        private DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
        private Quarto quarto = new Quarto();
        public VisualizarQuartos()
        {
            InitializeComponent();
            PopularDataGrid();
        }

        private void btBuscarReservaQuarto_Click(object sender, EventArgs e)
        {
            if(tbNumeroQuarto.Text.Trim() == "")
            {
                quarto.NumeroDoQuarto = 0;
            }

            else
            {
                quarto.NumeroDoQuarto = Convert.ToInt32(tbNumeroQuarto.Text);
            }
            PopularDataGrid();
        }

        private void PopularDataGrid()
        {
            DataSet ds = new DataSet();
            bLLQuarto = new BLLQuarto(cx);
            dALQuarto = new DALQuarto(cx);
            ds = bLLQuarto.BuscarQuarto(dALQuarto, quarto);

            dgvQuarto.DataSource = ds;
            dgvQuarto.DataMember = "ps_Quartos";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            quarto.NumeroDoQuarto = 0;
            tbNumeroQuarto.Clear();
            PopularDataGrid();
        }
    }
}
