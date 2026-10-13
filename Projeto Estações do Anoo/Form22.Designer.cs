namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Pratos_Invernooo
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
			this.Btn_Pratos_Invernioo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Pratos_Invernioo
			// 
			this.Btn_Pratos_Invernioo.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Pratos_Invernioo.Location = new System.Drawing.Point(2, 592);
			this.Btn_Pratos_Invernioo.Name = "Btn_Pratos_Invernioo";
			this.Btn_Pratos_Invernioo.Size = new System.Drawing.Size(212, 35);
			this.Btn_Pratos_Invernioo.TabIndex = 10;
			this.Btn_Pratos_Invernioo.Text = "VOLTAR";
			this.Btn_Pratos_Invernioo.UseVisualStyleBackColor = true;
			this.Btn_Pratos_Invernioo.Click += new System.EventHandler(this.Btn_Pratos_Invernioo_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Riffic Free Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(491, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 293);
			this.label1.TabIndex = 11;
			this.label1.Text = "Feijoada completa 🍲 — sabor marcante e calor que dura até o boss final.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Riffic Free Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(30, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(252, 227);
			this.label2.TabIndex = 12;
			this.label2.Text = "Lasanha de carne ou frango 🍝 — camadas de sabor e poder.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Riffic Free Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(1049, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(226, 355);
			this.label3.TabIndex = 13;
			this.label3.Text = "Sopa de legumes com frango 🥕🍗 — leve, nutritiva e perfeita para aquecer sem exa" +
    "gerar.";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Frm_Pratos_Invernooo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.marioeluigii;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1316, 627);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Btn_Pratos_Invernioo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Pratos_Invernooo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form22";
			this.Load += new System.EventHandler(this.Frm_Pratos_Invernooo_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Pratos_Invernioo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}