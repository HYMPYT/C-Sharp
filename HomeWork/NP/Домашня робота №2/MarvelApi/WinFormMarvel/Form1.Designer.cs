namespace WinFormMarvel
{
    partial class Form1
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
            this.flpCharacters = new System.Windows.Forms.FlowLayoutPanel();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericOffset = new System.Windows.Forms.NumericUpDown();
            this.numericLimit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // flpCharacters
            // 
            this.flpCharacters.AutoScroll = true;
            this.flpCharacters.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCharacters.Location = new System.Drawing.Point(0, 0);
            this.flpCharacters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpCharacters.Name = "flpCharacters";
            this.flpCharacters.Size = new System.Drawing.Size(1067, 493);
            this.flpCharacters.TabIndex = 0;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(812, 505);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(218, 34);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Offset:";
            // 
            // numericOffset
            // 
            this.numericOffset.Location = new System.Drawing.Point(114, 512);
            this.numericOffset.Name = "numericOffset";
            this.numericOffset.Size = new System.Drawing.Size(102, 22);
            this.numericOffset.TabIndex = 3;
            this.numericOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericLimit
            // 
            this.numericLimit.Location = new System.Drawing.Point(366, 512);
            this.numericLimit.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericLimit.Name = "numericLimit";
            this.numericLimit.Size = new System.Drawing.Size(102, 22);
            this.numericLimit.TabIndex = 4;
            this.numericLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(288, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Limit:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericLimit);
            this.Controls.Add(this.numericOffset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.flpCharacters);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MarvelApi";
            ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCharacters;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericOffset;
        private System.Windows.Forms.NumericUpDown numericLimit;
        private System.Windows.Forms.Label label2;
    }
}

