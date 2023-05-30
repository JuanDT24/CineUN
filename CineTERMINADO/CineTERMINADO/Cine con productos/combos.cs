using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cine
{
    public partial class combos : Form
    {
        public combos()
        {
            InitializeComponent();
        }

        private void sumacb1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadcb1.Text);
            string precioCh = "40000";
            if (count < 4)
            {

                count = count + 1;
                cantidadcb1.Text = count.ToString();
                int total1 = int.Parse(precioCh) * count;
                totalcb1.Text = total1.ToString();


            }
        }

        private void restacb1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadcb1.Text);
            string precioCh = "40000";

            if (count > 0)
            {

                count = count - 1;
                cantidadcb1.Text = count.ToString();
                int total1 = int.Parse(precioCh);
                int total2 = int.Parse(totalcb1.Text) - total1;
                totalcb1.Text = total2.ToString();

            }
        }

        private void sumacb2_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadcb2.Text);
            string precioCh = "25000";
            if (count < 4)
            {

                count = count + 1;
                cantidadcb2.Text = count.ToString();
                int total1 = int.Parse(precioCh) * count;
                totalcb2.Text = total1.ToString();


            }
        }

        private void restacb2_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadcb2.Text);
            string precioCh = "25000";

            if (count > 0)
            {

                count = count - 1;
                cantidadcb2.Text = count.ToString();
                int total1 = int.Parse(precioCh);
                int total2 = int.Parse(totalcb2.Text) - total1;
                totalcb2.Text = total2.ToString();

            }
        }

        private void sumacb3_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadcb3.Text);
            string precioCh = "12000";
            if (count < 4)
            {

                count = count + 1;
                cantidadcb3.Text = count.ToString();
                int total1 = int.Parse(precioCh) * count;
                totalcb3.Text = total1.ToString();


            }
        }

        private void restacb3_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadcb3.Text);
            string precioCh = "12000";

            if (count > 0)
            {

                count = count - 1;
                cantidadcb3.Text = count.ToString();
                int total1 = int.Parse(precioCh);
                int total2 = int.Parse(totalcb3.Text) - total1;
                totalcb3.Text = total2.ToString();

            }
        }

        private void Calcular_combo_Click(object sender, EventArgs e)
        {
            int total1 = int.Parse(totalcb1.Text) + int.Parse(totalcb2.Text) + int.Parse(totalcb3.Text);
            totalcombos.Text = total1.ToString();
        }
        public string Totalcombos { get; set; }
        private void sigu_combo_Click(object sender, EventArgs e)
        {
            this.Totalcombos = totalcombos.Text;

            this.Hide();
        }

        private void combos_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            int total1 = int.Parse(totalcb1.Text) + int.Parse(totalcb2.Text) + int.Parse(totalcb3.Text);
            totalcombos.Text = total1.ToString();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Totalcombos = totalcombos.Text;

            this.Hide();
        }
    }
}
