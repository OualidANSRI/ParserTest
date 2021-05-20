
namespace ParserTest
{
    partial class RNC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chiffreEntree = new System.Windows.Forms.TextBox();
            this.ChiffeNumerique = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chiffreEntree
            // 
            this.chiffreEntree.Location = new System.Drawing.Point(172, 164);
            this.chiffreEntree.Name = "chiffreEntree";
            this.chiffreEntree.Size = new System.Drawing.Size(125, 27);
            this.chiffreEntree.TabIndex = 0;
            this.chiffreEntree.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChiffeNumerique
            // 
            this.ChiffeNumerique.AutoSize = true;
            this.ChiffeNumerique.Location = new System.Drawing.Point(112, 113);
            this.ChiffeNumerique.Name = "ChiffeNumerique";
            this.ChiffeNumerique.Size = new System.Drawing.Size(245, 20);
            this.ChiffeNumerique.TabIndex = 1;
            this.ChiffeNumerique.Text = "Veuillez saisir un chiffre numérique :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChiffeNumerique);
            this.Controls.Add(this.chiffreEntree);
            this.Name = "RNC";
            this.Text = "Roman Numerical Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chiffreEntree;
        private System.Windows.Forms.Label ChiffeNumerique;
        private System.Windows.Forms.Button button1;
    }
}

