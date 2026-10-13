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
    public partial class Frm_Transicao_Outono: Form
    {
        public Frm_Transicao_Outono()
        {
            InitializeComponent();
        }

        private void Frm_Transicao_Outono_Load(object sender, EventArgs e)
        {
			Timer_Transicao_Outono .Interval = 4000;
			Timer_Transicao_Outono .Start();

			Pic_Transicao_Outono.Image = Properties.Resources.outono_gif_dinossaurinho; //adicionando imagem 
		}

        private void Pic_Transicao_Outono_Click(object sender, EventArgs e)
        {
           
        }

        private void Timer_Transicao_Outono_Tick(object sender, EventArgs e)
        {
			Timer_Transicao_Outono .Stop(); //parando o timer
            Frm_Outono frm_Outono = new Frm_Outono(); //instanciando
            frm_Outono.Show();
            Hide(); 
		}
    }
}
