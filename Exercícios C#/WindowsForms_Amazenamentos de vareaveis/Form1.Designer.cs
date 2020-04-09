namespace WindowsForms_Amazenamentos_de_vareaveis
{
    partial class Formteste
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClique = new System.Windows.Forms.Button();
            this.textnome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Testa Variavel";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClique.Location = new System.Drawing.Point(58, 187);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(117, 38);
            this.btnClique.TabIndex = 1;
            this.btnClique.Text = "Clique aqui!";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.BtnClique_Click);
            // 
            // textnome
            // 
            this.textnome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnome.Location = new System.Drawing.Point(37, 104);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(156, 20);
            this.textnome.TabIndex = 2;
            // 
            // Formteste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 237);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.label1);
            this.Name = "Formteste";
            this.Text = "Teste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.TextBox textnome;
    }
}

