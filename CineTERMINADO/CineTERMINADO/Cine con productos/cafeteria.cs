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
    //form cafeteria
    public partial class cafeteria : Form
    {
        public cafeteria()
        {
            InitializeComponent();
        }
        public cafeteria(string pelicula, string boletas, string precio)
        {
            InitializeComponent();
            PeliculaC.Text = pelicula;
            boletaC.Text = boletas;
            totalb.Text = precio;
        }



        private string totalFinal;
        private void button_combos_Click(object sender, EventArgs e)
        {
            using (combos formcombos = new combos())
            {
                formcombos.ShowDialog();

                string totalcombos = formcombos.Totalcombos;
                int total = int.Parse(Combos.Text) + int.Parse(totalcombos);


                Combos.Text = total.ToString();
            }

        }

      

        private void button_bebidas_Click(object sender, EventArgs e)
        {
            using (Bebidas formbebida= new Bebidas())
            {
                formbebida.ShowDialog();

                string totalbebida = formbebida.Totalbebida;
                int total = int.Parse(bebidas.Text) + int.Parse(totalbebida);
                bebidas.Text = total.ToString();
            }
        }

        private void comida_Click(object sender, EventArgs e)
        {
            using (crispetas formcrispeta = new crispetas())
            {
                formcrispeta.ShowDialog();

                string totalDulceria = formcrispeta.TotalDulceria1;
                int total = int.Parse(total_comida.Text) + int.Parse(totalDulceria);
                total_comida.Text = total.ToString();
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            int total1 = int.Parse(total_comida.Text) + int.Parse(bebidas.Text) + int.Parse(Combos.Text);
            totalD.Text = total1.ToString();
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            total_comida.Text = "0";
            bebidas.Text="0";
            Combos.Text = "0";
            totalD.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccionesTarjeta CreditActions = new AccionesTarjeta(PeliculaC.Text, boletaC.Text, totalb.Text, totalD.Text);
            CreditActions.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cafeteria_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            int total1 = int.Parse(total_comida.Text) + int.Parse(bebidas.Text) + int.Parse(Combos.Text);
            totalD.Text = total1.ToString();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            total_comida.Text = "0";
            bebidas.Text = "0";
            Combos.Text = "0";
            totalD.Text = "0";
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            AccionesTarjeta CreditActions = new AccionesTarjeta(PeliculaC.Text, boletaC.Text, totalb.Text, totalD.Text);
            CreditActions.Show();
            this.Hide();
        }
    }
}
