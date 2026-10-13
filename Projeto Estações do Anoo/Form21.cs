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
    public partial class Frm_Comidas_Invernoooo: Form
    {
        public Frm_Comidas_Invernoooo()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Comidas_Invernoo_Click(object sender, EventArgs e)
        {
            Frm_Inverno frm_Inverno = new Frm_Inverno(); //instanciando
            frm_Inverno.Show(); //abrindo
            Hide(); //fechando
        }

        private void Frm_Comidas_Invernoooo_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.mario_cha; //imagm
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando
        }
    }
}
