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
    public partial class Frm_Jogo: Form
    {
        public Frm_Jogo()
        {
            InitializeComponent();
        }

        private void Frm_Jogo_Load(object sender, EventArgs e)
        {
			BackgroundImage = Properties.Resources.ininici_mariono; //adicionando a imagem
			BackgroundImageLayout = ImageLayout.Stretch; //ajustando a imagem
		}

        private void Btn_Outono_Click(object sender, EventArgs e)
        {
            Frm_Transicao_Outono frm_Transicao_ = new Frm_Transicao_Outono(); //instanciando
            frm_Transicao_.Show(); //abrir
            Hide(); //fechando
            Timer_Outono.Start(); //inicia o timer para o formulario fechar
        }

        private void Btn_Verao_Click(object sender, EventArgs e)
        {
            Frm_Transição _Transição = new Frm_Transição(); //instanciando o objeto para ter a tela de transição
            _Transição.Show(); //abrindo a transição
            Hide(); 
            Timer_Um.Start(); //inicia o timer para o formulario fechar
        }

        private void Timer_Um_Tick(object sender, EventArgs e)
        {
            this.Close();
            Timer_Um.Stop(); //fechar o formulario atual e para o timer
        }

        private void Btn_Primavera_Click(object sender, EventArgs e)
        {
            Frm_Transicao_Primavera frm_Transicao_Primavera = new Frm_Transicao_Primavera();
            frm_Transicao_Primavera.Show();
            Hide(); //fechando
			Timer_Primavera.Start(); //começar o timer pro formulario abrir
		}

        private void Timer_Primavera_Tick(object sender, EventArgs e)
        {
			this.Close();
			Timer_Primavera.Stop(); //parando o timer

		}

        private void Btn_Voltar_Verao_Jogo_Click(object sender, EventArgs e)
        {
            Frm_Abertura frm_Abertura = new Frm_Abertura(); //instanciando
            frm_Abertura.Show();
            Hide(); //fechando
        }

        private void Timer_Outono_Tick(object sender, EventArgs e)
        {
			this.Close();
			Timer_Outono.Stop(); //parando o timer
		}

        private void Timer_Inverno_Tick(object sender, EventArgs e)
        {
			this.Close();
			Timer_Inverno.Stop(); //parando o timer
		}

        private void Btn_Inverno_Click(object sender, EventArgs e)
        {
            Frm_Transicao_Inverno frm_Transicao_ = new Frm_Transicao_Inverno(); //
            frm_Transicao_.Show();//
            Hide();
            Timer_Inverno.Start(); //começar o timer para o formulario abrir
        }
    }
    }

