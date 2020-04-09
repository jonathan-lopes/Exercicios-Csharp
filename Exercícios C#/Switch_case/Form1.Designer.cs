namespace Switch_case
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
            this.cboSemana = new System.Windows.Forms.ComboBox();
            this.labDia = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboSemana
            // 
            this.cboSemana.FormattingEnabled = true;
            this.cboSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
            this.cboSemana.Location = new System.Drawing.Point(89, 115);
            this.cboSemana.Name = "cboSemana";
            this.cboSemana.Size = new System.Drawing.Size(121, 21);
            this.cboSemana.TabIndex = 0;
            this.cboSemana.SelectedIndexChanged += new System.EventHandler(this.CboSemana_SelectedIndexChanged);
            // 
            // labDia
            // 
            this.labDia.AutoSize = true;
            this.labDia.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDia.Location = new System.Drawing.Point(24, 28);
            this.labDia.Name = "labDia";
            this.labDia.Size = new System.Drawing.Size(268, 29);
            this.labDia.TabIndex = 1;
            this.labDia.Text = "Escolha o dia da semana";
            // 
            // btnProximo
            // 
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnProximo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(217, 236);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(81, 43);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "Próximo  Exemplo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(315, 310);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.labDia);
            this.Controls.Add(this.cboSemana);
            this.Location = new System.Drawing.Point(96, 140);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Switch Case";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSemana;
        private System.Windows.Forms.Label labDia;
        private System.Windows.Forms.Button btnProximo;
    }
}

