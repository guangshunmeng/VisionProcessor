namespace VisionProcessor
{
    partial class dlgMatchShape
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
            this.picTempl = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.listMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTempl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 329);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(80, 329);
            // 
            // picTempl
            // 
            this.picTempl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTempl.Location = new System.Drawing.Point(80, 98);
            this.picTempl.Name = "picTempl";
            this.picTempl.Size = new System.Drawing.Size(301, 198);
            this.picTempl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTempl.TabIndex = 38;
            this.picTempl.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(375, 55);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 26);
            this.btnBrowse.TabIndex = 37;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(96, 55);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(272, 26);
            this.txtImage.TabIndex = 36;
            // 
            // listMode
            // 
            this.listMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMode.FormattingEnabled = true;
            this.listMode.Items.AddRange(new object[] {
            "SHT",
            "MHT",
            "PPHT"});
            this.listMode.Location = new System.Drawing.Point(96, 12);
            this.listMode.Name = "listMode";
            this.listMode.Size = new System.Drawing.Size(272, 28);
            this.listMode.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "模板";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "模式";
            // 
            // dlgMatchShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 392);
            this.Controls.Add(this.picTempl);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.listMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "dlgMatchShape";
            this.Text = "dlgMatchShape";
            this.Load += new System.EventHandler(this.dlgMatchShape_Load);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.listMode, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.Controls.SetChildIndex(this.picTempl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picTempl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTempl;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.ComboBox listMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}