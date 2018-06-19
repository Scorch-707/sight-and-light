namespace WindowsFormsApplication1
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
            this.pointDisplay = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uniquePointDisplay = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uniqueAngleDisplay = new System.Windows.Forms.RichTextBox();
            this.rayDisplay = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pointDisplay
            // 
            this.pointDisplay.Location = new System.Drawing.Point(12, 25);
            this.pointDisplay.Name = "pointDisplay";
            this.pointDisplay.Size = new System.Drawing.Size(250, 304);
            this.pointDisplay.TabIndex = 0;
            this.pointDisplay.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unique Points";
            // 
            // uniquePointDisplay
            // 
            this.uniquePointDisplay.Location = new System.Drawing.Point(12, 348);
            this.uniquePointDisplay.Name = "uniquePointDisplay";
            this.uniquePointDisplay.Size = new System.Drawing.Size(255, 304);
            this.uniquePointDisplay.TabIndex = 2;
            this.uniquePointDisplay.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unique Angles";
            // 
            // uniqueAngleDisplay
            // 
            this.uniqueAngleDisplay.Location = new System.Drawing.Point(283, 25);
            this.uniqueAngleDisplay.Name = "uniqueAngleDisplay";
            this.uniqueAngleDisplay.Size = new System.Drawing.Size(293, 304);
            this.uniqueAngleDisplay.TabIndex = 4;
            this.uniqueAngleDisplay.Text = "";
            // 
            // rayDisplay
            // 
            this.rayDisplay.Location = new System.Drawing.Point(273, 348);
            this.rayDisplay.Name = "rayDisplay";
            this.rayDisplay.Size = new System.Drawing.Size(383, 304);
            this.rayDisplay.TabIndex = 6;
            this.rayDisplay.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rays";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rayDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uniqueAngleDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uniquePointDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointDisplay);
            this.Name = "Form2";
            this.Text = "Ray Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox pointDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox uniquePointDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox uniqueAngleDisplay;
        private System.Windows.Forms.RichTextBox rayDisplay;
        private System.Windows.Forms.Label label4;
    }
}