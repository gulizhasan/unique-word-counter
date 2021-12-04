using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3assignment
{
    class BSTree<T> where T : IComparable
    {
        protected Node<T> root; //declare root as protected
        public BSTree() //creates an empty tree
        {
            root = null;
        }
        public void InsertItem(T item) //creates a tree with node as the root
        {
            insertItem(item, ref root);
        }
        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null) //if tree is null add item to tree
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0) //if item is smaller than tree.data 
                insertItem(item, ref tree.Left); //insert item to the left sub-tree

            else if (item.CompareTo(tree.Data) > 0) //if item is larger than tree.data
                insertItem(item, ref tree.Right); //insert item to the right sub-tree
        }
        public int Height() //returns the height of the tree
        {
            return height(root);
        }
        protected int height(Node<T> root)
        //Return the length in nodes of the longest path in the tree
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(height(root.Left), height(root.Right));
            }
        }
        public void InOrder(ref string buffer) //InOrder traversal
        {
            inOrder(root, ref buffer);
        }
        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null) //if tree is not null
            {
                inOrder(tree.Left, ref buffer); //traverse left sub-tree
                buffer += tree.Data.ToString() + ", "; //display value in node
                inOrder(tree.Right, ref buffer); //traverse right sub-tree
            }
        }
        public int Count()
        //Return the number of nodes contained in the tree
        {
            return count(this.root) + 1;
        }
        private int count(Node<T> root)
        {
            if (root == null) //if root is null return 0
            {
                return 0; 
            }
            else
            {
                //return the sum of nodes in the left and right tree and add 1 for the root
                return 1 + count(root.Left) + count(root.Right); 
            }
        }

        public bool Contains(T item) //returns true if the tree contains the item
        {
            return contains(item, this.root);
        }
        private bool contains(T item, Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (item.CompareTo(node.Data) < 0)
            {
                return contains(item, node.Left);
            }
            if (item.CompareTo(node.Data) > 0)
            {
                return contains(item, node.Right);
            }
            return true;
        }
    }
}
