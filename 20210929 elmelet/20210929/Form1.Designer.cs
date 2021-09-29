namespace _20210929
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
            this.btnevszak = new System.Windows.Forms.Button();
            this.btnkilepes = new System.Windows.Forms.Button();
            this.lblhonapok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnevszak
            // 
            this.btnevszak.Location = new System.Drawing.Point(143, 284);
            this.btnevszak.Name = "btnevszak";
            this.btnevszak.Size = new System.Drawing.Size(75, 23);
            this.btnevszak.TabIndex = 0;
            this.btnevszak.Text = "Évszak";
            this.btnevszak.UseVisualStyleBackColor = true;
            this.btnevszak.Click += new System.EventHandler(this.Btnevszak_Click);
            // 
            // btnkilepes
            // 
            this.btnkilepes.Location = new System.Drawing.Point(282, 283);
            this.btnkilepes.Name = "btnkilepes";
            this.btnkilepes.Size = new System.Drawing.Size(75, 23);
            this.btnkilepes.TabIndex = 1;
            this.btnkilepes.Text = "Kilépés";
            this.btnkilepes.UseVisualStyleBackColor = true;
            // 
            // lblhonapok
            // 
            this.lblhonapok.AutoSize = true;
            this.lblhonapok.Location = new System.Drawing.Point(87, 85);
            this.lblhonapok.Name = "lblhonapok";
            this.lblhonapok.Size = new System.Drawing.Size(98, 13);
            this.lblhonapok.TabIndex = 2;
            this.lblhonapok.Text = "Hónapok sorszáma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblhonapok);
            this.Controls.Add(this.btnkilepes);
            this.Controls.Add(this.btnevszak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnevszak;
        private System.Windows.Forms.Button btnkilepes;
        private System.Windows.Forms.Label lblhonapok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

