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
    public partial class Frm_Abertura: Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }



        private void Frm_Abertura_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.estações_do_ano_muio_melhor; //adicionando a imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando a imagem 
        }

        private void Btn_Jogar_Click(object sender, EventArgs e)
        {
            Frm_Jogo _Jogo = new Frm_Jogo(); //instanciando o objeto jogar para acessar a tela
            _Jogo.Show(); //abrindo a tela de jogo
            Hide(); //fechando a tela de abertura

        }

        private void Btn_Opcoes_Click(object sender, EventArgs e)
        {
            Application.Exit(); //sair do jogo
        }
    }
    }

