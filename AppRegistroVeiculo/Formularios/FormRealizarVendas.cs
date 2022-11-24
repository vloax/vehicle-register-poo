using AppRegistroVeiculo.RegrasDeNegocio;
using MeusComponentes.Interacoes;
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
    public partial class FormRealizarVendas : Form
    {
        List<Cliente> listaCliente = new List<Cliente>();
        List<Veiculo> listaVeiculo = new List<Veiculo>();
        List<Venda> listaVenda = new List<Venda>();

        private int idVenda = 0;

        public FormRealizarVendas()
        {
            InitializeComponent();
            //carregando o comboBox cliente
            CarregarListaCliente();
            CarregarListaVeiculo();
            FindLastId();
            cbPessoa.DataSource = listaCliente;
            cbPessoa.DisplayMember = "Nome";
            cbPessoa.SelectedIndex = -1;//para a opção ficar em branco
            //carregando co comboBox veículo
            cbVeiculo.DataSource = listaVeiculo;
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;//para a opção ficar em branco


            cbVeiculo.Focus();
            edModelo.Enabled = false;
            edNome.Enabled = false;
            edValorVenda.Enabled = false;
            cbPessoa.Enabled = false;
            cbVeiculo.Enabled = false;
            btAdd.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            dtpVendas.Enabled = false;

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

        private void FindLastId()
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
            idVenda = listaVenda.Last().Id;
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

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            edModelo.Text = "";
            Veiculo veiculo = new Veiculo();
            int posVeiculo = cbVeiculo.SelectedIndex;

            if (posVeiculo > -1)
            {
                int idVeiculo = listaVeiculo.ElementAt(posVeiculo).Id;
                edModelo.Text = listaVeiculo.ElementAt(posVeiculo).Modelo;
            }
   
        }

        private void cbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            edNome.Text = "";
            Cliente cliente = new Cliente();
            int posCliente = cbPessoa.SelectedIndex;

            if (posCliente > -1)
            {
              
                int idCliente = listaCliente.ElementAt(posCliente).Id;
                edNome.Text = listaCliente.ElementAt(posCliente).Nome;

            }
        

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            StreamWriter writerSells = new StreamWriter("vendas.csv", true);

            Venda venda = new Venda();

            venda.Id = ++idVenda;
            venda.DataVenda = dtpVendas.Value;
            venda.VeiculoId = cbVeiculo.SelectedIndex;
            venda.ClienteId = cbPessoa.SelectedIndex;
            venda.ValorDaVenda = Convert.ToDouble(edValorVenda.Text);

            writerSells.WriteLine(venda.ToString());

            writerSells.Close();

            cbVeiculo.Focus();
            edValorVenda.Clear();
            edModelo.Clear();
            edValorVenda.Clear();
            cbVeiculo.SelectedIndex = -1;
            cbPessoa.SelectedIndex = -1;
            edModelo.Enabled = false;
            edNome.Enabled = false;
            edValorVenda.Enabled = false;
            cbPessoa.Enabled = false;
            cbVeiculo.Enabled = false;
            btAdd.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            dtpVendas.Enabled = false;

            Mensagem.Informacao("Salvo com sucesso!", "2º A INF");
        
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja mesmo cancelar?", "2º A INFO");

            if (resp.ToLower() == "sim")
            {
                cbVeiculo.Focus();
                edModelo.Enabled = false;
                edNome.Enabled = false;
                edValorVenda.Enabled = false;
                cbPessoa.Enabled = false;
                cbVeiculo.Enabled = false;
                btAdd.Enabled = true;
                btSalvar.Enabled = false;
                btCancelar.Enabled = false;
                dtpVendas.Enabled = false;
            }


        }

        private void btAdd_Click(object sender, EventArgs e)
        {


            cbVeiculo.Focus();
            edModelo.Enabled = true;
            edNome.Enabled = true;
            edValorVenda.Enabled = true;
            cbPessoa.Enabled = true;
            cbVeiculo.Enabled = true;
            btAdd.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            dtpVendas.Enabled = true;
        }
    }
}
