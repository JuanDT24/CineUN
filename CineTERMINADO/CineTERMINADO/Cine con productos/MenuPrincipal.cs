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
    public partial class MenuPrincipal : Form
    {
        
        public MenuPrincipal(Login.Datos info)
        {
            InitializeComponent();
            NOMBREUS.Text = info.nombre;


        }



        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Taquilla fom1 = new Taquilla();
            fom1.ShowDialog();
            this.Hide();


        }



        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
