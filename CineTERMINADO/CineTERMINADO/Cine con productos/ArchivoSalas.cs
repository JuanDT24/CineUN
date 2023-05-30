using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class ArchivoSalas
    {

        public string readfile(string name)
        {
            TextReader lecturaN = new StreamReader(name + ".txt");
            string string_ = lecturaN.ReadLine();
            lecturaN.Close();
            return string_;
        }
        public string[] findDatachair(string name, string data, Tipo_Sala tipo)
        {
            TextReader lecturaN = new StreamReader(name + ".txt");
            string[] resultado = new string[77];

            Dictionary<string, string[]> diccionario = tipo.gettiposala();
            List<string> keys = new List<string>(diccionario.Keys);
            List<string[]> values = new List<string[]>(diccionario.Values);


            string temp = "";
            string x;
            int sw2 = 0;

            while (temp != null && sw2 == 0)
            {
                int i = 0;
                int j = 0;
                temp = lecturaN.ReadLine();
                x = temp;

                if (x != null)
                {
                    string[] vector = x.Split('/');
                    while (i < 3 && sw2 == 0)
                    {
                        if (keys[i] == vector[0])
                        {
                            while (j < 3 && sw2 == 0)

                            {
                                int k = 0;
                                while (k < 3) { 
                                if (values[j][k].ToString() == vector[1])
                                {
                                    if (data == vector[2])
                                    {
                                        for (int l = 3; l < 76; l++)
                                        {
                                            resultado[l - 3] = vector[l];
                                        }
                                        sw2 = 1;
                                    }

                                }
                                k++;
                                }
                                j++;
                            }
                        }
                        i++;
                    }
                }

            }

            if (sw2 == 1)
            {
                lecturaN.Close();
                return resultado;
            }
            else
            {
                lecturaN.Close();
                return null;
            }

            

        }
        public string[] get_room_Data(string name, string data, Tipo_Sala tipo)
        {
            TextReader lecturaN = new StreamReader(name + ".txt");
            string[] resultado = new string[4];

            Dictionary<string, string[]> diccionario = tipo.gettiposala();
            List<string> keys = new List<string>(diccionario.Keys);
            List<string[]> values = new List<string[]>(diccionario.Values);


            string temp = "";
            string x;
            int sw2 = 0;

            while (temp != null && sw2 == 0)
            {
                int i = 0;
                int j = 0;
                temp = lecturaN.ReadLine();
                x = temp;

                if (x != null)
                {
                    string[] vector = x.Split('/');
                    while (i < 3 && sw2 == 0)
                    {
                        if (keys[i] == vector[0])
                        {
                            resultado[0] = keys[i];
                            while (j < 3 && sw2 == 0)
                            {
                                int k = 0;
                                while (k < 3) { 
                                if (values[j][k].ToString() == vector[1])
                                {
                                    resultado[1] = values[j][k].ToString();
                                    if (data == vector[2])
                                    {
                                        resultado[2] = data;
                                        sw2 = 1;
                                    }

                                }
                                k++;
                               
                                }
                                j++;
                            }
                        }
                        i++;
                    }
                }

            }

            if (sw2 == 1)
            {
                lecturaN.Close();
                return resultado;

            }
            else
            {
                lecturaN.Close();
                return null;
            }
        }

    }
}
