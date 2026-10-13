namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Transicao_Outono
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
			this.Pic_Transicao_Outono = new System.Windows.Forms.PictureBox();
			this.Timer_Transicao_Outono = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Pic_Transicao_Outono)).BeginInit();
			this.SuspendLayout();
			// 
			// Pic_Transicao_Outono
			// 
			this.Pic_Transicao_Outono.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.outono_gif_dinossaurinho;
			this.Pic_Transicao_Outono.Location = new System.Drawing.Point(-1, -2);
			this.Pic_Transicao_Outono.Name = "Pic_Transicao_Outono";
			this.Pic_Transicao_Outono.Size = new System.Drawing.Size(507, 330);
			this.Pic_Transicao_Outono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Transicao_Outono.TabIndex = 0;
			this.Pic_Transicao_Outono.TabStop = false;
			this.Pic_Transicao_Outono.Click += new System.EventHandler(this.Pic_Transicao_Outono_Click);
			// 
			// Timer_Transicao_Outono
			// 
			this.Timer_Transicao_Outono.Tick += new System.EventHandler(this.Timer_Transicao_Outono_Tick);
			// 
			// Frm_Transicao_Outono
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 328);
			this.Controls.Add(this.Pic_Transicao_Outono);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Transicao_Outono";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form17";
			this.Load += new System.EventHandler(this.Frm_Transicao_Outono_Load);
			((System.ComponentModel.ISupportInitialize)(this.Pic_Transicao_Outono)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Transicao_Outono;
        private System.Windows.Forms.Timer Timer_Transicao_Outono;
    }
}