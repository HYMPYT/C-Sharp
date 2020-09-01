namespace SWAPI_APP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpCharacter = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericOffset = new System.Windows.Forms.NumericUpDown();
            this.numericLimit = new System.Windows.Forms.NumericUpDown();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCharacter
            // 
            this.flpCharacter.AutoScroll = true;
            this.flpCharacter.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCharacter.Location = new System.Drawing.Point(0, 0);
            this.flpCharacter.Name = "flpCharacter";
            this.flpCharacter.Size = new System.Drawing.Size(1201, 533);
            this.flpCharacter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Limit:";
            // 
            // numericOffset
            // 
            this.numericOffset.Location = new System.Drawing.Point(87, 565);
            this.numericOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericOffset.Name = "numericOffset";
            this.numericOffset.Size = new System.Drawing.Size(111, 27);
            this.numericOffset.TabIndex = 3;
            this.numericOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericLimit
            // 
            this.numericLimit.Location = new System.Drawing.Point(312, 565);
            this.numericLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLimit.Name = "numericLimit";
            this.numericLimit.Size = new System.Drawing.Size(102, 27);
            this.numericLimit.TabIndex = 4;
            this.numericLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(932, 559);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(214, 37);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoadBtn);
            this.panel1.Controls.Add(this.flpCharacter);
            this.panel1.Controls.Add(this.numericLimit);
            this.panel1.Controls.Add(this.numericOffset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 617);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 617);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StarWars";
            ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericOffset;
        private System.Windows.Forms.NumericUpDown numericLimit;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

