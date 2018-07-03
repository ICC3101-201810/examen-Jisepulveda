namespace Pacman
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.PacmanImg = new System.Windows.Forms.PictureBox();
            this.timerPacman = new System.Windows.Forms.Timer(this.components);
            this.FantasmaRosado = new System.Windows.Forms.PictureBox();
            this.FantasmaRojo = new System.Windows.Forms.PictureBox();
            this.timerFrutas = new System.Windows.Forms.Timer(this.components);
            this.Guinda = new System.Windows.Forms.PictureBox();
            this.Uva = new System.Windows.Forms.PictureBox();
            this.Contador = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PacmanImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantasmaRosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantasmaRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guinda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uva)).BeginInit();
            this.SuspendLayout();
            // 
            // PacmanImg
            // 
            this.PacmanImg.Image = ((System.Drawing.Image)(resources.GetObject("PacmanImg.Image")));
            this.PacmanImg.Location = new System.Drawing.Point(288, 295);
            this.PacmanImg.Name = "PacmanImg";
            this.PacmanImg.Size = new System.Drawing.Size(20, 20);
            this.PacmanImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PacmanImg.TabIndex = 0;
            this.PacmanImg.TabStop = false;
            // 
            // timerPacman
            // 
            this.timerPacman.Enabled = true;
            this.timerPacman.Interval = 1;
            this.timerPacman.Tick += new System.EventHandler(this.timerPacman_Tick);
            // 
            // FantasmaRosado
            // 
            this.FantasmaRosado.Image = ((System.Drawing.Image)(resources.GetObject("FantasmaRosado.Image")));
            this.FantasmaRosado.Location = new System.Drawing.Point(108, 139);
            this.FantasmaRosado.Name = "FantasmaRosado";
            this.FantasmaRosado.Size = new System.Drawing.Size(20, 20);
            this.FantasmaRosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FantasmaRosado.TabIndex = 1;
            this.FantasmaRosado.TabStop = false;
            // 
            // FantasmaRojo
            // 
            this.FantasmaRojo.Image = ((System.Drawing.Image)(resources.GetObject("FantasmaRojo.Image")));
            this.FantasmaRojo.Location = new System.Drawing.Point(332, 138);
            this.FantasmaRojo.Name = "FantasmaRojo";
            this.FantasmaRojo.Size = new System.Drawing.Size(20, 20);
            this.FantasmaRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FantasmaRojo.TabIndex = 2;
            this.FantasmaRojo.TabStop = false;
            // 
            // timerFrutas
            // 
            this.timerFrutas.Enabled = true;
            this.timerFrutas.Interval = 30000;
            this.timerFrutas.Tick += new System.EventHandler(this.timerFrutas_Tick);
            // 
            // Guinda
            // 
            this.Guinda.Image = ((System.Drawing.Image)(resources.GetObject("Guinda.Image")));
            this.Guinda.Location = new System.Drawing.Point(124, 401);
            this.Guinda.Name = "Guinda";
            this.Guinda.Size = new System.Drawing.Size(21, 20);
            this.Guinda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Guinda.TabIndex = 3;
            this.Guinda.TabStop = false;
            // 
            // Uva
            // 
            this.Uva.Image = ((System.Drawing.Image)(resources.GetObject("Uva.Image")));
            this.Uva.Location = new System.Drawing.Point(393, 414);
            this.Uva.Name = "Uva";
            this.Uva.Size = new System.Drawing.Size(21, 20);
            this.Uva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Uva.TabIndex = 4;
            this.Uva.TabStop = false;
            // 
            // Contador
            // 
            this.Contador.Interval = 10000;
            this.Contador.Tick += new System.EventHandler(this.Contador_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.Control;
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(72, 20);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score : 0";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Uva);
            this.Controls.Add(this.Guinda);
            this.Controls.Add(this.FantasmaRojo);
            this.Controls.Add(this.FantasmaRosado);
            this.Controls.Add(this.PacmanImg);
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PacmanImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantasmaRosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantasmaRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guinda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PacmanImg;
        private System.Windows.Forms.Timer timerPacman;
        private System.Windows.Forms.PictureBox FantasmaRosado;
        private System.Windows.Forms.PictureBox FantasmaRojo;
        private System.Windows.Forms.Timer timerFrutas;
        private System.Windows.Forms.PictureBox Guinda;
        private System.Windows.Forms.PictureBox Uva;
        private System.Windows.Forms.Timer Contador;
        private System.Windows.Forms.Label Score;
    }
}