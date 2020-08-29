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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_detener = new System.Windows.Forms.Button();
            this.Check_X = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Check_Z = new System.Windows.Forms.PictureBox();
            this.Check_Y = new System.Windows.Forms.PictureBox();
            this.Uncheck_X = new System.Windows.Forms.PictureBox();
            this.Uncheck_Y = new System.Windows.Forms.PictureBox();
            this.Uncheck_Z = new System.Windows.Forms.PictureBox();
            this.dataGridView_Acc = new System.Windows.Forms.DataGridView();
            this.Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acc_Value_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acc_Value_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acc_Value_Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_X_Y_Z = new System.Windows.Forms.PictureBox();
            this.Uncheck_X_Y_Z = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label_conectado = new System.Windows.Forms.Label();
            this.btn_iniciar_lectura = new System.Windows.Forms.Button();
            this.panel_controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Check_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uncheck_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uncheck_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uncheck_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_X_Y_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uncheck_X_Y_Z)).BeginInit();
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
            this.panel_controles.Size = new System.Drawing.Size(440, 32);
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
            this.button_minimizar.Location = new System.Drawing.Point(376, 0);
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
            this.button_cerrar.Location = new System.Drawing.Point(408, 0);
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
            this.txtAccX.Location = new System.Drawing.Point(105, 163);
            this.txtAccX.Name = "txtAccX";
            this.txtAccX.ReadOnly = true;
            this.txtAccX.Size = new System.Drawing.Size(43, 22);
            this.txtAccX.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(53, 166);
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
            this.txtAccY.Location = new System.Drawing.Point(236, 164);
            this.txtAccY.Name = "txtAccY";
            this.txtAccY.ReadOnly = true;
            this.txtAccY.Size = new System.Drawing.Size(42, 22);
            this.txtAccY.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(184, 166);
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
            this.label7.Location = new System.Drawing.Point(315, 167);
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
            this.txtAccZ.Location = new System.Drawing.Point(367, 165);
            this.txtAccZ.Name = "txtAccZ";
            this.txtAccZ.ReadOnly = true;
            this.txtAccZ.Size = new System.Drawing.Size(42, 22);
            this.txtAccZ.TabIndex = 53;
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
            this.btn_detener.Location = new System.Drawing.Point(126, 387);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(88, 23);
            this.btn_detener.TabIndex = 58;
            this.btn_detener.Text = "DETENER";
            this.btn_detener.UseVisualStyleBackColor = false;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // Check_X
            // 
            this.Check_X.Image = ((System.Drawing.Image)(resources.GetObject("Check_X.Image")));
            this.Check_X.Location = new System.Drawing.Point(30, 164);
            this.Check_X.Name = "Check_X";
            this.Check_X.Size = new System.Drawing.Size(20, 20);
            this.Check_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Check_X.TabIndex = 59;
            this.Check_X.TabStop = false;
            this.Check_X.Click += new System.EventHandler(this.Check_X_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(0, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // Check_Z
            // 
            this.Check_Z.Image = ((System.Drawing.Image)(resources.GetObject("Check_Z.Image")));
            this.Check_Z.Location = new System.Drawing.Point(291, 164);
            this.Check_Z.Name = "Check_Z";
            this.Check_Z.Size = new System.Drawing.Size(20, 20);
            this.Check_Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Check_Z.TabIndex = 61;
            this.Check_Z.TabStop = false;
            this.Check_Z.Click += new System.EventHandler(this.Check_Z_Click);
            // 
            // Check_Y
            // 
            this.Check_Y.Image = ((System.Drawing.Image)(resources.GetObject("Check_Y.Image")));
            this.Check_Y.Location = new System.Drawing.Point(160, 164);
            this.Check_Y.Name = "Check_Y";
            this.Check_Y.Size = new System.Drawing.Size(20, 20);
            this.Check_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Check_Y.TabIndex = 62;
            this.Check_Y.TabStop = false;
            this.Check_Y.Click += new System.EventHandler(this.Check_Y_Click);
            // 
            // Uncheck_X
            // 
            this.Uncheck_X.Image = ((System.Drawing.Image)(resources.GetObject("Uncheck_X.Image")));
            this.Uncheck_X.Location = new System.Drawing.Point(30, 164);
            this.Uncheck_X.Name = "Uncheck_X";
            this.Uncheck_X.Size = new System.Drawing.Size(20, 20);
            this.Uncheck_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Uncheck_X.TabIndex = 64;
            this.Uncheck_X.TabStop = false;
            this.Uncheck_X.Click += new System.EventHandler(this.Uncheck_X_Click);
            // 
            // Uncheck_Y
            // 
            this.Uncheck_Y.Image = ((System.Drawing.Image)(resources.GetObject("Uncheck_Y.Image")));
            this.Uncheck_Y.Location = new System.Drawing.Point(160, 164);
            this.Uncheck_Y.Name = "Uncheck_Y";
            this.Uncheck_Y.Size = new System.Drawing.Size(20, 20);
            this.Uncheck_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Uncheck_Y.TabIndex = 65;
            this.Uncheck_Y.TabStop = false;
            this.Uncheck_Y.Click += new System.EventHandler(this.Uncheck_Y_Click);
            // 
            // Uncheck_Z
            // 
            this.Uncheck_Z.Image = ((System.Drawing.Image)(resources.GetObject("Uncheck_Z.Image")));
            this.Uncheck_Z.Location = new System.Drawing.Point(291, 164);
            this.Uncheck_Z.Name = "Uncheck_Z";
            this.Uncheck_Z.Size = new System.Drawing.Size(20, 20);
            this.Uncheck_Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Uncheck_Z.TabIndex = 66;
            this.Uncheck_Z.TabStop = false;
            this.Uncheck_Z.Click += new System.EventHandler(this.Uncheck_Z_Click);
            // 
            // dataGridView_Acc
            // 
            this.dataGridView_Acc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Acc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Acc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Acc.ColumnHeadersHeight = 25;
            this.dataGridView_Acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Acc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Muestra,
            this.Acc_Value_X,
            this.Acc_Value_Y,
            this.Acc_Value_Z});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Acc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Acc.EnableHeadersVisualStyles = false;
            this.dataGridView_Acc.Location = new System.Drawing.Point(30, 231);
            this.dataGridView_Acc.Name = "dataGridView_Acc";
            this.dataGridView_Acc.RowHeadersVisible = false;
            this.dataGridView_Acc.Size = new System.Drawing.Size(379, 142);
            this.dataGridView_Acc.TabIndex = 69;
            // 
            // Muestra
            // 
            this.Muestra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Muestra.HeaderText = "Muesta";
            this.Muestra.Name = "Muestra";
            // 
            // Acc_Value_X
            // 
            this.Acc_Value_X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Acc_Value_X.HeaderText = "Eje X";
            this.Acc_Value_X.Name = "Acc_Value_X";
            // 
            // Acc_Value_Y
            // 
            this.Acc_Value_Y.HeaderText = "Eje Y";
            this.Acc_Value_Y.Name = "Acc_Value_Y";
            // 
            // Acc_Value_Z
            // 
            this.Acc_Value_Z.HeaderText = "Eje Z";
            this.Acc_Value_Z.Name = "Acc_Value_Z";
            // 
            // Check_X_Y_Z
            // 
            this.Check_X_Y_Z.Image = ((System.Drawing.Image)(resources.GetObject("Check_X_Y_Z.Image")));
            this.Check_X_Y_Z.Location = new System.Drawing.Point(29, 198);
            this.Check_X_Y_Z.Name = "Check_X_Y_Z";
            this.Check_X_Y_Z.Size = new System.Drawing.Size(20, 20);
            this.Check_X_Y_Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Check_X_Y_Z.TabIndex = 63;
            this.Check_X_Y_Z.TabStop = false;
            this.Check_X_Y_Z.Click += new System.EventHandler(this.Check_X_Y_Z_Click);
            // 
            // Uncheck_X_Y_Z
            // 
            this.Uncheck_X_Y_Z.Image = ((System.Drawing.Image)(resources.GetObject("Uncheck_X_Y_Z.Image")));
            this.Uncheck_X_Y_Z.Location = new System.Drawing.Point(29, 198);
            this.Uncheck_X_Y_Z.Name = "Uncheck_X_Y_Z";
            this.Uncheck_X_Y_Z.Size = new System.Drawing.Size(20, 20);
            this.Uncheck_X_Y_Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Uncheck_X_Y_Z.TabIndex = 67;
            this.Uncheck_X_Y_Z.TabStop = false;
            this.Uncheck_X_Y_Z.Click += new System.EventHandler(this.Uncheck_X_Y_Z_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(52, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Ejes X-Y-Z (Lectura simultánea). ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.Location = new System.Drawing.Point(320, 387);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiar.TabIndex = 72;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuardar.Location = new System.Drawing.Point(223, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 23);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label_conectado
            // 
            this.label_conectado.AutoSize = true;
            this.label_conectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_conectado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_conectado.Location = new System.Drawing.Point(27, 421);
            this.label_conectado.Name = "label_conectado";
            this.label_conectado.Size = new System.Drawing.Size(101, 13);
            this.label_conectado.TabIndex = 73;
            this.label_conectado.Text = "label_conectado";
            // 
            // btn_iniciar_lectura
            // 
            this.btn_iniciar_lectura.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_iniciar_lectura.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_iniciar_lectura.FlatAppearance.BorderSize = 0;
            this.btn_iniciar_lectura.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_iniciar_lectura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_iniciar_lectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar_lectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_lectura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_iniciar_lectura.Location = new System.Drawing.Point(29, 387);
            this.btn_iniciar_lectura.Name = "btn_iniciar_lectura";
            this.btn_iniciar_lectura.Size = new System.Drawing.Size(88, 23);
            this.btn_iniciar_lectura.TabIndex = 74;
            this.btn_iniciar_lectura.Text = "INICIAR";
            this.btn_iniciar_lectura.UseVisualStyleBackColor = false;
            this.btn_iniciar_lectura.Click += new System.EventHandler(this.btn_iniciar_lectura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 457);
            this.Controls.Add(this.btn_iniciar_lectura);
            this.Controls.Add(this.label_conectado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView_Acc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Uncheck_X_Y_Z);
            this.Controls.Add(this.Uncheck_Z);
            this.Controls.Add(this.Uncheck_Y);
            this.Controls.Add(this.Uncheck_X);
            this.Controls.Add(this.Check_X_Y_Z);
            this.Controls.Add(this.Check_Y);
            this.Controls.Add(this.Check_Z);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Check_X);
            this.Controls.Add(this.btn_detener);
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
            ((System.ComponentModel.ISupportInitialize)(this.Check_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uncheck_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uncheck_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uncheck_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_X_Y_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uncheck_X_Y_Z)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.PictureBox Check_X;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox Check_Z;
        private System.Windows.Forms.PictureBox Check_Y;
        private System.Windows.Forms.PictureBox Uncheck_X;
        private System.Windows.Forms.PictureBox Uncheck_Y;
        private System.Windows.Forms.PictureBox Uncheck_Z;
        private System.Windows.Forms.DataGridView dataGridView_Acc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acc_Value_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acc_Value_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acc_Value_Z;
        private System.Windows.Forms.PictureBox Check_X_Y_Z;
        private System.Windows.Forms.PictureBox Uncheck_X_Y_Z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label_conectado;
        private System.Windows.Forms.Button btn_iniciar_lectura;
    }
}

