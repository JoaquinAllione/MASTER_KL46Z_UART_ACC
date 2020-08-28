namespace UART_ACC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_controles = new System.Windows.Forms.Panel();
            this.label_titulo = new System.Windows.Forms.Label();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.txtAccX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPuertos = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.txtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtAccY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccZ = new System.Windows.Forms.TextBox();
            this.btn_leer_3_ejes = new System.Windows.Forms.Button();
            this.btn_leer_Y = new System.Windows.Forms.Button();
            this.btn_leer_Z = new System.Windows.Forms.Button();
            this.btn_leer_X = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_detener = new System.Windows.Forms.Button();
            this.panel_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_controles
            // 
            this.panel_controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel_controles.Controls.Add(this.label_titulo);
            this.panel_controles.Controls.Add(this.button_minimizar);
            this.panel_controles.Controls.Add(this.button_cerrar);
            this.panel_controles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_controles.Location = new System.Drawing.Point(0, 0);
            this.panel_controles.Name = "panel_controles";
            this.panel_controles.Size = new System.Drawing.Size(441, 32);
            this.panel_controles.TabIndex = 37;
            this.panel_controles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_controles_MouseMove);
            // 
            // label_titulo
            // 
            this.label_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.label_titulo.Location = new System.Drawing.Point(131, 8);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(183, 16);
            this.label_titulo.TabIndex = 37;
            this.label_titulo.Text = "ACELEROMETRO KL46-Z";
            this.label_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_titulo_MouseMove);
            // 
            // button_minimizar
            // 
            this.button_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimizar.FlatAppearance.BorderSize = 0;
            this.button_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("button_minimizar.Image")));
            this.button_minimizar.Location = new System.Drawing.Point(377, 0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(32, 32);
            this.button_minimizar.TabIndex = 37;
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cerrar.FlatAppearance.BorderSize = 0;
            this.button_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("button_cerrar.Image")));
            this.button_cerrar.Location = new System.Drawing.Point(409, 0);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(32, 32);
            this.button_cerrar.TabIndex = 37;
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // txtAccX
            // 
            this.txtAccX.BackColor = System.Drawing.Color.White;
            this.txtAccX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAccX.Location = new System.Drawing.Point(79, 162);
            this.txtAccX.Name = "txtAccX";
            this.txtAccX.ReadOnly = true;
            this.txtAccX.Size = new System.Drawing.Size(64, 22);
            this.txtAccX.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(27, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Eje X:";
            // 
            // cbxPuertos
            // 
            this.cbxPuertos.BackColor = System.Drawing.Color.White;
            this.cbxPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPuertos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxPuertos.FormattingEnabled = true;
            this.cbxPuertos.Location = new System.Drawing.Point(123, 54);
            this.cbxPuertos.Name = "cbxPuertos";
            this.cbxPuertos.Size = new System.Drawing.Size(121, 24);
            this.cbxPuertos.TabIndex = 47;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.BackColor = System.Drawing.Color.White;
            this.cbxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBaudRate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(123, 89);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cbxBaudRate.TabIndex = 46;
            // 
            // txtDatosRecibidos
            // 
            this.txtDatosRecibidos.BackColor = System.Drawing.Color.White;
            this.txtDatosRecibidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosRecibidos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDatosRecibidos.Location = new System.Drawing.Point(159, 127);
            this.txtDatosRecibidos.Name = "txtDatosRecibidos";
            this.txtDatosRecibidos.ReadOnly = true;
            this.txtDatosRecibidos.Size = new System.Drawing.Size(250, 22);
            this.txtDatosRecibidos.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Datos Recibidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "BaudRate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Puerto:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.LightGray;
            this.btnDesconectar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesconectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDesconectar.Location = new System.Drawing.Point(253, 89);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(156, 23);
            this.btnDesconectar.TabIndex = 41;
            this.btnDesconectar.Text = "DESCONECTAR";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.LightGray;
            this.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConectar.Location = new System.Drawing.Point(253, 55);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(156, 23);
            this.btnConectar.TabIndex = 40;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtAccY
            // 
            this.txtAccY.BackColor = System.Drawing.Color.White;
            this.txtAccY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAccY.Location = new System.Drawing.Point(215, 162);
            this.txtAccY.Name = "txtAccY";
            this.txtAccY.ReadOnly = true;
            this.txtAccY.Size = new System.Drawing.Size(64, 22);
            this.txtAccY.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(163, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Eje Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(293, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Eje Z:";
            // 
            // txtAccZ
            // 
            this.txtAccZ.BackColor = System.Drawing.Color.White;
            this.txtAccZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccZ.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAccZ.Location = new System.Drawing.Point(345, 161);
            this.txtAccZ.Name = "txtAccZ";
            this.txtAccZ.ReadOnly = true;
            this.txtAccZ.Size = new System.Drawing.Size(64, 22);
            this.txtAccZ.TabIndex = 53;
            // 
            // btn_leer_3_ejes
            // 
            this.btn_leer_3_ejes.BackColor = System.Drawing.Color.LightGray;
            this.btn_leer_3_ejes.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_leer_3_ejes.FlatAppearance.BorderSize = 0;
            this.btn_leer_3_ejes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_leer_3_ejes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_leer_3_ejes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leer_3_ejes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leer_3_ejes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_leer_3_ejes.Location = new System.Drawing.Point(321, 196);
            this.btn_leer_3_ejes.Name = "btn_leer_3_ejes";
            this.btn_leer_3_ejes.Size = new System.Drawing.Size(88, 23);
            this.btn_leer_3_ejes.TabIndex = 57;
            this.btn_leer_3_ejes.Text = "X-Y-Z";
            this.btn_leer_3_ejes.UseVisualStyleBackColor = false;
            this.btn_leer_3_ejes.Click += new System.EventHandler(this.btn_leer_3_ejes_Click);
            // 
            // btn_leer_Y
            // 
            this.btn_leer_Y.BackColor = System.Drawing.Color.LightGray;
            this.btn_leer_Y.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_leer_Y.FlatAppearance.BorderSize = 0;
            this.btn_leer_Y.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_leer_Y.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_leer_Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leer_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leer_Y.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_leer_Y.Location = new System.Drawing.Point(128, 196);
            this.btn_leer_Y.Name = "btn_leer_Y";
            this.btn_leer_Y.Size = new System.Drawing.Size(88, 23);
            this.btn_leer_Y.TabIndex = 56;
            this.btn_leer_Y.Text = "Y";
            this.btn_leer_Y.UseVisualStyleBackColor = false;
            this.btn_leer_Y.Click += new System.EventHandler(this.btn_leer_Y_Click);
            // 
            // btn_leer_Z
            // 
            this.btn_leer_Z.BackColor = System.Drawing.Color.LightGray;
            this.btn_leer_Z.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_leer_Z.FlatAppearance.BorderSize = 0;
            this.btn_leer_Z.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_leer_Z.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_leer_Z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leer_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leer_Z.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_leer_Z.Location = new System.Drawing.Point(224, 196);
            this.btn_leer_Z.Name = "btn_leer_Z";
            this.btn_leer_Z.Size = new System.Drawing.Size(88, 23);
            this.btn_leer_Z.TabIndex = 55;
            this.btn_leer_Z.Text = "Z";
            this.btn_leer_Z.UseVisualStyleBackColor = false;
            this.btn_leer_Z.Click += new System.EventHandler(this.btn_leer_Z_Click);
            // 
            // btn_leer_X
            // 
            this.btn_leer_X.BackColor = System.Drawing.Color.LightGray;
            this.btn_leer_X.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_leer_X.FlatAppearance.BorderSize = 0;
            this.btn_leer_X.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_leer_X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_leer_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leer_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leer_X.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_leer_X.Location = new System.Drawing.Point(31, 196);
            this.btn_leer_X.Name = "btn_leer_X";
            this.btn_leer_X.Size = new System.Drawing.Size(88, 23);
            this.btn_leer_X.TabIndex = 54;
            this.btn_leer_X.Text = "X";
            this.btn_leer_X.UseVisualStyleBackColor = false;
            this.btn_leer_X.Click += new System.EventHandler(this.btn_leer_X_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_detener
            // 
            this.btn_detener.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_detener.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_detener.FlatAppearance.BorderSize = 0;
            this.btn_detener.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_detener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_detener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detener.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_detener.Location = new System.Drawing.Point(321, 227);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(88, 23);
            this.btn_detener.TabIndex = 58;
            this.btn_detener.Text = "DETENER";
            this.btn_detener.UseVisualStyleBackColor = false;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 385);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_leer_3_ejes);
            this.Controls.Add(this.btn_leer_Y);
            this.Controls.Add(this.btn_leer_Z);
            this.Controls.Add(this.btn_leer_X);
            this.Controls.Add(this.txtAccZ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAccY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAccX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPuertos);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.txtDatosRecibidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.panel_controles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_controles.ResumeLayout(false);
            this.panel_controles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_controles;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.TextBox txtAccX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPuertos;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.TextBox txtDatosRecibidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtAccY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccZ;
        private System.Windows.Forms.Button btn_leer_3_ejes;
        private System.Windows.Forms.Button btn_leer_Y;
        private System.Windows.Forms.Button btn_leer_Z;
        private System.Windows.Forms.Button btn_leer_X;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_detener;
    }
}

