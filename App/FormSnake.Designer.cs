namespace App
{
    partial class FormSnake
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
            // 
            // btnMeal
            // 
            this.btnMeal.BackColor = System.Drawing.Color.Red;
            this.btnMeal.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMeal.FlatAppearance.BorderSize = 30;
            this.btnMeal.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnMeal.Location = new System.Drawing.Point(100, 100);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(20, 20);
            this.btnMeal.TabIndex = 1;
            this.btnMeal.UseVisualStyleBackColor = false;
            // 
            // FormSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnMeal);
            this.Controls.Add(this.btnSnake);
            this.KeyPreview = true;
            this.Name = "FormSnake";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FormSnake_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSnake_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Button btnMeal;
    }
}

