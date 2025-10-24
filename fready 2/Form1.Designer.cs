namespace fready_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.heigth = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pcturebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x.Location = new System.Drawing.Point(15, 62);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(22, 25);
            this.x.TabIndex = 0;
            this.x.Text = "x";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.y.Location = new System.Drawing.Point(15, 104);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(22, 25);
            this.y.TabIndex = 1;
            this.y.Text = "y";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(101, 67);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(101, 109);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(101, 205);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 8;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(101, 158);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 7;
            // 
            // heigth
            // 
            this.heigth.AutoSize = true;
            this.heigth.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heigth.Location = new System.Drawing.Point(15, 200);
            this.heigth.Name = "heigth";
            this.heigth.Size = new System.Drawing.Size(71, 25);
            this.heigth.TabIndex = 6;
            this.heigth.Text = "heigth";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.width.Location = new System.Drawing.Point(15, 152);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(63, 25);
            this.width.TabIndex = 5;
            this.width.Text = "witdh";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pcturebutton
            // 
            this.pcturebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pcturebutton.Location = new System.Drawing.Point(84, 266);
            this.pcturebutton.Name = "pcturebutton";
            this.pcturebutton.Size = new System.Drawing.Size(145, 42);
            this.pcturebutton.TabIndex = 9;
            this.pcturebutton.Text = "picture upload";
            this.pcturebutton.UseVisualStyleBackColor = true;
            this.pcturebutton.Click += new System.EventHandler(this.pcturebutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcturebutton);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.heigth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label heigth;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button pcturebutton;
        private System.Windows.Forms.Button button1;
    }
}

