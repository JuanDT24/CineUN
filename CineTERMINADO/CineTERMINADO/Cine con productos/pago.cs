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
    public partial class pago : Form
    {
        public pago()
        {
            InitializeComponent();
        }

        private void pago_Load(object sender, EventArgs e)
        {

        }

        public pago(string pelicula, string boleta, string total_boleta, string total_cafeteria)
        {
            InitializeComponent();
            Pelicula_pagar.Text = pelicula;
            boleta_pagar.Text = boleta;
            totalbo_pagar.Text = total_boleta;
            totaldul_pagarr.Text = total_cafeteria;
        }
    }
}
