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
    public partial class FormListarClientes : Form
    {

        private List<Cliente> listaCliente = new List<Cliente>();

        public FormListarClientes()
        {
            InitializeComponent();
            CarregarListaCliente();
            dtTabela.DataSource = listaCliente;

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

    }
}
