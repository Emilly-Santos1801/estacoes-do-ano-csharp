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
    public partial class Frm_Pratos_Verao: Form
    {
        public Frm_Pratos_Verao()
        {
            InitializeComponent();
        }

        private void Frm_Pratos_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Pratos_PNG;//
            BackgroundImageLayout = ImageLayout.Stretch; //
        }

        private void Btn_Voltar_Lugares_Click(object sender, EventArgs e)
        {
            Frm_Verão _Verão = new Frm_Verão(); //instanciando o objeto
            _Verão.Show(); //abrindo a tela
            Hide(); 
        }
    }
}
