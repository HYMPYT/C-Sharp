namespace SWAPI_APP
{
    partial class FilmControl
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
            this.TitleL = new System.Windows.Forms.Label();
            this.EpisodeL = new System.Windows.Forms.Label();
            this.ReleaseDateL = new System.Windows.Forms.Label();
            this.DirectorL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.Location = new System.Drawing.Point(3, 0);
            this.TitleL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(53, 20);
            this.TitleL.TabIndex = 0;
            this.TitleL.Text = "label1";
            // 
            // EpisodeL
            // 
            this.EpisodeL.AutoSize = true;
            this.EpisodeL.Location = new System.Drawing.Point(3, 25);
            this.EpisodeL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.EpisodeL.Name = "EpisodeL";
            this.EpisodeL.Size = new System.Drawing.Size(53, 20);
            this.EpisodeL.TabIndex = 1;
            this.EpisodeL.Text = "label2";
            // 
            // ReleaseDateL
            // 
            this.ReleaseDateL.AutoSize = true;
            this.ReleaseDateL.Location = new System.Drawing.Point(3, 50);
            this.ReleaseDateL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.ReleaseDateL.Name = "ReleaseDateL";
            this.ReleaseDateL.Size = new System.Drawing.Size(53, 20);
            this.ReleaseDateL.TabIndex = 2;
            this.ReleaseDateL.Text = "label3";
            // 
            // DirectorL
            // 
            this.DirectorL.AutoSize = true;
            this.DirectorL.Location = new System.Drawing.Point(3, 75);
            this.DirectorL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.DirectorL.Name = "DirectorL";
            this.DirectorL.Size = new System.Drawing.Size(53, 20);
            this.DirectorL.TabIndex = 3;
            this.DirectorL.Text = "label4";
            // 
            // FilmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DirectorL);
            this.Controls.Add(this.ReleaseDateL);
            this.Controls.Add(this.EpisodeL);
            this.Controls.Add(this.TitleL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FilmControl";
            this.Size = new System.Drawing.Size(280, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.Label EpisodeL;
        private System.Windows.Forms.Label ReleaseDateL;
        private System.Windows.Forms.Label DirectorL;
    }
}
