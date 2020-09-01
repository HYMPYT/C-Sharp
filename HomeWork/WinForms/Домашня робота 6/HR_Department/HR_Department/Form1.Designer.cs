namespace HR_Department
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DepList = new System.Windows.Forms.ComboBox();
            this.EmpList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ViberBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PositionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SalaryBox = new System.Windows.Forms.NumericUpDown();
            this.SkillsBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddDep = new System.Windows.Forms.Button();
            this.DelDep = new System.Windows.Forms.Button();
            this.AddEmp = new System.Windows.Forms.Button();
            this.DelEmp = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmpList);
            this.groupBox1.Controls.Add(this.DepList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 539);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список сотрудников";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.Reset);
            this.groupBox2.Controls.Add(this.DelEmp);
            this.groupBox2.Controls.Add(this.AddEmp);
            this.groupBox2.Controls.Add(this.DelDep);
            this.groupBox2.Controls.Add(this.AddDep);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(200, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление операциями";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SkillsBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.SalaryBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.PositionBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ViberBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.PhoneBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.EmailBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BirthDate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.NameBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(200, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 387);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Персональная информация";
            // 
            // DepList
            // 
            this.DepList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepList.FormattingEnabled = true;
            this.DepList.Location = new System.Drawing.Point(6, 21);
            this.DepList.Name = "DepList";
            this.DepList.Size = new System.Drawing.Size(188, 24);
            this.DepList.TabIndex = 0;
            this.DepList.SelectedIndexChanged += new System.EventHandler(this.DepList_SelectedIndexChanged);
            // 
            // EmpList
            // 
            this.EmpList.FormattingEnabled = true;
            this.EmpList.ItemHeight = 16;
            this.EmpList.Location = new System.Drawing.Point(6, 51);
            this.EmpList.Name = "EmpList";
            this.EmpList.ScrollAlwaysVisible = true;
            this.EmpList.Size = new System.Drawing.Size(188, 484);
            this.EmpList.TabIndex = 1;
            this.EmpList.SelectedIndexChanged += new System.EventHandler(this.EmpList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(89, 21);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(374, 22);
            this.NameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birthday:";
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(146, 51);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(200, 22);
            this.BirthDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(89, 85);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(374, 22);
            this.EmailBox.TabIndex = 5;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(89, 126);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(374, 22);
            this.PhoneBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // ViberBox
            // 
            this.ViberBox.Location = new System.Drawing.Point(89, 164);
            this.ViberBox.Name = "ViberBox";
            this.ViberBox.Size = new System.Drawing.Size(374, 22);
            this.ViberBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Viber:";
            // 
            // PositionBox
            // 
            this.PositionBox.Location = new System.Drawing.Point(89, 202);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(374, 22);
            this.PositionBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salary:";
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(146, 240);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(200, 22);
            this.SalaryBox.TabIndex = 13;
            // 
            // SkillsBox
            // 
            this.SkillsBox.Location = new System.Drawing.Point(89, 277);
            this.SkillsBox.Multiline = true;
            this.SkillsBox.Name = "SkillsBox";
            this.SkillsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SkillsBox.Size = new System.Drawing.Size(374, 89);
            this.SkillsBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Skills:";
            // 
            // AddDep
            // 
            this.AddDep.Location = new System.Drawing.Point(27, 34);
            this.AddDep.Name = "AddDep";
            this.AddDep.Size = new System.Drawing.Size(118, 32);
            this.AddDep.TabIndex = 0;
            this.AddDep.Text = "AddDep";
            this.AddDep.UseVisualStyleBackColor = true;
            this.AddDep.Click += new System.EventHandler(this.AddDep_Click);
            // 
            // DelDep
            // 
            this.DelDep.Location = new System.Drawing.Point(27, 88);
            this.DelDep.Name = "DelDep";
            this.DelDep.Size = new System.Drawing.Size(118, 32);
            this.DelDep.TabIndex = 1;
            this.DelDep.Text = "DelDep";
            this.DelDep.UseVisualStyleBackColor = true;
            this.DelDep.Click += new System.EventHandler(this.DelDep_Click);
            // 
            // AddEmp
            // 
            this.AddEmp.Location = new System.Drawing.Point(185, 34);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(118, 32);
            this.AddEmp.TabIndex = 2;
            this.AddEmp.Text = "AddEmp";
            this.AddEmp.UseVisualStyleBackColor = true;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // DelEmp
            // 
            this.DelEmp.Location = new System.Drawing.Point(185, 88);
            this.DelEmp.Name = "DelEmp";
            this.DelEmp.Size = new System.Drawing.Size(118, 32);
            this.DelEmp.TabIndex = 3;
            this.DelEmp.Text = "DelEmp";
            this.DelEmp.UseVisualStyleBackColor = true;
            this.DelEmp.Click += new System.EventHandler(this.DelEmp_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(345, 34);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(118, 32);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(345, 88);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(118, 32);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Система управления отделом кадров компании";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox EmpList;
        private System.Windows.Forms.ComboBox DepList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button DelEmp;
        private System.Windows.Forms.Button AddEmp;
        private System.Windows.Forms.Button DelDep;
        private System.Windows.Forms.Button AddDep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox SkillsBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown SalaryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PositionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ViberBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
    }
}

