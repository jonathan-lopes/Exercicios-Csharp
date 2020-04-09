namespace hello_world_winForms
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
            this.mensagem1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mensagem1
            // 
            this.mensagem1.BackColor = System.Drawing.Color.DarkCyan;
            this.mensagem1.ForeColor = System.Drawing.Color.White;
            this.mensagem1.Location = new System.Drawing.Point(84, 55);
            this.mensagem1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mensagem1.Name = "mensagem1";
            this.mensagem1.Size = new System.Drawing.Size(100, 34);
            this.mensagem1.TabIndex = 0;
            this.mensagem1.Text = "Mensagem";
            this.mensagem1.UseVisualStyleBackColor = false;
            this.mensagem1.Click += new System.EventHandler(this.Mensagem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 152);
            this.Controls.Add(this.mensagem1);
            this.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Olá Mundo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mensagem1;
    }
}

