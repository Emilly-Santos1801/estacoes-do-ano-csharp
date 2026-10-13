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
    public partial class Frm_Comidas_Primavera: Form
    {
        public Frm_Comidas_Primavera()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Lugares_Click(object sender, EventArgs e)
        {
            Frm_Primavera _Primavera = new Frm_Primavera() ; //instanciando
            _Primavera.Show(); //abrindo
            Hide(); //fechando
        }

        private void Frm_Comidas_Primavera_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.kirbycomidasremake;//imagem
            BackgroundImageLayout = ImageLayout.Stretch; //arrumando imagem
            pictureBox1.Image = Properties.Resources.primaverabolo; //pic
            pictureBox2.Image = Properties.Resources.primamoussedemaracuja; //pic
            pictureBox3.Image = Properties.Resources.primagelatina; //pic
            pictureBox4.Image = Properties.Resources.primasorvetedelimao; //pic

        }

        private void Lbl_Sobremesas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
