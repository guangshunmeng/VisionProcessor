namespace VisionProcessor
{
    partial class dlgMorphology
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnchor_Y = new System.Windows.Forms.TextBox();
            this.txtKSize_Width = new System.Windows.Forms.TextBox();
            this.txtAnchor_X = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.listMorphShape = new System.Windows.Forms.ComboBox();
            this.listBorderType = new System.Windows.Forms.ComboBox();
            this.txtKSize_Height = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(221, 258);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOK.Location = new System.Drawing.Point(56, 258);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 37);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "BorderType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Anchor";
            // 
            // txtAnchor_Y
            // 
            this.txtAnchor_Y.Location = new System.Drawing.Point(276, 124);
            this.txtAnchor_Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnchor_Y.Name = "txtAnchor_Y";
            this.txtAnchor_Y.Size = new System.Drawing.Size(98, 26);
            this.txtAnchor_Y.TabIndex = 18;
            // 
            // txtKSize_Width
            // 
            this.txtKSize_Width.Location = new System.Drawing.Point(133, 87);
            this.txtKSize_Width.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKSize_Width.Name = "txtKSize_Width";
            this.txtKSize_Width.Size = new System.Drawing.Size(98, 26);
            this.txtKSize_Width.TabIndex = 19;
            // 
            // txtAnchor_X
            // 
            this.txtAnchor_X.Location = new System.Drawing.Point(133, 124);
            this.txtAnchor_X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnchor_X.Name = "txtAnchor_X";
            this.txtAnchor_X.Size = new System.Drawing.Size(98, 26);
            this.txtAnchor_X.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 127);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "X";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(251, 127);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 20);
            this.label17.TabIndex = 14;
            this.label17.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "内核形状";
            // 
            // listOP
            // 
            this.listOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOP.FormattingEnabled = true;
            this.listOP.Location = new System.Drawing.Point(105, 13);
            this.listOP.Name = "listOP";
            this.listOP.Size = new System.Drawing.Size(269, 28);
            this.listOP.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "操作类别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "内核大小";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "次数";
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(105, 161);
            this.txtIteration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(126, 26);
            this.txtIteration.TabIndex = 19;
            // 
            // listMorphShape
            // 
            this.listMorphShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMorphShape.FormattingEnabled = true;
            this.listMorphShape.Location = new System.Drawing.Point(105, 50);
            this.listMorphShape.Name = "listMorphShape";
            this.listMorphShape.Size = new System.Drawing.Size(269, 28);
            this.listMorphShape.TabIndex = 23;
            // 
            // listBorderType
            // 
            this.listBorderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listBorderType.FormattingEnabled = true;
            this.listBorderType.Location = new System.Drawing.Point(106, 201);
            this.listBorderType.Name = "listBorderType";
            this.listBorderType.Size = new System.Drawing.Size(268, 28);
            this.listBorderType.TabIndex = 23;
            // 
            // txtKSize_Height
            // 
            this.txtKSize_Height.Location = new System.Drawing.Point(276, 87);
            this.txtKSize_Height.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKSize_Height.Name = "txtKSize_Height";
            this.txtKSize_Height.Size = new System.Drawing.Size(98, 26);
            this.txtKSize_Height.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "宽";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "高";
            // 
            // dlgMorphology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 324);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBorderType);
            this.Controls.Add(this.listMorphShape);
            this.Controls.Add(this.listOP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnchor_Y);
            this.Controls.Add(this.txtIteration);
            this.Controls.Add(this.txtKSize_Height);
            this.Controls.Add(this.txtKSize_Width);
            this.Controls.Add(this.txtAnchor_X);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dlgMorphology";
            this.Text = "形态学操作";
            this.Load += new System.EventHandler(this.dlgMorphology_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnchor_Y;
        private System.Windows.Forms.TextBox txtKSize_Width;
        private System.Windows.Forms.TextBox txtAnchor_X;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listOP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.ComboBox listMorphShape;
        private System.Windows.Forms.ComboBox listBorderType;
        private System.Windows.Forms.TextBox txtKSize_Height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}