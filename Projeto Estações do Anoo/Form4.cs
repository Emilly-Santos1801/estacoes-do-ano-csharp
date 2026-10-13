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
    public partial class Frm_Verão: Form
    {
        public Frm_Verão()
        {
            InitializeComponent();
        }

        private void Frm_Verão_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Verao_Semelemento_PNG; //adicionando imagem
            BackgroundImageLayout = ImageLayout.Stretch; //arrumando a imagem
        }

        private void Btn_Pratos_Click(object sender, EventArgs e)
        {
            Frm_Pratos_Verao pratos_Verao = new Frm_Pratos_Verao();//instanciando 
            pratos_Verao.Show();
            Hide();
        }

        private void Btn_Comidas_Click(object sender, EventArgs e)
        {
            Frm_Comidas_Verao frm_Comidas = new Frm_Comidas_Verao(); //instanciando o objeto para abrir a tela
            frm_Comidas.Show(); //abrindo a tela
            Hide();
        }

        private void Btn_Lugares_Click(object sender, EventArgs e)
        {
            Frm_Lugares_Verao frm_Lugares = new Frm_Lugares_Verao(); //instanciando
            frm_Lugares.Show(); //abrindo a tela
            Hide(); 
        }

        private void Btn_Voltar_Lugares_Click(object sender, EventArgs e)
        {
            Frm_Jogo _Jogo = new Frm_Jogo(); //instanciando
            _Jogo.Show(); //abrindo
            Hide(); //fechando
        }
    }
}
