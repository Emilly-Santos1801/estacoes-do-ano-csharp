namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Comidas_Outono
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Comidas_Outono));
			this.Btn_Voltar_Comidas_Outonoi = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Voltar_Comidas_Outonoi
			// 
			this.Btn_Voltar_Comidas_Outonoi.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Voltar_Comidas_Outonoi.Location = new System.Drawing.Point(2, 592);
			this.Btn_Voltar_Comidas_Outonoi.Name = "Btn_Voltar_Comidas_Outonoi";
			this.Btn_Voltar_Comidas_Outonoi.Size = new System.Drawing.Size(212, 35);
			this.Btn_Voltar_Comidas_Outonoi.TabIndex = 8;
			this.Btn_Voltar_Comidas_Outonoi.Text = "VOLTAR";
			this.Btn_Voltar_Comidas_Outonoi.UseVisualStyleBackColor = true;
			this.Btn_Voltar_Comidas_Outonoi.Click += new System.EventHandler(this.Btn_Voltar_Comidas_Outonoi_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Riffic Free Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(861, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(433, 331);
			this.label1.TabIndex = 9;
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Riffic Free Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(12, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(454, 322);
			this.label2.TabIndex = 10;
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Frm_Comidas_Outono
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.Yoshi_no_piquenique_de_outono;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1316, 627);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Btn_Voltar_Comidas_Outonoi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Comidas_Outono";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "COMIDAS";
			this.Load += new System.EventHandler(this.Frm_Comidas_Outono_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Voltar_Comidas_Outonoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}