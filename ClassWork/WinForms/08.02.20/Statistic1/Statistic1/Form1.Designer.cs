namespace Statistic1
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
            this.dataList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.legend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dataList
            // 
            this.dataList.FormattingEnabled = true;
            this.dataList.ItemHeight = 25;
            this.dataList.Location = new System.Drawing.Point(17, 106);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(250, 304);
            this.dataList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Legend:";
            // 
            // legend
            // 
            this.legend.ForeColor = System.Drawing.Color.Red;
            this.legend.Location = new System.Drawing.Point(102, 6);
            this.legend.Name = "legend";
            this.legend.Size = new System.Drawing.Size(165, 30);
            this.legend.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // result
            // 
            this.result.ForeColor = System.Drawing.Color.DarkBlue;
            this.result.Location = new System.Drawing.Point(102, 51);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(165, 30);
            this.result.TabIndex = 4;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(303, 7);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(243, 32);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить в список";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del.Location = new System.Drawing.Point(303, 45);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(243, 30);
            this.del.TabIndex = 6;
            this.del.Text = "Удалить из списка";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(303, 81);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(243, 31);
            this.clear.TabIndex = 7;
            this.clear.Text = "Очистить поля";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // clearAll
            // 
            this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearAll.Location = new System.Drawing.Point(303, 118);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(243, 32);
            this.clearAll.TabIndex = 8;
            this.clearAll.Text = "Очистить все";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc.Location = new System.Drawing.Point(303, 156);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(243, 32);
            this.calc.TabIndex = 9;
            this.calc.Text = "Вычислить";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(273, 200);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.report.Size = new System.Drawing.Size(294, 210);
            this.report.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 418);
            this.Controls.Add(this.report);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.legend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox legend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox report;
    }
}

