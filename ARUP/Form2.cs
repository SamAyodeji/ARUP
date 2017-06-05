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
using System.Security.AccessControl;
using System.Windows.Forms.VisualStyles;
using System.Collections;

namespace ARUP
{
    
    public partial class secure : Form
    {
        public secure()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            {
               
                
                try
                {

                   // string folderPath = textBox1.Text;
                   //convert picked folder to directoryinfo
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                    //get new name for folder
                    string newpath = Path.Combine(dir.Parent.FullName, "UnderCover");
                    //rename folder
                    Directory.Move (textBox1.Text, newpath);
                    //convert new path to directoryinfo
                    DirectoryInfo dir2 = new DirectoryInfo(newpath);
                    //hide new folder
                    dir2.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    //lock new folder
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity ds = Directory.GetAccessControl(newpath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsa);
                    Directory.SetAccessControl(newpath, ds);
                   //display success message
                    MessageBox.Show(" file Locked","Locked");
                    textBox1.Text = "";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openfd = new FolderBrowserDialog();//browse folder to choose file
            DialogResult dr = openfd.ShowDialog();
            textBox1.Text = openfd.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                string folderPath = textBox1.Text;
                
                string adminUserName = Environment.UserName;// getting your adminUserName
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
     ds.RemoveAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);
               
                MessageBox.Show(" file UnLocked" ,"Unlocked");
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
