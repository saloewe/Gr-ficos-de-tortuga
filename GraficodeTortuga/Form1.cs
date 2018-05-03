using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficodeTortuga
{
    public partial class Form1 : Form
    {
        Piso p = new Piso();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.moverPluma();
            label1.Text = p.info();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int distancia = Convert.ToInt16(textBox2.Text);
            p.pintar(distancia);
            textBox1.Text = p.mostrar();
            label1.Text = p.info();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.izq();
            label1.Text = p.info();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.derecha();
            label1.Text = p.info();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.reiniciar();
            textBox1.Text = p.mostrar();
            label1.Text = p.info();
        }
    }
}
