namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Transicao_Primavera
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
            this.Timer_Transicao_Primavera = new System.Windows.Forms.Timer(this.components);
            this.Pic_Transicao_Primavera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Transicao_Primavera)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Transicao_Primavera
            // 
            this.Timer_Transicao_Primavera.Interval = 5000;
            this.Timer_Transicao_Primavera.Tick += new System.EventHandler(this.Timer_Transicao_Primavera_Tick);
            // 
            // Pic_Transicao_Primavera
            // 
            this.Pic_Transicao_Primavera.Image = global::Projeto_Estações_do_Anoo.Properties.Resources.primaveramelhor_gif;
            this.Pic_Transicao_Primavera.Location = new System.Drawing.Point(-1, -1);
            this.Pic_Transicao_Primavera.Name = "Pic_Transicao_Primavera";
            this.Pic_Transicao_Primavera.Size = new System.Drawing.Size(509, 329);
            this.Pic_Transicao_Primavera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Transicao_Primavera.TabIndex = 0;
            this.Pic_Transicao_Primavera.TabStop = false;
            this.Pic_Transicao_Primavera.Click += new System.EventHandler(this.Pic_Transicao_Primavera_Click);
            // 
            // Frm_Transicao_Primavera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 328);
            this.Controls.Add(this.Pic_Transicao_Primavera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Transicao_Primavera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Frm_Transicao_Primavera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Transicao_Primavera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Transicao_Primavera;
        private System.Windows.Forms.Timer Timer_Transicao_Primavera;
    }
}