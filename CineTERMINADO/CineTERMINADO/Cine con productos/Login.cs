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
    public partial class Login : Form
    {
        string user_verificar;
        string contra_verificar;
        public string RutaArchivo { get; set; }
        public Login()
        {
            InitializeComponent();
        }
        public struct Datos {

            public string nombre;
        }
       

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void IrAmenu() {

            Datos info;
            info.nombre = TBnombre.Text;
            this.Hide();
            MenuPrincipal form2 = new MenuPrincipal(info);
            form2.Show();

        }


        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBnombre.Text == "" || TBcontra.Text == "") {

                    MessageBox.Show("Digita tus credenciales");

                }else
                user_verificar = TBnombre.Text;
                contra_verificar = TBcontra.Text;
                StreamReader leer;
                leer = File.OpenText("datosclientes.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] separador = { '-' };
                bool autorizado = false;
                cadena = leer.ReadLine();
                while (cadena != null && autorizado == false)
                {

                    arreglo = cadena.Split(separador);
                    if (arreglo[0].Trim().Equals(user_verificar) && arreglo[1].Trim().Equals(contra_verificar))
                    {
                        IrAmenu();
                        autorizado = true;
                    }
                    else {

                        cadena = leer.ReadLine();
                    }

                }
                if (autorizado==false) {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error:" + error);
            }

           }

                    
                

               

            
        
    

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            RegistroCliente form2 = new RegistroCliente();
            form2.Show();
            this.Hide();

        }

        private void TBnombre_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
