namespace Condição_if
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
            this.labIdade = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labIdade
            // 
            this.labIdade.AutoSize = true;
            this.labIdade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdade.Location = new System.Drawing.Point(55, 22);
            this.labIdade.Name = "labIdade";
            this.labIdade.Size = new System.Drawing.Size(158, 22);
            this.labIdade.TabIndex = 0;
            this.labIdade.Text = "Digite sua idade";
            this.labIdade.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(83, 73);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(99, 129);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(70, 38);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar idade";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(274, 188);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.labIdade);
            this.Name = "Form1";
            this.Text = "Verificador de Idade (by:Jonathan lopes)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labIdade;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnVerificar;
    }
}

