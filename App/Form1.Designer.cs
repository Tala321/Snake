namespace App
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
            this.btnSnake = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSnake
            // 
            this.btnSnake.BackColor = System.Drawing.Color.Blue;
            this.btnSnake.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSnake.FlatAppearance.BorderSize = 88;
            this.btnSnake.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSnake.Location = new System.Drawing.Point(0, 0);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(20, 20);
            this.btnSnake.TabIndex = 0;
            this.btnSnake.UseVisualStyleBackColor = false;
            this.btnSnake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSnake_KeyDown);
            // 
            // btnMeal
            // 
            this.btnMeal.BackColor = System.Drawing.Color.Red;
            this.btnMeal.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMeal.FlatAppearance.BorderSize = 30;
            this.btnMeal.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnMeal.Location = new System.Drawing.Point(543, 185);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(20, 20);
            this.btnMeal.TabIndex = 1;
            this.btnMeal.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMeal);
            this.Controls.Add(this.btnSnake);
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Button btnMeal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

