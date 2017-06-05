using System;
using System.IO;

using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CPM
{
    public partial class Secure_Folder : Form
    {
        public Secure_Folder()
        {
            InitializeComponent();
         
        }
       public static string path = "";
        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pathFileDialog = folderBrowserDialog1;
            pathFileDialog.ShowDialog();
            path = pathFileDialog.SelectedPath;
            txtb_path.Text = path;
             

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string dirPath = path;

            DirectoryInfo di = Directory.CreateDirectory(dirPath);
            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden | FileAttributes.System;
            MessageBox.Show("Folder Protected","Alert", MessageBoxButtons.OKCancel);
            Form frm = new Form1();
            frm.Show();
            

        }
    }
}
