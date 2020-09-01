namespace SWAPI_APP
{
    partial class StarshipControl
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
            this.ModelL = new System.Windows.Forms.Label();
            this.StarshipClassL = new System.Windows.Forms.Label();
            this.ManufacturerL = new System.Windows.Forms.Label();
            this.HyperDriveRatingL = new System.Windows.Forms.Label();
            this.MaxAtmospheringSpeedL = new System.Windows.Forms.Label();
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
            // ModelL
            // 
            this.ModelL.AutoSize = true;
            this.ModelL.Location = new System.Drawing.Point(3, 25);
            this.ModelL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.ModelL.Name = "ModelL";
            this.ModelL.Size = new System.Drawing.Size(53, 20);
            this.ModelL.TabIndex = 1;
            this.ModelL.Text = "label2";
            // 
            // StarshipClassL
            // 
            this.StarshipClassL.AutoSize = true;
            this.StarshipClassL.Location = new System.Drawing.Point(3, 50);
            this.StarshipClassL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.StarshipClassL.Name = "StarshipClassL";
            this.StarshipClassL.Size = new System.Drawing.Size(53, 20);
            this.StarshipClassL.TabIndex = 2;
            this.StarshipClassL.Text = "label3";
            // 
            // ManufacturerL
            // 
            this.ManufacturerL.AutoSize = true;
            this.ManufacturerL.Location = new System.Drawing.Point(3, 75);
            this.ManufacturerL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.ManufacturerL.Name = "ManufacturerL";
            this.ManufacturerL.Size = new System.Drawing.Size(53, 20);
            this.ManufacturerL.TabIndex = 3;
            this.ManufacturerL.Text = "label4";
            // 
            // HyperDriveRatingL
            // 
            this.HyperDriveRatingL.AutoSize = true;
            this.HyperDriveRatingL.Location = new System.Drawing.Point(3, 100);
            this.HyperDriveRatingL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.HyperDriveRatingL.Name = "HyperDriveRatingL";
            this.HyperDriveRatingL.Size = new System.Drawing.Size(53, 20);
            this.HyperDriveRatingL.TabIndex = 4;
            this.HyperDriveRatingL.Text = "label5";
            // 
            // MaxAtmospheringSpeedL
            // 
            this.MaxAtmospheringSpeedL.AutoSize = true;
            this.MaxAtmospheringSpeedL.Location = new System.Drawing.Point(3, 125);
            this.MaxAtmospheringSpeedL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.MaxAtmospheringSpeedL.Name = "MaxAtmospheringSpeedL";
            this.MaxAtmospheringSpeedL.Size = new System.Drawing.Size(53, 20);
            this.MaxAtmospheringSpeedL.TabIndex = 5;
            this.MaxAtmospheringSpeedL.Text = "label6";
            // 
            // StarshipControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaxAtmospheringSpeedL);
            this.Controls.Add(this.HyperDriveRatingL);
            this.Controls.Add(this.ManufacturerL);
            this.Controls.Add(this.StarshipClassL);
            this.Controls.Add(this.ModelL);
            this.Controls.Add(this.NameL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StarshipControl";
            this.Size = new System.Drawing.Size(280, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label ModelL;
        private System.Windows.Forms.Label StarshipClassL;
        private System.Windows.Forms.Label ManufacturerL;
        private System.Windows.Forms.Label HyperDriveRatingL;
        private System.Windows.Forms.Label MaxAtmospheringSpeedL;
    }
}
