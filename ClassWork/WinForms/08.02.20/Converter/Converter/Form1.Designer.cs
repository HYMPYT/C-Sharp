namespace Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fieldF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldC = new System.Windows.Forms.TextBox();
            this.mod1 = new System.Windows.Forms.RadioButton();
            this.mod2 = new System.Windows.Forms.RadioButton();
            this.calc = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fieldF
            // 
            this.fieldF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldF.ForeColor = System.Drawing.Color.Navy;
            this.fieldF.Location = new System.Drawing.Point(311, 40);
            this.fieldF.Name = "fieldF";
            this.fieldF.Size = new System.Drawing.Size(302, 38);
            this.fieldF.TabIndex = 1;
            this.fieldF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(306, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Температура по Фаренгейту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(306, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Температура по Цельсию";
            // 
            // fieldC
            // 
            this.fieldC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldC.ForeColor = System.Drawing.Color.Purple;
            this.fieldC.Location = new System.Drawing.Point(311, 130);
            this.fieldC.Name = "fieldC";
            this.fieldC.ReadOnly = true;
            this.fieldC.Size = new System.Drawing.Size(302, 38);
            this.fieldC.TabIndex = 4;
            this.fieldC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mod1
            // 
            this.mod1.AutoSize = true;
            this.mod1.Checked = true;
            this.mod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod1.ForeColor = System.Drawing.Color.Green;
            this.mod1.Location = new System.Drawing.Point(311, 190);
            this.mod1.Name = "mod1";
            this.mod1.Size = new System.Drawing.Size(125, 29);
            this.mod1.TabIndex = 5;
            this.mod1.TabStop = true;
            this.mod1.Text = "F  >>>  C";
            this.mod1.UseVisualStyleBackColor = true;
            this.mod1.CheckedChanged += new System.EventHandler(this.mod1_CheckedChanged);
            // 
            // mod2
            // 
            this.mod2.AutoSize = true;
            this.mod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod2.ForeColor = System.Drawing.Color.Green;
            this.mod2.Location = new System.Drawing.Point(488, 190);
            this.mod2.Name = "mod2";
            this.mod2.Size = new System.Drawing.Size(125, 29);
            this.mod2.TabIndex = 6;
            this.mod2.Text = "C  >>>  F";
            this.mod2.UseVisualStyleBackColor = true;
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc.Location = new System.Drawing.Point(311, 239);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(302, 37);
            this.calc.TabIndex = 7;
            this.calc.Text = "Вычислить";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.Location = new System.Drawing.Point(311, 290);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(302, 37);
            this.reset.TabIndex = 8;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 339);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.mod2);
            this.Controls.Add(this.mod1);
            this.Controls.Add(this.fieldC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldF);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fieldF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldC;
        private System.Windows.Forms.RadioButton mod1;
        private System.Windows.Forms.RadioButton mod2;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button reset;
    }
}

