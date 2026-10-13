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
    public partial class Frm_Outono: Form
    {
        public Frm_Outono()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Outonio_Click(object sender, EventArgs e)
        {
            Frm_Jogo frm_Jogo = new Frm_Jogo(); //instanciando
            frm_Jogo.Show(); //abrindo
            Hide(); //fechando
        }

        private void Btn_Pratitos_Outono_Click(object sender, EventArgs e)
        {
            Frm_Pratitos_Outono frm_Pratitos = new Frm_Pratitos_Outono();//instanciando
            frm_Pratitos.Show();//abrindo
            Hide(); //fechando
        }

        private void Btn_Lugarez_Outono_Click(object sender, EventArgs e)
        {
            Frm_Lugares_Outono frm_Lugares_ = new Frm_Lugares_Outono(); //
            frm_Lugares_.Show(); //
            Hide(); //
        }

        private void Btn_Comidasi_Outono_Click(object sender, EventArgs e)
        {
            Frm_Comidas_Outono frm_Comidas_ = new Frm_Comidas_Outono();//
            frm_Comidas_.Show();
            Hide(); 
        }

        private void Frm_Outono_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Outono_png; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando
        }

        private void Lbl_Outono_Click(object sender, EventArgs e)
        {

        }
    }
}
