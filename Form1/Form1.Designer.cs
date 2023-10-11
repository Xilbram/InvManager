using InvenManager.Svc;

namespace Form1
{
    public partial class Form1: Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(191, 450);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PopulateRootNodes();
        }
        #endregion
        private void PopulateRootNodes()
        {
            PopulateClienteNode();
            PopulateFuncionarioNode();
            PopulatePedidoNode();
            PopulateProdutoNode();
        }
        private void PopulateClienteNode()
        {
            TreeNode rootCliente = new TreeNode("Clientes");

            TreeNode verCliente = new TreeNode("Ver clientes");
            TreeNode adicionarCliente = new TreeNode("Adicionar clientes");
            TreeNode atualizarCliente = new TreeNode("Atualizar clientes");
            TreeNode removerCliente = new TreeNode("Remover clientes");

            rootCliente.Nodes.Add(verCliente);
            rootCliente.Nodes.Add(adicionarCliente);
            rootCliente.Nodes.Add(atualizarCliente);
            rootCliente.Nodes.Add(removerCliente);

            treeView1.Nodes.Add(rootCliente);
        }
        private void PopulateFuncionarioNode()
        {
            TreeNode rootCliente = new TreeNode("Funcionario");

            TreeNode verCliente = new TreeNode("Ver Funcionario");
            TreeNode adicionarCliente = new TreeNode("Adicionar Funcionario");
            TreeNode atualizarCliente = new TreeNode("Atualizar Funcionario");
            TreeNode removerCliente = new TreeNode("Remover Funcionario");

            rootCliente.Nodes.Add(verCliente);
            rootCliente.Nodes.Add(adicionarCliente);
            rootCliente.Nodes.Add(atualizarCliente);
            rootCliente.Nodes.Add(removerCliente);

            treeView1.Nodes.Add(rootCliente);
        }
        private void PopulatePedidoNode()
        {
            TreeNode rootCliente = new TreeNode("Pedido");

            TreeNode verPedido = new TreeNode("Ver pedidos");
            TreeNode adicionarPedido = new TreeNode("Adicionar pedidos");
            TreeNode atualizarPedido = new TreeNode("Atualizar pedidos");
            TreeNode removerPedido = new TreeNode("Remover pedidos");

            rootCliente.Nodes.Add(verPedido);
            rootCliente.Nodes.Add(adicionarPedido);
            rootCliente.Nodes.Add(atualizarPedido);
            rootCliente.Nodes.Add(removerPedido);

            treeView1.Nodes.Add(rootCliente);
        }
        private void PopulateProdutoNode()
        {
            TreeNode rootCliente = new TreeNode("Produto");

            TreeNode verCliente = new TreeNode("Ver produtos");
            TreeNode adicionarCliente = new TreeNode("Adicionar produtos");
            TreeNode atualizarCliente = new TreeNode("Atualizar produtos");
            TreeNode removerCliente = new TreeNode("Remover produtos");

            rootCliente.Nodes.Add(verCliente);
            rootCliente.Nodes.Add(adicionarCliente);
            rootCliente.Nodes.Add(atualizarCliente);
            rootCliente.Nodes.Add(removerCliente);

            treeView1.Nodes.Add(rootCliente);
        }

        private void verClienteNode_DoubleClick(object sender, EventArgs e)
        {
            // Get the DataGridView control.
            
            DataGridView datagridCli = this.Controls["datagridCliente"] as DataGridView;
            // Set the Visible property of the DataGridView control to true.
            datagridCli.Visible = true;

            // Bind the DataGridView control to a data source that contains the customer information.
            datagridCli.DataSource = ClienteSvc.getBulkCliente();
        }



        private TreeView treeView1;
        DataGridView gridCli = new DataGridView();
       
       

    }
}