using System.Collections.Generic;

namespace Test.Invitro.Task.Task1
{
    /// <summary>
    /// class TreeNode model used by wrappers like ...
    /// </summary>
    public class TreeNode
    {
        private readonly List<TreeNode> _childs = new List<TreeNode>();

        /// <summary>
        /// Node id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Parent node
        /// </summary>
        public TreeNode Parent { get; private set; }

        /// <summary>
        /// Child nodes
        /// </summary>
        public IEnumerable<TreeNode> Childs => _childs;

        private TreeNode()
        {
        }

        public TreeNode(int id, TreeNode parent)
        {
            Id = id;
            Parent = parent;
        }

        internal static IEnumerable<TreeNode> LoadTrees(IEnumerable<Node> table)
        {
            var roots = new List<TreeNode>();
            var treeNodes = new Dictionary<int, TreeNode>();
            foreach (var node in table)
            {
                TreeNode parent = null;
                if (node.ParentId.HasValue && !treeNodes.TryGetValue(node.ParentId.Value, out parent))
                    parent = treeNodes[node.ParentId.Value] = new TreeNode {Id = node.ParentId.Value};

                TreeNode treeNode;
                if (!treeNodes.TryGetValue(node.Id, out treeNode))
                    treeNode = treeNodes[node.Id] = new TreeNode {Id = node.Id, Parent = parent};

                if (parent != null)
                {
                    treeNode.Parent = parent;
                    parent._childs.Add(treeNode);
                }
                else
                    roots.Add(treeNode);
            }
            return roots;
        }
    }
}
