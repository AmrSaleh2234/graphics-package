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
            // bline
            // 
            this.bline.Location = new System.Drawing.Point(246, 455);
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
            this.pElipse.Location = new System.Drawing.Point(30, 25);
            this.pElipse.Name = "pElipse";
            this.pElipse.Size = new System.Drawing.Size(608, 264);
            this.pElipse.TabIndex = 18;
            // 
            // ry
            // 
            this.ry.Location = new System.Drawing.Point(178, 374);
            this.ry.Name = "ry";
            this.ry.Size = new System.Drawing.Size(111, 38);
            this.ry.TabIndex = 17;
            // 
            // xc
            // 
            this.xc.Location = new System.Drawing.Point(325, 374);
            this.xc.Name = "xc";
            this.xc.Size = new System.Drawing.Size(111, 38);
            this.xc.TabIndex = 16;
            // 
            // yc
            // 
            this.yc.Location = new System.Drawing.Point(469, 374);
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
            this.label4.Location = new System.Drawing.Point(463, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "enter yc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "enter ry";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "enter xc";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
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
            // sheeringyc
            // 
            this.sheeringyc.Location = new System.Drawing.Point(777, 157);
            this.sheeringyc.Name = "sheeringyc";
            this.sheeringyc.Size = new System.Drawing.Size(100, 38);
            this.sheeringyc.TabIndex = 41;
            this.sheeringyc.TextChanged += new System.EventHandler(this.Sheeringyc_TextChanged);
            // 
            // sheeringxc
            // 
            this.sheeringxc.Location = new System.Drawing.Point(668, 157);
            this.sheeringxc.Name = "sheeringxc";
            this.sheeringxc.Size = new System.Drawing.Size(100, 38);
            this.sheeringxc.TabIndex = 40;
            this.sheeringxc.TextChanged += new System.EventHandler(this.Sheeringxc_TextChanged);
            // 
            // sheering
            // 
            this.sheering.Location = new System.Drawing.Point(925, 157);
            this.sheering.Name = "sheering";
            this.sheering.Size = new System.Drawing.Size(134, 46);
            this.sheering.TabIndex = 39;
            this.sheering.Text = "sheering";
            this.sheering.UseVisualStyleBackColor = true;
            this.sheering.Click += new System.EventHandler(this.Sheering_Click);
            // 
            // refxy
            // 
            this.refxy.Location = new System.Drawing.Point(668, 281);
            this.refxy.Name = "refxy";
            this.refxy.Size = new System.Drawing.Size(189, 66);
            this.refxy.TabIndex = 38;
            this.refxy.Text = "reflection y";
            this.refxy.UseVisualStyleBackColor = true;
            this.refxy.Click += new System.EventHandler(this.Refxy_Click_1);
            // 
            // refxc
            // 
            this.refxc.Location = new System.Drawing.Point(863, 281);
            this.refxc.Name = "refxc";
            this.refxc.Size = new System.Drawing.Size(189, 66);
            this.refxc.TabIndex = 37;
            this.refxc.Text = "reflection x";
            this.refxc.UseVisualStyleBackColor = true;
            this.refxc.Click += new System.EventHandler(this.Refxc_Click_1);
            // 
            // brefc
            // 
            this.brefc.Location = new System.Drawing.Point(777, 372);
            this.brefc.Name = "brefc";
            this.brefc.Size = new System.Drawing.Size(189, 66);
            this.brefc.TabIndex = 36;
            this.brefc.Text = "reflection x,y";
            this.brefc.UseVisualStyleBackColor = true;
            this.brefc.Click += new System.EventHandler(this.Brefc_Click_1);
            // 
            // brotatec
            // 
            this.brotatec.Location = new System.Drawing.Point(925, 225);
            this.brotatec.Name = "brotatec";
            this.brotatec.Size = new System.Drawing.Size(121, 46);
            this.brotatec.TabIndex = 35;
            this.brotatec.Text = "rotate";
            this.brotatec.UseVisualStyleBackColor = true;
            this.brotatec.Click += new System.EventHandler(this.Brotatec_Click_1);
            // 
            // tRotateC
            // 
            this.tRotateC.Location = new System.Drawing.Point(723, 225);
            this.tRotateC.Name = "tRotateC";
            this.tRotateC.Size = new System.Drawing.Size(100, 38);
            this.tRotateC.TabIndex = 34;
            this.tRotateC.TextChanged += new System.EventHandler(this.TRotateC_TextChanged);
            // 
            // bscalc
            // 
            this.bscalc.Location = new System.Drawing.Point(925, 90);
            this.bscalc.Name = "bscalc";
            this.bscalc.Size = new System.Drawing.Size(121, 46);
            this.bscalc.TabIndex = 33;
            this.bscalc.Text = "scale";
            this.bscalc.UseVisualStyleBackColor = true;
            this.bscalc.Click += new System.EventHandler(this.Bscalc_Click_1);
            // 
            // scalCy
            // 
            this.scalCy.Location = new System.Drawing.Point(791, 90);
            this.scalCy.Name = "scalCy";
            this.scalCy.Size = new System.Drawing.Size(100, 38);
            this.scalCy.TabIndex = 32;
            this.scalCy.TextChanged += new System.EventHandler(this.ScalCy_TextChanged);
            // 
            // scalCx
            // 
            this.scalCx.Location = new System.Drawing.Point(668, 90);
            this.scalCx.Name = "scalCx";
            this.scalCx.Size = new System.Drawing.Size(100, 38);
            this.scalCx.TabIndex = 31;
            this.scalCx.TextChanged += new System.EventHandler(this.ScalCx_TextChanged);
            // 
            // transCy
            // 
            this.transCy.Location = new System.Drawing.Point(791, 25);
            this.transCy.Name = "transCy";
            this.transCy.Size = new System.Drawing.Size(100, 38);
            this.transCy.TabIndex = 30;
            this.transCy.TextChanged += new System.EventHandler(this.TransCy_TextChanged);
            // 
            // transCx
            // 
            this.transCx.Location = new System.Drawing.Point(668, 25);
            this.transCx.Name = "transCx";
            this.transCx.Size = new System.Drawing.Size(100, 38);
            this.transCx.TabIndex = 29;
            this.transCx.TextChanged += new System.EventHandler(this.TransCx_TextChanged);
            // 
            // transCButoon
            // 
            this.transCButoon.Location = new System.Drawing.Point(925, 25);
            this.transCButoon.Name = "transCButoon";
            this.transCButoon.Size = new System.Drawing.Size(121, 46);
            this.transCButoon.TabIndex = 28;
            this.transCButoon.Text = "translate";
            this.transCButoon.UseVisualStyleBackColor = true;
            this.transCButoon.Click += new System.EventHandler(this.TransCButoon_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 538);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.Text = "line DDA";
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