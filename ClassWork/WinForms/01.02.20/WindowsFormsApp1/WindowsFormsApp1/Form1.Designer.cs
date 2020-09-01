namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetAlarm = new System.Windows.Forms.Button();
            this.setAlarm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 334);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.secondNumericUpDown);
            this.panel2.Controls.Add(this.minuteNumericUpDown);
            this.panel2.Controls.Add(this.hourNumericUpDown);
            this.panel2.Controls.Add(this.resetAlarm);
            this.panel2.Controls.Add(this.setAlarm);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 334);
            this.panel2.TabIndex = 1;
            // 
            // resetAlarm
            // 
            this.resetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetAlarm.Location = new System.Drawing.Point(278, 258);
            this.resetAlarm.Name = "resetAlarm";
            this.resetAlarm.Size = new System.Drawing.Size(142, 39);
            this.resetAlarm.TabIndex = 4;
            this.resetAlarm.Text = "Сбросить";
            this.resetAlarm.UseVisualStyleBackColor = true;
            this.resetAlarm.Click += new System.EventHandler(this.resetAlarm_Click);
            // 
            // setAlarm
            // 
            this.setAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setAlarm.Location = new System.Drawing.Point(114, 258);
            this.setAlarm.Name = "setAlarm";
            this.setAlarm.Size = new System.Drawing.Size(142, 39);
            this.setAlarm.TabIndex = 3;
            this.setAlarm.Text = "Утановить";
            this.setAlarm.UseVisualStyleBackColor = true;
            this.setAlarm.Click += new System.EventHandler(this.setAlarm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(108, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Установка будильника:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourNumericUpDown.ForeColor = System.Drawing.Color.Red;
            this.hourNumericUpDown.Location = new System.Drawing.Point(114, 193);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(69, 30);
            this.hourNumericUpDown.TabIndex = 5;
            this.hourNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteNumericUpDown.ForeColor = System.Drawing.Color.Red;
            this.minuteNumericUpDown.Location = new System.Drawing.Point(235, 193);
            this.minuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(69, 30);
            this.minuteNumericUpDown.TabIndex = 6;
            this.minuteNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondNumericUpDown
            // 
            this.secondNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNumericUpDown.ForeColor = System.Drawing.Color.Red;
            this.secondNumericUpDown.Location = new System.Drawing.Point(351, 193);
            this.secondNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondNumericUpDown.Name = "secondNumericUpDown";
            this.secondNumericUpDown.Size = new System.Drawing.Size(69, 30);
            this.secondNumericUpDown.TabIndex = 7;
            this.secondNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(787, 334);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Простейшие электронные часы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetAlarm;
        private System.Windows.Forms.Button setAlarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown secondNumericUpDown;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
    }
}

