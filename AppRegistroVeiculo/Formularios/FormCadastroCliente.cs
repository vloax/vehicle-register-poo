using MeusComponentes.Interacoes;
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
using FerramentasBiblioteca.Validacoes;
using FerramentasBiblioteca.Formatacoes;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormCadastroCliente : Form
    {

        List<Cliente> clienteList = new List<Cliente>();

        private int idCli = 0;

        public FormCadastroCliente()
        {
            InitializeComponent();
            FindLastId();
            edNome.Focus();
            edNome.Enabled = false;
            edCpf.Enabled = false;
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            StreamWriter writerClient = new StreamWriter("cliente.csv", true);

            Cliente client = new Cliente();

            bool clientCpfValidation = ValidacoesSociais.ValidarCpf(edCpf.Text);

            if (clientCpfValidation == true)
            {
                client.Id = ++idCli;
                client.Nome = edNome.Text;
                client.Cpf = Mascaras.ManterApenasNumeros(edCpf.Text);

                writerClient.WriteLine(client.ToString());

                writerClient.Close();
                clienteList.Clear();
                FindLastId();


                edNome.Clear();
                edCpf.Clear();
                edNome.Focus();
                edNome.Enabled = false;
                edCpf.Enabled = false;
                btAdd.Enabled = true;
                btCancelar.Enabled = false;
                btSalvar.Enabled = false;

                Mensagem.Informacao("Salvo com sucesso!", "Client Register");

            }
            else
            {
                Mensagem.Erro("CPF INVÁLIDO!", "Client Registration");

                edNome.Clear();
                edCpf.Clear();
                edNome.Focus();
                edNome.Enabled = false;
                edCpf.Enabled = false;
                btAdd.Enabled = true;
                btCancelar.Enabled = false;
                btSalvar.Enabled = false;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja cancelar o cadastro?", "Cancelamento ");

            if (resp.ToLower() == "sim")
            {
                edNome.Clear();
                edCpf.Clear();
                edNome.Focus();
                edNome.Enabled = false;
                edCpf.Enabled = false;
                btAdd.Enabled = true;
                btCancelar.Enabled = false;
                btSalvar.Enabled = false;

            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            edNome.Focus();
            edNome.Enabled = true;
            edCpf.Enabled = true;
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }

        public void FindLastId()
        {
            clienteList.Clear();
            StreamReader srClient = new StreamReader("cliente.csv");

            while (!srClient.EndOfStream)
            {
                Cliente client = new Cliente();

                string[] register = srClient.ReadLine().Split(';');
                client.Id = Convert.ToInt32(register[0]);
                client.Cpf = register[1];
                client.Nome = register[2];
                clienteList.Add(client);
            }

            srClient.Close();
            idCli = clienteList.Last().Id;

        }

    }
}
