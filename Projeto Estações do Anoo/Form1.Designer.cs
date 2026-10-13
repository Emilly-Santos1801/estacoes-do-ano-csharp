namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Abertura
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
			this.Btn_Jogar = new System.Windows.Forms.Button();
			this.Btn_Opcoes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Btn_Jogar
			// 
			this.Btn_Jogar.BackColor = System.Drawing.Color.LightBlue;
			this.Btn_Jogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Jogar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Btn_Jogar.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Jogar.Location = new System.Drawing.Point(263, 332);
			this.Btn_Jogar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Btn_Jogar.Name = "Btn_Jogar";
			this.Btn_Jogar.Size = new System.Drawing.Size(239, 49);
			this.Btn_Jogar.TabIndex = 0;
			this.Btn_Jogar.Text = "JOGAR";
			this.Btn_Jogar.UseVisualStyleBackColor = false;
			this.Btn_Jogar.Click += new System.EventHandler(this.Btn_Jogar_Click);
			// 
			// Btn_Opcoes
			// 
			this.Btn_Opcoes.BackColor = System.Drawing.Color.LightBlue;
			this.Btn_Opcoes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Btn_Opcoes.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Opcoes.Location = new System.Drawing.Point(927, 332);
			this.Btn_Opcoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Btn_Opcoes.Name = "Btn_Opcoes";
			this.Btn_Opcoes.Size = new System.Drawing.Size(239, 49);
			this.Btn_Opcoes.TabIndex = 1;
			this.Btn_Opcoes.Text = "FECHAR JOGO";
			this.Btn_Opcoes.UseVisualStyleBackColor = false;
			this.Btn_Opcoes.Click += new System.EventHandler(this.Btn_Opcoes_Click);
			// 
			// Frm_Abertura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.estações_do_ano_muio_melhor;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1316, 627);
			this.Controls.Add(this.Btn_Opcoes);
			this.Controls.Add(this.Btn_Jogar);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Frm_Abertura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Abertura";
			this.Load += new System.EventHandler(this.Frm_Abertura_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Jogar;
        private System.Windows.Forms.Button Btn_Opcoes;
    }
}

