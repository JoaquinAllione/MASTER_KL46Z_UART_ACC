using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;

namespace UART_ACC
{

    public partial class Form1 : Form
    {

        private delegate void delegado(string accion);
        private string strBufferIn;
        private string strBufferOut;
        private bool estado_puerto;

        private string eje_selec = "";

        char caracter_delimitador = ':';
 
        private void acceso_Form(string accion)
        {
            strBufferIn = accion;
            
            //----------- DATOS A PASAR -------------//
            txtDatosRecibidos.Text = strBufferIn;
            //---------------------------------------//
        }

        private void accesoInt(string accion)
        {
            delegado variable;
            variable = new delegado(acceso_Form);
            object[] arg = { accion };
            base.Invoke(variable, arg);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inicializacion de variables.
            estado_puerto = false; //indicara si se esta conectado a un puerto o no
            strBufferIn = "";
            strBufferOut = "";

            //inicializacion de botones
            btn_leer_X.Enabled = false;
            btn_leer_Y.Enabled = false;
            btn_leer_Z.Enabled = false;
            btn_leer_3_ejes.Enabled = false;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = false;
            btn_detener.Enabled = false;

            //inicializacion de TextBox / ComboBox
            cbxBaudRate.SelectedIndex = 9;
            txtDatosRecibidos.Text = "";
            txtAccX.Text = "";
            txtAccY.Text = "";
            txtAccZ.Text = "";

            //buscando puertos de la PC / llenado de ComboBox para seleccionar puerto
            string[] Puertos_disponibles = SerialPort.GetPortNames();

            foreach (string puerto in Puertos_disponibles)
            {
                cbxPuertos.Items.Add(puerto);
            }

            if (cbxPuertos.Items.Count > 0)
            {
                cbxPuertos.SelectedIndex = 0;
                btnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se han encontrado puertos disponibles.");
                cbxPuertos.Items.Clear();
                cbxPuertos.Text = "                     ";
                strBufferIn = "";
                strBufferOut = "";
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = false;
                cbxBaudRate.SelectedIndex = 9;
            }

        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = Int32.Parse(cbxBaudRate.Text);
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = cbxPuertos.Text;
                serialPort1.Open();
                estado_puerto = true;
                btnDesconectar.Enabled = true;
                btnConectar.Enabled = false;
                btn_leer_X.Enabled = true;
                btn_leer_Y.Enabled = true;
                btn_leer_Z.Enabled = true;
                btn_leer_3_ejes.Enabled = true;
                btn_detener.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estado_puerto = false;
            }
        }

        //para poder desplazar el formulario desde el panel superior / label del titulo en la cabecera.
        int posX = 0;
        int posY = 0;

        private void panel_controles_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void label_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            serialPort1.Close(); //se cierra la conexion con el puerto seleccionado
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            estado_puerto = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (estado_puerto == true)
            {
                serialPort1.Close();
                estado_puerto = false;
            }
        }

        private void btn_leer_X_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            eje_selec = "X";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                serialPort1.DiscardOutBuffer();
                if(eje_selec == "X")
                {
                    strBufferOut = ":AccX\n";
                }else if (eje_selec == "Y")
                {
                    strBufferOut = ":AccY\n";
                }
                else if (eje_selec == "Z")
                {
                    strBufferOut = ":AccZ\n";
                }else
                {
                    strBufferOut = ":Axes\n";
                }
                serialPort1.Write(strBufferOut);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                accesoInt(serialPort1.ReadLine());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void btn_leer_Y_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            eje_selec = "Y";
        }

        private void btn_leer_Z_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            eje_selec = "Z";
        }

        private void btn_leer_3_ejes_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            eje_selec = "X-Y-Z";
        }
    }
}
