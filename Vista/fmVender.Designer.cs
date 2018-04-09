namespace Vista
{
    partial class fmVender
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtAccesorios = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.cmbTipoCoche = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbCargaImagen = new System.Windows.Forms.PictureBox();
            this.btnCargaImagen = new System.Windows.Forms.Button();
            this.ofdCargaImagen = new System.Windows.Forms.OpenFileDialog();
            this.btnVender = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(624, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 52);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources.ebayimage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(457, 222);
            this.txtMarca.MaxLength = 15;
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(171, 30);
            this.txtMarca.TabIndex = 2;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(457, 295);
            this.txtCiudad.MaxLength = 15;
            this.txtCiudad.Multiline = true;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(171, 27);
            this.txtCiudad.TabIndex = 2;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // txtLinea
            // 
            this.txtLinea.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.Location = new System.Drawing.Point(457, 258);
            this.txtLinea.MaxLength = 15;
            this.txtLinea.Multiline = true;
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(171, 31);
            this.txtLinea.TabIndex = 2;
            this.txtLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinea_KeyPress);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(457, 327);
            this.txtModelo.MaxLength = 4;
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(171, 29);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometraje.Location = new System.Drawing.Point(457, 397);
            this.txtKilometraje.MaxLength = 7;
            this.txtKilometraje.Multiline = true;
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(171, 29);
            this.txtKilometraje.TabIndex = 2;
            this.txtKilometraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilometraje_KeyPress);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(457, 362);
            this.txtPlaca.MaxLength = 6;
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(171, 29);
            this.txtPlaca.TabIndex = 2;
            this.txtPlaca.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtAccesorios
            // 
            this.txtAccesorios.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccesorios.Location = new System.Drawing.Point(457, 506);
            this.txtAccesorios.MaxLength = 50;
            this.txtAccesorios.Multiline = true;
            this.txtAccesorios.Name = "txtAccesorios";
            this.txtAccesorios.Size = new System.Drawing.Size(171, 52);
            this.txtAccesorios.TabIndex = 2;
            this.txtAccesorios.TextChanged += new System.EventHandler(this.txtAccesorios_TextChanged);
            this.txtAccesorios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccesorios_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(457, 470);
            this.txtPrecio.MaxLength = 9;
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(171, 30);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtMotor
            // 
            this.txtMotor.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotor.Location = new System.Drawing.Point(457, 432);
            this.txtMotor.MaxLength = 15;
            this.txtMotor.Multiline = true;
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(171, 32);
            this.txtMotor.TabIndex = 2;
            // 
            // cmbTipoCoche
            // 
            this.cmbTipoCoche.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCoche.FormattingEnabled = true;
            this.cmbTipoCoche.Location = new System.Drawing.Point(457, 186);
            this.cmbTipoCoche.Name = "cmbTipoCoche";
            this.cmbTipoCoche.Size = new System.Drawing.Size(171, 30);
            this.cmbTipoCoche.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "INGRESE LOS DATOS DE SU VEHÍCULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de vehículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca del vehículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Linea del vehículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ciudad del vehículo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Modelo del vehículo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Placa del vehículo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kilometraje";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(284, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 27);
            this.label9.TabIndex = 6;
            this.label9.Text = "Motor del vehículo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(284, 506);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "Accesorios del vehículo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(284, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 27);
            this.label10.TabIndex = 6;
            this.label10.Text = "Precio del vehículo";
            // 
            // pbCargaImagen
            // 
            this.pbCargaImagen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbCargaImagen.Location = new System.Drawing.Point(647, 186);
            this.pbCargaImagen.Name = "pbCargaImagen";
            this.pbCargaImagen.Size = new System.Drawing.Size(347, 372);
            this.pbCargaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCargaImagen.TabIndex = 7;
            this.pbCargaImagen.TabStop = false;
            // 
            // btnCargaImagen
            // 
            this.btnCargaImagen.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaImagen.Location = new System.Drawing.Point(457, 571);
            this.btnCargaImagen.Name = "btnCargaImagen";
            this.btnCargaImagen.Size = new System.Drawing.Size(105, 29);
            this.btnCargaImagen.TabIndex = 8;
            this.btnCargaImagen.Text = "EXAMINAR...";
            this.btnCargaImagen.UseVisualStyleBackColor = true;
            this.btnCargaImagen.Click += new System.EventHandler(this.btnCargaImagen_Click);
            // 
            // ofdCargaImagen
            // 
            this.ofdCargaImagen.FileName = "openFileDialog1";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVender.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(529, 629);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(124, 40);
            this.btnVender.TabIndex = 9;
            this.btnVender.Text = "PUBLICAR VEHÍCULO";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(284, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 27);
            this.label11.TabIndex = 6;
            this.label11.Text = "Cargar foto";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(349, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(997, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnCargaImagen);
            this.Controls.Add(this.pbCargaImagen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoCoche);
            this.Controls.Add(this.txtMotor);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtAccesorios);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnSalir);
            this.Name = "fmVender";
            this.Text = "PUBLICACIÓN DEL VEHÍCULO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmVender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtAccesorios;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.ComboBox cmbTipoCoche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbCargaImagen;
        private System.Windows.Forms.Button btnCargaImagen;
        private System.Windows.Forms.OpenFileDialog ofdCargaImagen;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}