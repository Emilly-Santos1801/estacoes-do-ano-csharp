namespace Projeto_Estações_do_Anoo
{
    partial class Frm_Jogo
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
			this.Btn_Primavera = new System.Windows.Forms.Button();
			this.Btn_Verao = new System.Windows.Forms.Button();
			this.Btn_Outono = new System.Windows.Forms.Button();
			this.Btn_Inverno = new System.Windows.Forms.Button();
			this.Txt_Texto_De_Inicio = new System.Windows.Forms.TextBox();
			this.Timer_Um = new System.Windows.Forms.Timer(this.components);
			this.Timer_Primavera = new System.Windows.Forms.Timer(this.components);
			this.Btn_Voltar_Verao_Jogo = new System.Windows.Forms.Button();
			this.Timer_Outono = new System.Windows.Forms.Timer(this.components);
			this.Timer_Inverno = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// Btn_Primavera
			// 
			this.Btn_Primavera.BackColor = System.Drawing.Color.SkyBlue;
			this.Btn_Primavera.Font = new System.Drawing.Font("Riffic Free Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Primavera.Location = new System.Drawing.Point(782, 226);
			this.Btn_Primavera.Name = "Btn_Primavera";
			this.Btn_Primavera.Size = new System.Drawing.Size(341, 83);
			this.Btn_Primavera.TabIndex = 0;
			this.Btn_Primavera.Text = "PRIMAVERA";
			this.Btn_Primavera.UseVisualStyleBackColor = false;
			this.Btn_Primavera.Click += new System.EventHandler(this.Btn_Primavera_Click);
			// 
			// Btn_Verao
			// 
			this.Btn_Verao.BackColor = System.Drawing.Color.SkyBlue;
			this.Btn_Verao.Font = new System.Drawing.Font("Riffic Free Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Verao.Location = new System.Drawing.Point(45, 96);
			this.Btn_Verao.Name = "Btn_Verao";
			this.Btn_Verao.Size = new System.Drawing.Size(341, 79);
			this.Btn_Verao.TabIndex = 1;
			this.Btn_Verao.Text = "VERÃO";
			this.Btn_Verao.UseVisualStyleBackColor = false;
			this.Btn_Verao.Click += new System.EventHandler(this.Btn_Verao_Click);
			// 
			// Btn_Outono
			// 
			this.Btn_Outono.BackColor = System.Drawing.Color.SkyBlue;
			this.Btn_Outono.Font = new System.Drawing.Font("Riffic Free Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Outono.Location = new System.Drawing.Point(278, 226);
			this.Btn_Outono.Name = "Btn_Outono";
			this.Btn_Outono.Size = new System.Drawing.Size(341, 77);
			this.Btn_Outono.TabIndex = 2;
			this.Btn_Outono.Text = "OUTONO";
			this.Btn_Outono.UseVisualStyleBackColor = false;
			this.Btn_Outono.Click += new System.EventHandler(this.Btn_Outono_Click);
			// 
			// Btn_Inverno
			// 
			this.Btn_Inverno.BackColor = System.Drawing.Color.SkyBlue;
			this.Btn_Inverno.Font = new System.Drawing.Font("Riffic Free Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Inverno.Location = new System.Drawing.Point(935, 83);
			this.Btn_Inverno.Name = "Btn_Inverno";
			this.Btn_Inverno.Size = new System.Drawing.Size(341, 83);
			this.Btn_Inverno.TabIndex = 3;
			this.Btn_Inverno.Text = "INVERNO";
			this.Btn_Inverno.UseVisualStyleBackColor = false;
			this.Btn_Inverno.Click += new System.EventHandler(this.Btn_Inverno_Click);
			// 
			// Txt_Texto_De_Inicio
			// 
			this.Txt_Texto_De_Inicio.BackColor = System.Drawing.Color.Snow;
			this.Txt_Texto_De_Inicio.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_Texto_De_Inicio.Location = new System.Drawing.Point(873, 566);
			this.Txt_Texto_De_Inicio.Multiline = true;
			this.Txt_Texto_De_Inicio.Name = "Txt_Texto_De_Inicio";
			this.Txt_Texto_De_Inicio.Size = new System.Drawing.Size(444, 61);
			this.Txt_Texto_De_Inicio.TabIndex = 5;
			this.Txt_Texto_De_Inicio.Text = "APERTE EM UMA DAS FASES E DESCUBRA O QUE TEM ATRÁS DE CADA UMA DELAS!";
			// 
			// Timer_Um
			// 
			this.Timer_Um.Tick += new System.EventHandler(this.Timer_Um_Tick);
			// 
			// Timer_Primavera
			// 
			this.Timer_Primavera.Tick += new System.EventHandler(this.Timer_Primavera_Tick);
			// 
			// Btn_Voltar_Verao_Jogo
			// 
			this.Btn_Voltar_Verao_Jogo.Font = new System.Drawing.Font("Riffic Free Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Voltar_Verao_Jogo.Location = new System.Drawing.Point(2, 592);
			this.Btn_Voltar_Verao_Jogo.Name = "Btn_Voltar_Verao_Jogo";
			this.Btn_Voltar_Verao_Jogo.Size = new System.Drawing.Size(212, 35);
			this.Btn_Voltar_Verao_Jogo.TabIndex = 6;
			this.Btn_Voltar_Verao_Jogo.Text = "VOLTAR";
			this.Btn_Voltar_Verao_Jogo.UseVisualStyleBackColor = true;
			this.Btn_Voltar_Verao_Jogo.Click += new System.EventHandler(this.Btn_Voltar_Verao_Jogo_Click);
			// 
			// Timer_Outono
			// 
			this.Timer_Outono.Tick += new System.EventHandler(this.Timer_Outono_Tick);
			// 
			// Timer_Inverno
			// 
			this.Timer_Inverno.Tick += new System.EventHandler(this.Timer_Inverno_Tick);
			// 
			// Frm_Jogo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImage = global::Projeto_Estações_do_Anoo.Properties.Resources.ininici_mariono;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1316, 627);
			this.Controls.Add(this.Btn_Voltar_Verao_Jogo);
			this.Controls.Add(this.Txt_Texto_De_Inicio);
			this.Controls.Add(this.Btn_Inverno);
			this.Controls.Add(this.Btn_Outono);
			this.Controls.Add(this.Btn_Verao);
			this.Controls.Add(this.Btn_Primavera);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Jogo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jogo";
			this.Load += new System.EventHandler(this.Frm_Jogo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Primavera;
        private System.Windows.Forms.Button Btn_Verao;
        private System.Windows.Forms.Button Btn_Outono;
        private System.Windows.Forms.Button Btn_Inverno;
        private System.Windows.Forms.TextBox Txt_Texto_De_Inicio;
        private System.Windows.Forms.Timer Timer_Um;
        private System.Windows.Forms.Timer Timer_Primavera;
        private System.Windows.Forms.Button Btn_Voltar_Verao_Jogo;
        private System.Windows.Forms.Timer Timer_Outono;
        private System.Windows.Forms.Timer Timer_Inverno;
    }
}