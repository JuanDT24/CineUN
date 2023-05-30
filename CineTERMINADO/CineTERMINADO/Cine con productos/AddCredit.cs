using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace Cine
{
    public partial class AddCredit : Form
    {
        private string pelicula;// cambio
        private string asientos;// cambio
        private string total; // cambio
        private string productos; // cambio
        public AddCredit(string pelicula, string asientos, string total, string productos)
        {
            this.pelicula = pelicula;
            this.asientos = asientos;
            this.total = total;
            this.productos = productos;

            InitializeComponent();

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

        private void Form5_Load(object sender, EventArgs e)
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
        private bool Find_Search(string ID, string password)
        {
            using (StreamReader lector = new StreamReader("datosclientes.txt"))
            {
                string linea;
                while ((linea = lector.ReadLine()) != null)
                {
                    string[] vector = linea.Split('-');
                    if (vector.Length >= 4 && ID == vector[3])
                    {
                        if (password == vector[1])
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                            return false;
                        }
                    }
                }
            }

            MessageBox.Show("ID no válido");
            return false;
        }



        private void btnVerify_Click(object sender, EventArgs e)
        {
            Form election = new AccionesTarjeta(this.pelicula, this.asientos, this.total, this.productos); // cambio
            BorrarError();


            if (Find_Search(textBoxIDD.Text, textBoxPassword.Text)) // cambio solamente este primer if
            {
                if (ValidarCampos())
                {
                    string CreditInfo = textBoxIDD.Text + "~" + txtTarjeta.Text + "~" + txtTitular.Text + "~" + txtCVV.Text + "~" + txtMM.Text + "/" + txtYY.Text;
                    bool CreditFound = false;
                    string[] lineas = File.ReadAllLines("Credit.txt");
                    foreach (string line in lineas)
                    {
                        if (line.Contains(txtTarjeta.Text))
                        {
                            CreditFound = true;
                        }

                    }
                    if (CreditFound == false)
                    {
                        using (StreamWriter write = new StreamWriter("Credit.txt", true))
                        {
                            write.WriteLine(CreditInfo);
                            MessageBox.Show("Tarjeta registrada exitosamente", "Mensaje");
                            write.Close();
                            election.ShowDialog();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta tarjeta ya se encuentra registrada", "Mensaje");
                        election.ShowDialog();
                        this.Hide();
                    }

                }
            }
            else // cambio else del primer if
            {
                MessageBox.Show("el id no se encuentra"); // cambio
            }
        }

        private void buttonBackFromAdd_Click(object sender, EventArgs e)
        {
            Form election = new AccionesTarjeta(this.pelicula, this.asientos, this.total, this.productos);
            election.Show();
            this.Hide();
        }

        private void textBoxIDD_TextChanged(object sender, EventArgs e)
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
            Form election = new AccionesTarjeta(this.pelicula, this.asientos, this.total, this.productos); // cambio
            BorrarError();


            if (Find_Search(textBoxIDD.Text, textBoxPassword.Text)) // cambio solamente este primer if
            {
                if (ValidarCampos())
                {
                    string CreditInfo = textBoxIDD.Text + "~" + txtTarjeta.Text + "~" + txtTitular.Text + "~" + txtCVV.Text + "~" + txtMM.Text + "/" + txtYY.Text;
                    bool CreditFound = false;
                    string[] lineas = File.ReadAllLines("Credit.txt");
                    foreach (string line in lineas)
                    {
                        if (line.Contains(txtTarjeta.Text))
                        {
                            CreditFound = true;
                        }

                    }
                    if (CreditFound == false)
                    {
                        using (StreamWriter write = new StreamWriter("Credit.txt", true))
                        {
                            write.WriteLine(CreditInfo);
                            MessageBox.Show("Tarjeta registrada exitosamente", "Mensaje");
                            write.Close();
                            election.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta tarjeta ya se encuentra registrada", "Mensaje");
                        election.Show();
                        this.Hide();
                    }

                }
            }
        }
    }
}
