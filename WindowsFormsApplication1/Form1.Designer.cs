namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.mouseX = new System.Windows.Forms.Label();
            this.mouseY = new System.Windows.Forms.Label();
            this.currentX = new System.Windows.Forms.Label();
            this.currentY = new System.Windows.Forms.Label();
            this.outside = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uniquePointsBtn = new System.Windows.Forms.Button();
            this.intersectsDisplay = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(665, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Click to Follow";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Follow Mouse";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // mouseX
            // 
            this.mouseX.AutoSize = true;
            this.mouseX.Location = new System.Drawing.Point(666, 304);
            this.mouseX.Name = "mouseX";
            this.mouseX.Size = new System.Drawing.Size(52, 13);
            this.mouseX.TabIndex = 2;
            this.mouseX.Text = "Mouse X:";
            // 
            // mouseY
            // 
            this.mouseY.AutoSize = true;
            this.mouseY.Location = new System.Drawing.Point(666, 327);
            this.mouseY.Name = "mouseY";
            this.mouseY.Size = new System.Drawing.Size(52, 13);
            this.mouseY.TabIndex = 3;
            this.mouseY.Text = "Mouse Y:";
            // 
            // currentX
            // 
            this.currentX.AutoSize = true;
            this.currentX.Location = new System.Drawing.Point(666, 355);
            this.currentX.Name = "currentX";
            this.currentX.Size = new System.Drawing.Size(54, 13);
            this.currentX.TabIndex = 4;
            this.currentX.Text = "Current X:";
            // 
            // currentY
            // 
            this.currentY.AutoSize = true;
            this.currentY.Location = new System.Drawing.Point(666, 377);
            this.currentY.Name = "currentY";
            this.currentY.Size = new System.Drawing.Size(54, 13);
            this.currentY.TabIndex = 5;
            this.currentY.Text = "Current Y:";
            // 
            // outside
            // 
            this.outside.AutoSize = true;
            this.outside.Location = new System.Drawing.Point(355, 208);
            this.outside.Name = "outside";
            this.outside.Size = new System.Drawing.Size(0, 13);
            this.outside.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 390);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // uniquePointsBtn
            // 
            this.uniquePointsBtn.Location = new System.Drawing.Point(788, 233);
            this.uniquePointsBtn.Name = "uniquePointsBtn";
            this.uniquePointsBtn.Size = new System.Drawing.Size(109, 47);
            this.uniquePointsBtn.TabIndex = 9;
            this.uniquePointsBtn.Text = "Debug Points";
            this.uniquePointsBtn.UseVisualStyleBackColor = true;
            this.uniquePointsBtn.Click += new System.EventHandler(this.uniquePointsBtn_Click);
            // 
            // intersectsDisplay
            // 
            this.intersectsDisplay.Location = new System.Drawing.Point(662, 21);
            this.intersectsDisplay.Name = "intersectsDisplay";
            this.intersectsDisplay.Size = new System.Drawing.Size(235, 200);
            this.intersectsDisplay.TabIndex = 10;
            this.intersectsDisplay.Text = "";
            this.intersectsDisplay.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Intersects:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "open draft1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intersectsDisplay);
            this.Controls.Add(this.uniquePointsBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.outside);
            this.Controls.Add(this.currentY);
            this.Controls.Add(this.currentX);
            this.Controls.Add(this.mouseY);
            this.Controls.Add(this.mouseX);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label mouseX;
        private System.Windows.Forms.Label mouseY;
        private System.Windows.Forms.Label currentX;
        private System.Windows.Forms.Label currentY;
        private System.Windows.Forms.Label outside;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uniquePointsBtn;
        private System.Windows.Forms.RichTextBox intersectsDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

