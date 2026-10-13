namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Transição
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
            this.Timer_Dois_Verao = new System.Windows.Forms.Timer(this.components);
            this.Pic_Verao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Verao)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Dois_Verao
            // 
            this.Timer_Dois_Verao.Interval = 5000;
            this.Timer_Dois_Verao.Tick += new System.EventHandler(this.Timer_Dois_Verao_Tick);
            // 
            // Pic_Verao
            // 
            this.Pic_Verao.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.Verao_gif_1;
            this.Pic_Verao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Verao.Location = new System.Drawing.Point(0, 0);
            this.Pic_Verao.Name = "Pic_Verao";
            this.Pic_Verao.Size = new System.Drawing.Size(519, 367);
            this.Pic_Verao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Verao.TabIndex = 0;
            this.Pic_Verao.TabStop = false;
            this.Pic_Verao.Click += new System.EventHandler(this.Pic_Verao_Click);
            // 
            // Frm_Transição
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 364);
            this.Controls.Add(this.Pic_Verao);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Frm_Transição";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transição";
            this.Load += new System.EventHandler(this.Frm_Transição_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Verao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Dois_Verao;
        private System.Windows.Forms.PictureBox Pic_Verao;
    }
}