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
    public partial class Frm_Pratos_Invernooo: Form
    {
        public Frm_Pratos_Invernooo()
        {
            InitializeComponent();
        }

        private void Btn_Pratos_Invernioo_Click(object sender, EventArgs e)
        {
            Frm_Inverno frm_Inverno = new Frm_Inverno();
            frm_Inverno.Show(); //abrindo
            Hide(); //fechando
        }

        private void Frm_Pratos_Invernooo_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.marioeluigii; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando a imagem
        }
    }
}
