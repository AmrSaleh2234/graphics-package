namespace WindowsFormsApp1
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
            this.bChooseLine = new System.Windows.Forms.Button();
            this.bChooseCircule = new System.Windows.Forms.Button();
            this.bChooseElipse = new System.Windows.Forms.Button();
            this.bChooseLineBres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bChooseLine
            // 
            this.bChooseLine.Location = new System.Drawing.Point(225, 52);
            this.bChooseLine.Margin = new System.Windows.Forms.Padding(6);
            this.bChooseLine.Name = "bChooseLine";
            this.bChooseLine.Size = new System.Drawing.Size(253, 45);
            this.bChooseLine.TabIndex = 0;
            this.bChooseLine.Text = "line DDA";
            this.bChooseLine.UseVisualStyleBackColor = true;
            this.bChooseLine.Click += new System.EventHandler(this.BChooseLine_Click);
            // 
            // bChooseCircule
            // 
            this.bChooseCircule.Location = new System.Drawing.Point(225, 239);
            this.bChooseCircule.Margin = new System.Windows.Forms.Padding(6);
            this.bChooseCircule.Name = "bChooseCircule";
            this.bChooseCircule.Size = new System.Drawing.Size(253, 45);
            this.bChooseCircule.TabIndex = 1;
            this.bChooseCircule.Text = "circule";
            this.bChooseCircule.UseVisualStyleBackColor = true;
            this.bChooseCircule.Click += new System.EventHandler(this.BChooseCircule_Click);
            // 
            // bChooseElipse
            // 
            this.bChooseElipse.Location = new System.Drawing.Point(225, 337);
            this.bChooseElipse.Margin = new System.Windows.Forms.Padding(6);
            this.bChooseElipse.Name = "bChooseElipse";
            this.bChooseElipse.Size = new System.Drawing.Size(253, 45);
            this.bChooseElipse.TabIndex = 2;
            this.bChooseElipse.Text = "elipse";
            this.bChooseElipse.UseVisualStyleBackColor = true;
            this.bChooseElipse.Click += new System.EventHandler(this.BChooseElipse_Click);
            // 
            // bChooseLineBres
            // 
            this.bChooseLineBres.Location = new System.Drawing.Point(225, 140);
            this.bChooseLineBres.Name = "bChooseLineBres";
            this.bChooseLineBres.Size = new System.Drawing.Size(253, 45);
            this.bChooseLineBres.TabIndex = 3;
            this.bChooseLineBres.Text = "line BRES";
            this.bChooseLineBres.UseVisualStyleBackColor = true;
            this.bChooseLineBres.Click += new System.EventHandler(this.BChooseLineBres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 468);
            this.Controls.Add(this.bChooseLineBres);
            this.Controls.Add(this.bChooseElipse);
            this.Controls.Add(this.bChooseCircule);
            this.Controls.Add(this.bChooseLine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "start form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bChooseLine;
        private System.Windows.Forms.Button bChooseCircule;
        private System.Windows.Forms.Button bChooseElipse;
        private System.Windows.Forms.Button bChooseLineBres;
    }
}

