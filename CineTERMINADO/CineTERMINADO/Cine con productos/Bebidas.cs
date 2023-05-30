using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }

        

        public string precio = "0";

        private void CoPequeña_CheckedChanged(object sender, EventArgs e)
        {
            int precioCo = 0;
            if (CoPequeña.Checked)
                precioCo = 5000;
            else if (CoMediana.Checked)
                precioCo = 10000;
            else if (CoGrande.Checked)
                precioCo = 12000;

            cantidadCo.Text = "0";
            totalCo.Text = "0";

            sumaCo.Enabled = restaCo.Enabled = true;
            precio = precioCo.ToString();
        }

        private void sumaCo_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadCo.Text);

            if (count < 4)
            {

                count = count + 1;
                cantidadCo.Text = count.ToString();
                int total1 = int.Parse(precio) * count;
                totalCo.Text = total1.ToString();


            }
        }

        private void restaCo_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadCo.Text);

            if (count > 0)
            {
                count = count - 1;
                cantidadCo.Text = count.ToString();
                int total1 = int.Parse(precio);
                int total2 = int.Parse(totalCo.Text) - total1;
                totalCo.Text = total2.ToString();

            }
        }

        private void Bebidas_Load(object sender, EventArgs e)
        {
            sumaCo.Enabled = false;
            restaCo.Enabled = false;
            sumaSp.Enabled = false;
            restaSp.Enabled = false;
            sumaQu.Enabled = false;
            restaQu.Enabled = false;
            
        }
        private void SpPequeña_CheckedChanged(object sender, EventArgs e)
        {
            int precioSp = 0;
            if (SpPequeña.Checked)
                precioSp = 5000;
            else if (SpMediana.Checked)
                precioSp = 10000;
            else if (SpGrande.Checked)
                precioSp = 12000;

            cantidadSp.Text = "0";
            textBox1.Text = "0";

            sumaSp.Enabled = restaSp.Enabled = true;
            precio = precioSp.ToString();
        }

        private void sumaSp_Click(object sender, EventArgs e)
        {

            int count = int.Parse(cantidadSp.Text);

            if (count < 4)
            {

                count = count + 1;
                cantidadSp.Text = count.ToString();
                int total1 = int.Parse(precio) * count;
                textBox1.Text = total1.ToString();


            }
        }

        private void restaSp_Click(object sender, EventArgs e)
        {

            int count = int.Parse(cantidadSp.Text);

            if (count > 0)
            {
                count = count - 1;
                cantidadSp.Text = count.ToString();
                int total1 = int.Parse(precio);
                int total2 = int.Parse(textBox1.Text) - total1;
                textBox1.Text = total2.ToString();

            }
        }

        

        private void Quradiobt_CheckedChanged(object sender, EventArgs e)
        {
            int precioQu = 0;
            if (QuPequeña.Checked)
                precioQu = 5000;
            else if (QuMediana.Checked)
                precioQu = 10000;
            else if (QuGrande.Checked)
                precioQu = 12000;

            CantidadQu.Text = "0";
            totalQu.Text = "0";

            sumaQu.Enabled = restaQu.Enabled = true;
            precio = precioQu.ToString();
        }

        private void sumaQu_Click(object sender, EventArgs e)
        {
            int count = int.Parse(CantidadQu.Text);

            if (count < 4)
            {

                count = count + 1;
                CantidadQu.Text = count.ToString();
                int total1 = int.Parse(precio) * count;
                totalQu.Text = total1.ToString();

            }
        }

        private void restaQu_Click(object sender, EventArgs e)
        {
            int count = int.Parse(CantidadQu.Text);

            if (count > 0)
            {
                count = count - 1;
                CantidadQu.Text = count.ToString();
                int total1 = int.Parse(precio);
                int total2 = int.Parse(totalQu.Text) - total1;
                totalQu.Text = total2.ToString();

            }
        }
       

        private void Calcular_Click(object sender, EventArgs e)
        {

            int total1 = int.Parse(totalCo.Text) + int.Parse(totalQu.Text) + int.Parse(textBox1.Text);
            totalbebida.Text = total1.ToString();
        }
        public string Totalbebida { get; set; }
        private void siguibe_Click(object sender, EventArgs e)
        {
            this.Totalbebida = totalbebida.Text;

            this.Close();
        }

        private void cantidadCo_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            int total1 = int.Parse(totalCo.Text) + int.Parse(totalQu.Text) + int.Parse(textBox1.Text);
            totalbebida.Text = total1.ToString();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Totalbebida = totalbebida.Text;

            this.Close();
        }
    }
}
