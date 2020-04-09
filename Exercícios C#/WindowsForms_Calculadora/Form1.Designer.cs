namespace WindowsForms_Calculadora
{
    partial class FormCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalc));
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.labcalculos = new System.Windows.Forms.Label();
            this.labnumero1 = new System.Windows.Forms.Label();
            this.labnumero2 = new System.Windows.Forms.Label();
            this.labresultado = new System.Windows.Forms.Label();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.butdividir = new System.Windows.Forms.Button();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNum1
            // 
            this.textNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum1.ForeColor = System.Drawing.Color.Red;
            this.textNum1.Location = new System.Drawing.Point(229, 123);
            this.textNum1.Margin = new System.Windows.Forms.Padding(5);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(113, 26);
            this.textNum1.TabIndex = 0;
            // 
            // textNum2
            // 
            this.textNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum2.ForeColor = System.Drawing.Color.Red;
            this.textNum2.Location = new System.Drawing.Point(229, 191);
            this.textNum2.Margin = new System.Windows.Forms.Padding(5);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(113, 26);
            this.textNum2.TabIndex = 1;
            this.textNum2.TextChanged += new System.EventHandler(this.Textnum2_TextChanged);
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.ForeColor = System.Drawing.Color.Red;
            this.textResultado.Location = new System.Drawing.Point(206, 391);
            this.textResultado.Margin = new System.Windows.Forms.Padding(5);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(136, 26);
            this.textResultado.TabIndex = 2;
            // 
            // labcalculos
            // 
            this.labcalculos.AutoSize = true;
            this.labcalculos.BackColor = System.Drawing.Color.Transparent;
            this.labcalculos.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcalculos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labcalculos.Location = new System.Drawing.Point(178, 23);
            this.labcalculos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labcalculos.Name = "labcalculos";
            this.labcalculos.Size = new System.Drawing.Size(241, 25);
            this.labcalculos.TabIndex = 3;
            this.labcalculos.Text = "CÁLCULOS BÁSICOS";
            // 
            // labnumero1
            // 
            this.labnumero1.AutoSize = true;
            this.labnumero1.BackColor = System.Drawing.Color.Transparent;
            this.labnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnumero1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labnumero1.Location = new System.Drawing.Point(27, 123);
            this.labnumero1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labnumero1.Name = "labnumero1";
            this.labnumero1.Size = new System.Drawing.Size(192, 20);
            this.labnumero1.TabIndex = 4;
            this.labnumero1.Text = "DIGITE O 1º NÚMERO";
            // 
            // labnumero2
            // 
            this.labnumero2.AutoSize = true;
            this.labnumero2.BackColor = System.Drawing.Color.Transparent;
            this.labnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnumero2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labnumero2.Location = new System.Drawing.Point(22, 191);
            this.labnumero2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labnumero2.Name = "labnumero2";
            this.labnumero2.Size = new System.Drawing.Size(197, 20);
            this.labnumero2.TabIndex = 5;
            this.labnumero2.Text = "DIGITE O 2º NÚMERO ";
            this.labnumero2.Click += new System.EventHandler(this.Labnumero2_Click);
            // 
            // labresultado
            // 
            this.labresultado.AutoSize = true;
            this.labresultado.BackColor = System.Drawing.Color.Transparent;
            this.labresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labresultado.ForeColor = System.Drawing.Color.LightYellow;
            this.labresultado.Location = new System.Drawing.Point(63, 391);
            this.labresultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labresultado.Name = "labresultado";
            this.labresultado.Size = new System.Drawing.Size(133, 24);
            this.labresultado.TabIndex = 6;
            this.labresultado.Text = "RESULTADO";
            // 
            // btnsoma
            // 
            this.btnsoma.BackColor = System.Drawing.Color.Lime;
            this.btnsoma.FlatAppearance.BorderSize = 0;
            this.btnsoma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnsoma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnsoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsoma.Location = new System.Drawing.Point(229, 267);
            this.btnsoma.Margin = new System.Windows.Forms.Padding(5);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(45, 37);
            this.btnsoma.TabIndex = 7;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = false;
            this.btnsoma.Click += new System.EventHandler(this.Btnsoma_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.BackColor = System.Drawing.Color.Lime;
            this.btnmultiplicar.FlatAppearance.BorderSize = 0;
            this.btnmultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnmultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnmultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmultiplicar.Location = new System.Drawing.Point(229, 329);
            this.btnmultiplicar.Margin = new System.Windows.Forms.Padding(5);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(45, 37);
            this.btnmultiplicar.TabIndex = 8;
            this.btnmultiplicar.Text = " * ";
            this.btnmultiplicar.UseVisualStyleBackColor = false;
            this.btnmultiplicar.Click += new System.EventHandler(this.Btnmultiplicar_Click);
            // 
            // butdividir
            // 
            this.butdividir.BackColor = System.Drawing.Color.Lime;
            this.butdividir.FlatAppearance.BorderSize = 0;
            this.butdividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.butdividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.butdividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butdividir.Location = new System.Drawing.Point(297, 329);
            this.butdividir.Margin = new System.Windows.Forms.Padding(5);
            this.butdividir.Name = "butdividir";
            this.butdividir.Size = new System.Drawing.Size(45, 37);
            this.butdividir.TabIndex = 9;
            this.butdividir.Text = "/";
            this.butdividir.UseVisualStyleBackColor = false;
            this.butdividir.Click += new System.EventHandler(this.Butdividir_Click);
            // 
            // btnsubtrair
            // 
            this.btnsubtrair.BackColor = System.Drawing.Color.Lime;
            this.btnsubtrair.FlatAppearance.BorderSize = 0;
            this.btnsubtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnsubtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnsubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubtrair.Location = new System.Drawing.Point(297, 267);
            this.btnsubtrair.Margin = new System.Windows.Forms.Padding(5);
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.Size = new System.Drawing.Size(45, 37);
            this.btnsubtrair.TabIndex = 10;
            this.btnsubtrair.Text = "-";
            this.btnsubtrair.UseVisualStyleBackColor = false;
            this.btnsubtrair.Click += new System.EventHandler(this.Btnsubtrair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Lime;
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnlimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Location = new System.Drawing.Point(472, 300);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(87, 47);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.Btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Lime;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Location = new System.Drawing.Point(472, 370);
            this.btnsair.Margin = new System.Windows.Forms.Padding(5);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(87, 47);
            this.btnsair.TabIndex = 12;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.Btnsair_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms_Calculadora.Properties.Resources.numeros_inteiros;
            this.ClientSize = new System.Drawing.Size(573, 431);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.butdividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.labresultado);
            this.Controls.Add(this.labnumero2);
            this.Controls.Add(this.labnumero1);
            this.Controls.Add(this.labcalculos);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCalc";
            this.Text = "Calculadora Básica";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label labcalculos;
        private System.Windows.Forms.Label labnumero1;
        private System.Windows.Forms.Label labnumero2;
        private System.Windows.Forms.Label labresultado;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button butdividir;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

