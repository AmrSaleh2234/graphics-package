namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ty2line = new System.Windows.Forms.TextBox();
            this.tx2line = new System.Windows.Forms.TextBox();
            this.ty1line = new System.Windows.Forms.TextBox();
            this.pLine = new System.Windows.Forms.Panel();
            this.bline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "enter y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "enter y2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 38);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ty2line
            // 
            this.ty2line.Location = new System.Drawing.Point(731, 359);
            this.ty2line.Name = "ty2line";
            this.ty2line.Size = new System.Drawing.Size(111, 38);
            this.ty2line.TabIndex = 5;
            // 
            // tx2line
            // 
            this.tx2line.Location = new System.Drawing.Point(484, 359);
            this.tx2line.Name = "tx2line";
            this.tx2line.Size = new System.Drawing.Size(111, 38);
            this.tx2line.TabIndex = 6;
            // 
            // ty1line
            // 
            this.ty1line.Location = new System.Drawing.Point(250, 359);
            this.ty1line.Name = "ty1line";
            this.ty1line.Size = new System.Drawing.Size(111, 38);
            this.ty1line.TabIndex = 7;
            // 
            // pLine
            // 
            this.pLine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pLine.Location = new System.Drawing.Point(155, 31);
            this.pLine.Name = "pLine";
            this.pLine.Size = new System.Drawing.Size(608, 264);
            this.pLine.TabIndex = 8;
            // 
            // bline
            // 
            this.bline.Location = new System.Drawing.Point(387, 433);
            this.bline.Name = "bline";
            this.bline.Size = new System.Drawing.Size(143, 44);
            this.bline.TabIndex = 9;
            this.bline.Text = "draw";
            this.bline.UseVisualStyleBackColor = true;
            this.bline.Click += new System.EventHandler(this.Bline_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.bline);
            this.Controls.Add(this.pLine);
            this.Controls.Add(this.ty1line);
            this.Controls.Add(this.tx2line);
            this.Controls.Add(this.ty2line);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ty2line;
        private System.Windows.Forms.TextBox tx2line;
        private System.Windows.Forms.TextBox ty1line;
        private System.Windows.Forms.Panel pLine;
        private System.Windows.Forms.Button bline;
    }
}