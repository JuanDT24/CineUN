using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cine
{
    public partial class RegistroCliente : Form
    {
        public string RutaArchivo = "datosclientes.txt";

        public RegistroCliente()
        {
            InitializeComponent();
             
    }

       
        public struct Datos
        {
            public string Name;


        }


        private void Registrar_Click(object sender, EventArgs e)
        {
            if (textBoxContra.Text == textBoxcontrarepe.Text) CuentasRepetidas();
            else {
                MessageBox.Show("Las contraseñas no coinciden");
            }




            

            
            
        }
        public void CuentasRepetidas() {
            
            string userReg=textBoxuser.Text;
            StreamReader leer;
            leer =File.OpenText("datosclientes.txt");
            string cadena;
            string[] arreglo = new string[2];
            char[] separador = { '-' };
            bool repetido = false;
            cadena = leer.ReadLine();
            while (cadena != null && repetido == false)
            {

                arreglo = cadena.Split(separador);
                if (arreglo[0].Trim().Equals(userReg))
                {
                    MessageBox.Show("Usuario ya se encuentra registrado");
                    leer.Close();
                    repetido=true;
                   
                }
                else
                {

                    cadena = leer.ReadLine();
                }

            }
            if (repetido == false)
            {
                leer.Close();
                RegistrarUsuarios();
            }
        }




        public void RegistrarUsuarios()
        {
            int numero = textBoxTarjeta.Text.Length;
            int tele = textBoxtelefono.Text.Length;
            if (numero != 16)
            {
                MessageBox.Show("El número de la tarjeta tiene que ser de 16 digitos");
            }
            if (tele != 10)
            {
                MessageBox.Show("El número de telefono tiene que ser de 10 digitos");
            }
            else
            {
                string user = textBoxuser.Text;
                string contra = textBoxContra.Text;
                string id = textBoxid.Text;
                string tarjeta = textBoxTarjeta.Text;

                if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(contra) && !string.IsNullOrEmpty(tarjeta) && !string.IsNullOrEmpty(id))
                {
                    string registro = user + "-" + contra + "-" + tarjeta + "-" +id;

                    // Leer todas las líneas del archivo y filtrar las líneas en blanco
                    string[] lineasExistentes = File.ReadAllLines("datosclientes.txt")
                        .Where(line => !string.IsNullOrWhiteSpace(line))
                        .ToArray();

                    // Agregar el nuevo registro al arreglo de líneas existentes
                    string[] nuevasLineas = lineasExistentes.Append(registro).ToArray();

                    // Sobreescribir el archivo con las nuevas líneas
                    File.WriteAllLines("datosclientes.txt", nuevasLineas);

                    MessageBox.Show("Se ha registrado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pueden dejar campos en blanco");
                }

                Login form1 = new Login();
                form1.RutaArchivo = RutaArchivo;
                form1.Show();
                this.Hide();
            }

        }





        private void Limpiar_Click(object sender, EventArgs e)
        {


            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBoxTarjeta.MaxLength = 16;
            textBoxtelefono.MaxLength = 10;
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxTarjeta_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


