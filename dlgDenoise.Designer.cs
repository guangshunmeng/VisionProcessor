namespace VisionProcessor
{
    partial class dlgDenoise
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplateWindowSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchWindowSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 166);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(35, 166);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(174, 21);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(128, 26);
            this.txtH.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "hColor";
            // 
            // txtHColor
            // 
            this.txtHColor.Location = new System.Drawing.Point(174, 53);
            this.txtHColor.Name = "txtHColor";
            this.txtHColor.Size = new System.Drawing.Size(128, 26);
            this.txtHColor.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "templateWindowSize";
            // 
            // txtTemplateWindowSize
            // 
            this.txtTemplateWindowSize.Location = new System.Drawing.Point(174, 85);
            this.txtTemplateWindowSize.Name = "txtTemplateWindowSize";
            this.txtTemplateWindowSize.Size = new System.Drawing.Size(128, 26);
            this.txtTemplateWindowSize.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "searchWindowSize";
            // 
            // txtSearchWindowSize
            // 
            this.txtSearchWindowSize.Location = new System.Drawing.Point(174, 117);
            this.txtSearchWindowSize.Name = "txtSearchWindowSize";
            this.txtSearchWindowSize.Size = new System.Drawing.Size(128, 26);
            this.txtSearchWindowSize.TabIndex = 24;
            // 
            // dlgDenoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 230);
            this.Controls.Add(this.txtSearchWindowSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemplateWindowSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label1);
            this.Name = "dlgDenoise";
            this.Text = "FastNlMeansDenoising";
            this.Load += new System.EventHandler(this.dlgDenoise_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtH, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtHColor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtTemplateWindowSize, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtSearchWindowSize, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemplateWindowSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchWindowSize;
    }
}