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
            this.treeViewCatalogs = new System.Windows.Forms.TreeView();
            this.imageListIcos = new System.Windows.Forms.ImageList(this.components);
            this.textBoxFullPath = new System.Windows.Forms.TextBox();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.filesStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewCatalogs
            // 
            this.treeViewCatalogs.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewCatalogs.ImageIndex = 0;
            this.treeViewCatalogs.ImageList = this.imageListIcos;
            this.treeViewCatalogs.Location = new System.Drawing.Point(0, 28);
            this.treeViewCatalogs.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewCatalogs.Name = "treeViewCatalogs";
            this.treeViewCatalogs.SelectedImageIndex = 0;
            this.treeViewCatalogs.Size = new System.Drawing.Size(300, 526);
            this.treeViewCatalogs.TabIndex = 0;
            this.treeViewCatalogs.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCatalogs_AfterExpand);
            this.treeViewCatalogs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCatalogs_AfterSelect);
            // 
            // imageListIcos
            // 
            this.imageListIcos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcos.ImageStream")));
            this.imageListIcos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcos.Images.SetKeyName(0, "disk.ico");
            this.imageListIcos.Images.SetKeyName(1, "file.ico");
            this.imageListIcos.Images.SetKeyName(2, "folder.ico");
            // 
            // textBoxFullPath
            // 
            this.textBoxFullPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFullPath.Location = new System.Drawing.Point(300, 28);
            this.textBoxFullPath.Name = "textBoxFullPath";
            this.textBoxFullPath.ReadOnly = true;
            this.textBoxFullPath.Size = new System.Drawing.Size(767, 26);
            this.textBoxFullPath.TabIndex = 1;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LargeImageList = this.imageListIcos;
            this.listViewFiles.Location = new System.Drawing.Point(300, 54);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(767, 500);
            this.listViewFiles.SmallImageList = this.imageListIcos;
            this.listViewFiles.StateImageList = this.imageListIcos;
            this.listViewFiles.TabIndex = 3;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesStyleToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1067, 28);
            this.menuStripMain.TabIndex = 4;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // filesStyleToolStripMenuItem
            // 
            this.filesStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.listToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.filesStyleToolStripMenuItem.Name = "filesStyleToolStripMenuItem";
            this.filesStyleToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.filesStyleToolStripMenuItem.Text = "Files Style";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.textBoxFullPath);
            this.Controls.Add(this.treeViewCatalogs);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Casual Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCatalogs;
        private System.Windows.Forms.ImageList imageListIcos;
        private System.Windows.Forms.TextBox textBoxFullPath;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem filesStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
    }
}

