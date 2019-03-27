using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ElVector vec;
        private void b1_Click(object sender, EventArgs e)
        {
            vec = new ElVector(Convert.ToInt32(t1.Text));
           
        }
        
        private void b2_Click(object sender, EventArgs e)
        {
            vec.llenar(Convert.ToInt32(t2.Text));
        }

        private void b3_Click(object sender, EventArgs e)
        {
            t3resultados.Text = vec.Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vec.GirarArriba();
            t3resultados.Text = vec.Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vec.GirarAbajo();
            t3resultados.Text = vec.Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vec.Invertir();
            t3resultados.Text = vec.Mostrar();
        }
    }
}
