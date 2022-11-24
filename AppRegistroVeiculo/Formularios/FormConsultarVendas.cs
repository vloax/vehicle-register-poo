using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroVeiculo.RegrasDeNegocio;
using System.IO;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormConsultarVendas : Form
    {
        List<Cliente> listaCliente = new List<Cliente>();
        List<Veiculo> listaVeiculo = new List<Veiculo>();
        List<Venda> listaVenda = new List<Venda>();

        public FormConsultarVendas()
        {
            InitializeComponent();
            CarregarListaCliente();
            CarregarListaVeiculo();
            CarregarListaVenda();
            //carregando o comboBox cliente
            cbCliente.DataSource = listaCliente;
            cbCliente.DisplayMember = "Nome";
            cbCliente.SelectedIndex = -1;//para a opção ficar em branco
            //carregando co comboBox veículo
            cbVeiculo.DataSource = listaVeiculo;
            cbVeiculo.DisplayMember = "Placa"; 
            cbVeiculo.SelectedIndex = -1;//para a opção ficar em branco
        }

        private void CarregarListaCliente()
        {
            StreamReader sr = new StreamReader("cliente.csv");
            while (!sr.EndOfStream)
            {
                Cliente cliente = new Cliente();
                string[] registro = sr.ReadLine().Split(';');
                cliente.Id = Convert.ToInt32(registro[0]);
                cliente.Cpf = registro[1];
                cliente.Nome = registro[2];
                listaCliente.Add(cliente);
            }
            sr.Close();
        }

        private void CarregarListaVeiculo()
        {
            StreamReader sr = new StreamReader("veiculos.csv");
            while (!sr.EndOfStream)
            {
                Veiculo veiculo = new Veiculo();
                string[] registro = sr.ReadLine().Split(';'); 
                veiculo.Id = Convert.ToInt32(registro[0]);
                veiculo.Modelo = registro[1];
                veiculo.Marca = registro[2];
                veiculo.Placa = registro[3];
                veiculo.Ano = Convert.ToInt32(registro[4]);
                veiculo.Valor = Convert.ToDouble(registro[5]);
                listaVeiculo.Add(veiculo);
            }
            sr.Close();
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
            sr.Close ();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            int posCliente = cbCliente.SelectedIndex;
            int posVeiculo = cbVeiculo.SelectedIndex;

            int idCliente = listaCliente.ElementAt(posCliente).Id;
            int idVeiculo = listaCliente.ElementAt(posVeiculo).Id;

            dgvTabela.DataSource = listaVenda.Where(v => v.ClienteId == idCliente && v.VeiculoId == idVeiculo).ToList();
           

        }
    }
}
