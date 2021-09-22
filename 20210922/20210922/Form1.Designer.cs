namespace _20210922
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
            this.btnkor = new System.Windows.Forms.Button();
            this.btngomb = new System.Windows.Forms.Button();
            this.lblkerulet = new System.Windows.Forms.Label();
            this.lblterulet = new System.Windows.Forms.Label();
            this.lblsugar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnkor
            // 
            this.btnkor.Location = new System.Drawing.Point(142, 232);
            this.btnkor.Name = "btnkor";
            this.btnkor.Size = new System.Drawing.Size(75, 23);
            this.btnkor.TabIndex = 0;
            this.btnkor.Text = "Kör";
            this.btnkor.UseVisualStyleBackColor = true;
            this.btnkor.Click += new System.EventHandler(this.Btnkor_Click);
            // 
            // btngomb
            // 
            this.btngomb.Location = new System.Drawing.Point(264, 232);
            this.btngomb.Name = "btngomb";
            this.btngomb.Size = new System.Drawing.Size(75, 23);
            this.btngomb.TabIndex = 1;
            this.btngomb.Text = "Gömb";
            this.btngomb.UseVisualStyleBackColor = true;
            this.btngomb.Click += new System.EventHandler(this.Btngomb_Click);
            // 
            // lblkerulet
            // 
            this.lblkerulet.AutoSize = true;
            this.lblkerulet.Location = new System.Drawing.Point(139, 141);
            this.lblkerulet.Name = "lblkerulet";
            this.lblkerulet.Size = new System.Drawing.Size(64, 13);
            this.lblkerulet.TabIndex = 2;
            this.lblkerulet.Text = "Kör kerülete";
            // 
            // lblterulet
            // 
            this.lblterulet.AutoSize = true;
            this.lblterulet.Location = new System.Drawing.Point(261, 141);
            this.lblterulet.Name = "lblterulet";
            this.lblterulet.Size = new System.Drawing.Size(61, 13);
            this.lblterulet.TabIndex = 3;
            this.lblterulet.Text = "Kör területe";
            // 
            // lblsugar
            // 
            this.lblsugar.AutoSize = true;
            this.lblsugar.Location = new System.Drawing.Point(106, 97);
            this.lblsugar.Name = "lblsugar";
            this.lblsugar.Size = new System.Drawing.Size(35, 13);
            this.lblsugar.TabIndex = 4;
            this.lblsugar.Text = "Sugár";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblsugar);
            this.Controls.Add(this.lblterulet);
            this.Controls.Add(this.lblkerulet);
            this.Controls.Add(this.btngomb);
            this.Controls.Add(this.btnkor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkor;
        private System.Windows.Forms.Button btngomb;
        private System.Windows.Forms.Label lblkerulet;
        private System.Windows.Forms.Label lblterulet;
        private System.Windows.Forms.Label lblsugar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

