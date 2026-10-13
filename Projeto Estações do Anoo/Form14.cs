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
    public partial class Frm_Lugares_Outono: Form
    {
        public Frm_Lugares_Outono()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Lugares_Outonoi_Click(object sender, EventArgs e)
        {
            Frm_Outono frm_Outono = new Frm_Outono(); //
            frm_Outono.Show();//
            Hide(); //
        }

        private void Frm_Lugares_Outono_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Dinooutonoo; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
