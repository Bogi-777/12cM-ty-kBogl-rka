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
            this.btnszamitas = new System.Windows.Forms.Button();
            this.btnkilepes = new System.Windows.Forms.Button();
            this.lblszam = new System.Windows.Forms.Label();
            this.lblgyok = new System.Windows.Forms.Label();
            this.txtszam = new System.Windows.Forms.TextBox();
            this.txtgyok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnszamitas
            // 
            this.btnszamitas.Location = new System.Drawing.Point(125, 336);
            this.btnszamitas.Name = "btnszamitas";
            this.btnszamitas.Size = new System.Drawing.Size(75, 23);
            this.btnszamitas.TabIndex = 0;
            this.btnszamitas.Text = "Számítás";
            this.btnszamitas.UseVisualStyleBackColor = true;
            this.btnszamitas.Click += new System.EventHandler(this.Btnszamitas_Click);
            // 
            // btnkilepes
            // 
            this.btnkilepes.Location = new System.Drawing.Point(322, 336);
            this.btnkilepes.Name = "btnkilepes";
            this.btnkilepes.Size = new System.Drawing.Size(75, 23);
            this.btnkilepes.TabIndex = 1;
            this.btnkilepes.Text = "Kilépés";
            this.btnkilepes.UseVisualStyleBackColor = true;
            this.btnkilepes.Click += new System.EventHandler(this.Btnkilepes_Click);
            // 
            // lblszam
            // 
            this.lblszam.AutoSize = true;
            this.lblszam.Location = new System.Drawing.Point(125, 109);
            this.lblszam.Name = "lblszam";
            this.lblszam.Size = new System.Drawing.Size(33, 13);
            this.lblszam.TabIndex = 2;
            this.lblszam.Text = "Szám";
            this.lblszam.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblgyok
            // 
            this.lblgyok.AutoSize = true;
            this.lblgyok.Location = new System.Drawing.Point(125, 170);
            this.lblgyok.Name = "lblgyok";
            this.lblgyok.Size = new System.Drawing.Size(69, 13);
            this.lblgyok.TabIndex = 3;
            this.lblgyok.Text = "Négyzetgyök";
            // 
            // txtszam
            // 
            this.txtszam.Location = new System.Drawing.Point(306, 101);
            this.txtszam.Name = "txtszam";
            this.txtszam.Size = new System.Drawing.Size(100, 20);
            this.txtszam.TabIndex = 4;
            this.txtszam.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtgyok
            // 
            this.txtgyok.Location = new System.Drawing.Point(266, 170);
            this.txtgyok.Name = "txtgyok";
            this.txtgyok.Size = new System.Drawing.Size(100, 20);
            this.txtgyok.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtgyok);
            this.Controls.Add(this.txtszam);
            this.Controls.Add(this.lblgyok);
            this.Controls.Add(this.lblszam);
            this.Controls.Add(this.btnkilepes);
            this.Controls.Add(this.btnszamitas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnszamitas;
        private System.Windows.Forms.Button btnkilepes;
        private System.Windows.Forms.Label lblszam;
        private System.Windows.Forms.Label lblgyok;
        private System.Windows.Forms.TextBox txtszam;
        private System.Windows.Forms.TextBox txtgyok;
    }
}

