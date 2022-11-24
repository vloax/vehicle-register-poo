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
    public partial class FormConsultarVeiculo : Form
    {
        List<Veiculo> listaVeiculo = new List<Veiculo>();


        public FormConsultarVeiculo()
        {

            InitializeComponent();
            CarregarListaVeiculo();
            cbVeiculo.DataSource = listaVeiculo;
            cbVeiculo.DisplayMember = "Placa";
            
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

        private void btConsultar_Click_1(object sender, EventArgs e)
        {
            int pos = cbVeiculo.SelectedIndex;
            int idVeiculo = listaVeiculo.ElementAt(pos).Id;
            dgvCliente.DataSource = listaVeiculo.Where(v => v.Id == idVeiculo).ToList();
        }
    }
}
