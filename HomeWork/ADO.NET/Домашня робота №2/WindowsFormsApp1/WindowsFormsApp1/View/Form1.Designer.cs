namespace WindowsFormsApp1
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
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.cbFromCard = new System.Windows.Forms.ComboBox();
            this.nudMoneyToTransfer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbToCard = new System.Windows.Forms.ComboBox();
            this.pOps = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bTransferr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoneyToTransfer)).BeginInit();
            this.pOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCards
            // 
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCards.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCards.Location = new System.Drawing.Point(0, 0);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.ReadOnly = true;
            this.dgvCards.Size = new System.Drawing.Size(349, 223);
            this.dgvCards.TabIndex = 0;
            // 
            // cbFromCard
            // 
            this.cbFromCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFromCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromCard.FormattingEnabled = true;
            this.cbFromCard.Location = new System.Drawing.Point(12, 100);
            this.cbFromCard.Name = "cbFromCard";
            this.cbFromCard.Size = new System.Drawing.Size(121, 21);
            this.cbFromCard.TabIndex = 1;
            this.cbFromCard.SelectionChangeCommitted += new System.EventHandler(this.cbFromCard_SelectionChangeCommitted);
            // 
            // nudMoneyToTransfer
            // 
            this.nudMoneyToTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMoneyToTransfer.Location = new System.Drawing.Point(12, 149);
            this.nudMoneyToTransfer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMoneyToTransfer.Name = "nudMoneyToTransfer";
            this.nudMoneyToTransfer.Size = new System.Drawing.Size(120, 20);
            this.nudMoneyToTransfer.TabIndex = 2;
            this.nudMoneyToTransfer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Money amount";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // cbToCard
            // 
            this.cbToCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbToCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToCard.FormattingEnabled = true;
            this.cbToCard.Location = new System.Drawing.Point(172, 100);
            this.cbToCard.Name = "cbToCard";
            this.cbToCard.Size = new System.Drawing.Size(121, 21);
            this.cbToCard.TabIndex = 6;
            // 
            // pOps
            // 
            this.pOps.Controls.Add(this.bTransferr);
            this.pOps.Controls.Add(this.label4);
            this.pOps.Controls.Add(this.tbFilter);
            this.pOps.Controls.Add(this.cbToCard);
            this.pOps.Controls.Add(this.cbFromCard);
            this.pOps.Controls.Add(this.label3);
            this.pOps.Controls.Add(this.nudMoneyToTransfer);
            this.pOps.Controls.Add(this.label2);
            this.pOps.Controls.Add(this.label1);
            this.pOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOps.Location = new System.Drawing.Point(349, 0);
            this.pOps.Name = "pOps";
            this.pOps.Size = new System.Drawing.Size(305, 223);
            this.pOps.TabIndex = 7;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(6, 25);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(129, 20);
            this.tbFilter.TabIndex = 7;
            this.tbFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilter_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filter Table by User Name";
            // 
            // bTransferr
            // 
            this.bTransferr.Location = new System.Drawing.Point(12, 188);
            this.bTransferr.Name = "bTransferr";
            this.bTransferr.Size = new System.Drawing.Size(120, 23);
            this.bTransferr.TabIndex = 9;
            this.bTransferr.Text = "Transferr";
            this.bTransferr.UseVisualStyleBackColor = true;
            this.bTransferr.Click += new System.EventHandler(this.bTransferr_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 223);
            this.Controls.Add(this.pOps);
            this.Controls.Add(this.dgvCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Transaction Mover";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoneyToTransfer)).EndInit();
            this.pOps.ResumeLayout(false);
            this.pOps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.ComboBox cbFromCard;
        private System.Windows.Forms.NumericUpDown nudMoneyToTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbToCard;
        private System.Windows.Forms.Panel pOps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button bTransferr;
    }
}