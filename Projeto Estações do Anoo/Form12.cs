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
    public partial class Frm_Transicao_Primavera: Form
    {
        public Frm_Transicao_Primavera()
        {
            InitializeComponent();
        }

        private void Pic_Transicao_Primavera_Click(object sender, EventArgs e)
        {
 
        }

        private void Timer_Transicao_Primavera_Tick(object sender, EventArgs e)
        {

            Timer_Transicao_Primavera.Stop(); //parando o timer
			Frm_Primavera _Primavera = new Frm_Primavera(); //instanciando
            _Primavera.Show(); //abrir tela
			this.Hide(); //fechando formulario

        }

        private void Frm_Transicao_Primavera_Load(object sender, EventArgs e)
        {

			Timer_Transicao_Primavera.Interval = 4000;
			Timer_Transicao_Primavera.Start();

            Pic_Transicao_Primavera.Image = Properties.Resources.primaveramelhor_gif;//adicionando
        }
    }
}
