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
            this.transCButoon = new System.Windows.Forms.Button();
            this.transCx = new System.Windows.Forms.TextBox();
            this.transCy = new System.Windows.Forms.TextBox();
            this.scalCy = new System.Windows.Forms.TextBox();
            this.scalCx = new System.Windows.Forms.TextBox();
            this.bscalc = new System.Windows.Forms.Button();
            this.brotatec = new System.Windows.Forms.Button();
            this.tRotateC = new System.Windows.Forms.TextBox();
            this.brefc = new System.Windows.Forms.Button();
            this.refxc = new System.Windows.Forms.Button();
            this.refxy = new System.Windows.Forms.Button();
            this.sheeringyc = new System.Windows.Forms.TextBox();
            this.sheeringxc = new System.Windows.Forms.TextBox();
            this.sheering = new System.Windows.Forms.Button();
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
            this.pcircule.Location = new System.Drawing.Point(12, 23);
            this.pcircule.Name = "pcircule";
            this.pcircule.Size = new System.Drawing.Size(599, 308);
            this.pcircule.TabIndex = 1;
            this.pcircule.Paint += new System.Windows.Forms.PaintEventHandler(this.Pcircule_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "x center ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "radius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "y center";
            // 
            // txc
            // 
            this.txc.Location = new System.Drawing.Point(53, 440);
            this.txc.Name = "txc";
            this.txc.Size = new System.Drawing.Size(100, 38);
            this.txc.TabIndex = 6;
            // 
            // trc
            // 
            this.trc.Location = new System.Drawing.Point(305, 440);
            this.trc.Name = "trc";
            this.trc.Size = new System.Drawing.Size(100, 38);
            this.trc.TabIndex = 7;
            // 
            // tyc
            // 
            this.tyc.Location = new System.Drawing.Point(185, 440);
            this.tyc.Name = "tyc";
            this.tyc.Size = new System.Drawing.Size(100, 38);
            this.tyc.TabIndex = 8;
            // 
            // bcircule
            // 
            this.bcircule.Location = new System.Drawing.Point(152, 509);
            this.bcircule.Name = "bcircule";
            this.bcircule.Size = new System.Drawing.Size(126, 46);
            this.bcircule.TabIndex = 9;
            this.bcircule.Text = "draw";
            this.bcircule.UseVisualStyleBackColor = true;
            this.bcircule.Click += new System.EventHandler(this.Bcircule_Click);
            // 
            // transCButoon
            // 
            this.transCButoon.Location = new System.Drawing.Point(874, 37);
            this.transCButoon.Name = "transCButoon";
            this.transCButoon.Size = new System.Drawing.Size(121, 46);
            this.transCButoon.TabIndex = 10;
            this.transCButoon.Text = "translate";
            this.transCButoon.UseVisualStyleBackColor = true;
            this.transCButoon.Click += new System.EventHandler(this.TransCButoon_Click);
            // 
            // transCx
            // 
            this.transCx.Location = new System.Drawing.Point(617, 37);
            this.transCx.Name = "transCx";
            this.transCx.Size = new System.Drawing.Size(100, 38);
            this.transCx.TabIndex = 11;
            // 
            // transCy
            // 
            this.transCy.Location = new System.Drawing.Point(740, 37);
            this.transCy.Name = "transCy";
            this.transCy.Size = new System.Drawing.Size(100, 38);
            this.transCy.TabIndex = 12;
            // 
            // scalCy
            // 
            this.scalCy.Location = new System.Drawing.Point(740, 102);
            this.scalCy.Name = "scalCy";
            this.scalCy.Size = new System.Drawing.Size(100, 38);
            this.scalCy.TabIndex = 15;
            // 
            // scalCx
            // 
            this.scalCx.Location = new System.Drawing.Point(617, 102);
            this.scalCx.Name = "scalCx";
            this.scalCx.Size = new System.Drawing.Size(100, 38);
            this.scalCx.TabIndex = 14;
            // 
            // bscalc
            // 
            this.bscalc.Location = new System.Drawing.Point(874, 102);
            this.bscalc.Name = "bscalc";
            this.bscalc.Size = new System.Drawing.Size(121, 46);
            this.bscalc.TabIndex = 16;
            this.bscalc.Text = "scale";
            this.bscalc.UseVisualStyleBackColor = true;
            this.bscalc.Click += new System.EventHandler(this.Bscalc_Click);
            // 
            // brotatec
            // 
            this.brotatec.Location = new System.Drawing.Point(874, 237);
            this.brotatec.Name = "brotatec";
            this.brotatec.Size = new System.Drawing.Size(121, 46);
            this.brotatec.TabIndex = 19;
            this.brotatec.Text = "rotate";
            this.brotatec.UseVisualStyleBackColor = true;
            this.brotatec.Click += new System.EventHandler(this.Brotatec_Click);
            // 
            // tRotateC
            // 
            this.tRotateC.Location = new System.Drawing.Point(672, 237);
            this.tRotateC.Name = "tRotateC";
            this.tRotateC.Size = new System.Drawing.Size(100, 38);
            this.tRotateC.TabIndex = 17;
            // 
            // brefc
            // 
            this.brefc.Location = new System.Drawing.Point(726, 412);
            this.brefc.Name = "brefc";
            this.brefc.Size = new System.Drawing.Size(189, 66);
            this.brefc.TabIndex = 22;
            this.brefc.Text = "reflection x,y";
            this.brefc.UseVisualStyleBackColor = true;
            this.brefc.Click += new System.EventHandler(this.Brefc_Click);
            // 
            // refxc
            // 
            this.refxc.Location = new System.Drawing.Point(832, 302);
            this.refxc.Name = "refxc";
            this.refxc.Size = new System.Drawing.Size(189, 66);
            this.refxc.TabIndex = 23;
            this.refxc.Text = "reflection x";
            this.refxc.UseVisualStyleBackColor = true;
            this.refxc.Click += new System.EventHandler(this.Refxc_Click);
            // 
            // refxy
            // 
            this.refxy.Location = new System.Drawing.Point(617, 302);
            this.refxy.Name = "refxy";
            this.refxy.Size = new System.Drawing.Size(189, 66);
            this.refxy.TabIndex = 24;
            this.refxy.Text = "reflection y";
            this.refxy.UseVisualStyleBackColor = true;
            this.refxy.Click += new System.EventHandler(this.Refxy_Click);
            // 
            // sheeringyc
            // 
            this.sheeringyc.Location = new System.Drawing.Point(726, 169);
            this.sheeringyc.Name = "sheeringyc";
            this.sheeringyc.Size = new System.Drawing.Size(100, 38);
            this.sheeringyc.TabIndex = 27;
            // 
            // sheeringxc
            // 
            this.sheeringxc.Location = new System.Drawing.Point(617, 169);
            this.sheeringxc.Name = "sheeringxc";
            this.sheeringxc.Size = new System.Drawing.Size(100, 38);
            this.sheeringxc.TabIndex = 26;
            // 
            // sheering
            // 
            this.sheering.Location = new System.Drawing.Point(874, 169);
            this.sheering.Name = "sheering";
            this.sheering.Size = new System.Drawing.Size(134, 46);
            this.sheering.TabIndex = 25;
            this.sheering.Text = "sheering";
            this.sheering.UseVisualStyleBackColor = true;
            this.sheering.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 560);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "circule";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Button transCButoon;
        private System.Windows.Forms.TextBox transCx;
        private System.Windows.Forms.TextBox transCy;
        private System.Windows.Forms.TextBox scalCy;
        private System.Windows.Forms.TextBox scalCx;
        private System.Windows.Forms.Button bscalc;
        private System.Windows.Forms.Button brotatec;
        private System.Windows.Forms.TextBox tRotateC;
        private System.Windows.Forms.Button brefc;
        private System.Windows.Forms.Button refxc;
        private System.Windows.Forms.Button refxy;
        private System.Windows.Forms.TextBox sheeringyc;
        private System.Windows.Forms.TextBox sheeringxc;
        private System.Windows.Forms.Button sheering;
    }
}