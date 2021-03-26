namespace Token_Generate
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
            this.tb_inp = new System.Windows.Forms.TextBox();
            this.btn_gen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_inp
            // 
            this.tb_inp.Location = new System.Drawing.Point(195, 51);
            this.tb_inp.Multiline = true;
            this.tb_inp.Name = "tb_inp";
            this.tb_inp.Size = new System.Drawing.Size(273, 98);
            this.tb_inp.TabIndex = 0;
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(235, 193);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(169, 23);
            this.btn_gen.TabIndex = 2;
            this.btn_gen.Text = "Generate Token";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(195, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 95);
            this.listBox1.TabIndex = 3;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(398, 225);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.tb_inp);
            this.Name = "Form1";
            this.Text = "Token Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_inp;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Exit;
    }
}

