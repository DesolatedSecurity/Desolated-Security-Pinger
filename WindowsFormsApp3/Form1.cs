using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private const string V = "Connected";
        TcpClient tcpClient = new TcpClient();
        public static int port = 80;
        public static TcpClient client;

        public object pingresult { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send((textBox1.Text));
            if (pingresult.ToString() == "Success")
            {
                DialogResult dialogResult = MessageBox.Show("IP " + textBox1.Text + "Is Online.", textBox1.Text + MessageBoxButtons.YesNo);
                label2.Text = textBox1.Text;
                label4.Text = "Online";
                label4.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = textBox1.Text;
                label4.Text = "Offline";
                label4.ForeColor = Color.Red;
                DialogResult dialogResult = MessageBox.Show("IP " + textBox1.Text + "Offline.", textBox1.Text + MessageBoxButtons.YesNo);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
