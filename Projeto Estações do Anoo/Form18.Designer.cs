namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Transicao_Inverno
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
			this.components = new System.ComponentModel.Container();
			this.Timer_Transicao_Inverno = new System.Windows.Forms.Timer(this.components);
			this.Pic_Inverno_Gif = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Pic_Inverno_Gif)).BeginInit();
			this.SuspendLayout();
			// 
			// Timer_Transicao_Inverno
			// 
			this.Timer_Transicao_Inverno.Tick += new System.EventHandler(this.Timer_Transicao_Inverno_Tick);
			// 
			// Pic_Inverno_Gif
			// 
			this.Pic_Inverno_Gif.Image = global::Projeto_Estações_do_Anoo.Properties.Resources.mariofrio_gif;
			this.Pic_Inverno_Gif.Location = new System.Drawing.Point(-1, -2);
			this.Pic_Inverno_Gif.Name = "Pic_Inverno_Gif";
			this.Pic_Inverno_Gif.Size = new System.Drawing.Size(514, 351);
			this.Pic_Inverno_Gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Inverno_Gif.TabIndex = 0;
			this.Pic_Inverno_Gif.TabStop = false;
			this.Pic_Inverno_Gif.Click += new System.EventHandler(this.Pic_Inverno_Gif_Click);
			// 
			// Frm_Transicao_Inverno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 330);
			this.Controls.Add(this.Pic_Inverno_Gif);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Transicao_Inverno";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form18";
			this.Load += new System.EventHandler(this.Frm_Transicao_Inverno_Load);
			((System.ComponentModel.ISupportInitialize)(this.Pic_Inverno_Gif)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Transicao_Inverno;
        private System.Windows.Forms.PictureBox Pic_Inverno_Gif;
    }
}