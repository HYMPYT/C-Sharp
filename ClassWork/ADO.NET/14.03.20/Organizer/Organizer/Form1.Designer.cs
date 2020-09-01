namespace Organizer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriesList = new System.Windows.Forms.ComboBox();
            this.AddCategory = new System.Windows.Forms.Button();
            this.DelCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AboutField = new System.Windows.Forms.TextBox();
            this.TermField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddTask = new System.Windows.Forms.Button();
            this.DelTask = new System.Windows.Forms.Button();
            this.EditTask = new System.Windows.Forms.Button();
            this.ResetTask = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TaskList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DelCategory);
            this.panel1.Controls.Add(this.AddCategory);
            this.panel1.Controls.Add(this.CategoriesList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 387);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ResetTask);
            this.panel2.Controls.Add(this.EditTask);
            this.panel2.Controls.Add(this.DelTask);
            this.panel2.Controls.Add(this.AddTask);
            this.panel2.Controls.Add(this.TermField);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AboutField);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TitleField);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(274, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 387);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категории";
            // 
            // CategoriesList
            // 
            this.CategoriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesList.FormattingEnabled = true;
            this.CategoriesList.Location = new System.Drawing.Point(12, 32);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.Size = new System.Drawing.Size(251, 28);
            this.CategoriesList.TabIndex = 1;
            this.CategoriesList.SelectedIndexChanged += new System.EventHandler(this.CategoriesList_SelectedIndexChanged);
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(12, 66);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(112, 31);
            this.AddCategory.TabIndex = 2;
            this.AddCategory.Text = "Добавить";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // DelCategory
            // 
            this.DelCategory.Location = new System.Drawing.Point(151, 66);
            this.DelCategory.Name = "DelCategory";
            this.DelCategory.Size = new System.Drawing.Size(112, 31);
            this.DelCategory.TabIndex = 3;
            this.DelCategory.Text = "Удалить";
            this.DelCategory.UseVisualStyleBackColor = true;
            this.DelCategory.Click += new System.EventHandler(this.DelCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Задачи";
            // 
            // TaskList
            // 
            this.TaskList.FormattingEnabled = true;
            this.TaskList.ItemHeight = 20;
            this.TaskList.Location = new System.Drawing.Point(12, 134);
            this.TaskList.Name = "TaskList";
            this.TaskList.ScrollAlwaysVisible = true;
            this.TaskList.Size = new System.Drawing.Size(251, 244);
            this.TaskList.TabIndex = 5;
            this.TaskList.SelectedIndexChanged += new System.EventHandler(this.TaskList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название задачи:";
            // 
            // TitleField
            // 
            this.TitleField.Location = new System.Drawing.Point(174, 6);
            this.TitleField.Name = "TitleField";
            this.TitleField.Size = new System.Drawing.Size(229, 27);
            this.TitleField.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Описание задачи:";
            // 
            // AboutField
            // 
            this.AboutField.Location = new System.Drawing.Point(10, 63);
            this.AboutField.Multiline = true;
            this.AboutField.Name = "AboutField";
            this.AboutField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AboutField.Size = new System.Drawing.Size(393, 205);
            this.AboutField.TabIndex = 3;
            // 
            // TermField
            // 
            this.TermField.Location = new System.Drawing.Point(203, 274);
            this.TermField.Name = "TermField";
            this.TermField.Size = new System.Drawing.Size(200, 27);
            this.TermField.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Информация о сроке:";
            // 
            // AddTask
            // 
            this.AddTask.Location = new System.Drawing.Point(10, 307);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(187, 31);
            this.AddTask.TabIndex = 6;
            this.AddTask.Text = "Добавить задачу";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // DelTask
            // 
            this.DelTask.Location = new System.Drawing.Point(216, 307);
            this.DelTask.Name = "DelTask";
            this.DelTask.Size = new System.Drawing.Size(187, 31);
            this.DelTask.TabIndex = 7;
            this.DelTask.Text = "Удалить задачу";
            this.DelTask.UseVisualStyleBackColor = true;
            this.DelTask.Click += new System.EventHandler(this.DelTask_Click);
            // 
            // EditTask
            // 
            this.EditTask.Location = new System.Drawing.Point(10, 344);
            this.EditTask.Name = "EditTask";
            this.EditTask.Size = new System.Drawing.Size(187, 31);
            this.EditTask.TabIndex = 8;
            this.EditTask.Text = "Редактировать";
            this.EditTask.UseVisualStyleBackColor = true;
            this.EditTask.Click += new System.EventHandler(this.EditTask_Click);
            // 
            // ResetTask
            // 
            this.ResetTask.Location = new System.Drawing.Point(216, 344);
            this.ResetTask.Name = "ResetTask";
            this.ResetTask.Size = new System.Drawing.Size(187, 31);
            this.ResetTask.TabIndex = 9;
            this.ResetTask.Text = "Сбросить";
            this.ResetTask.UseVisualStyleBackColor = true;
            this.ResetTask.Click += new System.EventHandler(this.ResetTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персональный органайзер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox TaskList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DelCategory;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.ComboBox CategoriesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ResetTask;
        private System.Windows.Forms.Button EditTask;
        private System.Windows.Forms.Button DelTask;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.TextBox TermField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AboutField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TitleField;
        private System.Windows.Forms.Label label3;
    }
}

