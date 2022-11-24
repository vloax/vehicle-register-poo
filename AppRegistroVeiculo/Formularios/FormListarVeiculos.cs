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
    public partial class FormListarVeiculos : Form
    {
        List<Veiculo> listaVeiculo = new List<Veiculo>();

        public FormListarVeiculos()
        {
            InitializeComponent();
            CarregarListaVeiculo();
            dtTabela.DataSource = listaVeiculo;
        
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
    }
}
