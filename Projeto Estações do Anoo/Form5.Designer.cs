namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Comidas_Verao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Comidas_Verao));
			this.Lbl_Texto_Comidas = new System.Windows.Forms.Label();
			this.Pic_Mario_Agua = new System.Windows.Forms.PictureBox();
			this.Lbl_Agua = new System.Windows.Forms.Label();
			this.Btn_Voltar_Comidas = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Mario_Agua)).BeginInit();
			this.SuspendLayout();
			// 
			// Lbl_Texto_Comidas
			// 
			this.Lbl_Texto_Comidas.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Texto_Comidas.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Texto_Comidas.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Lbl_Texto_Comidas.Location = new System.Drawing.Point(257, 9);
			this.Lbl_Texto_Comidas.Name = "Lbl_Texto_Comidas";
			this.Lbl_Texto_Comidas.Size = new System.Drawing.Size(976, 257);
			this.Lbl_Texto_Comidas.TabIndex = 0;
			this.Lbl_Texto_Comidas.Text = resources.GetString("Lbl_Texto_Comidas.Text");
			this.Lbl_Texto_Comidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Lbl_Texto_Comidas.Click += new System.EventHandler(this.Lbl_Texto_Comidas_Click);
			// 
			// Pic_Mario_Agua
			// 
			this.Pic_Mario_Agua.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.mario_Agua_Jpg;
			this.Pic_Mario_Agua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Pic_Mario_Agua.Location = new System.Drawing.Point(42, 12);
			this.Pic_Mario_Agua.Name = "Pic_Mario_Agua";
			this.Pic_Mario_Agua.Size = new System.Drawing.Size(209, 194);
			this.Pic_Mario_Agua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Mario_Agua.TabIndex = 1;
			this.Pic_Mario_Agua.TabStop = false;
			this.Pic_Mario_Agua.Click += new System.EventHandler(this.Pic_Mario_Agua_Click);
			// 
			// Lbl_Agua
			// 
			this.Lbl_Agua.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Agua.Font = new System.Drawing.Font("Riffic Free Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Agua.Location = new System.Drawing.Point(44, 215);
			this.Lbl_Agua.Name = "Lbl_Agua";
			this.Lbl_Agua.Size = new System.Drawing.Size(207, 51);
			this.Lbl_Agua.TabIndex = 2;
			this.Lbl_Agua.Text = "E NÃO SE ESQUEÇA, SEMPRE BEBA ÁGUA!";
			this.Lbl_Agua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Btn_Voltar_Comidas
			// 
			this.Btn_Voltar_Comidas.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Voltar_Comidas.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Voltar_Comidas.Location = new System.Drawing.Point(12, 580);
			this.Btn_Voltar_Comidas.Name = "Btn_Voltar_Comidas";
			this.Btn_Voltar_Comidas.Size = new System.Drawing.Size(212, 35);
			this.Btn_Voltar_Comidas.TabIndex = 3;
			this.Btn_Voltar_Comidas.Text = "VOLTAR";
			this.Btn_Voltar_Comidas.UseVisualStyleBackColor = false;
			this.Btn_Voltar_Comidas.Click += new System.EventHandler(this.Btn_Voltar_Comidas_Click);
			// 
			// Frm_Comidas_Verao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.carrinhos_Png;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1316, 627);
			this.Controls.Add(this.Btn_Voltar_Comidas);
			this.Controls.Add(this.Lbl_Agua);
			this.Controls.Add(this.Pic_Mario_Agua);
			this.Controls.Add(this.Lbl_Texto_Comidas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Comidas_Verao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "COMIDAS VERÃO";
			this.Load += new System.EventHandler(this.Frm_Comidas_Verao_Load);
			((System.ComponentModel.ISupportInitialize)(this.Pic_Mario_Agua)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Texto_Comidas;
        private System.Windows.Forms.PictureBox Pic_Mario_Agua;
        private System.Windows.Forms.Label Lbl_Agua;
        private System.Windows.Forms.Button Btn_Voltar_Comidas;
    }
}