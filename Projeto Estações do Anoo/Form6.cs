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
    public partial class Frm_Lugares_Verao: Form
    {
        public Frm_Lugares_Verao()
        {
            InitializeComponent();
        }

        private void Frm_Lugares_Verao_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Lugares_Png;
            BackgroundImageLayout = ImageLayout.Stretch; //imagem
        }

        private void Pic_Fernando_Click(object sender, EventArgs e)
        {
            Pic_Fernando.Image = Properties.Resources.Lugar_Fernando_Jpeg;//
        }

        private void Pic_Jericoacora_Click(object sender, EventArgs e)
        {
            Pic_Jericoacora.Image = Properties.Resources.lugar_Jericoara_JPEG;//
        }

        private void Pic_Boipeba_Click(object sender, EventArgs e)
        {
            Pic_Boipeba.Image = Properties.Resources.Lugar_Boipeba_JPEG;//
        }

        private void Btn_Voltar_Lugares_Click(object sender, EventArgs e)
        {
            Frm_Verão _Verão = new Frm_Verão (); //instanciando
            _Verão.Show(); //abrir a tela
            Hide(); //fechar
        }
    }
}
