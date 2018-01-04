using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lulu_Bank
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Text = "Lulu Bank";
            //Bitmap icon = new Bitmap("Resources/dinheiro.png");
            this.Icon = Icon.FromHandle(Properties.Resources.dinheiro.GetHicon());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            conta1.numero = 1;
            conta1.titular = "Joaquim Jose";
            conta1.saldo = 20000;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxDinheiro_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
