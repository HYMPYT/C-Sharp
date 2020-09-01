namespace SWAPI_APP
{
    partial class SpeciesControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameL = new System.Windows.Forms.Label();
            this.ClassificationL = new System.Windows.Forms.Label();
            this.DesignationL = new System.Windows.Forms.Label();
            this.AverageLifespanL = new System.Windows.Forms.Label();
            this.LanguageL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(3, 0);
            this.NameL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(53, 20);
            this.NameL.TabIndex = 0;
            this.NameL.Text = "label1";
            // 
            // ClassificationL
            // 
            this.ClassificationL.AutoSize = true;
            this.ClassificationL.Location = new System.Drawing.Point(3, 25);
            this.ClassificationL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.ClassificationL.Name = "ClassificationL";
            this.ClassificationL.Size = new System.Drawing.Size(53, 20);
            this.ClassificationL.TabIndex = 1;
            this.ClassificationL.Text = "label2";
            // 
            // DesignationL
            // 
            this.DesignationL.AutoSize = true;
            this.DesignationL.Location = new System.Drawing.Point(3, 50);
            this.DesignationL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.DesignationL.Name = "DesignationL";
            this.DesignationL.Size = new System.Drawing.Size(53, 20);
            this.DesignationL.TabIndex = 2;
            this.DesignationL.Text = "label3";
            // 
            // AverageLifespanL
            // 
            this.AverageLifespanL.AutoSize = true;
            this.AverageLifespanL.Location = new System.Drawing.Point(3, 75);
            this.AverageLifespanL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.AverageLifespanL.Name = "AverageLifespanL";
            this.AverageLifespanL.Size = new System.Drawing.Size(53, 20);
            this.AverageLifespanL.TabIndex = 3;
            this.AverageLifespanL.Text = "label4";
            // 
            // LanguageL
            // 
            this.LanguageL.AutoSize = true;
            this.LanguageL.Location = new System.Drawing.Point(3, 100);
            this.LanguageL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LanguageL.Name = "LanguageL";
            this.LanguageL.Size = new System.Drawing.Size(53, 20);
            this.LanguageL.TabIndex = 4;
            this.LanguageL.Text = "label5";
            // 
            // SpeciesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LanguageL);
            this.Controls.Add(this.AverageLifespanL);
            this.Controls.Add(this.DesignationL);
            this.Controls.Add(this.ClassificationL);
            this.Controls.Add(this.NameL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SpeciesControl";
            this.Size = new System.Drawing.Size(280, 144);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label ClassificationL;
        private System.Windows.Forms.Label DesignationL;
        private System.Windows.Forms.Label AverageLifespanL;
        private System.Windows.Forms.Label LanguageL;
    }
}
