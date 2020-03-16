namespace VisionProcessor
{
    partial class dlgThreshold
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
            this.tab_TH = new System.Windows.Forms.TabControl();
            this.pageTH = new System.Windows.Forms.TabPage();
            this.groupParams = new System.Windows.Forms.GroupBox();
            this.listTypes = new System.Windows.Forms.ListBox();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTheshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageATH = new System.Windows.Forms.TabPage();
            this.group_ATH_Param = new System.Windows.Forms.GroupBox();
            this.listATypes = new System.Windows.Forms.ComboBox();
            this.radAGaussian = new System.Windows.Forms.RadioButton();
            this.radAMean = new System.Windows.Forms.RadioButton();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.txtABlockSize = new System.Windows.Forms.TextBox();
            this.txtAMaxValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_TH.SuspendLayout();
            this.pageTH.SuspendLayout();
            this.groupParams.SuspendLayout();
            this.pageATH.SuspendLayout();
            this.group_ATH_Param.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(110, 278);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 38);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tab_TH
            // 
            this.tab_TH.Controls.Add(this.pageTH);
            this.tab_TH.Controls.Add(this.pageATH);
            this.tab_TH.Location = new System.Drawing.Point(12, 12);
            this.tab_TH.Name = "tab_TH";
            this.tab_TH.SelectedIndex = 0;
            this.tab_TH.Size = new System.Drawing.Size(513, 258);
            this.tab_TH.TabIndex = 5;
            // 
            // pageTH
            // 
            this.pageTH.Controls.Add(this.groupParams);
            this.pageTH.Location = new System.Drawing.Point(4, 29);
            this.pageTH.Name = "pageTH";
            this.pageTH.Padding = new System.Windows.Forms.Padding(3);
            this.pageTH.Size = new System.Drawing.Size(505, 225);
            this.pageTH.TabIndex = 0;
            this.pageTH.Text = "二值化";
            this.pageTH.UseVisualStyleBackColor = true;
            // 
            // groupParams
            // 
            this.groupParams.Controls.Add(this.listTypes);
            this.groupParams.Controls.Add(this.txtMaxValue);
            this.groupParams.Controls.Add(this.label3);
            this.groupParams.Controls.Add(this.label2);
            this.groupParams.Controls.Add(this.txtTheshold);
            this.groupParams.Controls.Add(this.label1);
            this.groupParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupParams.Location = new System.Drawing.Point(3, 3);
            this.groupParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupParams.Name = "groupParams";
            this.groupParams.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupParams.Size = new System.Drawing.Size(499, 219);
            this.groupParams.TabIndex = 3;
            this.groupParams.TabStop = false;
            this.groupParams.Text = "参数";
            // 
            // listTypes
            // 
            this.listTypes.FormattingEnabled = true;
            this.listTypes.ItemHeight = 20;
            this.listTypes.Location = new System.Drawing.Point(98, 91);
            this.listTypes.Name = "listTypes";
            this.listTypes.Size = new System.Drawing.Size(193, 124);
            this.listTypes.TabIndex = 2;
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(98, 58);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(100, 26);
            this.txtMaxValue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "maxValue";
            // 
            // txtTheshold
            // 
            this.txtTheshold.Location = new System.Drawing.Point(98, 26);
            this.txtTheshold.Name = "txtTheshold";
            this.txtTheshold.Size = new System.Drawing.Size(100, 26);
            this.txtTheshold.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theshold";
            // 
            // pageATH
            // 
            this.pageATH.Controls.Add(this.group_ATH_Param);
            this.pageATH.Location = new System.Drawing.Point(4, 29);
            this.pageATH.Name = "pageATH";
            this.pageATH.Padding = new System.Windows.Forms.Padding(3);
            this.pageATH.Size = new System.Drawing.Size(505, 225);
            this.pageATH.TabIndex = 1;
            this.pageATH.Text = "自适应二值化";
            this.pageATH.UseVisualStyleBackColor = true;
            // 
            // group_ATH_Param
            // 
            this.group_ATH_Param.Controls.Add(this.listATypes);
            this.group_ATH_Param.Controls.Add(this.radAGaussian);
            this.group_ATH_Param.Controls.Add(this.radAMean);
            this.group_ATH_Param.Controls.Add(this.txtAC);
            this.group_ATH_Param.Controls.Add(this.txtABlockSize);
            this.group_ATH_Param.Controls.Add(this.txtAMaxValue);
            this.group_ATH_Param.Controls.Add(this.label8);
            this.group_ATH_Param.Controls.Add(this.label7);
            this.group_ATH_Param.Controls.Add(this.label6);
            this.group_ATH_Param.Controls.Add(this.label5);
            this.group_ATH_Param.Controls.Add(this.label4);
            this.group_ATH_Param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_ATH_Param.Location = new System.Drawing.Point(3, 3);
            this.group_ATH_Param.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ATH_Param.Name = "group_ATH_Param";
            this.group_ATH_Param.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ATH_Param.Size = new System.Drawing.Size(499, 219);
            this.group_ATH_Param.TabIndex = 4;
            this.group_ATH_Param.TabStop = false;
            this.group_ATH_Param.Text = "参数";
            // 
            // listATypes
            // 
            this.listATypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listATypes.FormattingEnabled = true;
            this.listATypes.Location = new System.Drawing.Point(138, 97);
            this.listATypes.Name = "listATypes";
            this.listATypes.Size = new System.Drawing.Size(238, 28);
            this.listATypes.TabIndex = 5;
            // 
            // radAGaussian
            // 
            this.radAGaussian.AutoSize = true;
            this.radAGaussian.Location = new System.Drawing.Point(260, 60);
            this.radAGaussian.Name = "radAGaussian";
            this.radAGaussian.Size = new System.Drawing.Size(87, 24);
            this.radAGaussian.TabIndex = 4;
            this.radAGaussian.Text = "Gaussian";
            this.radAGaussian.UseVisualStyleBackColor = true;
            // 
            // radAMean
            // 
            this.radAMean.AutoSize = true;
            this.radAMean.Checked = true;
            this.radAMean.Location = new System.Drawing.Point(138, 60);
            this.radAMean.Name = "radAMean";
            this.radAMean.Size = new System.Drawing.Size(66, 24);
            this.radAMean.TabIndex = 4;
            this.radAMean.TabStop = true;
            this.radAMean.Text = "Mean";
            this.radAMean.UseVisualStyleBackColor = true;
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(138, 173);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(100, 26);
            this.txtAC.TabIndex = 3;
            // 
            // txtABlockSize
            // 
            this.txtABlockSize.Location = new System.Drawing.Point(138, 135);
            this.txtABlockSize.Name = "txtABlockSize";
            this.txtABlockSize.Size = new System.Drawing.Size(100, 26);
            this.txtABlockSize.TabIndex = 3;
            // 
            // txtAMaxValue
            // 
            this.txtAMaxValue.Location = new System.Drawing.Point(138, 21);
            this.txtAMaxValue.Name = "txtAMaxValue";
            this.txtAMaxValue.Size = new System.Drawing.Size(100, 26);
            this.txtAMaxValue.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "blockSize";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "thesholdType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "adaptiveMethod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "maxValue";
            // 
            // dlgThreshold
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 330);
            this.Controls.Add(this.tab_TH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dlgThreshold";
            this.Text = "二值化";
            this.Load += new System.EventHandler(this.dlgThreshold_Load);
            this.tab_TH.ResumeLayout(false);
            this.pageTH.ResumeLayout(false);
            this.groupParams.ResumeLayout(false);
            this.groupParams.PerformLayout();
            this.pageATH.ResumeLayout(false);
            this.group_ATH_Param.ResumeLayout(false);
            this.group_ATH_Param.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tab_TH;
        private System.Windows.Forms.TabPage pageTH;
        private System.Windows.Forms.GroupBox groupParams;
        private System.Windows.Forms.ListBox listTypes;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTheshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pageATH;
        private System.Windows.Forms.GroupBox group_ATH_Param;
        private System.Windows.Forms.ComboBox listATypes;
        private System.Windows.Forms.RadioButton radAGaussian;
        private System.Windows.Forms.RadioButton radAMean;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.TextBox txtABlockSize;
        private System.Windows.Forms.TextBox txtAMaxValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}