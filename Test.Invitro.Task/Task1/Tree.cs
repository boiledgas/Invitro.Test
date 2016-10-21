using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Invitro.Task.Task1
{
    public class Tree
    {
        public TreeNode Root { get; }

        public Tree(TreeNode root)
        {
            Root = root;
        }

        public void Walk(Action<TreeNode, TreeNode> action)
        {
            Walk(Root, action);
        }

        private void Walk(TreeNode parent, Action<TreeNode, TreeNode> action)
        {
            foreach (var treeNode in parent.Childs)
            {
                action(parent, treeNode);
                Walk(treeNode, action);
            }
        }

        public static IEnumerable<Tree> LoadTrees(IEnumerable<Node> nodes)
        {
            return TreeNode.LoadTrees(nodes).Select(root => new Tree(root));
        } 
    }
}
