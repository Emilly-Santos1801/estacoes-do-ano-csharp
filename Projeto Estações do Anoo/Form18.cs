using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Estações_do_Anoo
{
    public partial class Frm_Transicao_Inverno: Form
    {
        public Frm_Transicao_Inverno()
        {
            InitializeComponent();
        }

        private void Frm_Transicao_Inverno_Load(object sender, EventArgs e)
        {
			Timer_Transicao_Inverno.Interval = 4000; //intervalo de tempo do timer
			Timer_Transicao_Inverno.Start(); //iniciando o timer
			Pic_Inverno_Gif.Image = Properties.Resources.mariofrio_gif; //abrindo imagem
        }

        private void Timer_Transicao_Inverno_Tick(object sender, EventArgs e)
        {
            Timer_Transicao_Inverno.Stop(); 
			Frm_Inverno frm_Inverno = new Frm_Inverno();//instanciando
			frm_Inverno.Show();//abrindo
			Hide();
		}

        private void Pic_Inverno_Gif_Click(object sender, EventArgs e)
        {

        }
    }
}
