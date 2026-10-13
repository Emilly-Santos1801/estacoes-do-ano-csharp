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
    public partial class Frm_Comidas_Outono: Form
    {
        public Frm_Comidas_Outono()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Comidas_Outonoi_Click(object sender, EventArgs e)
        {
            Frm_Outono frm_Outono = new Frm_Outono(); //instanciando
            frm_Outono.Show(); //abrindo
            Hide(); //fechando
        }

        private void Frm_Comidas_Outono_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Yoshi_no_piquenique_de_outono; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando
        }
    }
}
