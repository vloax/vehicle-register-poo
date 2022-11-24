using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroVeiculo.Formularios;

namespace AppRegistroVeiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroCliente form = new FormCadastroCliente();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCadastroVeiculo form = new FormCadastroVeiculo();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormRealizarVendas form = new FormRealizarVendas();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormConsultarVeiculo form = new FormConsultarVeiculo();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultarCliente form = new FormConsultarCliente();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormConsultarVendas form = new FormConsultarVendas();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormListarClientes form = new FormListarClientes();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormListarVeiculos form = new FormListarVeiculos();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormListarVendas form = new FormListarVendas();
            form.ShowDialog();
        }
    }
}
