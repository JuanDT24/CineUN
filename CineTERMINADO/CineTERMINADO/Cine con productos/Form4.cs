using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string precio, string nombre, string numero)
        {
            InitializeComponent();
            labelprec.Text = precio;
            nombreG.Text = nombre;
            cantidad.Text = numero;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter escritura = new StreamWriter("factura" + ".txt", true);

            escritura.WriteLine($"{labelprec}/{nombreG}/{cantidad}");


            escritura.Close();
        }
    }
}
