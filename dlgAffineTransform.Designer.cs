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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_0_0 = new System.Windows.Forms.TextBox();
            this.txt_0_1 = new System.Windows.Forms.TextBox();
            this.txt_0_2 = new System.Windows.Forms.TextBox();
            this.txt_1_0 = new System.Windows.Forms.TextBox();
            this.txt_1_1 = new System.Windows.Forms.TextBox();
            this.txt_1_2 = new System.Windows.Forms.TextBox();
            this.txt_2_0 = new System.Windows.Forms.TextBox();
            this.txt_2_1 = new System.Windows.Forms.TextBox();
            this.txt_2_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 138);
            this.btnCancel.Text = "关闭";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(154, 138);
            this.btnOK.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "矩阵";
            // 
            // txt_0_0
            // 
            this.txt_0_0.Location = new System.Drawing.Point(77, 10);
            this.txt_0_0.Name = "txt_0_0";
            this.txt_0_0.Size = new System.Drawing.Size(100, 26);
            this.txt_0_0.TabIndex = 24;
            // 
            // txt_0_1
            // 
            this.txt_0_1.Location = new System.Drawing.Point(183, 10);
            this.txt_0_1.Name = "txt_0_1";
            this.txt_0_1.Size = new System.Drawing.Size(100, 26);
            this.txt_0_1.TabIndex = 24;
            // 
            // txt_0_2
            // 
            this.txt_0_2.Location = new System.Drawing.Point(289, 10);
            this.txt_0_2.Name = "txt_0_2";
            this.txt_0_2.Size = new System.Drawing.Size(100, 26);
            this.txt_0_2.TabIndex = 24;
            // 
            // txt_1_0
            // 
            this.txt_1_0.Location = new System.Drawing.Point(77, 42);
            this.txt_1_0.Name = "txt_1_0";
            this.txt_1_0.Size = new System.Drawing.Size(100, 26);
            this.txt_1_0.TabIndex = 24;
            // 
            // txt_1_1
            // 
            this.txt_1_1.Location = new System.Drawing.Point(183, 42);
            this.txt_1_1.Name = "txt_1_1";
            this.txt_1_1.Size = new System.Drawing.Size(100, 26);
            this.txt_1_1.TabIndex = 24;
            // 
            // txt_1_2
            // 
            this.txt_1_2.Location = new System.Drawing.Point(289, 42);
            this.txt_1_2.Name = "txt_1_2";
            this.txt_1_2.Size = new System.Drawing.Size(100, 26);
            this.txt_1_2.TabIndex = 24;
            // 
            // txt_2_0
            // 
            this.txt_2_0.Location = new System.Drawing.Point(77, 74);
            this.txt_2_0.Name = "txt_2_0";
            this.txt_2_0.Size = new System.Drawing.Size(100, 26);
            this.txt_2_0.TabIndex = 24;
            this.txt_2_0.Visible = false;
            // 
            // txt_2_1
            // 
            this.txt_2_1.Location = new System.Drawing.Point(183, 74);
            this.txt_2_1.Name = "txt_2_1";
            this.txt_2_1.Size = new System.Drawing.Size(100, 26);
            this.txt_2_1.TabIndex = 24;
            this.txt_2_1.Visible = false;
            // 
            // txt_2_2
            // 
            this.txt_2_2.Location = new System.Drawing.Point(289, 74);
            this.txt_2_2.Name = "txt_2_2";
            this.txt_2_2.Size = new System.Drawing.Size(100, 26);
            this.txt_2_2.TabIndex = 24;
            this.txt_2_2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "应用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dlgAffineTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_2_2);
            this.Controls.Add(this.txt_1_2);
            this.Controls.Add(this.txt_0_2);
            this.Controls.Add(this.txt_2_1);
            this.Controls.Add(this.txt_1_1);
            this.Controls.Add(this.txt_0_1);
            this.Controls.Add(this.txt_2_0);
            this.Controls.Add(this.txt_1_0);
            this.Controls.Add(this.txt_0_0);
            this.Controls.Add(this.label1);
            this.Name = "dlgAffineTransform";
            this.Text = "AffineTransform";
            this.Load += new System.EventHandler(this.dlgAffineTransform_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_0_0, 0);
            this.Controls.SetChildIndex(this.txt_1_0, 0);
            this.Controls.SetChildIndex(this.txt_2_0, 0);
            this.Controls.SetChildIndex(this.txt_0_1, 0);
            this.Controls.SetChildIndex(this.txt_1_1, 0);
            this.Controls.SetChildIndex(this.txt_2_1, 0);
            this.Controls.SetChildIndex(this.txt_0_2, 0);
            this.Controls.SetChildIndex(this.txt_1_2, 0);
            this.Controls.SetChildIndex(this.txt_2_2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_0_0;
        private System.Windows.Forms.TextBox txt_0_1;
        private System.Windows.Forms.TextBox txt_0_2;
        private System.Windows.Forms.TextBox txt_1_0;
        private System.Windows.Forms.TextBox txt_1_1;
        private System.Windows.Forms.TextBox txt_1_2;
        private System.Windows.Forms.TextBox txt_2_0;
        private System.Windows.Forms.TextBox txt_2_1;
        private System.Windows.Forms.TextBox txt_2_2;
        private System.Windows.Forms.Button button1;
    }
}