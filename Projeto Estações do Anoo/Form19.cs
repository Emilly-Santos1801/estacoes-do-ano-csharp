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
    public partial class Frm_Inverno: Form
    {
        public Frm_Inverno()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Invenoo_Click(object sender, EventArgs e)
        {
            Frm_Jogo frm_Jogo = new Frm_Jogo(); //instanciando
            frm_Jogo.Show(); //abrindo
            Hide();//fechando
        }

        private void Btn_Pratoss_Invernoo_Click(object sender, EventArgs e)
        {
            Frm_Pratos_Invernooo frm_Pratos_ = new Frm_Pratos_Invernooo(); //instanciando
            frm_Pratos_.Show(); //abrindo
            Hide(); //fechando
        }

        private void Btn_Lugares_Invernos_Click(object sender, EventArgs e)
        {
            Frm_Lugares_Invernoo frm_Lugares_Invernoo = new Frm_Lugares_Invernoo(); //instanciando
            frm_Lugares_Invernoo.Show(); //abrindo
            Hide(); //fechando
        }

        private void Btn_Comidinhas_Invernoo_Click(object sender, EventArgs e)
        {
            Frm_Comidas_Invernoooo frm_Comidas = new Frm_Comidas_Invernoooo(); //instanciando
            frm_Comidas.Show(); //abrindo
            Hide(); //fechando
        }

        private void Frm_Inverno_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Inverno_PNG; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando
            Pic_Favorito.Image = Properties.Resources.estrelamerio; //gif fav
        }

        private void Pic_Favorito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns, você achou minha estação favorita!"); //adicionando a mensagem no messagebox
        }
    }
}
