namespace WindowsFormsApp1
{
    partial class Form5
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
            this.blineBres = new System.Windows.Forms.Button();
            this.pLineBres = new System.Windows.Forms.Panel();
            this.ty1lineBres = new System.Windows.Forms.TextBox();
            this.tx2lineBres = new System.Windows.Forms.TextBox();
            this.ty2lineBres = new System.Windows.Forms.TextBox();
            this.tx1LineBres = new System.Windows.Forms.TextBox();
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
            // blineBres
            // 
            this.blineBres.Location = new System.Drawing.Point(229, 448);
            this.blineBres.Name = "blineBres";
            this.blineBres.Size = new System.Drawing.Size(143, 44);
            this.blineBres.TabIndex = 19;
            this.blineBres.Text = "draw";
            this.blineBres.UseVisualStyleBackColor = true;
            this.blineBres.Click += new System.EventHandler(this.BlineBres_Click);
            // 
            // pLineBres
            // 
            this.pLineBres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pLineBres.Location = new System.Drawing.Point(24, 22);
            this.pLineBres.Name = "pLineBres";
            this.pLineBres.Size = new System.Drawing.Size(608, 264);
            this.pLineBres.TabIndex = 18;
            // 
            // ty1lineBres
            // 
            this.ty1lineBres.Location = new System.Drawing.Point(171, 365);
            this.ty1lineBres.Name = "ty1lineBres";
            this.ty1lineBres.Size = new System.Drawing.Size(111, 38);
            this.ty1lineBres.TabIndex = 17;
            // 
            // tx2lineBres
            // 
            this.tx2lineBres.Location = new System.Drawing.Point(332, 365);
            this.tx2lineBres.Name = "tx2lineBres";
            this.tx2lineBres.Size = new System.Drawing.Size(111, 38);
            this.tx2lineBres.TabIndex = 16;
            this.tx2lineBres.TextChanged += new System.EventHandler(this.Tx2lineBres_TextChanged);
            // 
            // ty2lineBres
            // 
            this.ty2lineBres.Location = new System.Drawing.Point(484, 365);
            this.ty2lineBres.Name = "ty2lineBres";
            this.ty2lineBres.Size = new System.Drawing.Size(111, 38);
            this.ty2lineBres.TabIndex = 15;
            this.ty2lineBres.TextChanged += new System.EventHandler(this.Ty2lineBres_TextChanged);
            // 
            // tx1LineBres
            // 
            this.tx1LineBres.Location = new System.Drawing.Point(37, 365);
            this.tx1LineBres.Name = "tx1LineBres";
            this.tx1LineBres.Size = new System.Drawing.Size(111, 38);
            this.tx1LineBres.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "enter y2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "enter y1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "enter x2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "enter x1";
            // 
            // sheeringyc
            // 
            this.sheeringyc.Location = new System.Drawing.Point(764, 179);
            this.sheeringyc.Name = "sheeringyc";
            this.sheeringyc.Size = new System.Drawing.Size(100, 38);
            this.sheeringyc.TabIndex = 69;
            this.sheeringyc.TextChanged += new System.EventHandler(this.Sheeringyc_TextChanged);
            // 
            // sheeringxc
            // 
            this.sheeringxc.Location = new System.Drawing.Point(655, 179);
            this.sheeringxc.Name = "sheeringxc";
            this.sheeringxc.Size = new System.Drawing.Size(100, 38);
            this.sheeringxc.TabIndex = 68;
            this.sheeringxc.TextChanged += new System.EventHandler(this.Sheeringxc_TextChanged);
            // 
            // sheering
            // 
            this.sheering.Location = new System.Drawing.Point(912, 179);
            this.sheering.Name = "sheering";
            this.sheering.Size = new System.Drawing.Size(134, 46);
            this.sheering.TabIndex = 67;
            this.sheering.Text = "sheering";
            this.sheering.UseVisualStyleBackColor = true;
            this.sheering.Click += new System.EventHandler(this.Sheering_Click);
            // 
            // refxy
            // 
            this.refxy.Location = new System.Drawing.Point(655, 303);
            this.refxy.Name = "refxy";
            this.refxy.Size = new System.Drawing.Size(189, 66);
            this.refxy.TabIndex = 66;
            this.refxy.Text = "reflection y";
            this.refxy.UseVisualStyleBackColor = true;
            this.refxy.Click += new System.EventHandler(this.Refxy_Click);
            // 
            // refxc
            // 
            this.refxc.Location = new System.Drawing.Point(850, 303);
            this.refxc.Name = "refxc";
            this.refxc.Size = new System.Drawing.Size(189, 66);
            this.refxc.TabIndex = 65;
            this.refxc.Text = "reflection x";
            this.refxc.UseVisualStyleBackColor = true;
            this.refxc.Click += new System.EventHandler(this.Refxc_Click);
            // 
            // brefc
            // 
            this.brefc.Location = new System.Drawing.Point(764, 394);
            this.brefc.Name = "brefc";
            this.brefc.Size = new System.Drawing.Size(189, 66);
            this.brefc.TabIndex = 64;
            this.brefc.Text = "reflection x,y";
            this.brefc.UseVisualStyleBackColor = true;
            this.brefc.Click += new System.EventHandler(this.Brefc_Click);
            // 
            // brotatec
            // 
            this.brotatec.Location = new System.Drawing.Point(912, 247);
            this.brotatec.Name = "brotatec";
            this.brotatec.Size = new System.Drawing.Size(121, 46);
            this.brotatec.TabIndex = 63;
            this.brotatec.Text = "rotate";
            this.brotatec.UseVisualStyleBackColor = true;
            this.brotatec.Click += new System.EventHandler(this.Brotatec_Click);
            // 
            // tRotateC
            // 
            this.tRotateC.Location = new System.Drawing.Point(710, 247);
            this.tRotateC.Name = "tRotateC";
            this.tRotateC.Size = new System.Drawing.Size(100, 38);
            this.tRotateC.TabIndex = 62;
            this.tRotateC.TextChanged += new System.EventHandler(this.TRotateC_TextChanged);
            // 
            // bscalc
            // 
            this.bscalc.Location = new System.Drawing.Point(912, 112);
            this.bscalc.Name = "bscalc";
            this.bscalc.Size = new System.Drawing.Size(121, 46);
            this.bscalc.TabIndex = 61;
            this.bscalc.Text = "scale";
            this.bscalc.UseVisualStyleBackColor = true;
            this.bscalc.Click += new System.EventHandler(this.Bscalc_Click);
            // 
            // scalCy
            // 
            this.scalCy.Location = new System.Drawing.Point(778, 112);
            this.scalCy.Name = "scalCy";
            this.scalCy.Size = new System.Drawing.Size(100, 38);
            this.scalCy.TabIndex = 60;
            this.scalCy.TextChanged += new System.EventHandler(this.ScalCy_TextChanged);
            // 
            // scalCx
            // 
            this.scalCx.Location = new System.Drawing.Point(655, 112);
            this.scalCx.Name = "scalCx";
            this.scalCx.Size = new System.Drawing.Size(100, 38);
            this.scalCx.TabIndex = 59;
            this.scalCx.TextChanged += new System.EventHandler(this.ScalCx_TextChanged);
            // 
            // transCy
            // 
            this.transCy.Location = new System.Drawing.Point(778, 47);
            this.transCy.Name = "transCy";
            this.transCy.Size = new System.Drawing.Size(100, 38);
            this.transCy.TabIndex = 58;
            this.transCy.TextChanged += new System.EventHandler(this.TransCy_TextChanged);
            // 
            // transCx
            // 
            this.transCx.Location = new System.Drawing.Point(655, 47);
            this.transCx.Name = "transCx";
            this.transCx.Size = new System.Drawing.Size(100, 38);
            this.transCx.TabIndex = 57;
            this.transCx.TextChanged += new System.EventHandler(this.TransCx_TextChanged);
            // 
            // transCButoon
            // 
            this.transCButoon.Location = new System.Drawing.Point(912, 47);
            this.transCButoon.Name = "transCButoon";
            this.transCButoon.Size = new System.Drawing.Size(121, 46);
            this.transCButoon.TabIndex = 56;
            this.transCButoon.Text = "translate";
            this.transCButoon.UseVisualStyleBackColor = true;
            this.transCButoon.Click += new System.EventHandler(this.TransCButoon_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 577);
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
            this.Controls.Add(this.blineBres);
            this.Controls.Add(this.pLineBres);
            this.Controls.Add(this.ty1lineBres);
            this.Controls.Add(this.tx2lineBres);
            this.Controls.Add(this.ty2lineBres);
            this.Controls.Add(this.tx1LineBres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form5";
            this.Text = "lineBRES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button blineBres;
        private System.Windows.Forms.Panel pLineBres;
        private System.Windows.Forms.TextBox ty1lineBres;
        private System.Windows.Forms.TextBox tx2lineBres;
        private System.Windows.Forms.TextBox ty2lineBres;
        private System.Windows.Forms.TextBox tx1LineBres;
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