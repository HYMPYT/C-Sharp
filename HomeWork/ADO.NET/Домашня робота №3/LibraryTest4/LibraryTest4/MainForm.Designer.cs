namespace LibraryTest4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mfBtnRunQuery = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvTableView = new System.Windows.Forms.DataGridView();
            this.mtfQuery = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlStatus = new MaterialSkin.Controls.MaterialLabel();
            this.cbAuthors = new System.Windows.Forms.ComboBox();
            this.mlBooksCount = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // mfBtnRunQuery
            // 
            this.mfBtnRunQuery.AutoSize = true;
            this.mfBtnRunQuery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfBtnRunQuery.Depth = 0;
            this.mfBtnRunQuery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mfBtnRunQuery.Location = new System.Drawing.Point(0, 518);
            this.mfBtnRunQuery.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.mfBtnRunQuery.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfBtnRunQuery.Name = "mfBtnRunQuery";
            this.mfBtnRunQuery.Primary = false;
            this.mfBtnRunQuery.Size = new System.Drawing.Size(789, 36);
            this.mfBtnRunQuery.TabIndex = 1;
            this.mfBtnRunQuery.Text = "Run Query";
            this.mfBtnRunQuery.UseVisualStyleBackColor = true;
            this.mfBtnRunQuery.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // dgvTableView
            // 
            this.dgvTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTableView.Location = new System.Drawing.Point(0, 0);
            this.dgvTableView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTableView.Name = "dgvTableView";
            this.dgvTableView.Size = new System.Drawing.Size(789, 299);
            this.dgvTableView.TabIndex = 2;
            // 
            // mtfQuery
            // 
            this.mtfQuery.Depth = 0;
            this.mtfQuery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtfQuery.Hint = "";
            this.mtfQuery.Location = new System.Drawing.Point(0, 490);
            this.mtfQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtfQuery.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtfQuery.Name = "mtfQuery";
            this.mtfQuery.PasswordChar = '\0';
            this.mtfQuery.SelectedText = "";
            this.mtfQuery.SelectionLength = 0;
            this.mtfQuery.SelectionStart = 0;
            this.mtfQuery.Size = new System.Drawing.Size(789, 28);
            this.mtfQuery.TabIndex = 3;
            this.mtfQuery.Text = "select * from Books";
            this.mtfQuery.UseSystemPasswordChar = false;
            this.mtfQuery.TextChanged += new System.EventHandler(this.materialSingleLineTextField1_TextChanged);
            // 
            // mlStatus
            // 
            this.mlStatus.AutoSize = true;
            this.mlStatus.Depth = 0;
            this.mlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlStatus.Location = new System.Drawing.Point(0, 299);
            this.mlStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlStatus.Name = "mlStatus";
            this.mlStatus.Size = new System.Drawing.Size(63, 24);
            this.mlStatus.TabIndex = 4;
            this.mlStatus.Text = "Status";
            // 
            // cbAuthors
            // 
            this.cbAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthors.FormattingEnabled = true;
            this.cbAuthors.Location = new System.Drawing.Point(612, 337);
            this.cbAuthors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAuthors.Name = "cbAuthors";
            this.cbAuthors.Size = new System.Drawing.Size(160, 24);
            this.cbAuthors.TabIndex = 5;
            this.cbAuthors.SelectedIndexChanged += new System.EventHandler(this.cbAuthors_SelectedIndexChanged);
            // 
            // mlBooksCount
            // 
            this.mlBooksCount.AutoSize = true;
            this.mlBooksCount.Depth = 0;
            this.mlBooksCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlBooksCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlBooksCount.Location = new System.Drawing.Point(560, 337);
            this.mlBooksCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlBooksCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlBooksCount.Name = "mlBooksCount";
            this.mlBooksCount.Size = new System.Drawing.Size(21, 24);
            this.mlBooksCount.TabIndex = 6;
            this.mlBooksCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 554);
            this.Controls.Add(this.mlBooksCount);
            this.Controls.Add(this.cbAuthors);
            this.Controls.Add(this.mlStatus);
            this.Controls.Add(this.mtfQuery);
            this.Controls.Add(this.dgvTableView);
            this.Controls.Add(this.mfBtnRunQuery);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton mfBtnRunQuery;
        private System.Windows.Forms.DataGridView dgvTableView;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtfQuery;
        private MaterialSkin.Controls.MaterialLabel mlStatus;
        private System.Windows.Forms.ComboBox cbAuthors;
        private MaterialSkin.Controls.MaterialLabel mlBooksCount;
    }
}