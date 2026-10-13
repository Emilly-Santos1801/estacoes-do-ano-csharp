namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Pratos_Primavera
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pratos_Primavera));
			this.Btn_Voltar_Lugares = new System.Windows.Forms.Button();
			this.Lbl_Prat_Prima = new System.Windows.Forms.Label();
			this.Lbl_Pratobebi_Prima = new System.Windows.Forms.Label();
			this.Pic_Pratoss = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Pratoss)).BeginInit();
			this.SuspendLayout();
			// 
			// Btn_Voltar_Lugares
			// 
			this.Btn_Voltar_Lugares.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Voltar_Lugares.Location = new System.Drawing.Point(2, 590);
			this.Btn_Voltar_Lugares.Name = "Btn_Voltar_Lugares";
			this.Btn_Voltar_Lugares.Size = new System.Drawing.Size(212, 35);
			this.Btn_Voltar_Lugares.TabIndex = 5;
			this.Btn_Voltar_Lugares.Text = "VOLTAR";
			this.Btn_Voltar_Lugares.UseVisualStyleBackColor = true;
			this.Btn_Voltar_Lugares.Click += new System.EventHandler(this.Btn_Voltar_Lugares_Click);
			// 
			// Lbl_Prat_Prima
			// 
			this.Lbl_Prat_Prima.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Prat_Prima.Font = new System.Drawing.Font("Riffic Free Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Prat_Prima.Location = new System.Drawing.Point(523, -4);
			this.Lbl_Prat_Prima.Name = "Lbl_Prat_Prima";
			this.Lbl_Prat_Prima.Size = new System.Drawing.Size(763, 400);
			this.Lbl_Prat_Prima.TabIndex = 7;
			this.Lbl_Prat_Prima.Text = resources.GetString("Lbl_Prat_Prima.Text");
			this.Lbl_Prat_Prima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Lbl_Pratobebi_Prima
			// 
			this.Lbl_Pratobebi_Prima.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Pratobebi_Prima.Font = new System.Drawing.Font("Riffic Free Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Pratobebi_Prima.Location = new System.Drawing.Point(28, 300);
			this.Lbl_Pratobebi_Prima.Name = "Lbl_Pratobebi_Prima";
			this.Lbl_Pratobebi_Prima.Size = new System.Drawing.Size(469, 290);
			this.Lbl_Pratobebi_Prima.TabIndex = 8;
			this.Lbl_Pratobebi_Prima.Text = "BEBIDAS:\r\nÁgua aromatizada com hortelã e limão 🍋🌿 — leve e hidratante.\r\n\r\nChá g" +
    "elado de frutas vermelhas 🍓 — adoçado naturalmente.\r\n\r\nVitamina de morango 🍓🥛" +
    " — cremosa e doce.";
			this.Lbl_Pratobebi_Prima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Pic_Pratoss
			// 
			this.Pic_Pratoss.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.Kirby;
			this.Pic_Pratoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Pic_Pratoss.Location = new System.Drawing.Point(70, 12);
			this.Pic_Pratoss.Name = "Pic_Pratoss";
			this.Pic_Pratoss.Size = new System.Drawing.Size(333, 285);
			this.Pic_Pratoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Pratoss.TabIndex = 9;
			this.Pic_Pratoss.TabStop = false;
			// 
			// Frm_Pratos_Primavera
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.kerbywallpaperpratros;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1316, 627);
			this.Controls.Add(this.Pic_Pratoss);
			this.Controls.Add(this.Lbl_Pratobebi_Prima);
			this.Controls.Add(this.Lbl_Prat_Prima);
			this.Controls.Add(this.Btn_Voltar_Lugares);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Pratos_Primavera";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PRATOS";
			this.Load += new System.EventHandler(this.Frm_Pratos_Primavera_Load);
			((System.ComponentModel.ISupportInitialize)(this.Pic_Pratoss)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Voltar_Lugares;
        private System.Windows.Forms.Label Lbl_Prat_Prima;
        private System.Windows.Forms.Label Lbl_Pratobebi_Prima;
        private System.Windows.Forms.PictureBox Pic_Pratoss;
    }
}