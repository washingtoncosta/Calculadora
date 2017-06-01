using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            painel.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            painel.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            painel.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            painel.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            painel.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            painel.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            painel.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            painel.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            painel.Text += "9";
        }

        private void painel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tivi.v1 = Convert.ToDouble(painel.Text);
            Tivi.op = 1;
            painel.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Double res = 0;
            Tivi.v2 = Convert.ToDouble(painel.Text);
            if (Tivi.op == 1)
            {
                res = Tivi.v1 + Tivi.v2;
            }
            else if (Tivi.op == 2)
            {
                res = Tivi.v1 - Tivi.v2;

            }
            else if (Tivi.op == 3)
            {
                res = Tivi.v1 / Tivi.v2;
            }
            else if (Tivi.op == 4)
            {
                res = Tivi.v1 * Tivi.v2;
            }
            painel.Text = Convert.ToString(res);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tivi.v1 = Convert.ToDouble(painel.Text);
            Tivi.op = 2;
            painel.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Tivi.v1 = Convert.ToDouble(painel.Text);
            Tivi.op = 3;
            painel.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Tivi.v1 = Convert.ToDouble(painel.Text);
            Tivi.op = 4;
            painel.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            painel.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            painel.Clear();
        }

        private void Integrantes_Click(object sender, EventArgs e)
        {
            painel.Text += "Alexandre Ra:2215111907 / Washington Costa Ra:2215112179";
        }
    }
}
