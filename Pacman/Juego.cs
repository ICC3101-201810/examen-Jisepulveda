using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Juego : Form
    {

        Random random = new Random();
        int Puntaje = 0;
        public Juego()
        {
            InitializeComponent();

            int xRed = random.Next(0, this.Width);
            int yRed = random.Next(0, this.Height);
            int xPink = random.Next(0, this.Width);
            int yPink = random.Next(0, this.Height);

            FantasmaRojo.Location = new Point(xRed, yRed);
            FantasmaRosado.Location = new Point(xPink, yPink);

            Guinda.Visible = false;
            Uva.Visible = false;
        }
        public enum Flechas
        {
            Arriba = 1,
            Abajo = 2,
            Izquierda = 3,
            Derecha = 4

        }

        Flechas flecha;

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            //left = 37
            //Up = 38
            //right = 39
            //down = 40
            
            if (e.KeyValue == 38)
            {
                flecha = Flechas.Arriba;
            }
            if (e.KeyValue == 40)
            {
                flecha = Flechas.Abajo;
            }
            if (e.KeyValue == 37)
            {
                flecha = Flechas.Izquierda;
            }
            if (e.KeyValue == 39)
            {
                flecha = Flechas.Derecha;
            }
        }

        private void timerPacman_Tick(object sender, EventArgs e)
        {
            switch (flecha)
            {
                case Flechas.Arriba:
                    if (PacmanImg.Location.Y > 0)
                    {
                        PacmanImg.Location = new Point(PacmanImg.Location.X, PacmanImg.Location.Y - 1);
                    }
                    else
                    {
                        PacmanImg.Location = new Point(PacmanImg.Location.X, this.Height);
                    }
                    break;

                case Flechas.Abajo:
                    if (PacmanImg.Location.Y < this.Height + PacmanImg.Height)
                    {
                        PacmanImg.Location = new Point(PacmanImg.Location.X, PacmanImg.Location.Y + 1);
                    }
                    else
                    {
                        PacmanImg.Location = new Point(PacmanImg.Location.X, 0);
                    }
                    break;

                case Flechas.Izquierda:
                    if (PacmanImg.Location.X > 0)
                    {
                        PacmanImg.Location = new Point(PacmanImg.Location.X - 1, PacmanImg.Location.Y);
                    }
                    else
                    {
                        PacmanImg.Location = new Point(this.Width ,PacmanImg.Location.Y);
                    }
                    break;

                case Flechas.Derecha:
                    if (PacmanImg.Location.X < PacmanImg.Width + this.Width)
                    {
                        PacmanImg.Location = new Point(PacmanImg.Location.X + 1, PacmanImg.Location.Y);
                    }
                    else
                    {
                        PacmanImg.Location = new Point(0 ,PacmanImg.Location.Y);
                    }
                    break;

                default:
                    break;
            }


            if (PacmanImg.Location.Y == Guinda.Location.Y + Guinda.Height && Guinda.Visible == true)
            {
                Puntaje += 10;
                Guinda.Visible = false;
                Score.Text = "Score : " + Puntaje;
            }

            if (PacmanImg.Location.Y == Uva.Location.Y + Uva.Height && Uva.Visible == true)
            {
                Puntaje += 15;
                Uva.Visible = false;
                Score.Text = "Score : " + Puntaje;
            }

            if (PacmanImg.Location.X == Guinda.Location.X + Guinda.Width && Guinda.Visible == true)
            {
                Puntaje += 10;
                Guinda.Visible = false;
                Score.Text = "Score : " + Puntaje;
            }

            if (PacmanImg.Location.X == Uva.Location.X + Uva.Width && Uva.Visible == true)
            {
                Puntaje += 15;
                Uva.Visible = false;
                Score.Text = "Score : " + Puntaje;
            }

            if (PacmanImg.Location.Y + PacmanImg.Height == Guinda.Location.Y && Guinda.Visible == true)
            {
                Puntaje += 10;
                Guinda.Visible = false;
                Score.Text = "Score : " + Puntaje;
            }

            if (PacmanImg.Location.Y + PacmanImg.Height == Uva.Location.Y && Uva.Visible == true)
            {
                Puntaje += 15;
                Uva.Visible = false;
                Score.Text = "Score : " + Puntaje;
            }

            if (PacmanImg.Location.X + PacmanImg.Width == Guinda.Location.X && Guinda.Visible == true)
            {
                Puntaje += 10;
                Guinda.Visible = false;
                Score.Text = "Score : " + Puntaje;
            }

            if (PacmanImg.Location.X + PacmanImg.Width == Uva.Location.X && Uva.Visible == true)
            {
                Puntaje += 15;
                Uva.Visible = false;
                Score.Text = "Score : " + Puntaje;
            }

        }

        

        private void timerFrutas_Tick(object sender, EventArgs e)
        {
            
            int xGuinda = random.Next(0, this.Width - Guinda.Width);
            int yGuinda = random.Next(0, this.Height - Guinda.Height);
            int xUva = random.Next(0, this.Width - Uva.Width);
            int yUva = random.Next(0, this.Height - Uva.Height);

            Guinda.Location = new Point(xGuinda, yGuinda);
            Uva.Location = new Point(xUva, yUva);

            Guinda.Visible = true;
            Uva.Visible = true;

            Contador.Enabled = true;
            Contador.Start();
            


            
        }

        private void Contador_Tick(object sender, EventArgs e)
        {
            Guinda.Visible = false;
            Uva.Visible = false;

            Contador.Stop();
            Contador.Enabled = false;
        }
    }
}
