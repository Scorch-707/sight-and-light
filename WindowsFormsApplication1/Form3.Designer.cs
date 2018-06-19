namespace WindowsFormsApplication1
{
    partial class draft1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.intersectLbl = new System.Windows.Forms.Label();
            this.rayLbl = new System.Windows.Forms.Label();
            this.r_pxLbl = new System.Windows.Forms.Label();
            this.r_pyLbl = new System.Windows.Forms.Label();
            this.r_dxLbl = new System.Windows.Forms.Label();
            this.r_dyLbl = new System.Windows.Forms.Label();
            this.s_dyLbl = new System.Windows.Forms.Label();
            this.s_dxLbl = new System.Windows.Forms.Label();
            this.s_pyLbl = new System.Windows.Forms.Label();
            this.s_pxLbl = new System.Windows.Forms.Label();
            this.r_magLbl = new System.Windows.Forms.Label();
            this.s_magLbl = new System.Windows.Forms.Label();
            this.T1Lbl = new System.Windows.Forms.Label();
            this.T2Lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.XLbl = new System.Windows.Forms.Label();
            this.YLbl = new System.Windows.Forms.Label();
            this.mouseLbl = new System.Windows.Forms.Label();
            this.closestIntersectsLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 360);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // intersectLbl
            // 
            this.intersectLbl.AutoSize = true;
            this.intersectLbl.Location = new System.Drawing.Point(646, 82);
            this.intersectLbl.Name = "intersectLbl";
            this.intersectLbl.Size = new System.Drawing.Size(59, 13);
            this.intersectLbl.TabIndex = 10;
            this.intersectLbl.Text = "Intersects: ";
            // 
            // rayLbl
            // 
            this.rayLbl.AutoSize = true;
            this.rayLbl.Location = new System.Drawing.Point(646, 39);
            this.rayLbl.Name = "rayLbl";
            this.rayLbl.Size = new System.Drawing.Size(37, 13);
            this.rayLbl.TabIndex = 11;
            this.rayLbl.Text = "Rays: ";
            // 
            // r_pxLbl
            // 
            this.r_pxLbl.AutoSize = true;
            this.r_pxLbl.Location = new System.Drawing.Point(3, 0);
            this.r_pxLbl.Name = "r_pxLbl";
            this.r_pxLbl.Size = new System.Drawing.Size(33, 13);
            this.r_pxLbl.TabIndex = 12;
            this.r_pxLbl.Text = "r_px: ";
            // 
            // r_pyLbl
            // 
            this.r_pyLbl.AutoSize = true;
            this.r_pyLbl.Location = new System.Drawing.Point(3, 18);
            this.r_pyLbl.Name = "r_pyLbl";
            this.r_pyLbl.Size = new System.Drawing.Size(33, 13);
            this.r_pyLbl.TabIndex = 13;
            this.r_pyLbl.Text = "r_py: ";
            // 
            // r_dxLbl
            // 
            this.r_dxLbl.AutoSize = true;
            this.r_dxLbl.Location = new System.Drawing.Point(3, 36);
            this.r_dxLbl.Name = "r_dxLbl";
            this.r_dxLbl.Size = new System.Drawing.Size(33, 13);
            this.r_dxLbl.TabIndex = 14;
            this.r_dxLbl.Text = "r_dx: ";
            // 
            // r_dyLbl
            // 
            this.r_dyLbl.AutoSize = true;
            this.r_dyLbl.Location = new System.Drawing.Point(3, 54);
            this.r_dyLbl.Name = "r_dyLbl";
            this.r_dyLbl.Size = new System.Drawing.Size(33, 13);
            this.r_dyLbl.TabIndex = 15;
            this.r_dyLbl.Text = "r_dy: ";
            // 
            // s_dyLbl
            // 
            this.s_dyLbl.AutoSize = true;
            this.s_dyLbl.Location = new System.Drawing.Point(89, 54);
            this.s_dyLbl.Name = "s_dyLbl";
            this.s_dyLbl.Size = new System.Drawing.Size(35, 13);
            this.s_dyLbl.TabIndex = 19;
            this.s_dyLbl.Text = "s_dy: ";
            // 
            // s_dxLbl
            // 
            this.s_dxLbl.AutoSize = true;
            this.s_dxLbl.Location = new System.Drawing.Point(89, 36);
            this.s_dxLbl.Name = "s_dxLbl";
            this.s_dxLbl.Size = new System.Drawing.Size(35, 13);
            this.s_dxLbl.TabIndex = 18;
            this.s_dxLbl.Text = "s_dx: ";
            // 
            // s_pyLbl
            // 
            this.s_pyLbl.AutoSize = true;
            this.s_pyLbl.Location = new System.Drawing.Point(89, 18);
            this.s_pyLbl.Name = "s_pyLbl";
            this.s_pyLbl.Size = new System.Drawing.Size(35, 13);
            this.s_pyLbl.TabIndex = 17;
            this.s_pyLbl.Text = "s_py: ";
            // 
            // s_pxLbl
            // 
            this.s_pxLbl.AutoSize = true;
            this.s_pxLbl.Location = new System.Drawing.Point(89, 0);
            this.s_pxLbl.Name = "s_pxLbl";
            this.s_pxLbl.Size = new System.Drawing.Size(35, 13);
            this.s_pxLbl.TabIndex = 16;
            this.s_pxLbl.Text = "s_px: ";
            // 
            // r_magLbl
            // 
            this.r_magLbl.AutoSize = true;
            this.r_magLbl.Location = new System.Drawing.Point(646, 248);
            this.r_magLbl.Name = "r_magLbl";
            this.r_magLbl.Size = new System.Drawing.Size(42, 13);
            this.r_magLbl.TabIndex = 20;
            this.r_magLbl.Text = "r_mag: ";
            // 
            // s_magLbl
            // 
            this.s_magLbl.AutoSize = true;
            this.s_magLbl.Location = new System.Drawing.Point(646, 271);
            this.s_magLbl.Name = "s_magLbl";
            this.s_magLbl.Size = new System.Drawing.Size(44, 13);
            this.s_magLbl.TabIndex = 21;
            this.s_magLbl.Text = "s_mag: ";
            // 
            // T1Lbl
            // 
            this.T1Lbl.AutoSize = true;
            this.T1Lbl.Location = new System.Drawing.Point(646, 314);
            this.T1Lbl.Name = "T1Lbl";
            this.T1Lbl.Size = new System.Drawing.Size(26, 13);
            this.T1Lbl.TabIndex = 22;
            this.T1Lbl.Text = "T1: ";
            // 
            // T2Lbl
            // 
            this.T2Lbl.AutoSize = true;
            this.T2Lbl.Location = new System.Drawing.Point(646, 345);
            this.T2Lbl.Name = "T2Lbl";
            this.T2Lbl.Size = new System.Drawing.Size(26, 13);
            this.T2Lbl.TabIndex = 23;
            this.T2Lbl.Text = "T2: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.r_pxLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.r_pyLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.r_dyLbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.r_dxLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.s_pxLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.s_pyLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.s_dyLbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.s_dxLbl, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(649, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 75);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // XLbl
            // 
            this.XLbl.AutoSize = true;
            this.XLbl.Location = new System.Drawing.Point(760, 314);
            this.XLbl.Name = "XLbl";
            this.XLbl.Size = new System.Drawing.Size(20, 13);
            this.XLbl.TabIndex = 25;
            this.XLbl.Text = "X: ";
            // 
            // YLbl
            // 
            this.YLbl.AutoSize = true;
            this.YLbl.Location = new System.Drawing.Point(760, 345);
            this.YLbl.Name = "YLbl";
            this.YLbl.Size = new System.Drawing.Size(20, 13);
            this.YLbl.TabIndex = 23;
            this.YLbl.Text = "Y: ";
            // 
            // mouseLbl
            // 
            this.mouseLbl.AutoSize = true;
            this.mouseLbl.Location = new System.Drawing.Point(646, 9);
            this.mouseLbl.Name = "mouseLbl";
            this.mouseLbl.Size = new System.Drawing.Size(45, 13);
            this.mouseLbl.TabIndex = 26;
            this.mouseLbl.Text = "Mouse: ";
            // 
            // closestIntersectsLbl
            // 
            this.closestIntersectsLbl.AutoSize = true;
            this.closestIntersectsLbl.Location = new System.Drawing.Point(863, 9);
            this.closestIntersectsLbl.Name = "closestIntersectsLbl";
            this.closestIntersectsLbl.Size = new System.Drawing.Size(96, 13);
            this.closestIntersectsLbl.TabIndex = 27;
            this.closestIntersectsLbl.Text = "Closest Intersects: ";
            // 
            // draft1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 372);
            this.Controls.Add(this.closestIntersectsLbl);
            this.Controls.Add(this.mouseLbl);
            this.Controls.Add(this.YLbl);
            this.Controls.Add(this.XLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.T2Lbl);
            this.Controls.Add(this.T1Lbl);
            this.Controls.Add(this.s_magLbl);
            this.Controls.Add(this.r_magLbl);
            this.Controls.Add(this.rayLbl);
            this.Controls.Add(this.intersectLbl);
            this.Controls.Add(this.panel1);
            this.Name = "draft1";
            this.Text = "draft1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label intersectLbl;
        private System.Windows.Forms.Label rayLbl;
        private System.Windows.Forms.Label r_pxLbl;
        private System.Windows.Forms.Label r_pyLbl;
        private System.Windows.Forms.Label r_dxLbl;
        private System.Windows.Forms.Label r_dyLbl;
        private System.Windows.Forms.Label s_dyLbl;
        private System.Windows.Forms.Label s_dxLbl;
        private System.Windows.Forms.Label s_pyLbl;
        private System.Windows.Forms.Label s_pxLbl;
        private System.Windows.Forms.Label r_magLbl;
        private System.Windows.Forms.Label s_magLbl;
        private System.Windows.Forms.Label T1Lbl;
        private System.Windows.Forms.Label T2Lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label XLbl;
        private System.Windows.Forms.Label YLbl;
        private System.Windows.Forms.Label mouseLbl;
        private System.Windows.Forms.Label closestIntersectsLbl;
    }
}