﻿namespace WindowsFormsApp1
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
            this.sheeringyc = new System.Windows.Forms.TextBox();
            this.sheeringxc = new System.Windows.Forms.TextBox();
            this.sheering = new System.Windows.Forms.Button();
            this.refxy = new System.Windows.Forms.Button();
            this.refxc = new System.Windows.Forms.Button();
            this.brefc = new System.Windows.Forms.Button();
            this.brotatec = new System.Windows.Forms.Button();
            this.tRotateC = new System.Windows.Forms.TextBox();
            this.bscalc = new System.Windows.Forms.Button();
            this.scalCy = new System.Windows.Forms.TextBox();
            this.scalCx = new System.Windows.Forms.TextBox();
            this.transCy = new System.Windows.Forms.TextBox();
            this.transCx = new System.Windows.Forms.TextBox();
            this.transCButoon = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(348, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "enter y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "enter y2";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
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
            this.ty2line.Location = new System.Drawing.Point(471, 359);
            this.ty2line.Name = "ty2line";
            this.ty2line.Size = new System.Drawing.Size(111, 38);
            this.ty2line.TabIndex = 5;
            this.ty2line.TextChanged += new System.EventHandler(this.Ty2line_TextChanged);
            // 
            // tx2line
            // 
            this.tx2line.Location = new System.Drawing.Point(342, 359);
            this.tx2line.Name = "tx2line";
            this.tx2line.Size = new System.Drawing.Size(111, 38);
            this.tx2line.TabIndex = 6;
            // 
            // ty1line
            // 
            this.ty1line.Location = new System.Drawing.Point(204, 359);
            this.ty1line.Name = "ty1line";
            this.ty1line.Size = new System.Drawing.Size(111, 38);
            this.ty1line.TabIndex = 7;
            // 
            // pLine
            // 
            this.pLine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pLine.Location = new System.Drawing.Point(37, 24);
            this.pLine.Name = "pLine";
            this.pLine.Size = new System.Drawing.Size(608, 264);
            this.pLine.TabIndex = 8;
            // 
            // bline
            // 
            this.bline.Location = new System.Drawing.Point(257, 435);
            this.bline.Name = "bline";
            this.bline.Size = new System.Drawing.Size(143, 44);
            this.bline.TabIndex = 9;
            this.bline.Text = "draw";
            this.bline.UseVisualStyleBackColor = true;
            this.bline.Click += new System.EventHandler(this.Bline_Click);
            // 
            // sheeringyc
            // 
            this.sheeringyc.Location = new System.Drawing.Point(763, 156);
            this.sheeringyc.Name = "sheeringyc";
            this.sheeringyc.Size = new System.Drawing.Size(100, 38);
            this.sheeringyc.TabIndex = 55;
            // 
            // sheeringxc
            // 
            this.sheeringxc.Location = new System.Drawing.Point(654, 156);
            this.sheeringxc.Name = "sheeringxc";
            this.sheeringxc.Size = new System.Drawing.Size(100, 38);
            this.sheeringxc.TabIndex = 54;
            // 
            // sheering
            // 
            this.sheering.Location = new System.Drawing.Point(911, 156);
            this.sheering.Name = "sheering";
            this.sheering.Size = new System.Drawing.Size(134, 46);
            this.sheering.TabIndex = 53;
            this.sheering.Text = "sheering";
            this.sheering.UseVisualStyleBackColor = true;
            this.sheering.Click += new System.EventHandler(this.Sheering_Click);
            // 
            // refxy
            // 
            this.refxy.Location = new System.Drawing.Point(654, 280);
            this.refxy.Name = "refxy";
            this.refxy.Size = new System.Drawing.Size(189, 66);
            this.refxy.TabIndex = 52;
            this.refxy.Text = "reflection y";
            this.refxy.UseVisualStyleBackColor = true;
            this.refxy.Click += new System.EventHandler(this.Refxy_Click);
            // 
            // refxc
            // 
            this.refxc.Location = new System.Drawing.Point(849, 280);
            this.refxc.Name = "refxc";
            this.refxc.Size = new System.Drawing.Size(189, 66);
            this.refxc.TabIndex = 51;
            this.refxc.Text = "reflection x";
            this.refxc.UseVisualStyleBackColor = true;
            this.refxc.Click += new System.EventHandler(this.Refxc_Click);
            // 
            // brefc
            // 
            this.brefc.Location = new System.Drawing.Point(763, 371);
            this.brefc.Name = "brefc";
            this.brefc.Size = new System.Drawing.Size(189, 66);
            this.brefc.TabIndex = 50;
            this.brefc.Text = "reflection x,y";
            this.brefc.UseVisualStyleBackColor = true;
            this.brefc.Click += new System.EventHandler(this.Brefc_Click);
            // 
            // brotatec
            // 
            this.brotatec.Location = new System.Drawing.Point(911, 224);
            this.brotatec.Name = "brotatec";
            this.brotatec.Size = new System.Drawing.Size(121, 46);
            this.brotatec.TabIndex = 49;
            this.brotatec.Text = "rotate";
            this.brotatec.UseVisualStyleBackColor = true;
            this.brotatec.Click += new System.EventHandler(this.Brotatec_Click);
            // 
            // tRotateC
            // 
            this.tRotateC.Location = new System.Drawing.Point(709, 224);
            this.tRotateC.Name = "tRotateC";
            this.tRotateC.Size = new System.Drawing.Size(100, 38);
            this.tRotateC.TabIndex = 48;
            // 
            // bscalc
            // 
            this.bscalc.Location = new System.Drawing.Point(911, 89);
            this.bscalc.Name = "bscalc";
            this.bscalc.Size = new System.Drawing.Size(121, 46);
            this.bscalc.TabIndex = 47;
            this.bscalc.Text = "scale";
            this.bscalc.UseVisualStyleBackColor = true;
            this.bscalc.Click += new System.EventHandler(this.Bscalc_Click);
            // 
            // scalCy
            // 
            this.scalCy.Location = new System.Drawing.Point(777, 89);
            this.scalCy.Name = "scalCy";
            this.scalCy.Size = new System.Drawing.Size(100, 38);
            this.scalCy.TabIndex = 46;
            // 
            // scalCx
            // 
            this.scalCx.Location = new System.Drawing.Point(654, 89);
            this.scalCx.Name = "scalCx";
            this.scalCx.Size = new System.Drawing.Size(100, 38);
            this.scalCx.TabIndex = 45;
            // 
            // transCy
            // 
            this.transCy.Location = new System.Drawing.Point(777, 24);
            this.transCy.Name = "transCy";
            this.transCy.Size = new System.Drawing.Size(100, 38);
            this.transCy.TabIndex = 44;
            // 
            // transCx
            // 
            this.transCx.Location = new System.Drawing.Point(654, 24);
            this.transCx.Name = "transCx";
            this.transCx.Size = new System.Drawing.Size(100, 38);
            this.transCx.TabIndex = 43;
            // 
            // transCButoon
            // 
            this.transCButoon.Location = new System.Drawing.Point(911, 24);
            this.transCButoon.Name = "transCButoon";
            this.transCButoon.Size = new System.Drawing.Size(121, 46);
            this.transCButoon.TabIndex = 42;
            this.transCButoon.Text = "translate";
            this.transCButoon.UseVisualStyleBackColor = true;
            this.transCButoon.Click += new System.EventHandler(this.TransCButoon_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 511);
            this.Controls.Add(this.sheeringyc);
            this.Controls.Add(this.sheeringxc);
            this.Controls.Add(this.sheering);
            this.Controls.Add(this.refxy);
            this.Controls.Add(this.refxc);
            this.Controls.Add(this.brefc);
            this.Controls.Add(this.brotatec);
            this.Controls.Add(this.tRotateC);
            this.Controls.Add(this.bscalc);
            this.Controls.Add(this.scalCy);
            this.Controls.Add(this.scalCx);
            this.Controls.Add(this.transCy);
            this.Controls.Add(this.transCx);
            this.Controls.Add(this.transCButoon);
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
            this.Text = "Line DDA";
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
        private System.Windows.Forms.TextBox sheeringyc;
        private System.Windows.Forms.TextBox sheeringxc;
        private System.Windows.Forms.Button sheering;
        private System.Windows.Forms.Button refxy;
        private System.Windows.Forms.Button refxc;
        private System.Windows.Forms.Button brefc;
        private System.Windows.Forms.Button brotatec;
        private System.Windows.Forms.TextBox tRotateC;
        private System.Windows.Forms.Button bscalc;
        private System.Windows.Forms.TextBox scalCy;
        private System.Windows.Forms.TextBox scalCx;
        private System.Windows.Forms.TextBox transCy;
        private System.Windows.Forms.TextBox transCx;
        private System.Windows.Forms.Button transCButoon;
    }
}