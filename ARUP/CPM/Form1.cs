using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace CPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_cpm_Click(object sender, EventArgs e)
        {
            string dirPath = Secure_Folder.path;

            DirectoryInfo di = Directory.CreateDirectory(dirPath);
            di.Attributes = FileAttributes.Normal;
            MessageBox.Show("Job Folder Access Granted");
            Process.Start(dirPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
