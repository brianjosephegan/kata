using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public sealed class BinaryTreeLevelSorter
    {
        public class Node
        {
            public Node Left { get; }
            public Node Right { get; }
            public int Value { get; }

            public Node(Node left, Node right, int value)
            {
                Left = left;
                Right = right;
                Value = value;
            }
        }

        public List<int> Sort(Node node)
        {
            List<int> result = new List<int>();
            Queue<Node> nodesToVisit = new Queue<Node>();

            if (node != null)
            {
                nodesToVisit.Enqueue(node);
            }

            while (nodesToVisit.Any())
            {
                var currentNode = nodesToVisit.Dequeue();

                result.Add(currentNode.Value);

                if (currentNode.Left != null)
                {
                    nodesToVisit.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    nodesToVisit.Enqueue(currentNode.Right);
                }
            }

            return result;
        }
    }
}
