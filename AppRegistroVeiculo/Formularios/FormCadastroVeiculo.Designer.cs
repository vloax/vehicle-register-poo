namespace AppRegistroVeiculo.Formularios
{
    partial class FormCadastroVeiculo
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
            this.label6 = new System.Windows.Forms.Label();
            this.edValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edAno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edPlaca = new System.Windows.Forms.TextBox();
            this.edMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edModelo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(273, 463);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(6);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(154, 42);
            this.btSalvar.TabIndex = 42;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(439, 463);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(154, 42);
            this.btCancelar.TabIndex = 41;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(107, 463);
            this.btAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(154, 42);
            this.btAdd.TabIndex = 40;
            this.btAdd.Text = "ADD+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "VALOR:";
            // 
            // edValor
            // 
            this.edValor.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edValor.Location = new System.Drawing.Point(219, 388);
            this.edValor.Margin = new System.Windows.Forms.Padding(6);
            this.edValor.Name = "edValor";
            this.edValor.Size = new System.Drawing.Size(278, 30);
            this.edValor.TabIndex = 38;
            this.edValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "ANO:";
            // 
            // edAno
            // 
            this.edAno.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edAno.Location = new System.Drawing.Point(135, 301);
            this.edAno.Margin = new System.Windows.Forms.Padding(6);
            this.edAno.Name = "edAno";
            this.edAno.Size = new System.Drawing.Size(186, 30);
            this.edAno.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "PLACA:";
            // 
            // edPlaca
            // 
            this.edPlaca.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edPlaca.Location = new System.Drawing.Point(354, 301);
            this.edPlaca.Margin = new System.Windows.Forms.Padding(6);
            this.edPlaca.Name = "edPlaca";
            this.edPlaca.Size = new System.Drawing.Size(218, 30);
            this.edPlaca.TabIndex = 34;
            // 
            // edMarca
            // 
            this.edMarca.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edMarca.Location = new System.Drawing.Point(134, 213);
            this.edMarca.Margin = new System.Windows.Forms.Padding(6);
            this.edMarca.Name = "edMarca";
            this.edMarca.Size = new System.Drawing.Size(438, 30);
            this.edMarca.TabIndex = 33;
            this.edMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "MARCA:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "MODELO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edModelo
            // 
            this.edModelo.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edModelo.Location = new System.Drawing.Point(135, 125);
            this.edModelo.Margin = new System.Windows.Forms.Padding(6);
            this.edModelo.Name = "edModelo";
            this.edModelo.Size = new System.Drawing.Size(438, 30);
            this.edModelo.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 71);
            this.panel2.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR VEÍCULO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 540);
            this.Controls.Add(this.edModelo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edPlaca);
            this.Controls.Add(this.edMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCadastroVeiculo";
            this.Text = "CADASTRAR VEÍCULOS";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edPlaca;
        private System.Windows.Forms.TextBox edMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edModelo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}