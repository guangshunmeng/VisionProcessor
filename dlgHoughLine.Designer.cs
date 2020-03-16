namespace VisionProcessor
{
    partial class dlgHoughLine
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtRho = new System.Windows.Forms.TextBox();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSrn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinLength = new System.Windows.Forms.TextBox();
            this.txtMaxGap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 321);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(78, 321);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "rho";
            // 
            // txtRho
            // 
            this.txtRho.Location = new System.Drawing.Point(170, 69);
            this.txtRho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRho.Name = "txtRho";
            this.txtRho.Size = new System.Drawing.Size(193, 26);
            this.txtRho.TabIndex = 24;
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(170, 105);
            this.txtTheta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(193, 26);
            this.txtTheta.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "theta";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(170, 141);
            this.txtThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(193, 26);
            this.txtThreshold.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "threshold";
            // 
            // txtSrn
            // 
            this.txtSrn.Location = new System.Drawing.Point(170, 177);
            this.txtSrn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSrn.Name = "txtSrn";
            this.txtSrn.Size = new System.Drawing.Size(193, 26);
            this.txtSrn.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "srn";
            // 
            // txtStn
            // 
            this.txtStn.Location = new System.Drawing.Point(170, 213);
            this.txtStn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStn.Name = "txtStn";
            this.txtStn.Size = new System.Drawing.Size(193, 26);
            this.txtStn.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "stn";
            // 
            // txtMinLength
            // 
            this.txtMinLength.Location = new System.Drawing.Point(170, 249);
            this.txtMinLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinLength.Name = "txtMinLength";
            this.txtMinLength.Size = new System.Drawing.Size(193, 26);
            this.txtMinLength.TabIndex = 24;
            // 
            // txtMaxGap
            // 
            this.txtMaxGap.Location = new System.Drawing.Point(170, 285);
            this.txtMaxGap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxGap.Name = "txtMaxGap";
            this.txtMaxGap.Size = new System.Drawing.Size(193, 26);
            this.txtMaxGap.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "minLineLength";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "maxLineGap";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "类型";
            // 
            // listMethod
            // 
            this.listMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMethod.FormattingEnabled = true;
            this.listMethod.Items.AddRange(new object[] {
            "SHT",
            "MHT",
            "PPHT"});
            this.listMethod.Location = new System.Drawing.Point(170, 28);
            this.listMethod.Name = "listMethod";
            this.listMethod.Size = new System.Drawing.Size(193, 28);
            this.listMethod.TabIndex = 25;
            this.listMethod.SelectedIndexChanged += new System.EventHandler(this.listMethod_SelectedIndexChanged);
            // 
            // dlgHoughLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 373);
            this.Controls.Add(this.listMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxGap);
            this.Controls.Add(this.txtMinLength);
            this.Controls.Add(this.txtStn);
            this.Controls.Add(this.txtSrn);
            this.Controls.Add(this.txtThreshold);
            this.Controls.Add(this.txtTheta);
            this.Controls.Add(this.txtRho);
            this.Name = "dlgHoughLine";
            this.Text = "HoughLine";
            this.Load += new System.EventHandler(this.dlgHoughtLine_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtRho, 0);
            this.Controls.SetChildIndex(this.txtTheta, 0);
            this.Controls.SetChildIndex(this.txtThreshold, 0);
            this.Controls.SetChildIndex(this.txtSrn, 0);
            this.Controls.SetChildIndex(this.txtStn, 0);
            this.Controls.SetChildIndex(this.txtMinLength, 0);
            this.Controls.SetChildIndex(this.txtMaxGap, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.listMethod, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRho;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinLength;
        private System.Windows.Forms.TextBox txtMaxGap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox listMethod;
    }
}