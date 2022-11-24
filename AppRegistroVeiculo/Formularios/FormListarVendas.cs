using AppRegistroVeiculo.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormListarVendas : Form
    {
        List<Venda> listaVenda = new List<Venda>();

        public FormListarVendas()
        {
            InitializeComponent();
            CarregarListaVenda();
            dtTabela.DataSource = listaVenda;   

        }

        private void CarregarListaVenda()
        {
            StreamReader sr = new StreamReader("vendas.csv");
            while (!sr.EndOfStream)
            {
                Venda venda = new Venda();
                string[] registro = sr.ReadLine().Split(';');
                venda.Id = Convert.ToInt32(registro[0]);
                venda.DataVenda = Convert.ToDateTime(registro[1]);
                venda.ValorDaVenda = Convert.ToDouble(registro[2]);
                venda.VeiculoId = Convert.ToInt32(registro[3]);
                venda.ClienteId = Convert.ToInt32(registro[4]);
                listaVenda.Add(venda);
            }
            sr.Close();
        }

        private void dtTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
