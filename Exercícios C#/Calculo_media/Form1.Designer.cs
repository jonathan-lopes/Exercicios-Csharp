namespace Calculo_media
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncalcular = new System.Windows.Forms.Button();
            this.labN1 = new System.Windows.Forms.Label();
            this.labN2 = new System.Windows.Forms.Label();
            this.labN3 = new System.Windows.Forms.Label();
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.textNota3 = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Label();
            this.labMedia = new System.Windows.Forms.Label();
            this.textMedia = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btncalcular.FlatAppearance.BorderSize = 0;
            this.btncalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btncalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btncalcular.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(12, 235);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(78, 25);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Cálcular ";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // labN1
            // 
            this.labN1.AutoSize = true;
            this.labN1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labN1.Location = new System.Drawing.Point(24, 90);
            this.labN1.Name = "labN1";
            this.labN1.Size = new System.Drawing.Size(109, 15);
            this.labN1.TabIndex = 1;
            this.labN1.Text = "Digite  a 1º Nota";
            // 
            // labN2
            // 
            this.labN2.AutoSize = true;
            this.labN2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labN2.Location = new System.Drawing.Point(24, 135);
            this.labN2.Name = "labN2";
            this.labN2.Size = new System.Drawing.Size(109, 15);
            this.labN2.TabIndex = 2;
            this.labN2.Text = "Digite  a 2º Nota";
            // 
            // labN3
            // 
            this.labN3.AutoSize = true;
            this.labN3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labN3.Location = new System.Drawing.Point(24, 178);
            this.labN3.Name = "labN3";
            this.labN3.Size = new System.Drawing.Size(109, 15);
            this.labN3.TabIndex = 3;
            this.labN3.Text = "Digite  a 3º Nota";
            this.labN3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textNota1
            // 
            this.textNota1.Location = new System.Drawing.Point(139, 88);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(81, 20);
            this.textNota1.TabIndex = 4;
            // 
            // textNota2
            // 
            this.textNota2.Location = new System.Drawing.Point(139, 130);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(81, 20);
            this.textNota2.TabIndex = 5;
            this.textNota2.TextChanged += new System.EventHandler(this.TextNota2_TextChanged);
            // 
            // textNota3
            // 
            this.textNota3.Location = new System.Drawing.Point(139, 173);
            this.textNota3.Name = "textNota3";
            this.textNota3.Size = new System.Drawing.Size(81, 20);
            this.textNota3.TabIndex = 6;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(22, 19);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(259, 28);
            this.C.TabIndex = 7;
            this.C.Text = "Cálculo de Média do Aluno";
            // 
            // labMedia
            // 
            this.labMedia.AutoSize = true;
            this.labMedia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMedia.Location = new System.Drawing.Point(62, 279);
            this.labMedia.Name = "labMedia";
            this.labMedia.Size = new System.Drawing.Size(49, 15);
            this.labMedia.TabIndex = 8;
            this.labMedia.Text = "Média";
            // 
            // textMedia
            // 
            this.textMedia.Location = new System.Drawing.Point(117, 277);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(100, 20);
            this.textMedia.TabIndex = 9;
            // 
            // btnlimpar
            // 
            this.btnlimpar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnlimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnlimpar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(117, 235);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(78, 25);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.Btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnsair.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(221, 235);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(78, 25);
            this.btnsair.TabIndex = 11;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.Btnsair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(311, 303);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.textMedia);
            this.Controls.Add(this.labMedia);
            this.Controls.Add(this.C);
            this.Controls.Add(this.textNota3);
            this.Controls.Add(this.textNota2);
            this.Controls.Add(this.textNota1);
            this.Controls.Add(this.labN3);
            this.Controls.Add(this.labN2);
            this.Controls.Add(this.labN1);
            this.Controls.Add(this.btncalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Cálculo de Média (By:Jonathan Lopes)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label labN1;
        private System.Windows.Forms.Label labN2;
        private System.Windows.Forms.Label labN3;
        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.TextBox textNota3;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label labMedia;
        private System.Windows.Forms.TextBox textMedia;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

