namespace VisionProcessor
{
    partial class dlgAffineTransform
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMatrix = new System.Windows.Forms.TabPage();
            this.tabParm = new System.Windows.Forms.TabPage();
            this.txt_2_2 = new System.Windows.Forms.TextBox();
            this.txt_1_2 = new System.Windows.Forms.TextBox();
            this.txt_0_2 = new System.Windows.Forms.TextBox();
            this.txt_2_1 = new System.Windows.Forms.TextBox();
            this.txt_1_1 = new System.Windows.Forms.TextBox();
            this.txt_0_1 = new System.Windows.Forms.TextBox();
            this.txt_2_0 = new System.Windows.Forms.TextBox();
            this.txt_1_0 = new System.Windows.Forms.TextBox();
            this.txt_0_0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCenterX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCenterY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRotateAngle = new System.Windows.Forms.TextBox();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabMatrix.SuspendLayout();
            this.tabParm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(268, 260);
            this.btnCancel.Text = "关闭";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(160, 260);
            this.btnOK.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "应用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMatrix);
            this.tabControl1.Controls.Add(this.tabParm);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 240);
            this.tabControl1.TabIndex = 26;
            // 
            // tabMatrix
            // 
            this.tabMatrix.Controls.Add(this.txt_2_2);
            this.tabMatrix.Controls.Add(this.txt_1_2);
            this.tabMatrix.Controls.Add(this.txt_0_2);
            this.tabMatrix.Controls.Add(this.txt_2_1);
            this.tabMatrix.Controls.Add(this.txt_1_1);
            this.tabMatrix.Controls.Add(this.txt_0_1);
            this.tabMatrix.Controls.Add(this.txt_2_0);
            this.tabMatrix.Controls.Add(this.txt_1_0);
            this.tabMatrix.Controls.Add(this.txt_0_0);
            this.tabMatrix.Location = new System.Drawing.Point(4, 29);
            this.tabMatrix.Name = "tabMatrix";
            this.tabMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatrix.Size = new System.Drawing.Size(336, 207);
            this.tabMatrix.TabIndex = 0;
            this.tabMatrix.Text = "矩阵";
            this.tabMatrix.UseVisualStyleBackColor = true;
            // 
            // tabParm
            // 
            this.tabParm.Controls.Add(this.txtCenterY);
            this.tabParm.Controls.Add(this.label3);
            this.tabParm.Controls.Add(this.txtScale);
            this.tabParm.Controls.Add(this.txtRotateAngle);
            this.tabParm.Controls.Add(this.txtCenterX);
            this.tabParm.Controls.Add(this.label2);
            this.tabParm.Controls.Add(this.label5);
            this.tabParm.Controls.Add(this.label4);
            this.tabParm.Controls.Add(this.label1);
            this.tabParm.Location = new System.Drawing.Point(4, 29);
            this.tabParm.Name = "tabParm";
            this.tabParm.Padding = new System.Windows.Forms.Padding(3);
            this.tabParm.Size = new System.Drawing.Size(336, 207);
            this.tabParm.TabIndex = 1;
            this.tabParm.Text = "参数";
            this.tabParm.UseVisualStyleBackColor = true;
            // 
            // txt_2_2
            // 
            this.txt_2_2.Location = new System.Drawing.Point(223, 70);
            this.txt_2_2.Name = "txt_2_2";
            this.txt_2_2.Size = new System.Drawing.Size(100, 26);
            this.txt_2_2.TabIndex = 25;
            this.txt_2_2.Visible = false;
            // 
            // txt_1_2
            // 
            this.txt_1_2.Location = new System.Drawing.Point(223, 38);
            this.txt_1_2.Name = "txt_1_2";
            this.txt_1_2.Size = new System.Drawing.Size(100, 26);
            this.txt_1_2.TabIndex = 26;
            // 
            // txt_0_2
            // 
            this.txt_0_2.Location = new System.Drawing.Point(223, 6);
            this.txt_0_2.Name = "txt_0_2";
            this.txt_0_2.Size = new System.Drawing.Size(100, 26);
            this.txt_0_2.TabIndex = 27;
            // 
            // txt_2_1
            // 
            this.txt_2_1.Location = new System.Drawing.Point(117, 70);
            this.txt_2_1.Name = "txt_2_1";
            this.txt_2_1.Size = new System.Drawing.Size(100, 26);
            this.txt_2_1.TabIndex = 28;
            this.txt_2_1.Visible = false;
            // 
            // txt_1_1
            // 
            this.txt_1_1.Location = new System.Drawing.Point(117, 38);
            this.txt_1_1.Name = "txt_1_1";
            this.txt_1_1.Size = new System.Drawing.Size(100, 26);
            this.txt_1_1.TabIndex = 29;
            // 
            // txt_0_1
            // 
            this.txt_0_1.Location = new System.Drawing.Point(117, 6);
            this.txt_0_1.Name = "txt_0_1";
            this.txt_0_1.Size = new System.Drawing.Size(100, 26);
            this.txt_0_1.TabIndex = 30;
            // 
            // txt_2_0
            // 
            this.txt_2_0.Location = new System.Drawing.Point(11, 70);
            this.txt_2_0.Name = "txt_2_0";
            this.txt_2_0.Size = new System.Drawing.Size(100, 26);
            this.txt_2_0.TabIndex = 31;
            this.txt_2_0.Visible = false;
            // 
            // txt_1_0
            // 
            this.txt_1_0.Location = new System.Drawing.Point(11, 38);
            this.txt_1_0.Name = "txt_1_0";
            this.txt_1_0.Size = new System.Drawing.Size(100, 26);
            this.txt_1_0.TabIndex = 32;
            // 
            // txt_0_0
            // 
            this.txt_0_0.Location = new System.Drawing.Point(11, 6);
            this.txt_0_0.Name = "txt_0_0";
            this.txt_0_0.Size = new System.Drawing.Size(100, 26);
            this.txt_0_0.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "中心";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // txtCenterX
            // 
            this.txtCenterX.Location = new System.Drawing.Point(97, 10);
            this.txtCenterX.Name = "txtCenterX";
            this.txtCenterX.Size = new System.Drawing.Size(100, 26);
            this.txtCenterX.TabIndex = 2;
            this.txtCenterX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y";
            // 
            // txtCenterY
            // 
            this.txtCenterY.Location = new System.Drawing.Point(226, 10);
            this.txtCenterY.Name = "txtCenterY";
            this.txtCenterY.Size = new System.Drawing.Size(100, 26);
            this.txtCenterY.TabIndex = 2;
            this.txtCenterY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "旋转角度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "缩放";
            // 
            // txtRotateAngle
            // 
            this.txtRotateAngle.Location = new System.Drawing.Point(97, 59);
            this.txtRotateAngle.Name = "txtRotateAngle";
            this.txtRotateAngle.Size = new System.Drawing.Size(100, 26);
            this.txtRotateAngle.TabIndex = 2;
            this.txtRotateAngle.Text = "0";
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(97, 107);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(100, 26);
            this.txtScale.TabIndex = 2;
            this.txtScale.Text = "1";
            // 
            // dlgAffineTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 311);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "dlgAffineTransform";
            this.Text = "AffineTransform";
            this.Load += new System.EventHandler(this.dlgAffineTransform_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabMatrix.ResumeLayout(false);
            this.tabMatrix.PerformLayout();
            this.tabParm.ResumeLayout(false);
            this.tabParm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMatrix;
        private System.Windows.Forms.TextBox txt_2_2;
        private System.Windows.Forms.TextBox txt_1_2;
        private System.Windows.Forms.TextBox txt_0_2;
        private System.Windows.Forms.TextBox txt_2_1;
        private System.Windows.Forms.TextBox txt_1_1;
        private System.Windows.Forms.TextBox txt_0_1;
        private System.Windows.Forms.TextBox txt_2_0;
        private System.Windows.Forms.TextBox txt_1_0;
        private System.Windows.Forms.TextBox txt_0_0;
        private System.Windows.Forms.TabPage tabParm;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.TextBox txtRotateAngle;
        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}