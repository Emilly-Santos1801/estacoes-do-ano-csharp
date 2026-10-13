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
    public partial class Frm_Primavera: Form
    {
        public Frm_Primavera()
        {
            InitializeComponent();
        }

        private void Btn_Pratos_Primavera_Click(object sender, EventArgs e)
        {
            Frm_Pratos_Primavera _Pratos_Primavera = new Frm_Pratos_Primavera(); //instanciando
            _Pratos_Primavera.Show(); //abrindo a tela
            Hide(); //fechando
        }

        private void Btn_Lugares_Primavera_Click(object sender, EventArgs e)
        {
            Frm_Lugares_Primavera _Lugares_Primavera = new Frm_Lugares_Primavera() ; //instanciando
            _Lugares_Primavera.Show(); //abrindo a tela
            Hide(); //fechando
        }

        private void Btn_Comidas_Click(object sender, EventArgs e)
        {
            Frm_Comidas_Primavera _Comidas_Primavera = new Frm_Comidas_Primavera(); //instanciando
            _Comidas_Primavera.Show(); //abrindo
            Hide(); //fechando
        }

        private void Btn_Voltar_Lugares_Click(object sender, EventArgs e)
        {
            Frm_Jogo _Jogo = new Frm_Jogo(); //abrir a tela inicial
            _Jogo.Show(); //abrir
            Hide(); //fechando
        }

        private void Frm_Primavera_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.primaverasemborboletas; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando imagem
        }
    }
}
