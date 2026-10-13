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
    public partial class Frm_Transição: Form
    {
        public Frm_Transição()
        {
            InitializeComponent();
        }

        private void Frm_Transição_Load(object sender, EventArgs e)
        {
			// define o tempo da transição (4 segundos)
			Timer_Dois_Verao.Interval = 4000;

			// inicia o timer
			Timer_Dois_Verao.Start();

            Pic_Verao.Image = Properties.Resources.Verao_gif_1; //adicionando a picture a imagem
        }

        private void Timer_Dois_Verao_Tick(object sender, EventArgs e)
        {
			// para o timer para não repetir
			Timer_Dois_Verao.Stop();

			// abre a tela do verão
			Frm_Verão _Verão = new Frm_Verão();
			_Verão.Show();

			// esconde a tela de transição
			this.Hide();


		}

        private void Pic_Verao_Click(object sender, EventArgs e)
        {

        }
    }
}
