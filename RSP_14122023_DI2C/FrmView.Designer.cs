namespace RSP_14122023_DIV2C
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            pcbEmergenciaEnCurso = new PictureBox();
            lblVida = new Label();
            pgbVida = new ProgressBar();
            imglServidores = new ImageList(components);
            btnAbrirCentro = new Button();
            btnEnviarBombero = new Button();
            btnEnviarMedico = new Button();
            btnEnviarPolicia = new Button();
            btnCerrarCentro = new Button();
            pcbServidorPublico = new PictureBox();
            lblProbabilidad = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbEmergenciaEnCurso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbServidorPublico).BeginInit();
            SuspendLayout();
            // 
            // pcbEmergenciaEnCurso
            // 
            pcbEmergenciaEnCurso.Location = new Point(377, 12);
            pcbEmergenciaEnCurso.Name = "pcbEmergenciaEnCurso";
            pcbEmergenciaEnCurso.Size = new Size(177, 153);
            pcbEmergenciaEnCurso.SizeMode = PictureBoxSizeMode.Zoom;
            pcbEmergenciaEnCurso.TabIndex = 0;
            pcbEmergenciaEnCurso.TabStop = false;
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.BackColor = Color.MediumSeaGreen;
            lblVida.Location = new Point(380, 210);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(35, 15);
            lblVida.TabIndex = 1;
            lblVida.Text = "100%";
            // 
            // pgbVida
            // 
            pgbVida.Location = new Point(380, 202);
            pgbVida.Name = "pgbVida";
            pgbVida.Size = new Size(174, 32);
            pgbVida.Step = 1;
            pgbVida.TabIndex = 2;
            pgbVida.Value = 100;
            // 
            // imglServidores
            // 
            imglServidores.ColorDepth = ColorDepth.Depth32Bit;
            imglServidores.ImageStream = (ImageListStreamer)resources.GetObject("imglServidores.ImageStream");
            imglServidores.TransparentColor = Color.Transparent;
            imglServidores.Images.SetKeyName(0, "bombero.gif");
            imglServidores.Images.SetKeyName(1, "medico.gif");
            imglServidores.Images.SetKeyName(2, "policia.gif");
            // 
            // btnAbrirCentro
            // 
            btnAbrirCentro.Location = new Point(7, 302);
            btnAbrirCentro.Name = "btnAbrirCentro";
            btnAbrirCentro.Size = new Size(150, 56);
            btnAbrirCentro.TabIndex = 3;
            btnAbrirCentro.Text = "Abrir Centro";
            btnAbrirCentro.UseVisualStyleBackColor = true;
            btnAbrirCentro.Click += btnAbrirCentro_Click;
            // 
            // btnEnviarBombero
            // 
            btnEnviarBombero.FlatStyle = FlatStyle.Flat;
            btnEnviarBombero.Image = Properties.Resources.bomberoIcono;
            btnEnviarBombero.Location = new Point(7, 12);
            btnEnviarBombero.Name = "btnEnviarBombero";
            btnEnviarBombero.Size = new Size(64, 64);
            btnEnviarBombero.TabIndex = 4;
            btnEnviarBombero.UseVisualStyleBackColor = true;
            btnEnviarBombero.Click += btnEnviarBombero_Click;
            // 
            // btnEnviarMedico
            // 
            btnEnviarMedico.FlatStyle = FlatStyle.Flat;
            btnEnviarMedico.Image = Properties.Resources.medicoIcono;
            btnEnviarMedico.Location = new Point(7, 82);
            btnEnviarMedico.Name = "btnEnviarMedico";
            btnEnviarMedico.Size = new Size(64, 64);
            btnEnviarMedico.TabIndex = 5;
            btnEnviarMedico.UseVisualStyleBackColor = true;
            btnEnviarMedico.Click += btnEnviarMedico_Click;
            // 
            // btnEnviarPolicia
            // 
            btnEnviarPolicia.FlatStyle = FlatStyle.Flat;
            btnEnviarPolicia.Image = Properties.Resources.policiaIcono;
            btnEnviarPolicia.Location = new Point(7, 152);
            btnEnviarPolicia.Name = "btnEnviarPolicia";
            btnEnviarPolicia.Size = new Size(64, 64);
            btnEnviarPolicia.TabIndex = 6;
            btnEnviarPolicia.UseVisualStyleBackColor = true;
            btnEnviarPolicia.Click += btnEnviarPolicia_Click;
            // 
            // btnCerrarCentro
            // 
            btnCerrarCentro.Location = new Point(404, 302);
            btnCerrarCentro.Name = "btnCerrarCentro";
            btnCerrarCentro.Size = new Size(150, 56);
            btnCerrarCentro.TabIndex = 7;
            btnCerrarCentro.Text = "Cerrar Centro";
            btnCerrarCentro.UseVisualStyleBackColor = true;
            btnCerrarCentro.Click += btnCerrarCentro_Click;
            // 
            // pcbServidorPublico
            // 
            pcbServidorPublico.Location = new Point(170, 12);
            pcbServidorPublico.Name = "pcbServidorPublico";
            pcbServidorPublico.Size = new Size(177, 153);
            pcbServidorPublico.SizeMode = PictureBoxSizeMode.Zoom;
            pcbServidorPublico.TabIndex = 8;
            pcbServidorPublico.TabStop = false;
            // 
            // lblProbabilidad
            // 
            lblProbabilidad.AutoSize = true;
            lblProbabilidad.Location = new Point(380, 184);
            lblProbabilidad.Name = "lblProbabilidad";
            lblProbabilidad.Size = new Size(115, 15);
            lblProbabilidad.TabIndex = 9;
            lblProbabilidad.Text = "Probabilidad de vida";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 363);
            Controls.Add(lblProbabilidad);
            Controls.Add(pcbServidorPublico);
            Controls.Add(btnCerrarCentro);
            Controls.Add(btnEnviarPolicia);
            Controls.Add(btnEnviarMedico);
            Controls.Add(btnEnviarBombero);
            Controls.Add(btnAbrirCentro);
            Controls.Add(lblVida);
            Controls.Add(pgbVida);
            Controls.Add(pcbEmergenciaEnCurso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Centro de emergencias";
            Load += FrmView_Load;
            ((System.ComponentModel.ISupportInitialize)pcbEmergenciaEnCurso).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbServidorPublico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbEmergenciaEnCurso;
        private Label lblVida;
        private ProgressBar pgbVida;
        private ImageList imglServidores;
        private Button btnAbrirCentro;
        private Button btnEnviarBombero;
        private Button btnEnviarMedico;
        private Button btnEnviarPolicia;
        private Button btnCerrarCentro;
        private PictureBox pcbServidorPublico;
        private Label lblProbabilidad;
    }
}
