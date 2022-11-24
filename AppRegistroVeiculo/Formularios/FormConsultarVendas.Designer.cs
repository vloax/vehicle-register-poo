namespace AppRegistroVeiculo.Formularios
{
    partial class FormConsultarVendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "SELECIONE O VEÍCULO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "SELECIONE O CLIENTE:";
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(386, 134);
            this.cbVeiculo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(287, 29);
            this.cbVeiculo.TabIndex = 37;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCliente.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(44, 134);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(290, 29);
            this.cbCliente.TabIndex = 36;
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(265, 194);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(198, 38);
            this.btConsultar.TabIndex = 40;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // dgvTabela
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            this.dgvTabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabela.AutoGenerateColumns = false;
            this.dgvTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Venda,
            this.valor});
            this.dgvTabela.DataSource = this.bindingSource1;
            this.dgvTabela.Location = new System.Drawing.Point(15, 259);
            this.dgvTabela.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(701, 254);
            this.dgvTabela.TabIndex = 41;
            // 
            // Venda
            // 
            this.Venda.DataPropertyName = "DataVenda";
            this.Venda.HeaderText = "DATA DA VENDA";
            this.Venda.Name = "Venda";
            // 
            // valor
            // 
            this.valor.DataPropertyName = "ValorDaVenda";
            this.valor.HeaderText = "VALOR DA VENDA";
            this.valor.Name = "valor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 71);
            this.panel2.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(707, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "CONSULTAR VENDAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.cbCliente);
            this.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormConsultarVendas";
            this.Text = "FormConsultarVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}