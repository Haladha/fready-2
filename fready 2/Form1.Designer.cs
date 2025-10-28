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
            this.x = new System.Windows.Forms.MaskedTextBox();
            this.y = new System.Windows.Forms.MaskedTextBox();
            this.heigth = new System.Windows.Forms.MaskedTextBox();
            this.width = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pcturebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(101, 67);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 20);
            this.x.TabIndex = 3;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(101, 109);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(100, 20);
            this.y.TabIndex = 4;
            // 
            // heigth
            // 
            this.heigth.Location = new System.Drawing.Point(101, 205);
            this.heigth.Name = "heigth";
            this.heigth.Size = new System.Drawing.Size(100, 20);
            this.heigth.TabIndex = 8;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(101, 158);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Height:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcturebutton);
            this.Controls.Add(this.heigth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox x;
        private System.Windows.Forms.MaskedTextBox y;
        private System.Windows.Forms.MaskedTextBox heigth;
        private System.Windows.Forms.MaskedTextBox width;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button pcturebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

