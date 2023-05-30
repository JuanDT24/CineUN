using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class Salas
    {
        int numerodesalas = 9;
    }
    internal class Tipo_Sala : Salas
    {
        Dictionary<string, string[]> numYtipo;
        string[] vector = new string[] { "1", "2", "3" };
        string[] vector2 = new string[] { "4", "5", "6" };
        string[] vector3 = new string[] { "7", "8", "9" };

        public Tipo_Sala() : base()
        {

            this.numYtipo = new Dictionary<string, string[]>() { { "2D", vector }, { "3D", vector2 }, { "4D", vector3 } };
        }

        public Dictionary<string, string[]> gettiposala()
        {
            return this.numYtipo;
        }
    }


}
