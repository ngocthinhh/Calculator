
namespace Calculator
{
    partial class Form1
    {
        /// <summary> sss
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCong = new System.Windows.Forms.Button();
            this.textBoxKQ = new System.Windows.Forms.TextBox();
            this.buttonTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(49, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(486, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 26);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonCong
            // 
            this.buttonCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCong.Location = new System.Drawing.Point(176, 154);
            this.buttonCong.Name = "buttonCong";
            this.buttonCong.Size = new System.Drawing.Size(143, 54);
            this.buttonCong.TabIndex = 1;
            this.buttonCong.Text = "+";
            this.buttonCong.UseVisualStyleBackColor = true;
            // 
            // textBoxKQ
            // 
            this.textBoxKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxKQ.Location = new System.Drawing.Point(275, 280);
            this.textBoxKQ.Name = "textBoxKQ";
            this.textBoxKQ.Size = new System.Drawing.Size(270, 26);
            this.textBoxKQ.TabIndex = 0;
            this.textBoxKQ.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonTru
            // 
            this.buttonTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonTru.Location = new System.Drawing.Point(486, 154);
            this.buttonTru.Name = "buttonTru";
            this.buttonTru.Size = new System.Drawing.Size(143, 54);
            this.buttonTru.TabIndex = 1;
            this.buttonTru.Text = "-";
            this.buttonTru.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTru);
            this.Controls.Add(this.buttonCong);
            this.Controls.Add(this.textBoxKQ);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCong;
        private System.Windows.Forms.TextBox textBoxKQ;
        private System.Windows.Forms.Button buttonTru;
    }
}

