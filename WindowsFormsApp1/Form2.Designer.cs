namespace WindowsFormsApp1
{
    partial class Form2
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
            this.pcircule = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txc = new System.Windows.Forms.TextBox();
            this.trc = new System.Windows.Forms.TextBox();
            this.tyc = new System.Windows.Forms.TextBox();
            this.bcircule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            // 
            // pcircule
            // 
            this.pcircule.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pcircule.Location = new System.Drawing.Point(132, 27);
            this.pcircule.Name = "pcircule";
            this.pcircule.Size = new System.Drawing.Size(599, 308);
            this.pcircule.TabIndex = 1;
            this.pcircule.Paint += new System.Windows.Forms.PaintEventHandler(this.Pcircule_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "x center ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "radius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "y center";
            // 
            // txc
            // 
            this.txc.Location = new System.Drawing.Point(138, 440);
            this.txc.Name = "txc";
            this.txc.Size = new System.Drawing.Size(100, 38);
            this.txc.TabIndex = 6;
            // 
            // trc
            // 
            this.trc.Location = new System.Drawing.Point(616, 440);
            this.trc.Name = "trc";
            this.trc.Size = new System.Drawing.Size(100, 38);
            this.trc.TabIndex = 7;
            // 
            // tyc
            // 
            this.tyc.Location = new System.Drawing.Point(386, 440);
            this.tyc.Name = "tyc";
            this.tyc.Size = new System.Drawing.Size(100, 38);
            this.tyc.TabIndex = 8;
            // 
            // bcircule
            // 
            this.bcircule.Location = new System.Drawing.Point(373, 509);
            this.bcircule.Name = "bcircule";
            this.bcircule.Size = new System.Drawing.Size(126, 46);
            this.bcircule.TabIndex = 9;
            this.bcircule.Text = "draw";
            this.bcircule.UseVisualStyleBackColor = true;
            this.bcircule.Click += new System.EventHandler(this.Bcircule_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 567);
            this.Controls.Add(this.bcircule);
            this.Controls.Add(this.tyc);
            this.Controls.Add(this.trc);
            this.Controls.Add(this.txc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcircule);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pcircule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txc;
        private System.Windows.Forms.TextBox trc;
        private System.Windows.Forms.TextBox tyc;
        private System.Windows.Forms.Button bcircule;
    }
}