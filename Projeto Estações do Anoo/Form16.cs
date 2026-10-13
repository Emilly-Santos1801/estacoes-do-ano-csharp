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
    public partial class Frm_Pratitos_Outono: Form
    {
        public Frm_Pratitos_Outono()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Pratos_Outonoi_Click(object sender, EventArgs e)
        {
            Frm_Outono frm_Outono = new Frm_Outono(); //instanciando
            frm_Outono.Show(); //abrir
            Hide(); 
        }

        private void Frm_Pratitos_Outono_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.outono_pratos; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //ajustando
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
