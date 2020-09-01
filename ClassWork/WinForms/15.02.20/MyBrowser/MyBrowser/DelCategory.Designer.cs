namespace MyBrowser
{
    partial class DelCategory
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
            this.DelOkBtn = new System.Windows.Forms.Button();
            this.DelCancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DelOkBtn
            // 
            this.DelOkBtn.Location = new System.Drawing.Point(30, 117);
            this.DelOkBtn.Name = "DelOkBtn";
            this.DelOkBtn.Size = new System.Drawing.Size(183, 39);
            this.DelOkBtn.TabIndex = 1;
            this.DelOkBtn.Text = "OK";
            this.DelOkBtn.UseVisualStyleBackColor = true;
            this.DelOkBtn.Click += new System.EventHandler(this.DelOkBtn_Click);
            // 
            // DelCancelBtn
            // 
            this.DelCancelBtn.Location = new System.Drawing.Point(226, 117);
            this.DelCancelBtn.Name = "DelCancelBtn";
            this.DelCancelBtn.Size = new System.Drawing.Size(189, 39);
            this.DelCancelBtn.TabIndex = 2;
            this.DelCancelBtn.Text = "Cancel";
            this.DelCancelBtn.UseVisualStyleBackColor = true;
            this.DelCancelBtn.Click += new System.EventHandler(this.DelCancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя удаляемой категории:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(385, 22);
            this.textBox1.TabIndex = 4;
            // 
            // DelCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 202);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelCancelBtn);
            this.Controls.Add(this.DelOkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DelCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Category";
            this.Load += new System.EventHandler(this.DelCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DelOkBtn;
        private System.Windows.Forms.Button DelCancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}