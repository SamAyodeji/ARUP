using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARUP
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text =="admin" & textBox2.Text == "admin") //admin's login details
                {
                 secure f2 = new secure();
                 f2.Show();
                this.Hide();
                 }
            else
                {
                MessageBox.Show("unidentified staff ID or password,Please complete the CMP document","Error");
                }
            
        }
    }
}
