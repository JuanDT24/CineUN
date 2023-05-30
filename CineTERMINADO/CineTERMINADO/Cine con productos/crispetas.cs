using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Cine
{
    public partial class crispetas : Form
    {
        public crispetas()
        {
            InitializeComponent();
           

        }
       

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public void sumarcr_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadcr.Text);

            if (count < 4)
            {
               
                count = count + 1;
                cantidadcr.Text = count.ToString();
                int total1 = int.Parse(precio) * count;
                total.Text = total1.ToString();
                
                


            }

          
        }
        public void restarcr_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadcr.Text);

            if (count > 0)
            {
                count = count - 1;
                cantidadcr.Text = count.ToString();
                int total1 = int.Parse(precio);
                int total2 = int.Parse(total.Text) - total1;
                total.Text = total2.ToString();
                
            }

            
        }
        public string precio = "0";
        public void CrPequeña_CheckedChanged(object sender, EventArgs e)
        {
            int precioCr = 0;
            if (CrPequeña.Checked)
                precioCr = 10000;
            else if (CrMediana.Checked)
                precioCr = 15000;
            else if (CrGrande.Checked)
                precioCr = 20000;

            cantidadcr.Text = "0";
            total.Text = "0";

            sumarcr.Enabled = restarcr.Enabled = true;
            precio = precioCr.ToString();
        }

        

        public void sumaCh_Click(object sender, EventArgs e)
        {
            int count = int.Parse(countch.Text);
            string precioCh = "2000";
            if (count < 4)
            {

                count = count + 1;
                countch.Text = count.ToString();
                int total1 = int.Parse(precioCh) * count;
                totalch.Text = total1.ToString();

                
            }
        }
        public void restaCh_Click(object sender, EventArgs e)
        {
            int count = int.Parse(countch.Text);
            string precioCh = "2000";

            if (count > 0)
            {

                count = count - 1;
                countch.Text = count.ToString();
                int total1 = int.Parse(precioCh);
                int total2 = int.Parse(totalch.Text) - total1;
                totalch.Text = total2.ToString();
                
            }
        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            int precioCr = 0;
            cantidadP.Text = "0";
            totalP.Text = "0";

            sumaP.Enabled = restaP.Enabled = true;
            precio = precioCr.ToString();
        }

       public void sumaP_Click(object sender, EventArgs e)
        {
            int count = int.Parse(cantidadP.Text);
            string preciop = "5000";
            if (count < 4)
            {

                count = count + 1;
                cantidadP.Text = count.ToString();
                int total1 = int.Parse(preciop) * count;
                totalP.Text = total1.ToString();
                
                
            }
        }
        public  void restaP_Click(object sender, EventArgs e)
        {

            int count = int.Parse(cantidadP.Text);
            string preciop = "5000";

            if (count > 0)
            {

                count = count - 1;
                cantidadP.Text = count.ToString();
                int total1 = int.Parse(preciop);
                int total2 = int.Parse(totalP.Text) - total1;
                totalP.Text = total2.ToString();
                

            }
        }
        public void crispetas_Load(object sender, EventArgs e)
        {
            sumarcr.Enabled = false;
            restarcr.Enabled = false;
            sumaP.Enabled = false;
            restaP.Enabled = false;
        }
        
        

        public void Calcular_Click(object sender, EventArgs e)
        {
            int total1 = int.Parse(totalP.Text) + int.Parse(totalch.Text)+ int.Parse(total.Text);
            totaldulceria.Text= total1.ToString();
            
        }
        public string TotalDulceria1 { get; set; }

        public void button1_Click(object sender, EventArgs e)
        {
            this.TotalDulceria1 = totaldulceria.Text;
            
            this.Close();
            
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            int total1 = int.Parse(totalP.Text) + int.Parse(totalch.Text) + int.Parse(total.Text);
            totaldulceria.Text = total1.ToString();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            this.TotalDulceria1 = totaldulceria.Text;

            this.Close();
        }
    }
    }

