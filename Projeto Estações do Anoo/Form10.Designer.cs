namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Lugares_Primavera
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Lugares_Primavera));
			this.Btn_Voltar_Lugares = new System.Windows.Forms.Button();
			this.Lbl_Lugaresii = new System.Windows.Forms.Label();
			this.Pic_Jardim = new System.Windows.Forms.PictureBox();
			this.Pic_Parquer = new System.Windows.Forms.PictureBox();
			this.Pic_Feirinha = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Jardim)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Parquer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Feirinha)).BeginInit();
			this.SuspendLayout();
			// 
			// Btn_Voltar_Lugares
			// 
			this.Btn_Voltar_Lugares.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Voltar_Lugares.Location = new System.Drawing.Point(1, 589);
			this.Btn_Voltar_Lugares.Name = "Btn_Voltar_Lugares";
			this.Btn_Voltar_Lugares.Size = new System.Drawing.Size(212, 35);
			this.Btn_Voltar_Lugares.TabIndex = 5;
			this.Btn_Voltar_Lugares.Text = "VOLTAR";
			this.Btn_Voltar_Lugares.UseVisualStyleBackColor = true;
			this.Btn_Voltar_Lugares.Click += new System.EventHandler(this.Btn_Voltar_Lugares_Click);
			// 
			// Lbl_Lugaresii
			// 
			this.Lbl_Lugaresii.BackColor = System.Drawing.Color.Transparent;
			this.Lbl_Lugaresii.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Lugaresii.Location = new System.Drawing.Point(257, 9);
			this.Lbl_Lugaresii.Name = "Lbl_Lugaresii";
			this.Lbl_Lugaresii.Size = new System.Drawing.Size(970, 438);
			this.Lbl_Lugaresii.TabIndex = 7;
			this.Lbl_Lugaresii.Text = resources.GetString("Lbl_Lugaresii.Text");
			this.Lbl_Lugaresii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Lbl_Lugaresii.Click += new System.EventHandler(this.Lbl_Lugaresii_Click);
			// 
			// Pic_Jardim
			// 
			this.Pic_Jardim.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.jardimbotanico;
			this.Pic_Jardim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Pic_Jardim.Location = new System.Drawing.Point(116, 19);
			this.Pic_Jardim.Name = "Pic_Jardim";
			this.Pic_Jardim.Size = new System.Drawing.Size(135, 106);
			this.Pic_Jardim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Jardim.TabIndex = 8;
			this.Pic_Jardim.TabStop = false;
			this.Pic_Jardim.Click += new System.EventHandler(this.Pic_Jardim_Click);
			// 
			// Pic_Parquer
			// 
			this.Pic_Parquer.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.parque_do_carmo;
			this.Pic_Parquer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Pic_Parquer.Location = new System.Drawing.Point(116, 173);
			this.Pic_Parquer.Name = "Pic_Parquer";
			this.Pic_Parquer.Size = new System.Drawing.Size(135, 104);
			this.Pic_Parquer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Parquer.TabIndex = 9;
			this.Pic_Parquer.TabStop = false;
			// 
			// Pic_Feirinha
			// 
			this.Pic_Feirinha.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.feirinhaprimavera;
			this.Pic_Feirinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Pic_Feirinha.Location = new System.Drawing.Point(116, 331);
			this.Pic_Feirinha.Name = "Pic_Feirinha";
			this.Pic_Feirinha.Size = new System.Drawing.Size(135, 105);
			this.Pic_Feirinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Feirinha.TabIndex = 10;
			this.Pic_Feirinha.TabStop = false;
			// 
			// Frm_Lugares_Primavera
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.kirby_wallpaper_jpg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1316, 627);
			this.Controls.Add(this.Pic_Feirinha);
			this.Controls.Add(this.Pic_Parquer);
			this.Controls.Add(this.Pic_Jardim);
			this.Controls.Add(this.Lbl_Lugaresii);
			this.Controls.Add(this.Btn_Voltar_Lugares);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Lugares_Primavera";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LUGARES";
			this.Load += new System.EventHandler(this.Frm_Lugares_Primavera_Load);
			((System.ComponentModel.ISupportInitialize)(this.Pic_Jardim)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Parquer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Feirinha)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Voltar_Lugares;
        private System.Windows.Forms.Label Lbl_Lugaresii;
        private System.Windows.Forms.PictureBox Pic_Jardim;
        private System.Windows.Forms.PictureBox Pic_Parquer;
        private System.Windows.Forms.PictureBox Pic_Feirinha;
    }
}