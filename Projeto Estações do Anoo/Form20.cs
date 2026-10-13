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
    public partial class Frm_Lugares_Invernoo: Form
    {
        public Frm_Lugares_Invernoo()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Lugares_Invernio_Click(object sender, EventArgs e)
        {
            Frm_Inverno frm_Inverno = new Frm_Inverno(); //instanciando
            frm_Inverno.Show(); //abrindo
            Hide(); //fechando
        }

        private void Frm_Lugares_Invernoo_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.frio_cabana_inverno; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando a imagem bb
        }
    }
}
