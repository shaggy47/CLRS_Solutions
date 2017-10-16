using System;

namespace ElementaryDataStrucutres.Trees
{
    class Node
    {
        private int data;
        public int Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.data = value;
            }
        }

        public Node(int item)
        {
            this.data = item;
            this.Left = null;
            this.Right = null;
        }

        public Node Left { get; set; }
        public Node Right { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
