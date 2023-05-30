using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Taquilla : Form
    {
        private Image imagenBoton1 = Properties.Resources.avatar;
        private string textoboton1 = "Sinopsis:\nJake Sully y Ney'tiri han formado una familia y hacen\ntodo lo posible por permanecer juntos. Sin embargo,\ndeben abandonar su hogar y explorar las regiones de\nPandora cuando una antigua amenaza reaparece.";
        private string textoboton3 = "Reparto:\nSam Worthington, Zoe Saldaña, Stephen Lang y Sigourney Weaver";
        private string textoboton2 = "Titulo: Avatar 2";
        private string textoboton4 = "Duracion: 202 Min";
        private string textoboton5 = "Accion, Aventura";
        private string textoboton6 = "Director:  James Cameron";
        private Image mario = Properties.Resources.mariocartelera;
        private string mariotext1 = "Sinopsis:\nUn fontanero llamado Mario viaja por un laberinto\nsubterráneo con su hermano, Luigi, intentando\nsalvar a una princesa capturada.";
        private string mariotext3 = "Reparto:\nJack Black, Anya Taylor-Joy, Chris Pratt y Charlie Day";
        private string mariotext2 = "Titulo: Super Mario Bros La Película";
        private string mariotext4 = "Duracion: 100 Min";
        private string mariotext5 = "Accion, Animada, Comedia";
        private string mariotext6 = "Director: Chris Meledandri, Shigeru Miyamoto";
        private Image suzume = Properties.Resources.suzume_grande;
        private string suzumetext1 = "Sinopsis:\nUna joven de 17 años llamada Suzume ayuda a un misterioso\njoven a cerrar las puertas de otro mundo que están provocando\ndesastres en todo Japón.";
        private string suzumetext2 = "Titulo: Suzume";
        private string suzumetext3 = "Reparto: Hokuto Matsumura, Nanoka Hara, Kana Hanazawa\ny Ryūnosuke Kamiki";
        private string suzumetext4 = "Duracion: 122 Min";
        private string suzumetext5 = "Animada, Fantasía";
        private string suzumetext6 = "Director: Makoto Shinkai";
        private Image rapido = Properties.Resources.fast_cartelera;
        private string fasttext1 = "Sinopsis:\nEl ex-convicto Dominic Toretto ahora tiene la responsabilidad de proteger\na su equipo y a su familia de un nuevo y peligroso villano llamado Dante,\nel cual resulta ser el hijo del antiguo mafioso y narcotraficante brasileño , \nHernán Reyes, quien ha estado planeando su venganza por la muerte de\nsu padre durante los últimos doce años desde los acontecimientos de Fast Five.";
        private string fasttext2 = "Titulo: Rápidos y furiosos 10";
        private string fasttext3 = "Reparto: Vin diesel, Jason Momoa, Alan Ritchson, Michelle Rodriguez\nBrie Larson, Sung Kang, Jason Statham, Tyrese Gibson\nJordana Brewster y John Cena ";
        private string fasttext4 = "Duracion: 141 Min";
        private string fasttext5 = "Accion, Aventura, Crimen";
        private string fasttext6 = "Director: Louis Leterrier";
        private Image spiderman = Properties.Resources.spiderman_grande;
        private string spidertext1 = "Sinopsis:\nMiles Morales se embarca en una aventura épica que\ntransportará al simpático Spiderman de Brooklyn a través\ndel Multiverso para unir fuerzas con Gwen Stacy y un\nnuevo equipo.";
        private string spidertext2 = "Titulo: Spider-man a través del spiderverso";
        private string spidertext3 = "Reparto: Hailee Steinfeld, Shameik Moore,Oscar Isaac y Daniel Kaluuya";
        private string spidertext4 = "Duracion: 120 Min";
        private string spidertext5 = "Accion, Aventura, Fantasía";
        private string spidertext6 = "Director: Joaquim Dos Santos, Justin K. Thompson y Kemp Powers ";
        private Image John = Properties.Resources.john_wick_g;
        private string johntext1 = "Sinopsis\nJohn Wick, legendario asesino retirado, vuelve de nuevo a la\nacción impulsado por una incontrolable búsqueda de\nvenganza. Al tener que luchar contra asesinos sedientos de\nsangre que le persiguen, John tendrá que llevar sus habilidades\nal límite si quiere salir esta vez con vida.";
        private string johntext2 = "Titulo: John Wick 4";
        private string johntext3 = "Reparto: Keanu Reeves,Rina Sawayama, Bill Skarsgård, Donnie Yen\nLaurence Fishburne, Ian McShane, Natalia Tena, Shamier Anderson\nMarko Zaror, Scott Adkins, Lance Reddick, Hiroyuki Sanada     ";
        private string johntext4 = "Duracion: 169 Min";
        private string johntext5 = "Accion, Thriller";
        private string johntext6 = "Director: Chad Stahelski";
        string[] Avatar = new string[] { "14:00", "16:00", "18:00", "15:30", "20:00", "16:30", "21:30" };
        string[] jh = new string[] { "14:15", "16:30", "18:45", "17:30", "22:00", "15:00", "18:00" };
        string[] Mario = new string[] { "13:00", "15:25", "16:45", "17:10", "21:30", "19:00", "20:20" };
        string[] Suzume = new string[] { "13:20", "17:25", "18:00", "20:10", "21:30", "15:45", "19:30" };
        string[] Fast = new string[] { "12:30", "13:10", "16:15", "11:30", "20:00", "13:50", "18:20" };
        string[] Spider = new string[] { "14:20", "15:50", "18:45", "11:00", "21:00", "16:40", "22:00" };
        public Taquilla()
        {
            InitializeComponent();
             

    }

        private void peli1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2(imagenBoton1, textoboton1,textoboton2, textoboton3, textoboton4, textoboton5,textoboton6, Avatar);
            formulario.Show();
            this.Hide();

        }

        private void peli2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2(mario, mariotext1, mariotext2, mariotext3, mariotext4, mariotext5,mariotext6,Mario);
            formulario.Show();
                this.Hide(); 
        }

        private void peli3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2(suzume, suzumetext1, suzumetext2, suzumetext3, suzumetext4, suzumetext5, suzumetext6, Suzume);
            formulario.Show();
            this.Hide();
        }

        private void peli4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2(rapido, fasttext1, fasttext2, fasttext3, fasttext4, fasttext5, fasttext6, Fast);
            formulario.Show();
            this.Hide();
        }

        private void peli5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2(spiderman, spidertext1, spidertext2, spidertext3, spidertext4, spidertext5, spidertext6, Spider);
            formulario.Show();
            this.Hide();
        }

        private void peli6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2(John, johntext1, johntext2, johntext3, johntext4, johntext5, johntext6, jh);
            formulario.Show();
            this.Hide();
        }

        private void Taquilla_Load(object sender, EventArgs e)
        {

        }
    }
}
