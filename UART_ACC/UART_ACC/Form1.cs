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
            string[] cadena;
            string signo = "";
            int s = 1;
            cadena = strBufferIn.Split(caracter_delimitador);
            //----------- DATOS A PASAR -------------//

            txtDatosRecibidos.Text = strBufferIn;

            if ((eje_selec == "X")|| (eje_selec == "Y")|| (eje_selec == "Z"))
            {
                if (cadena[2] == "N") //para evaluar el signo del valor leido
                {
                    signo = "-";
                    s = -1;
                    //panel_X.BackColor = Color.Red;
                }
                else
                {
                    signo = "+";
                    //panel_X.BackColor = Color.Green;
                }
                if (eje_selec == "X")//para evaluar el eje que se desea leer
                {
                    txtAccX.Text = signo + cadena[3];
                    int n = dataGridView_Acc.Rows.Add();
                    dataGridView_Acc.Rows[n].Cells[0].Value = time;
                    dataGridView_Acc.Rows[n].Cells[1].Value = signo + cadena[3];
                    chart_Acc.Series["Acc_Value"].Points.AddY(s*(Convert.ToInt16(cadena[3])));
                }
                else if (eje_selec == "Y")
                {
                    txtAccY.Text = signo + cadena[3];
                    int n = dataGridView_Acc.Rows.Add();
                    dataGridView_Acc.Rows[n].Cells[0].Value = time;
                    dataGridView_Acc.Rows[n].Cells[2].Value = signo + cadena[3];
                    chart_Acc.Series["Acc_Value"].Points.AddY(s * (Convert.ToInt16(cadena[3])));
                }
                else if (eje_selec == "Z")
                {
                    txtAccZ.Text = signo + cadena[3];
                    int n = dataGridView_Acc.Rows.Add();
                    dataGridView_Acc.Rows[n].Cells[0].Value = time;
                    dataGridView_Acc.Rows[n].Cells[3].Value = signo + cadena[3];
                    chart_Acc.Series["Acc_Value"].Points.AddY(s * (Convert.ToInt16(cadena[3])));
                }
            }else
            {
                int n = dataGridView_Acc.Rows.Add();
                if (cadena[1] == "N") //para evaluar el signo del valor leido
                {
                    signo = "-";
                }
                else
                {
                    signo = "+";
                }
                txtAccX.Text = signo + cadena[2];
                dataGridView_Acc.Rows[n].Cells[1].Value = signo + cadena[2];
                if (cadena[3] == "N") //para evaluar el signo del valor leido
                {
                    signo = "-";
                }
                else
                {
                    signo = "+";
                }
                txtAccY.Text = signo + cadena[4];
                dataGridView_Acc.Rows[n].Cells[2].Value = signo + cadena[4];
                if (cadena[5] == "N") //para evaluar el signo del valor leido
                {
                    signo = "-";
                }
                else
                {
                    signo = "+";
                }
                txtAccZ.Text = signo + cadena[6];
                dataGridView_Acc.Rows[n].Cells[3].Value = signo + cadena[6];
            }
            
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
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = false;
            btn_detener.Enabled = false;
            btn_iniciar_lectura.Enabled = false;

            //inicializacion de TextBox / ComboBox
            cbxBaudRate.SelectedIndex = 9;
            txtDatosRecibidos.Text = "";
            txtAccX.Text = "";
            txtAccY.Text = "";
            txtAccZ.Text = "";
            label_conectado.Text = "Desconectado";

            //inicializacion de los check boxes
            Uncheck_X.Enabled = false;
            Uncheck_Y.Enabled = false;
            Uncheck_Z.Enabled = false;
            Uncheck_X_Y_Z.Enabled = false;

            Check_X.Visible = false;
            Check_Y.Visible = false;
            Check_Z.Visible = false;
            Check_X_Y_Z.Visible = false;

            Uncheck_X.Visible = true;
            Uncheck_Y.Visible = true;
            Uncheck_Z.Visible = true;
            Uncheck_X_Y_Z.Visible = true;

            //inicializacion de la grafica
            init_chart_Acc();

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
                Uncheck_X.Enabled = true;
                Uncheck_Y.Enabled = true;
                Uncheck_Z.Enabled = true;
                Uncheck_X_Y_Z.Enabled = true;
                btn_detener.Enabled = true;
                label_conectado.Text = "Conectado a " + cbxPuertos.Text;
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

        public void init_chart_Acc()
        {
            int x;
            int y;

            for (x = 0; x < 99; x++)
            {
                y = (int)(100 *(1 - Math.Pow(2.7, -0.05 * x)));
                chart_Acc.Series["Acc_Value"].Points.AddY(Convert.ToInt16(y));
            }
        }

        private void limpiar_datos()
        {
            //limpia tanto los TextBoxs como el DataGridView.
            txtDatosRecibidos.Text = ""; 
            txtAccX.Text = "";
            txtAccY.Text = "";
            txtAccZ.Text = "";
            chart_Acc.Series["Acc_Value"].Points.Clear();
            dataGridView_Acc.Rows.Clear();
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort1.Close(); //se cierra la conexion con el puerto seleccionado
            limpiar_datos();
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            estado_puerto = false;
            label_conectado.Text = "Desconectado";
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
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
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
                }else if (eje_selec == "X_Y_Z")
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

        private void Uncheck_X_Click(object sender, EventArgs e)
        {
            Check_Y_Click( sender,  e);
            Check_Z_Click( sender, e);
            Check_X_Y_Z_Click(sender, e);
            Check_X.Visible = true;
            Uncheck_X.Visible = false;
            btn_iniciar_lectura.Enabled = true;
            eje_selec = "X";
        }

        private void Check_X_Click(object sender, EventArgs e)
        {
            btn_iniciar_lectura.Enabled = false;
            Check_X.Visible = false;
            Uncheck_X.Visible = true;
            timer1.Stop();
        }

        private void Check_Y_Click(object sender, EventArgs e)
        {
            btn_iniciar_lectura.Enabled = false;
            Check_Y.Visible = false;
            Uncheck_Y.Visible = true;
            timer1.Stop();
        }

        private void Uncheck_Y_Click(object sender, EventArgs e)
        {
            Check_X_Click(sender, e);
            Check_Z_Click(sender, e);
            Check_X_Y_Z_Click(sender, e);
            btn_iniciar_lectura.Enabled = true;
            Check_Y.Visible = true;
            Uncheck_Y.Visible = false;
            
            eje_selec = "Y";
        }

        private void Check_Z_Click(object sender, EventArgs e)
        {
            btn_iniciar_lectura.Enabled = false;
            Check_Z.Visible = false;
            Uncheck_Z.Visible = true;
            timer1.Stop();
        }

        private void Uncheck_Z_Click(object sender, EventArgs e)
        {
            Check_Y_Click(sender, e);
            Check_X_Click(sender, e);
            Check_X_Y_Z_Click(sender, e);
            btn_iniciar_lectura.Enabled = true;
            Check_Z.Visible = true;
            Uncheck_Z.Visible = false;
            
            eje_selec = "Z";
        }

        private void Uncheck_X_Y_Z_Click(object sender, EventArgs e)
        {
            Check_Y_Click(sender, e);
            Check_X_Click(sender, e);
            Check_Z_Click(sender, e);
            btn_iniciar_lectura.Enabled = true;
            Check_X_Y_Z.Visible = true;
            Uncheck_X_Y_Z.Visible = false;
            
            eje_selec = "X_Y_Z";
        }

        private void Check_X_Y_Z_Click(object sender, EventArgs e)
        {
            btn_iniciar_lectura.Enabled = false;
            Check_X_Y_Z.Visible = false;
            Uncheck_X_Y_Z.Visible = true;
            timer1.Stop();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_datos();
        }

        private void btn_iniciar_lectura_Click(object sender, EventArgs e)
        {
            time = 0;
            limpiar_datos();
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
