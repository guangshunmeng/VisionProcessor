namespace VisionProcessor
{
    partial class dlgCanny
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
            this.txtThreshold2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThreshold1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApertureSize = new System.Windows.Forms.TextBox();
            this.chkL2gradient = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(173, 157);
            this.btnCancel.TabIndex = 20;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(47, 157);
            this.btnOK.TabIndex = 19;
            // 
            // txtThreshold2
            // 
            this.txtThreshold2.Location = new System.Drawing.Point(118, 41);
            this.txtThreshold2.Name = "txtThreshold2";
            this.txtThreshold2.Size = new System.Drawing.Size(181, 26);
            this.txtThreshold2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "apertureSize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "threshold2";
            // 
            // txtThreshold1
            // 
            this.txtThreshold1.Location = new System.Drawing.Point(118, 9);
            this.txtThreshold1.Name = "txtThreshold1";
            this.txtThreshold1.Size = new System.Drawing.Size(181, 26);
            this.txtThreshold1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "threshold1";
            // 
            // txtApertureSize
            // 
            this.txtApertureSize.Location = new System.Drawing.Point(118, 71);
            this.txtApertureSize.Name = "txtApertureSize";
            this.txtApertureSize.Size = new System.Drawing.Size(181, 26);
            this.txtApertureSize.TabIndex = 16;
            // 
            // chkL2gradient
            // 
            this.chkL2gradient.AutoSize = true;
            this.chkL2gradient.Location = new System.Drawing.Point(118, 105);
            this.chkL2gradient.Name = "chkL2gradient";
            this.chkL2gradient.Size = new System.Drawing.Size(100, 24);
            this.chkL2gradient.TabIndex = 21;
            this.chkL2gradient.Text = "L2gradient";
            this.chkL2gradient.UseVisualStyleBackColor = true;
            // 
            // dlgCanny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 216);
            this.Controls.Add(this.chkL2gradient);
            this.Controls.Add(this.txtApertureSize);
            this.Controls.Add(this.txtThreshold2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThreshold1);
            this.Controls.Add(this.label1);
            this.Name = "dlgCanny";
            this.Text = "Canny边缘提取";
            this.Load += new System.EventHandler(this.dlgCanny_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtThreshold1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtThreshold2, 0);
            this.Controls.SetChildIndex(this.txtApertureSize, 0);
            this.Controls.SetChildIndex(this.chkL2gradient, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThreshold2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThreshold1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApertureSize;
        private System.Windows.Forms.CheckBox chkL2gradient;
    }
}