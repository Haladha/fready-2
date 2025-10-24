using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fready_2
{

    public partial class Form2 : Form
    {
        private Random random = new Random();

        // Import necessary function to make the form click-through
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            pictureBox1.ImageLocation = Form1.path;
            Console.WriteLine(Form1.path);
            // Set form to always be on top
            this.TopMost = true;
            this.pictureBox1.Size = new System.Drawing.Size(Convert.ToInt32(Form1.wid), Convert.ToInt32(Form1.heig));


            // Set form's transparency to make it click-through
            SetFormClickThrough(this.Handle);



            // Set up Timer to move the PictureBox
            Timer timer = new Timer();
            timer.Interval = 20; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void SetFormClickThrough(IntPtr hwnd)
        {
            // Set the extended window style to make the form click-through
            int exStyle = (int)GetWindowLong(hwnd, GWL_EXSTYLE);
            exStyle |= WS_EX_LAYERED | WS_EX_TRANSPARENT;
            SetWindowLong(hwnd, GWL_EXSTYLE, exStyle);
        }
        private int moveX = Convert.ToInt32(Form1.xv); // Horizontal speed
        private int moveY = Convert.ToInt32(Form1.yv); // Vertical speed
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Move the PictureBox
            pictureBox1.Left += moveX;
            pictureBox1.Top += moveY;

            // Check for border collisions and reverse direction if necessary
            if (pictureBox1.Left <= 0 || pictureBox1.Right >= this.ClientSize.Width)
            {
                moveX = -moveX; // Reverse horizontal direction
            }

            if (pictureBox1.Top <= 0 || pictureBox1.Bottom >= this.ClientSize.Height)
            {
                moveY = -moveY; // Reverse vertical direction
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
