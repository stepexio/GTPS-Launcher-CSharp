using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter on = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", false);
            on.WriteLine("IP growtopia1.com");
            on.WriteLine("IP growtopia2.com");
            on.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter off = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", false);
            off.WriteLine("127.0.0.1 growtopia1.com");
            off.Close();
        }
    }
}
