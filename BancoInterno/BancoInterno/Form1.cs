using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoInterno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MacPedido_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"c:\matheuscs\textto" + DateTime.Now.ToString("dd_MM_ss") + ".txt", txt_Texto.Text);
            txt_Texto.Clear();
            MessageBox.Show("Pedido Realizado");
        }

        private void pic_McChickenCombo_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "McChicken Combo \r\n Preço R$:26,50"; //valor e quebrando o texto
        }

        private void pic_BigMacConbo_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "BigMac Combo \r\n Preço R$:45,00"; //valor e quebrando o texto
        }

        private void pic_CheeseBurgerCombo_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "CheeseBurger Combo \r\n Preço R$:25,00"; //valor e quebrando o texto
        }

        private void pic_QuarterPounderCombo_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "Quarter Pounder Combo \r\n Preço R$:32,00"; //valor e quebrando o texto
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "McFish Combo \r\n Preço R$:48,90"; //valor e quebrando o texto
        }
    }
}
