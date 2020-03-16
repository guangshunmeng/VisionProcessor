namespace VisionProcessor
{
    partial class dlgBlur
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
            this.txtB_SigmaSpace = new System.Windows.Forms.TextBox();
            this.txtB_SigmaColor = new System.Windows.Forms.TextBox();
            this.txtB_d = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pageBlur = new System.Windows.Forms.TabPage();
            this.groupParams = new System.Windows.Forms.GroupBox();
            this.listBorderTypes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnchor_Y = new System.Windows.Forms.TextBox();
            this.txtKSize_Height = new System.Windows.Forms.TextBox();
            this.txtAnchor_X = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtKSize_Width = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group_ATH_Param = new System.Windows.Forms.GroupBox();
            this.listBBorderTypes = new System.Windows.Forms.ListBox();
            this.pageBilateral = new System.Windows.Forms.TabPage();
            this.tab_Blur = new System.Windows.Forms.TabControl();
            this.pageGaussian = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGKSize_Height = new System.Windows.Forms.TextBox();
            this.txtGKSize_Width = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.listGBorderTypes = new System.Windows.Forms.ListBox();
            this.txtGSigmaY = new System.Windows.Forms.TextBox();
            this.txtGSigmaX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pageMedian = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMKSize = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pageBlur.SuspendLayout();
            this.groupParams.SuspendLayout();
            this.group_ATH_Param.SuspendLayout();
            this.pageBilateral.SuspendLayout();
            this.tab_Blur.SuspendLayout();
            this.pageGaussian.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pageMedian.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 338);
            this.btnCancel.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(117, 338);
            this.btnOK.TabIndex = 6;
            // 
            // txtB_SigmaSpace
            // 
            this.txtB_SigmaSpace.Location = new System.Drawing.Point(138, 84);
            this.txtB_SigmaSpace.Name = "txtB_SigmaSpace";
            this.txtB_SigmaSpace.Size = new System.Drawing.Size(100, 26);
            this.txtB_SigmaSpace.TabIndex = 3;
            // 
            // txtB_SigmaColor
            // 
            this.txtB_SigmaColor.Location = new System.Drawing.Point(138, 52);
            this.txtB_SigmaColor.Name = "txtB_SigmaColor";
            this.txtB_SigmaColor.Size = new System.Drawing.Size(100, 26);
            this.txtB_SigmaColor.TabIndex = 3;
            // 
            // txtB_d
            // 
            this.txtB_d.Location = new System.Drawing.Point(138, 21);
            this.txtB_d.Name = "txtB_d";
            this.txtB_d.Size = new System.Drawing.Size(100, 26);
            this.txtB_d.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "SigmaSpace";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "SigmaColor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "BorderType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "d";
            // 
            // pageBlur
            // 
            this.pageBlur.Controls.Add(this.groupParams);
            this.pageBlur.Location = new System.Drawing.Point(4, 29);
            this.pageBlur.Name = "pageBlur";
            this.pageBlur.Padding = new System.Windows.Forms.Padding(3);
            this.pageBlur.Size = new System.Drawing.Size(460, 285);
            this.pageBlur.TabIndex = 0;
            this.pageBlur.Text = "均值";
            this.pageBlur.UseVisualStyleBackColor = true;
            // 
            // groupParams
            // 
            this.groupParams.Controls.Add(this.listBorderTypes);
            this.groupParams.Controls.Add(this.label3);
            this.groupParams.Controls.Add(this.label2);
            this.groupParams.Controls.Add(this.txtAnchor_Y);
            this.groupParams.Controls.Add(this.txtKSize_Height);
            this.groupParams.Controls.Add(this.txtAnchor_X);
            this.groupParams.Controls.Add(this.label18);
            this.groupParams.Controls.Add(this.txtKSize_Width);
            this.groupParams.Controls.Add(this.label17);
            this.groupParams.Controls.Add(this.label16);
            this.groupParams.Controls.Add(this.label15);
            this.groupParams.Controls.Add(this.label1);
            this.groupParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupParams.Location = new System.Drawing.Point(3, 3);
            this.groupParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupParams.Name = "groupParams";
            this.groupParams.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupParams.Size = new System.Drawing.Size(454, 279);
            this.groupParams.TabIndex = 3;
            this.groupParams.TabStop = false;
            this.groupParams.Text = "参数";
            // 
            // listBorderTypes
            // 
            this.listBorderTypes.FormattingEnabled = true;
            this.listBorderTypes.ItemHeight = 20;
            this.listBorderTypes.Location = new System.Drawing.Point(107, 91);
            this.listBorderTypes.Name = "listBorderTypes";
            this.listBorderTypes.Size = new System.Drawing.Size(299, 164);
            this.listBorderTypes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "BorderType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Anchor";
            // 
            // txtAnchor_Y
            // 
            this.txtAnchor_Y.Location = new System.Drawing.Point(306, 58);
            this.txtAnchor_Y.Name = "txtAnchor_Y";
            this.txtAnchor_Y.Size = new System.Drawing.Size(100, 26);
            this.txtAnchor_Y.TabIndex = 1;
            // 
            // txtKSize_Height
            // 
            this.txtKSize_Height.Location = new System.Drawing.Point(306, 26);
            this.txtKSize_Height.Name = "txtKSize_Height";
            this.txtKSize_Height.Size = new System.Drawing.Size(100, 26);
            this.txtKSize_Height.TabIndex = 1;
            // 
            // txtAnchor_X
            // 
            this.txtAnchor_X.Location = new System.Drawing.Point(132, 58);
            this.txtAnchor_X.Name = "txtAnchor_X";
            this.txtAnchor_X.Size = new System.Drawing.Size(100, 26);
            this.txtAnchor_X.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(103, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "X";
            // 
            // txtKSize_Width
            // 
            this.txtKSize_Width.Location = new System.Drawing.Point(132, 26);
            this.txtKSize_Width.Name = "txtKSize_Width";
            this.txtKSize_Width.Size = new System.Drawing.Size(100, 26);
            this.txtKSize_Width.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(277, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(103, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "宽";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(277, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "高";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KSize";
            // 
            // group_ATH_Param
            // 
            this.group_ATH_Param.Controls.Add(this.listBBorderTypes);
            this.group_ATH_Param.Controls.Add(this.txtB_SigmaSpace);
            this.group_ATH_Param.Controls.Add(this.txtB_SigmaColor);
            this.group_ATH_Param.Controls.Add(this.txtB_d);
            this.group_ATH_Param.Controls.Add(this.label8);
            this.group_ATH_Param.Controls.Add(this.label7);
            this.group_ATH_Param.Controls.Add(this.label6);
            this.group_ATH_Param.Controls.Add(this.label4);
            this.group_ATH_Param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_ATH_Param.Location = new System.Drawing.Point(3, 3);
            this.group_ATH_Param.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ATH_Param.Name = "group_ATH_Param";
            this.group_ATH_Param.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ATH_Param.Size = new System.Drawing.Size(454, 279);
            this.group_ATH_Param.TabIndex = 4;
            this.group_ATH_Param.TabStop = false;
            this.group_ATH_Param.Text = "参数";
            // 
            // listBBorderTypes
            // 
            this.listBBorderTypes.FormattingEnabled = true;
            this.listBBorderTypes.ItemHeight = 20;
            this.listBBorderTypes.Location = new System.Drawing.Point(138, 116);
            this.listBBorderTypes.Name = "listBBorderTypes";
            this.listBBorderTypes.Size = new System.Drawing.Size(283, 144);
            this.listBBorderTypes.TabIndex = 4;
            // 
            // pageBilateral
            // 
            this.pageBilateral.Controls.Add(this.group_ATH_Param);
            this.pageBilateral.Location = new System.Drawing.Point(4, 29);
            this.pageBilateral.Name = "pageBilateral";
            this.pageBilateral.Padding = new System.Windows.Forms.Padding(3);
            this.pageBilateral.Size = new System.Drawing.Size(460, 285);
            this.pageBilateral.TabIndex = 1;
            this.pageBilateral.Text = "双边";
            this.pageBilateral.UseVisualStyleBackColor = true;
            // 
            // tab_Blur
            // 
            this.tab_Blur.Controls.Add(this.pageBlur);
            this.tab_Blur.Controls.Add(this.pageBilateral);
            this.tab_Blur.Controls.Add(this.pageGaussian);
            this.tab_Blur.Controls.Add(this.pageMedian);
            this.tab_Blur.Location = new System.Drawing.Point(12, 12);
            this.tab_Blur.Name = "tab_Blur";
            this.tab_Blur.SelectedIndex = 0;
            this.tab_Blur.Size = new System.Drawing.Size(468, 318);
            this.tab_Blur.TabIndex = 8;
            // 
            // pageGaussian
            // 
            this.pageGaussian.Controls.Add(this.groupBox1);
            this.pageGaussian.Location = new System.Drawing.Point(4, 29);
            this.pageGaussian.Name = "pageGaussian";
            this.pageGaussian.Padding = new System.Windows.Forms.Padding(3);
            this.pageGaussian.Size = new System.Drawing.Size(460, 285);
            this.pageGaussian.TabIndex = 2;
            this.pageGaussian.Text = "高斯";
            this.pageGaussian.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGKSize_Height);
            this.groupBox1.Controls.Add(this.txtGKSize_Width);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.listGBorderTypes);
            this.groupBox1.Controls.Add(this.txtGSigmaY);
            this.groupBox1.Controls.Add(this.txtGSigmaX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(454, 279);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // txtGKSize_Height
            // 
            this.txtGKSize_Height.Location = new System.Drawing.Point(327, 22);
            this.txtGKSize_Height.Name = "txtGKSize_Height";
            this.txtGKSize_Height.Size = new System.Drawing.Size(100, 26);
            this.txtGKSize_Height.TabIndex = 15;
            // 
            // txtGKSize_Width
            // 
            this.txtGKSize_Width.Location = new System.Drawing.Point(159, 22);
            this.txtGKSize_Width.Name = "txtGKSize_Width";
            this.txtGKSize_Width.Size = new System.Drawing.Size(100, 26);
            this.txtGKSize_Width.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(130, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 20);
            this.label19.TabIndex = 13;
            this.label19.Text = "宽";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(298, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "高";
            // 
            // listGBorderTypes
            // 
            this.listGBorderTypes.FormattingEnabled = true;
            this.listGBorderTypes.ItemHeight = 20;
            this.listGBorderTypes.Location = new System.Drawing.Point(128, 117);
            this.listGBorderTypes.Name = "listGBorderTypes";
            this.listGBorderTypes.Size = new System.Drawing.Size(299, 124);
            this.listGBorderTypes.TabIndex = 12;
            // 
            // txtGSigmaY
            // 
            this.txtGSigmaY.Location = new System.Drawing.Point(128, 85);
            this.txtGSigmaY.Name = "txtGSigmaY";
            this.txtGSigmaY.Size = new System.Drawing.Size(100, 26);
            this.txtGSigmaY.TabIndex = 9;
            // 
            // txtGSigmaX
            // 
            this.txtGSigmaX.Location = new System.Drawing.Point(128, 53);
            this.txtGSigmaX.Name = "txtGSigmaX";
            this.txtGSigmaX.Size = new System.Drawing.Size(100, 26);
            this.txtGSigmaX.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "SigmaY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "SigmaX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "BorderType";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "KSize";
            // 
            // pageMedian
            // 
            this.pageMedian.Controls.Add(this.groupBox2);
            this.pageMedian.Location = new System.Drawing.Point(4, 29);
            this.pageMedian.Name = "pageMedian";
            this.pageMedian.Size = new System.Drawing.Size(460, 285);
            this.pageMedian.TabIndex = 3;
            this.pageMedian.Text = "中值";
            this.pageMedian.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMKSize);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(460, 285);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数";
            // 
            // txtMKSize
            // 
            this.txtMKSize.Location = new System.Drawing.Point(98, 26);
            this.txtMKSize.Name = "txtMKSize";
            this.txtMKSize.Size = new System.Drawing.Size(100, 26);
            this.txtMKSize.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "KSize";
            // 
            // dlgBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 396);
            this.Controls.Add(this.tab_Blur);
            this.Name = "dlgBlur";
            this.Text = "滤波";
            this.Load += new System.EventHandler(this.dlgBlur_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tab_Blur, 0);
            this.pageBlur.ResumeLayout(false);
            this.groupParams.ResumeLayout(false);
            this.groupParams.PerformLayout();
            this.group_ATH_Param.ResumeLayout(false);
            this.group_ATH_Param.PerformLayout();
            this.pageBilateral.ResumeLayout(false);
            this.tab_Blur.ResumeLayout(false);
            this.pageGaussian.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pageMedian.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtB_SigmaSpace;
        private System.Windows.Forms.TextBox txtB_SigmaColor;
        private System.Windows.Forms.TextBox txtB_d;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage pageBlur;
        private System.Windows.Forms.GroupBox groupParams;
        private System.Windows.Forms.ListBox listBorderTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKSize_Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_ATH_Param;
        private System.Windows.Forms.TabPage pageBilateral;
        private System.Windows.Forms.TabControl tab_Blur;
        private System.Windows.Forms.TabPage pageGaussian;
        private System.Windows.Forms.TabPage pageMedian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMKSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAnchor_Y;
        private System.Windows.Forms.TextBox txtKSize_Height;
        private System.Windows.Forms.TextBox txtAnchor_X;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBBorderTypes;
        private System.Windows.Forms.ListBox listGBorderTypes;
        private System.Windows.Forms.TextBox txtGSigmaY;
        private System.Windows.Forms.TextBox txtGSigmaX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGKSize_Height;
        private System.Windows.Forms.TextBox txtGKSize_Width;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}