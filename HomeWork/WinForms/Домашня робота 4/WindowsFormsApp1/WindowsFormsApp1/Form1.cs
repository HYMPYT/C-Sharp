using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeViewCatalogs_AfterExpand(object sender, TreeViewEventArgs e)
        {
            UpdateChilderNodes(e.Node, 2);
            UpdateListViewFiles(e.Node.Name);
            textBoxFullPath.Text = e.Node.Name;
        }

        private void treeViewCatalogs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateChilderNodes(e.Node, 2);
            UpdateListViewFiles(e.Node.Name);
            textBoxFullPath.Text = e.Node.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTreeViewCatalogs();
        }

        private void UpdateTreeViewCatalogs()
        {
            this.treeViewCatalogs.Nodes.Clear();
            foreach (string item in Directory.GetLogicalDrives())
            {
                TreeNode _volume = new TreeNode(item, 0, 0);
                _volume.Name = item;
                UpdateChilderNodes(_volume, 2);
                treeViewCatalogs.Nodes.Add(_volume);
            }
        }

        private void FillNodesRecurse(string path, TreeNode node)
        {
            foreach (string item in Directory.EnumerateDirectories(path))
                if (AccessIsAllowed(item, FileSystemRights.Modify))
                {
                    TreeNode _dir = new TreeNode(Path.GetFileName(item), 1, 1);
                    _dir.Name = item;
                    FillNodesRecurse(item, _dir);
                    node.Nodes.Add(_dir);
                }
        }

        private void UpdateChilderNodes(TreeNode node, int subTrees)
        {
            int subTreesLeft = subTrees;
            if (subTreesLeft > 0)
            {
                subTreesLeft--;
                node.Nodes.Clear();
                if (AccessIsAllowed(node.Name, FileSystemRights.Modify))
                    foreach (string item in Directory.EnumerateDirectories(node.Name))
                        if (AccessIsAllowed(item, FileSystemRights.Modify))
                        {
                            TreeNode _dir = new TreeNode(Path.GetFileName(item), 1, 1);
                            _dir.Name = item;
                            UpdateChilderNodes(_dir, subTreesLeft);
                            node.Nodes.Add(_dir);
                        }
            }
        }

        static bool AccessIsAllowed(string directoryName, FileSystemRights rights)
        {
            bool AllowingRightsIsPresent = false;
            bool ForbiddingRightsIsPresent = false;

            void ProcessACT(AccessControlType type)
            {
                if (type == AccessControlType.Allow)
                    AllowingRightsIsPresent = true;
                else if (type == AccessControlType.Deny)
                    ForbiddingRightsIsPresent = true;
            }

            DirectorySecurity directorySecurity = new DirectorySecurity();
            try
            {
                directorySecurity = Directory.GetAccessControl(directoryName);
            }
            catch (Exception)
            {
                return false;
            }

            WindowsIdentity wi = WindowsIdentity.GetCurrent();
            foreach (FileSystemAccessRule ar in
                directorySecurity.GetAccessRules(true, true, typeof(SecurityIdentifier)))
                if (ar.FileSystemRights.HasFlag(rights))
                {
                    if (ar.IdentityReference.Value == wi.User.Value)
                        ProcessACT(ar.AccessControlType);
                    else
                        foreach (IdentityReference ir in wi.Groups)
                            if (ar.IdentityReference.Value == ir.Value)
                                ProcessACT(ar.AccessControlType);
                }

            if (ForbiddingRightsIsPresent)
                return false;
            else if (AllowingRightsIsPresent)
                return true;
            else
                return false;
        }

        private void UpdateListViewFiles(string path)
        {
            listViewFiles.Items.Clear();
            if (AccessIsAllowed(path, FileSystemRights.Modify) && Directory.GetFiles(path).Count() > 0)
            {
                foreach (var item in Directory.GetFiles(path))
                {
                    ListViewItem lviItem = new ListViewItem(Path.GetFileName(item), 2);
                    listViewFiles.Items.Add(lviItem);
                }
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewFiles.View = View.LargeIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewFiles.View = View.Details;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewFiles.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewFiles.View = View.List;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewFiles.View = View.Tile;
        }
    }
}
