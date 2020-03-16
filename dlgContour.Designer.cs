namespace VisionProcessor
{
    partial class dlgContour
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
            this.listMethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 186);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(64, 186);
            // 
            // listMethod
            // 
            this.listMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMethod.FormattingEnabled = true;
            this.listMethod.Items.AddRange(new object[] {
            "SHT",
            "MHT",
            "PPHT"});
            this.listMethod.Location = new System.Drawing.Point(180, 104);
            this.listMethod.Name = "listMethod";
            this.listMethod.Size = new System.Drawing.Size(221, 28);
            this.listMethod.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "ApproximationMode";
            // 
            // listMode
            // 
            this.listMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMode.FormattingEnabled = true;
            this.listMode.Items.AddRange(new object[] {
            "SHT",
            "MHT",
            "PPHT"});
            this.listMode.Location = new System.Drawing.Point(180, 31);
            this.listMode.Name = "listMode";
            this.listMode.Size = new System.Drawing.Size(221, 28);
            this.listMode.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "RetrievalMode";
            // 
            // dlgContour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 269);
            this.Controls.Add(this.listMode);
            this.Controls.Add(this.listMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "dlgContour";
            this.Text = "findcontour";
            this.Load += new System.EventHandler(this.dlgContour_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.listMethod, 0);
            this.Controls.SetChildIndex(this.listMode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox listMode;
        private System.Windows.Forms.Label label1;
    }
}