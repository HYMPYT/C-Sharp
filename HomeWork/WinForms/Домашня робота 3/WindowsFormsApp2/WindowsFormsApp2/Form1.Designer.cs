namespace WindowsFormsApp2
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.comboBoxGoods = new System.Windows.Forms.ComboBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonAddExist = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.textBoxTotalValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 25;
            this.listBoxCart.Location = new System.Drawing.Point(18, 18);
            this.listBoxCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(402, 404);
            this.listBoxCart.TabIndex = 0;
            this.listBoxCart.SelectedIndexChanged += new System.EventHandler(this.listBoxCart_SelectedIndexChanged);
            // 
            // comboBoxGoods
            // 
            this.comboBoxGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGoods.FormattingEnabled = true;
            this.comboBoxGoods.Location = new System.Drawing.Point(430, 18);
            this.comboBoxGoods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGoods.Name = "comboBoxGoods";
            this.comboBoxGoods.Size = new System.Drawing.Size(180, 33);
            this.comboBoxGoods.TabIndex = 1;
            this.comboBoxGoods.SelectedIndexChanged += new System.EventHandler(this.comboBoxGoods_SelectedIndexChanged);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(430, 108);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(148, 30);
            this.textBoxValue.TabIndex = 2;
            // 
            // buttonAddExist
            // 
            this.buttonAddExist.Location = new System.Drawing.Point(618, 18);
            this.buttonAddExist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddExist.Name = "buttonAddExist";
            this.buttonAddExist.Size = new System.Drawing.Size(88, 28);
            this.buttonAddExist.TabIndex = 3;
            this.buttonAddExist.Text = "Add Exist";
            this.buttonAddExist.UseVisualStyleBackColor = true;
            this.buttonAddExist.Click += new System.EventHandler(this.buttonAddExist_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(18, 434);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 35);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(138, 434);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(112, 35);
            this.buttonAddNew.TabIndex = 6;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // textBoxTotalValue
            // 
            this.textBoxTotalValue.Location = new System.Drawing.Point(431, 176);
            this.textBoxTotalValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotalValue.Name = "textBoxTotalValue";
            this.textBoxTotalValue.ReadOnly = true;
            this.textBoxTotalValue.Size = new System.Drawing.Size(148, 30);
            this.textBoxTotalValue.TabIndex = 7;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(427, 78);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(63, 25);
            this.labelValue.TabIndex = 8;
            this.labelValue.Text = "Value";
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Location = new System.Drawing.Point(427, 151);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(112, 25);
            this.labelTotalValue.TabIndex = 9;
            this.labelTotalValue.Text = "Total Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 507);
            this.Controls.Add(this.labelTotalValue);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.textBoxTotalValue);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddExist);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.comboBoxGoods);
            this.Controls.Add(this.listBoxCart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.ComboBox comboBoxGoods;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonAddExist;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.TextBox textBoxTotalValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelTotalValue;
    }
}

