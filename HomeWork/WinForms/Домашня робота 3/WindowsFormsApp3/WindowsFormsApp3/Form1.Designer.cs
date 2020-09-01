namespace WindowsFormsApp3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoadTextBtn = new System.Windows.Forms.Button();
            this.EditTextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(969, 445);
            this.textBox1.TabIndex = 0;
            // 
            // LoadTextBtn
            // 
            this.LoadTextBtn.Location = new System.Drawing.Point(80, 488);
            this.LoadTextBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadTextBtn.Name = "LoadTextBtn";
            this.LoadTextBtn.Size = new System.Drawing.Size(336, 40);
            this.LoadTextBtn.TabIndex = 1;
            this.LoadTextBtn.Text = "Загрузить";
            this.LoadTextBtn.UseVisualStyleBackColor = true;
            this.LoadTextBtn.Click += new System.EventHandler(this.LoadTextBtn_Click);
            // 
            // EditTextBtn
            // 
            this.EditTextBtn.Enabled = false;
            this.EditTextBtn.Location = new System.Drawing.Point(555, 488);
            this.EditTextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditTextBtn.Name = "EditTextBtn";
            this.EditTextBtn.Size = new System.Drawing.Size(336, 40);
            this.EditTextBtn.TabIndex = 2;
            this.EditTextBtn.Text = "Редактировать";
            this.EditTextBtn.UseVisualStyleBackColor = true;
            this.EditTextBtn.Click += new System.EventHandler(this.EditTextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 543);
            this.Controls.Add(this.EditTextBtn);
            this.Controls.Add(this.LoadTextBtn);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LoadTextBtn;
        private System.Windows.Forms.Button EditTextBtn;
    }
}

