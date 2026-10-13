namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Pratos_Verao
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
			this.Btn_Voltar_Lugares = new System.Windows.Forms.Button();
			this.Lbl_Pratos_Veraooi = new System.Windows.Forms.Label();
			this.Lbl_Bebidas_Verao = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Voltar_Lugares
			// 
			this.Btn_Voltar_Lugares.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Voltar_Lugares.Location = new System.Drawing.Point(2, 590);
			this.Btn_Voltar_Lugares.Name = "Btn_Voltar_Lugares";
			this.Btn_Voltar_Lugares.Size = new System.Drawing.Size(212, 35);
			this.Btn_Voltar_Lugares.TabIndex = 4;
			this.Btn_Voltar_Lugares.Text = "VOLTAR";
			this.Btn_Voltar_Lugares.UseVisualStyleBackColor = true;
			this.Btn_Voltar_Lugares.Click += new System.EventHandler(this.Btn_Voltar_Lugares_Click);
			// 
			// Lbl_Pratos_Veraooi
			// 
			this.Lbl_Pratos_Veraooi.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Pratos_Veraooi.Font = new System.Drawing.Font("Riffic Free Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Pratos_Veraooi.Location = new System.Drawing.Point(667, -1);
			this.Lbl_Pratos_Veraooi.Name = "Lbl_Pratos_Veraooi";
			this.Lbl_Pratos_Veraooi.Size = new System.Drawing.Size(540, 235);
			this.Lbl_Pratos_Veraooi.TabIndex = 5;
			this.Lbl_Pratos_Veraooi.Text = "Água de coco 🥥 — recarrega o “medidor de hidratação”.\r\n\r\nSuco natural de maracuj" +
    "á ou limão 🍋 — refresca e acalma os nervos do jogador.\r\n\r\nChá gelado de hortelã" +
    " 🌿 — aumenta o foco e o bem-estar.\r\n";
			this.Lbl_Pratos_Veraooi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Lbl_Bebidas_Verao
			// 
			this.Lbl_Bebidas_Verao.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Bebidas_Verao.Font = new System.Drawing.Font("Riffic Free Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Bebidas_Verao.Location = new System.Drawing.Point(102, 9);
			this.Lbl_Bebidas_Verao.Name = "Lbl_Bebidas_Verao";
			this.Lbl_Bebidas_Verao.Size = new System.Drawing.Size(476, 234);
			this.Lbl_Bebidas_Verao.TabIndex = 6;
			this.Lbl_Bebidas_Verao.Text = "Arroz e feijão 🍛 — o combo clássico brasileiro!\r\n\r\nFrango grelhado com legumes 🍗" +
    "🥦 — leve, saboroso e fácil de digerir.\r\n\r\n\r\nPeixe assado com limão 🐠 — rico e" +
    "m ômega-3 e com sabor refrescante.\r\n";
			this.Lbl_Bebidas_Verao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Frm_Pratos_Verao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.Pratos_PNG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1316, 627);
			this.Controls.Add(this.Lbl_Bebidas_Verao);
			this.Controls.Add(this.Lbl_Pratos_Veraooi);
			this.Controls.Add(this.Btn_Voltar_Lugares);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Pratos_Verao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pratos";
			this.Load += new System.EventHandler(this.Frm_Pratos_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Voltar_Lugares;
        private System.Windows.Forms.Label Lbl_Pratos_Veraooi;
        private System.Windows.Forms.Label Lbl_Bebidas_Verao;
    }
}