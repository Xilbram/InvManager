using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvManagerView
{
    public partial class MainForm : Form
    {
        static void Main() { }
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void NodeMouseClick(object sender, MouseEventArgs e)
        {
            GridClientes gridCli = new GridClientes();

            gridCli.ShowDialog(this);

        }
    }
}
