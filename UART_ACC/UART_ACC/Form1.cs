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

        char caracter_delimitador = ':';

        private void acceso_Form(string accion)
        {
            strBufferIn = accion;
            //----------- DATOS A PASAR -------------//
            
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
            estado_puerto = false;
            strBufferIn = "";
            strBufferOut = "";

            //inicializacion de botones
            btn_leer_X.Enabled = false;
            btn_leer_Y.Enabled = false;
            btn_leer_Z.Enabled = false;
            btn_leer_3_ejes.Enabled = false;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = false;

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
    }
}
