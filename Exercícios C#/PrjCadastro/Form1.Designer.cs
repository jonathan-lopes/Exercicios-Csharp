namespace PrjCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labcadastro = new System.Windows.Forms.Label();
            this.labnome = new System.Windows.Forms.Label();
            this.labendereco = new System.Windows.Forms.Label();
            this.labtelefone = new System.Windows.Forms.Label();
            this.labcidade = new System.Windows.Forms.Label();
            this.labbairro = new System.Windows.Forms.Label();
            this.labestado = new System.Windows.Forms.Label();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxendereco = new System.Windows.Forms.TextBox();
            this.textBoxtelefone = new System.Windows.Forms.TextBox();
            this.textBoxcidade = new System.Windows.Forms.TextBox();
            this.textBoxbairro = new System.Windows.Forms.TextBox();
            this.textBoxestado = new System.Windows.Forms.TextBox();
            this.buttonnovo = new System.Windows.Forms.Button();
            this.buttonsalvar = new System.Windows.Forms.Button();
            this.buttonsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labcadastro
            // 
            this.labcadastro.AutoSize = true;
            this.labcadastro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcadastro.Location = new System.Drawing.Point(238, 38);
            this.labcadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labcadastro.Name = "labcadastro";
            this.labcadastro.Size = new System.Drawing.Size(118, 22);
            this.labcadastro.TabIndex = 0;
            this.labcadastro.Text = "CADASTRO";
            // 
            // labnome
            // 
            this.labnome.AutoSize = true;
            this.labnome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnome.Location = new System.Drawing.Point(9, 142);
            this.labnome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labnome.Name = "labnome";
            this.labnome.Size = new System.Drawing.Size(45, 16);
            this.labnome.TabIndex = 1;
            this.labnome.Text = "Nome";
            // 
            // labendereco
            // 
            this.labendereco.AutoSize = true;
            this.labendereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labendereco.Location = new System.Drawing.Point(9, 176);
            this.labendereco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labendereco.Name = "labendereco";
            this.labendereco.Size = new System.Drawing.Size(68, 16);
            this.labendereco.TabIndex = 2;
            this.labendereco.Text = "Endereço";
            // 
            // labtelefone
            // 
            this.labtelefone.AutoSize = true;
            this.labtelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtelefone.Location = new System.Drawing.Point(9, 210);
            this.labtelefone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labtelefone.Name = "labtelefone";
            this.labtelefone.Size = new System.Drawing.Size(63, 16);
            this.labtelefone.TabIndex = 3;
            this.labtelefone.Text = "Telefone";
            // 
            // labcidade
            // 
            this.labcidade.AutoSize = true;
            this.labcidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcidade.Location = new System.Drawing.Point(9, 245);
            this.labcidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labcidade.Name = "labcidade";
            this.labcidade.Size = new System.Drawing.Size(53, 16);
            this.labcidade.TabIndex = 4;
            this.labcidade.Text = "Cidade";
            // 
            // labbairro
            // 
            this.labbairro.AutoSize = true;
            this.labbairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labbairro.Location = new System.Drawing.Point(409, 210);
            this.labbairro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labbairro.Name = "labbairro";
            this.labbairro.Size = new System.Drawing.Size(47, 16);
            this.labbairro.TabIndex = 5;
            this.labbairro.Text = "Bairro";
            this.labbairro.Click += new System.EventHandler(this.Labbairro_Click);
            // 
            // labestado
            // 
            this.labestado.AutoSize = true;
            this.labestado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labestado.Location = new System.Drawing.Point(406, 245);
            this.labestado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labestado.Name = "labestado";
            this.labestado.Size = new System.Drawing.Size(50, 16);
            this.labestado.TabIndex = 6;
            this.labestado.Text = "Estado";
            this.labestado.Click += new System.EventHandler(this.Labestado_Click);
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(82, 137);
            this.textBoxnome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(317, 26);
            this.textBoxnome.TabIndex = 7;
            // 
            // textBoxendereco
            // 
            this.textBoxendereco.Location = new System.Drawing.Point(82, 171);
            this.textBoxendereco.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxendereco.Name = "textBoxendereco";
            this.textBoxendereco.Size = new System.Drawing.Size(317, 26);
            this.textBoxendereco.TabIndex = 8;
            // 
            // textBoxtelefone
            // 
            this.textBoxtelefone.Location = new System.Drawing.Point(82, 205);
            this.textBoxtelefone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxtelefone.Name = "textBoxtelefone";
            this.textBoxtelefone.Size = new System.Drawing.Size(317, 26);
            this.textBoxtelefone.TabIndex = 9;
            // 
            // textBoxcidade
            // 
            this.textBoxcidade.Location = new System.Drawing.Point(82, 239);
            this.textBoxcidade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxcidade.Name = "textBoxcidade";
            this.textBoxcidade.Size = new System.Drawing.Size(317, 26);
            this.textBoxcidade.TabIndex = 10;
            // 
            // textBoxbairro
            // 
            this.textBoxbairro.Location = new System.Drawing.Point(455, 205);
            this.textBoxbairro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxbairro.Name = "textBoxbairro";
            this.textBoxbairro.Size = new System.Drawing.Size(130, 26);
            this.textBoxbairro.TabIndex = 11;
            // 
            // textBoxestado
            // 
            this.textBoxestado.Location = new System.Drawing.Point(455, 239);
            this.textBoxestado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxestado.Name = "textBoxestado";
            this.textBoxestado.Size = new System.Drawing.Size(130, 26);
            this.textBoxestado.TabIndex = 12;
            // 
            // buttonnovo
            // 
            this.buttonnovo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonnovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnovo.Location = new System.Drawing.Point(44, 345);
            this.buttonnovo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonnovo.Name = "buttonnovo";
            this.buttonnovo.Size = new System.Drawing.Size(95, 35);
            this.buttonnovo.TabIndex = 13;
            this.buttonnovo.Text = "Novo";
            this.buttonnovo.UseVisualStyleBackColor = false;
            // 
            // buttonsalvar
            // 
            this.buttonsalvar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonsalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalvar.Location = new System.Drawing.Point(254, 345);
            this.buttonsalvar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonsalvar.Name = "buttonsalvar";
            this.buttonsalvar.Size = new System.Drawing.Size(92, 35);
            this.buttonsalvar.TabIndex = 14;
            this.buttonsalvar.Text = "Salvar";
            this.buttonsalvar.UseVisualStyleBackColor = false;
            this.buttonsalvar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonsair
            // 
            this.buttonsair.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonsair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsair.Location = new System.Drawing.Point(438, 345);
            this.buttonsair.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(109, 35);
            this.buttonsair.TabIndex = 15;
            this.buttonsair.Text = "Sair";
            this.buttonsair.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 393);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.buttonsalvar);
            this.Controls.Add(this.buttonnovo);
            this.Controls.Add(this.textBoxestado);
            this.Controls.Add(this.textBoxbairro);
            this.Controls.Add(this.textBoxcidade);
            this.Controls.Add(this.textBoxtelefone);
            this.Controls.Add(this.textBoxendereco);
            this.Controls.Add(this.textBoxnome);
            this.Controls.Add(this.labestado);
            this.Controls.Add(this.labbairro);
            this.Controls.Add(this.labcidade);
            this.Controls.Add(this.labtelefone);
            this.Controls.Add(this.labendereco);
            this.Controls.Add(this.labnome);
            this.Controls.Add(this.labcadastro);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labcadastro;
        private System.Windows.Forms.Label labnome;
        private System.Windows.Forms.Label labendereco;
        private System.Windows.Forms.Label labtelefone;
        private System.Windows.Forms.Label labcidade;
        private System.Windows.Forms.Label labbairro;
        private System.Windows.Forms.Label labestado;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxendereco;
        private System.Windows.Forms.TextBox textBoxtelefone;
        private System.Windows.Forms.TextBox textBoxcidade;
        private System.Windows.Forms.TextBox textBoxbairro;
        private System.Windows.Forms.TextBox textBoxestado;
        private System.Windows.Forms.Button buttonnovo;
        private System.Windows.Forms.Button buttonsalvar;
        private System.Windows.Forms.Button buttonsair;
    }
}

