namespace AppRegistroVeiculo.Formularios
{
    partial class FormRealizarVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtpVendas = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edNome = new System.Windows.Forms.TextBox();
            this.hk = new System.Windows.Forms.Label();
            this.edValorVenda = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(440, 457);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(124, 42);
            this.btSalvar.TabIndex = 40;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(310, 457);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(124, 42);
            this.btCancelar.TabIndex = 39;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(180, 457);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(124, 42);
            this.btAdd.TabIndex = 38;
            this.btAdd.Text = "ADD+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtpVendas
            // 
            this.dtpVendas.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVendas.Location = new System.Drawing.Point(168, 205);
            this.dtpVendas.Name = "dtpVendas";
            this.dtpVendas.Size = new System.Drawing.Size(396, 30);
            this.dtpVendas.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "DATA DA VENDA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "SELECIONE O VEÍCULO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "SELECIONE O CLIENTE:";
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(373, 129);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(322, 33);
            this.cbVeiculo.TabIndex = 33;
            this.cbVeiculo.SelectedIndexChanged += new System.EventHandler(this.cbVeiculo_SelectedIndexChanged);
            // 
            // cbPessoa
            // 
            this.cbPessoa.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Location = new System.Drawing.Point(34, 129);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(321, 33);
            this.cbPessoa.TabIndex = 32;
            this.cbPessoa.SelectedIndexChanged += new System.EventHandler(this.cbPessoa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "MODELO:";
            // 
            // edModelo
            // 
            this.edModelo.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edModelo.Location = new System.Drawing.Point(171, 270);
            this.edModelo.Name = "edModelo";
            this.edModelo.Size = new System.Drawing.Size(393, 30);
            this.edModelo.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "NOME:";
            // 
            // edNome
            // 
            this.edNome.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNome.Location = new System.Drawing.Point(173, 337);
            this.edNome.Name = "edNome";
            this.edNome.Size = new System.Drawing.Size(393, 30);
            this.edNome.TabIndex = 45;
            // 
            // hk
            // 
            this.hk.AutoSize = true;
            this.hk.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hk.Location = new System.Drawing.Point(168, 377);
            this.hk.Name = "hk";
            this.hk.Size = new System.Drawing.Size(177, 25);
            this.hk.TabIndex = 48;
            this.hk.Text = "VALOR DA VENDA:";
            // 
            // edValorVenda
            // 
            this.edValorVenda.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edValorVenda.Location = new System.Drawing.Point(171, 405);
            this.edValorVenda.Name = "edValorVenda";
            this.edValorVenda.Size = new System.Drawing.Size(395, 30);
            this.edValorVenda.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 71);
            this.panel2.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(707, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "REALIZAR VENDA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRealizarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hk);
            this.Controls.Add(this.edValorVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edModelo);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtpVendas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.cbPessoa);
            this.Name = "FormRealizarVendas";
            this.Text = "FormRealizarVendas";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DateTimePicker dtpVendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edNome;
        private System.Windows.Forms.Label hk;
        private System.Windows.Forms.TextBox edValorVenda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}