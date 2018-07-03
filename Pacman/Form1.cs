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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            if (Jugador.Text == "")
            {
                MessageBox.Show("No ha ingresado un usario");
            }
            else
            {
                Juego jugar = new Juego();

                jugar.Show();
                this.Hide();
            }
        }
    }
}
