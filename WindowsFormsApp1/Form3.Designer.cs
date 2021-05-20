namespace WindowsFormsApp1
{
    partial class Form3
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
            this.bline = new System.Windows.Forms.Button();
            this.pElipse = new System.Windows.Forms.Panel();
            this.ry = new System.Windows.Forms.TextBox();
            this.xc = new System.Windows.Forms.TextBox();
            this.yc = new System.Windows.Forms.TextBox();
            this.rx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bline
            // 
            this.bline.Location = new System.Drawing.Point(374, 448);
            this.bline.Name = "bline";
            this.bline.Size = new System.Drawing.Size(143, 44);
            this.bline.TabIndex = 19;
            this.bline.Text = "draw";
            this.bline.UseVisualStyleBackColor = true;
            this.bline.Click += new System.EventHandler(this.Bline_Click);
            // 
            // pElipse
            // 
            this.pElipse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pElipse.Location = new System.Drawing.Point(142, 46);
            this.pElipse.Name = "pElipse";
            this.pElipse.Size = new System.Drawing.Size(608, 264);
            this.pElipse.TabIndex = 18;
            // 
            // ry
            // 
            this.ry.Location = new System.Drawing.Point(237, 374);
            this.ry.Name = "ry";
            this.ry.Size = new System.Drawing.Size(111, 38);
            this.ry.TabIndex = 17;
            // 
            // xc
            // 
            this.xc.Location = new System.Drawing.Point(471, 374);
            this.xc.Name = "xc";
            this.xc.Size = new System.Drawing.Size(111, 38);
            this.xc.TabIndex = 16;
            // 
            // yc
            // 
            this.yc.Location = new System.Drawing.Point(718, 374);
            this.yc.Name = "yc";
            this.yc.Size = new System.Drawing.Size(111, 38);
            this.yc.TabIndex = 15;
            // 
            // rx
            // 
            this.rx.Location = new System.Drawing.Point(50, 374);
            this.rx.Name = "rx";
            this.rx.Size = new System.Drawing.Size(111, 38);
            this.rx.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "enter yc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "enter ry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "enter xc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "enter rx";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 538);
            this.Controls.Add(this.bline);
            this.Controls.Add(this.pElipse);
            this.Controls.Add(this.ry);
            this.Controls.Add(this.xc);
            this.Controls.Add(this.yc);
            this.Controls.Add(this.rx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bline;
        private System.Windows.Forms.Panel pElipse;
        private System.Windows.Forms.TextBox ry;
        private System.Windows.Forms.TextBox xc;
        private System.Windows.Forms.TextBox yc;
        private System.Windows.Forms.TextBox rx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}