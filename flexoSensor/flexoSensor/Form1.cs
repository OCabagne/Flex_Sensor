using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;

namespace flexoSensor
{
    public partial class Main : Form
    {
        private string bin;
        private bool cmd;
       private double volt = 2.5;
        private int sec = 0;
        SerialPort SP = new SerialPort();

        public Main()
        {
            InitializeComponent();
            SP.BaudRate = 9600;
            SP.PortName = "COM5";
            grafica.Legends.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (cmd)
            {
                SP.Close();
                cmd = false;
                connect.Text = "Conectar";
            }
            else
            {
                try
                {
                    SP.Open();
                    cmd = true;
                    connect.Text = "Desconectar";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            sec++;
            double grade = 0;
            int i = 8, j;
            //timer.Stop();
            if (cmd)
            {
                bin = SP.ReadLine();
                binario.Text = bin;

                for(j = 0; j < 7; j++)
                {
                    if (bin[j] == '1')
                    {
                        grade += (1 / (Math.Pow(2, i)));
                    }
                    i--;
                }
                grade = (((grade * volt * 100) - 60) * 3);
                //grade = grade / 100;
                Grados.Text = grade.ToString() + "°";
                //Grados.Text = bin[1].ToString();

                this.grafica.Series["Grafica"].Points.AddXY(sec, grade);
                grade = 0;
            }
        }
    }
}
