using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minify_Project_Export
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "C:\\inetpub\\wwwroot\\procentric\\app\\HTV";
        }
        public List<string> Folders = new List<string>();
        public List<string> Files = new List<string>();
        public string sufixPath = DateTime.Now.ToString("(yyyy-MM-dd)");
        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = label1.Text;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "") {
                MessageBox.Show("Please Choose a path");
                return;
            }
            
            ToBox.Text = label1.Text  +"\\ExportMinify" + sufixPath;
            ListFiles.DataSource = null;
            ListFiles.Items.Clear();
            Files.Clear();
            string[] MultipleFilters = Filters.Text.Split('|');
            Folders.Add(label1.Text);
            string First = "";
            while(Folders.Count != 0)
            {
                First = Folders.First();
                Folders.Remove(First);
                foreach (string FileFilter in MultipleFilters)
                {
                    Files.AddRange(Directory.GetFiles(First, FileFilter));
                }
                Folders.AddRange(Directory.GetDirectories(First));
            }
            ListFiles.DataSource = Files;
            FoundedLable.Text = Files.Count().ToString();


        }

        private void Copy_btn_Click(object sender, EventArgs e)
        {
            if(Files.Count == 0)
            {
                MessageBox.Show("Please Choose Get Files From The Path....!");
                return;
            }
            string First = "";
            ListFiles.DataSource = null;
            while (Files.Count != 0)
            {
                First = Files.First();
                Files.Remove(First);
                ListFiles.Items.Remove(First);
                string[] PathArr = First.Split('\\');
                string NewPath = First.Replace(label1.Text, ToBox.Text);
                if (!Directory.Exists(NewPath.Replace("\\" + PathArr.Last(),"")))
                    Directory.CreateDirectory(NewPath.Replace("\\" + PathArr.Last(), ""));
                File.Copy(First, NewPath, true);
            }
            Process.Start(ToBox.Text);
        }

        private void locationbtn_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    ToBox.Text = folderDialog.SelectedPath + "\\ExportMinify" + sufixPath;
                }
            }
        }
        
    }
}
