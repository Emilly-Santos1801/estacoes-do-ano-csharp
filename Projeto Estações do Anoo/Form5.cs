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
    public partial class Frm_Comidas_Verao: Form
    {
        public Frm_Comidas_Verao()
        {
            InitializeComponent();
        }

        private void Frm_Comidas_Verao_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.carrinhos_Png; //adicionando imagem
            BackgroundImageLayout = ImageLayout.Stretch; //arrumando
            Pic_Mario_Agua.Image = Properties.Resources.mario_Agua_Jpg; //
        }


private void Pic_Mario_Agua_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Voltar_Comidas_Click(object sender, EventArgs e)
        {
            Frm_Verão _Verão = new Frm_Verão(); //instanciando
            _Verão.Show(); //abrir tela
            Hide(); //fechando
        }

        private void Lbl_Texto_Comidas_Click(object sender, EventArgs e)
        {

        }
    }
    }

