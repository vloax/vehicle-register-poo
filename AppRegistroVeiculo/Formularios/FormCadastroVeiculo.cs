using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppRegistroVeiculo.RegrasDeNegocio;
using MeusComponentes.Interacoes;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormCadastroVeiculo : Form
    {
        private int id;
        List<Veiculo> listaVeiculo = new List<Veiculo>();

        public FormCadastroVeiculo()
        {
            InitializeComponent();
            BuscarUltimoId();
            edModelo.Clear();
            edMarca.Clear();
            edPlaca.Clear();
            edValor.Clear();
            edAno.Clear();
            edAno.Enabled = false;
            edMarca.Enabled = false;
            edModelo.Enabled = false;
            edPlaca.Enabled = false;
            edValor.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            btAdd.Enabled = true;
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            //############################
            Veiculo veiculo = new Veiculo();//criar o objeto veiculo
            veiculo.Id = ++id;
            veiculo.Modelo = edModelo.Text; 
            veiculo.Marca = edMarca.Text;
            veiculo.Placa = edPlaca.Text;
            veiculo.Ano = Convert.ToInt32(edAno.Text);
            veiculo.Valor = Convert.ToDouble(edValor.Text);

            //#############################
            StreamWriter sw = new StreamWriter("veiculos.csv", true); 
            sw.WriteLine(veiculo.ToString());
            sw.Close();//salva e fecha o arquivo
            BuscarUltimoId();//atualizar lista
            //######################
            Mensagem.Informacao("Salvo com sucesso!", "2º INF");
            //limpar componentes 
            edModelo.Clear();edMarca.Clear(); edPlaca.Clear();
            edValor.Clear();edAno.Clear();
            //bloquear os componentes 
            edAno.Enabled = false; edMarca.Enabled = false;
            edModelo.Enabled = false; edPlaca.Enabled = false;
            edValor.Enabled = false; btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            //Ativar o botão ADD
            btAdd.Enabled = true; 
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //liberar componentes para edição
            edAno.Enabled = true; edMarca.Enabled = true;
            edModelo.Enabled = true; edPlaca.Enabled = true;
            edValor.Enabled = true; btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            //bloquear botão ADD
            btAdd.Enabled = false; 
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja cancelar?", "2º A INF");

            if (resp.ToLower() == "sim")
            {
                edModelo.Clear(); 
                edMarca.Clear();
                edPlaca.Clear();
                edValor.Clear(); 
                edAno.Clear();
                edAno.Enabled = false; 
                edMarca.Enabled = false;
                edModelo.Enabled = false; 
                edPlaca.Enabled = false;
                edValor.Enabled = false; 
                btSalvar.Enabled = false;
                btCancelar.Enabled = false;
                btAdd.Enabled = true;
            }

        }

        private void BuscarUltimoId()
        {
            listaVeiculo.Clear();//limpar a lista
            StreamReader sr = new StreamReader("veiculos.csv");

            if (sr.EndOfStream == null)
            {

                id = 1;

            }
            else
            {
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
                id = listaVeiculo.Last().Id;
            }
            

        }
    }
}
