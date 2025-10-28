using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fready_2
{
    public partial class Form1 : Form
    {
        public static string path;
        public static string xv;
        public static string yv;
        public static string wid;
        public static string heig;
        public Form1()
        {
            InitializeComponent();
             
            
        }
        
        public void pcturebutton_Click(object sender, EventArgs e)
        {
            
            string[] allowedExtensions = { ".png", ".jpg", ".webp", ".bmp", ".avif", ".gif" };
            DialogResult fajl = openFileDialog1.ShowDialog();
            string filenev = openFileDialog1.SafeFileName;

            if (fajl == DialogResult.OK && allowedExtensions.Contains(filenev.Substring(filenev.LastIndexOf("."))))
            {
                path = openFileDialog1.FileName;
                
            }
            else
            {
                MessageBox.Show("rossz file tipus");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xv = x.Text;
            yv = y.Text;
            wid = width.Text;
            heig = heigth.Text; 
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            Console.WriteLine(xv);
        }
        
    }
}
