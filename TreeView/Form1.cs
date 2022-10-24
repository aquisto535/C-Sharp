using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TreeNode node1 = new TreeNode(txtNode.Text);

            if (treeView1.SelectedNode != null & treeView1.SelectedNode.IsSelected)
            {
                treeView1.SelectedNode.Nodes.Add(node1);
            }
            else
            {
                treeView1.Nodes.Add(node1);
            }

            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null & treeView1.SelectedNode.IsSelected)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
