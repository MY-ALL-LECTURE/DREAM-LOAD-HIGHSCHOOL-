using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _01BASIC
{
    public partial class winform : Form
    {

        private SerialPort serialPort = new SerialPort();

        public winform()
        {
            InitializeComponent();
        }

        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("HELLO WORLD");
            //Console.WriteLine("sender : " + sender);
            //Console.WriteLine("EventArgs : " + e);
            ComboBox cb = (ComboBox)sender;
            Console.Write("Selected Idx : " + cb.SelectedIndex+"  ");
            Console.WriteLine("Selected Value : " + cb.Items[cb.SelectedIndex]);

        }

        private void conn_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Conn_Btn Click : " + this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString()); ;
            try
            {
                this.serialPort.PortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();
                this.serialPort.BaudRate = 9600;
                this.serialPort.DataBits = 8;
                this.serialPort.StopBits = System.IO.Ports.StopBits.One;
                this.serialPort.Parity = System.IO.Ports.Parity.None;
                this.serialPort.Open();
                Console.WriteLine("CONNECTION SUCCESS");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                this.serialPort.Close();
            }
        
            
        }


        private void textArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void winform_Load(object sender, EventArgs e)
        {

        }
    }
}
