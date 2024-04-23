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

namespace _01BASIC
{
    public partial class winform : Form
    {

        
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
            Console.WriteLine("Conn_Btn Click : "+ this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString());
            ;

        }

        private void txtInsert_KeyDown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine("KEYCODE : " + e.KeyCode);
            //Console.WriteLine("KEYVALUE : " + e.KeyValue);
            if(e.KeyValue == 13)
            {
                this.textArea.AppendText( this.txtInsert.Text + "\r\n" );
                this.txtInsert.Text = "";
            }

        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
