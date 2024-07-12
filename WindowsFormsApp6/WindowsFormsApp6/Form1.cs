using ccapi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = ccapi.ExploitApi.Inject(Application.StartupPath + "\\bin\\api\\CeleryInject.exe", true, false);
            switch (result)
            {
                case 0:
                    MessageBox.Show("roblox isnt open open it");
                    break;
                case 1:
                    MessageBox.Show("injected yay");
                    break;
                case 2:
                    MessageBox.Show("failed to inject oh man");
                    break;
                case 3:
                    MessageBox.Show("run as admin");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ccapi.ExploitApi.Execute(richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
