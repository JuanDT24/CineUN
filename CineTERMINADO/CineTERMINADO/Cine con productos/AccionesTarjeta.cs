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
    public partial class AccionesTarjeta : Form
    {
        public AccionesTarjeta()
        {
            InitializeComponent();
        }

        public AccionesTarjeta(string pelicula, string asientos, string total, string productos)
        {
            InitializeComponent();
            peliculaC.Text = pelicula;
            cantidad_asientos.Text = asientos;
            total_cantidad.Text = total;
            total_productos.Text = productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addCredit = new AddCredit(peliculaC.Text, cantidad_asientos.Text, total_cantidad.Text, total_productos.Text); // cambio
            addCredit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form goPay = new VerifyAndPay(peliculaC.Text, cantidad_asientos.Text, total_cantidad.Text, total_productos.Text);
            goPay.ShowDialog();
        }

        

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addCredit = new AddCredit(peliculaC.Text, cantidad_asientos.Text, total_cantidad.Text, total_productos.Text); // cambio
            addCredit.Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form goPay = new VerifyAndPay(peliculaC.Text, cantidad_asientos.Text, total_cantidad.Text, total_productos.Text);
            goPay.Show();
        }
    }
}
