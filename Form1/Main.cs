namespace Form1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PopulateRootNodes();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_MouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Adicionar clientes")
            {
                DataInputForm dataInputForm = new DataInputForm();
                dataInputForm.ShowDialog();
            }
        }



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

    }
}