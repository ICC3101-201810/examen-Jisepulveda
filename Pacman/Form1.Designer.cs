namespace Pacman
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bienvenido = new System.Windows.Forms.Label();
            this.NombreJugador = new System.Windows.Forms.Label();
            this.Jugador = new System.Windows.Forms.TextBox();
            this.Jugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bienvenido
            // 
            this.Bienvenido.AutoSize = true;
            this.Bienvenido.Font = new System.Drawing.Font("Bauhaus 93", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenido.Location = new System.Drawing.Point(55, 9);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(562, 108);
            this.Bienvenido.TabIndex = 0;
            this.Bienvenido.Text = "BIENVENIDO";
            // 
            // NombreJugador
            // 
            this.NombreJugador.AutoSize = true;
            this.NombreJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreJugador.Location = new System.Drawing.Point(281, 161);
            this.NombreJugador.Name = "NombreJugador";
            this.NombreJugador.Size = new System.Drawing.Size(110, 16);
            this.NombreJugador.TabIndex = 1;
            this.NombreJugador.Text = "Nombre Jugador";
            // 
            // Jugador
            // 
            this.Jugador.Location = new System.Drawing.Point(235, 196);
            this.Jugador.Name = "Jugador";
            this.Jugador.Size = new System.Drawing.Size(203, 20);
            this.Jugador.TabIndex = 2;
            // 
            // Jugar
            // 
            this.Jugar.Location = new System.Drawing.Point(299, 235);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(75, 23);
            this.Jugar.TabIndex = 3;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 277);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.Jugador);
            this.Controls.Add(this.NombreJugador);
            this.Controls.Add(this.Bienvenido);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenido;
        private System.Windows.Forms.Label NombreJugador;
        private System.Windows.Forms.TextBox Jugador;
        private System.Windows.Forms.Button Jugar;
    }
}

