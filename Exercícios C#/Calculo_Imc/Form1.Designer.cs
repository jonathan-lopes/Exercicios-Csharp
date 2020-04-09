namespace Calculo_Imc
{
    partial class fomr1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fomr1));
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.textBoxpeso = new System.Windows.Forms.TextBox();
            this.textBoxImc = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.labPeso = new System.Windows.Forms.Label();
            this.labAltura = new System.Windows.Forms.Label();
            this.labImc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnverificar.FlatAppearance.BorderSize = 0;
            this.btnverificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnverificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnverificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificar.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificar.Location = new System.Drawing.Point(31, 347);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(75, 42);
            this.btnverificar.TabIndex = 0;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Click += new System.EventHandler(this.Btnverificar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnlimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnlimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpar.Location = new System.Drawing.Point(169, 347);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 42);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.Btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Gainsboro;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(300, 347);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 42);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.Btnsair_Click);
            // 
            // textBoxpeso
            // 
            this.textBoxpeso.Location = new System.Drawing.Point(160, 195);
            this.textBoxpeso.Name = "textBoxpeso";
            this.textBoxpeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxpeso.TabIndex = 3;
            // 
            // textBoxImc
            // 
            this.textBoxImc.Location = new System.Drawing.Point(160, 294);
            this.textBoxImc.Name = "textBoxImc";
            this.textBoxImc.Size = new System.Drawing.Size(100, 20);
            this.textBoxImc.TabIndex = 4;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(160, 244);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 5;
            // 
            // labPeso
            // 
            this.labPeso.AutoSize = true;
            this.labPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPeso.Location = new System.Drawing.Point(19, 198);
            this.labPeso.Name = "labPeso";
            this.labPeso.Size = new System.Drawing.Size(119, 13);
            this.labPeso.TabIndex = 6;
            this.labPeso.Text = "DIGITE SUA PESO:";
            this.labPeso.Click += new System.EventHandler(this.LabPeso_Click);
            // 
            // labAltura
            // 
            this.labAltura.AutoSize = true;
            this.labAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAltura.Location = new System.Drawing.Point(19, 247);
            this.labAltura.Name = "labAltura";
            this.labAltura.Size = new System.Drawing.Size(135, 13);
            this.labAltura.TabIndex = 7;
            this.labAltura.Text = "DIGITE SUA ALTURA:";
            // 
            // labImc
            // 
            this.labImc.AutoSize = true;
            this.labImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labImc.Location = new System.Drawing.Point(19, 294);
            this.labImc.Name = "labImc";
            this.labImc.Size = new System.Drawing.Size(74, 13);
            this.labImc.TabIndex = 8;
            this.labImc.Text = "SEU IMC É:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "CÁLCULO IMC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculo_Imc.Properties.Resources._104554544_gettyimages_483724717;
            this.pictureBox1.Location = new System.Drawing.Point(118, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // fomr1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(399, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labImc);
            this.Controls.Add(this.labAltura);
            this.Controls.Add(this.labPeso);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxImc);
            this.Controls.Add(this.textBoxpeso);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnverificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fomr1";
            this.Text = "Cálculo Imc (By: Jonathan Lopes)";
            this.Load += new System.EventHandler(this.Fomr1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox textBoxpeso;
        private System.Windows.Forms.TextBox textBoxImc;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label labPeso;
        private System.Windows.Forms.Label labAltura;
        private System.Windows.Forms.Label labImc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

