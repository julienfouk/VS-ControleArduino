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

namespace WindowFormArduino
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // allumer
            myport.WriteLine("O");

            // on recupere le retour de l'arduino pour l'afficher dans le label
            label1.Text= myport.ReadLine();



        }

        private void init()
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM4";
            myport.Open();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myport.WriteLine("F");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myport.WriteLine("B");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myport.WriteLine("J");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            myport.WriteLine("V");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myport.WriteLine("R");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myport.WriteLine("Z");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myport.WriteLine("T");
            //myport.ReadTimeout=5000;
            label1.Text = myport.ReadLine() + " Degré Celsius";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myport.WriteLine("H");
            //myport.ReadTimeout=5000;
            label1.Text = myport.ReadLine() + " % Humidité";
        }
    }
}
