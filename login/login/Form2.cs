using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.Properties;

namespace login
{
    public partial class newpass : Form
    {
        public newpass()
        {
            InitializeComponent();
        }
        string pass = Settings.Default.pass;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == pass)
            {
                Settings.Default.pass = textBox2.Text;
                Settings.Default.Save();
                MessageBox.Show("todo bien");
            }
            else
            {
                MessageBox.Show("todo mal");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
