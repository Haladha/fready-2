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

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;

        private int moveX;
        private int moveY;

        public Form2()
        {
            InitializeComponent();

            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.TopMost = true;

            pictureBox1.ImageLocation = Form1.path;
            Console.WriteLine(Form1.path);

            // Safely convert the string inputs
            if (!int.TryParse(Form1.xv, out moveX)) moveX = 2; // fallback speed
            if (!int.TryParse(Form1.yv, out moveY)) moveY = 2;
            if (!int.TryParse(Form1.wid, out int width)) width = 100;
            if (!int.TryParse(Form1.heig, out int height)) height = 100;

            pictureBox1.Size = new Size(width, height);

            // Make form click-through
            SetFormClickThrough(this.Handle);

            // Set up Timer to move the PictureBox
            Timer timer = new Timer
            {
                Interval = 20
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void SetFormClickThrough(IntPtr hwnd)
        {
            int exStyle = (int)GetWindowLong(hwnd, GWL_EXSTYLE);
            exStyle |= WS_EX_LAYERED | WS_EX_TRANSPARENT;
            SetWindowLong(hwnd, GWL_EXSTYLE, exStyle);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += moveX;
            pictureBox1.Top += moveY;

            if (pictureBox1.Left <= 0 || pictureBox1.Right >= this.ClientSize.Width)
                moveX = -moveX;

            if (pictureBox1.Top <= 0 || pictureBox1.Bottom >= this.ClientSize.Height)
                moveY = -moveY;
        }
    }
}
