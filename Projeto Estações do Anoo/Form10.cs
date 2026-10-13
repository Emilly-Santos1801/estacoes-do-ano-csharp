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
    public partial class Frm_Lugares_Primavera: Form
    {
        public Frm_Lugares_Primavera()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Lugares_Click(object sender, EventArgs e)
        {
            Frm_Primavera _Primavera = new Frm_Primavera(); //instanciando a tela
            _Primavera.Show(); //abrindo
            Hide(); //fechando
        }

        private void Frm_Lugares_Primavera_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.kirby_wallpaper_jpg  ; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //arrumando
            Pic_Jardim.Image = Properties.Resources.jardimbotanico; //
            Pic_Feirinha.Image = Properties.Resources.feirinhaprimavera;//
            Pic_Parquer.Image = Properties.Resources.parque_do_carmo; //
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pic_Jardim_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Lugaresii_Click(object sender, EventArgs e)
        {

        }
    }
}
