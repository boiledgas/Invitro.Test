using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Invitro.Task.Task1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var table1 = new List<Node>
            {
                new Node {Id = 1, ParentId = null},
                new Node {Id = 2, ParentId = 1},
                new Node {Id = 3, ParentId = 2},
                new Node {Id = 4, ParentId = 3},
                new Node {Id = 5, ParentId = 4},
                new Node {Id = 6, ParentId = 5},
                new Node {Id = 7, ParentId = 6},

                new Node {Id = 8, ParentId = 9},
                new Node {Id = 9, ParentId = 10},
                new Node {Id = 10, ParentId = 11},
                new Node {Id = 11, ParentId = 12},
                new Node {Id = 12, ParentId = 13},
                new Node {Id = 13, ParentId = 14},
                new Node {Id = 14, ParentId = null},
            };
            var trees = Tree.LoadTrees(table1);
            foreach (var tree in trees)
            {
                tree.Walk((parent, treeNode) =>
                {
                    var node = table1.FirstOrDefault(n => 
                        n.Id == treeNode.Id && treeNode.Parent != null && n.ParentId == treeNode.Parent.Id);
                    Assert.IsNotNull(node);
                    table1.Remove(node);
                });
                var root = table1.FirstOrDefault(n => n.Id == tree.Root.Id && n.ParentId == null);
                Assert.IsNotNull(root);
                table1.Remove(root);
            }

            Assert.AreEqual(table1.Count, 0);
        }
    }
}
