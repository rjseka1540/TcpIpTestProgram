using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIpTestProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (bt.Text == "button1")
            {
                MessageBox.Show("Button 1");
            }
            else
            {
                MessageBox.Show("Button 2");
            }

        }
    }
}
