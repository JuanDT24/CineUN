using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class VerifyAndPay : Form
    {
        private string pelicula;// cambio
        private string asientos;// cambio
        private string total; // cambio
        private string productos; // cambio
        
       

        public VerifyAndPay(string pelicula, string asientos, string total, string productos)
        {
            this.pelicula = pelicula;
            this.asientos = asientos;
            this.total = total;
            this.productos = productos;
            
            InitializeComponent();
            peliculaC.Text = pelicula;
            cantidad_asientos.Text = asientos;
            total_cantidad.Text = total;
            total_productos.Text = productos;
        }
        private bool ValidarCampos()
        {
            bool validar = true;
            //Cuando los campos están vacíos
            if (txtTarjeta.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtTarjeta, "Ingrese el número");
            }
            if (txtTitular.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtTitular, "Ingrese el titular");
            }
            if (txtCVV.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtCVV, "Ingrese el código de seguridad");
            }
            if (txtMM.Text == "MM")
            {
                validar = false;
                errorProvider1.SetError(txtMM, "Elija un mes");
            }
            if (txtYY.Text == "YY")
            {
                validar = false;
                errorProvider1.SetError(txtYY, "Elija un año");
            }

            //Cuando se escriben otro tipo de dato del que se pide

            if (!long.TryParse(txtTarjeta.Text, out _))
            {
                validar = false;
                errorProvider1.SetError(txtTarjeta, "Solo se permiten valores numéricos");
            }

            if (!int.TryParse(txtCVV.Text, out _))
            {
                validar = false;
                errorProvider1.SetError(txtCVV, "Solo se permiten valores numéricos");
            }

            //Cuando se escribe una longitud no permitida

            if (txtTarjeta.Text.Length != 16)
            {
                validar = false;
                errorProvider1.SetError(txtTarjeta, "El número de tarjeta debe ser de 16 dígitos");
            }

            if (txtCVV.Text.Length != 3)
            {
                validar = false;
                errorProvider1.SetError(txtCVV, "El código de seguridad tiene 3 dígitos");
            }

            return validar;
        }

        private void BorrarError()
        {
            errorProvider1.SetError(txtTarjeta, "");
            errorProvider1.SetError(txtTitular, "");
            errorProvider1.SetError(txtCVV, "");
            errorProvider1.SetError(txtMM, "");
            errorProvider1.SetError(txtYY, "");
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            txtTarjeta.MaxLength = 16;
            txtCVV.MaxLength = 3;
            //Elementos de combobox de mes
            txtMM.Items.Add("MM");
            txtMM.Items.Add("01");
            txtMM.Items.Add("02");
            txtMM.Items.Add("03");
            txtMM.Items.Add("04");
            txtMM.Items.Add("05");
            txtMM.Items.Add("06");
            txtMM.Items.Add("07");
            txtMM.Items.Add("08");
            txtMM.Items.Add("09");
            txtMM.Items.Add("10");
            txtMM.Items.Add("11");
            txtMM.Items.Add("12");

            //Elementos de combobox de año
            txtYY.Items.Add("YY");
            txtYY.Items.Add("23");
            txtYY.Items.Add("24");
            txtYY.Items.Add("25");
            txtYY.Items.Add("26");
        }
        


        private void btnPay_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (ValidarCampos())
            {
                string CreditInfo = txtTarjeta.Text + "~" + txtTitular.Text + "~" + txtCVV.Text + "~" + txtMM.Text + "/" + txtYY.Text;
                bool CreditFound = false;
                string[] lineas = File.ReadAllLines("Credit.txt");
                foreach (string line in lineas)
                {
                    if (line.Contains(CreditInfo))
                    {
                        CreditFound = true;
                    }

                }
                if (CreditFound)
                {
                    MessageBox.Show("Se ha realizado el pago", "Mensaje");
                    Form election = new Login();
                    election.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La tarjeta no está registrada", "Mensaje");
                    Form election = new AccionesTarjeta();
                    election.ShowDialog();
                    this.Hide();
                }
            }
            
        }

        private void buttonBackfromPay_Click(object sender, EventArgs e)
        {
            Form election = new AccionesTarjeta(this.pelicula, this.asientos, this.total, this.productos);
            election.Show();
            this.Hide();
        }

        private void total_cantidad_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Form election = new AccionesTarjeta(this.pelicula, this.asientos, this.total, this.productos);
            election.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (ValidarCampos())
            {
                string CreditInfo = txtTarjeta.Text + "~" + txtTitular.Text + "~" + txtCVV.Text + "~" + txtMM.Text + "/" + txtYY.Text;
                bool CreditFound = false;
                string[] lineas = File.ReadAllLines("Credit.txt");
                foreach (string line in lineas)
                {
                    if (line.Contains(CreditInfo))
                    {
                        CreditFound = true;
                    }

                }
                if (CreditFound)
                {
                    MessageBox.Show("Se ha realizado el pago", "Mensaje");
                    Form election = new Login();
                    election.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La tarjeta no está registrada", "Mensaje");
                    Form election = new AccionesTarjeta();
                    election.ShowDialog();
                    this.Hide();
                }
            }
        }
    }
}
