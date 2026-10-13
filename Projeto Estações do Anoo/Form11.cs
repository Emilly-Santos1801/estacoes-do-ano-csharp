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
    public partial class Frm_Pratos_Primavera: Form
    {
        public Frm_Pratos_Primavera()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Lugares_Click(object sender, EventArgs e)
        {
            Frm_Primavera _Primavera = new Frm_Primavera(); //instanciando a tela
            _Primavera.Show(); //abrindo
            Hide(); //fechando
        }

        private void Frm_Pratos_Primavera_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.kerbywallpaperpratros; //imagem
            BackgroundImageLayout = ImageLayout.Stretch; //arrumando a imagem
        }
    }
}
