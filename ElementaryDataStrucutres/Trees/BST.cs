using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryDataStrucutres.Trees
{
    class BST
    {
        private Node root;

        public BST()
        {
            root = null;
        }

        private Node Add(Node node, int item)
        {
            if (node == null)
            {
                node = new Node(item);
                if (root == null)
                {
                    root = node;
                    return root;
                }

                return node;
            }
            

            if (item < node.Data)
            {
                node.Left = Add(node.Left, item);
            }
            else
            {
                node.Right = Add(node.Right, item);
            }

            return node;
        }

        public void Add(int item)
        {
            Add(root, item);
        }
    }
}
