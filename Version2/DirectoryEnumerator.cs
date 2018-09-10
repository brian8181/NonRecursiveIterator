using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Version2
{
    /// <summary>
    /// A node in a directory tree
    /// </summary>
    public class Node : IEnumerable
    {
        private Node parent = null;
        private DirectoryInfo di;
        private DirectoryInfo[] dirs = null;
        private int index = 0;
        
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="parent">the parent node</param>
        /// <param name="di">the directory info</param>
        public Node(Node parent, DirectoryInfo di)
        {
            this.di = di;
            this.dirs = di.GetDirectories();
            this.parent = parent;
        }


        /// <summary>
        /// the directory info of this node
        /// </summary>
        public DirectoryInfo Info
        {
            get { return di; }
        }

        /// <summary>
        /// Gets the parent node
        /// </summary>
        public Node Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        /// <summary>
        /// Gets next child node & advances the postion
        /// </summary>
        /// <returns></returns>
        public DirectoryInfo NextChild()
        {
            if (index < Children.Length)
            {
                return Children[index++];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// gets the child nodes
        /// </summary>
        public DirectoryInfo[] Children
        {
            get { return dirs; }
            set { dirs = value; }
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return new DirectoryEnumerator(di);
        }

        #endregion
    }
    
    /// <summary>
    /// a non recursive directory enumerator
    /// </summary>
    public class DirectoryEnumerator : IEnumerator<Node>
    {
        #region IEnumerator<Node> Members
        private Node node = null;

        public DirectoryEnumerator(DirectoryInfo di)
        {
            node = new Node(null, di);
        }
        
        public DirectoryEnumerator(Node node)
        {
            this.node = node;
        }

        /// <summary>
        /// return current postion
        /// </summary>
        public Node Current
        {
            get { return node; }
        }
        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            node = null;
        }
        #endregion

        #region IEnumerator Members
        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }
               
        /// <summary>
        /// moves iterator forward one node
        /// </summary>
        /// <returns>true if moves, false if the end has been reached</returns>
        public bool MoveNext()
        {
            while (node != null)
            {
                DirectoryInfo current_dir = node.NextChild();
                if (current_dir != null)
                {
                    node = new Node(node, current_dir);
                    return true;
                }
                else
                {
                    node = node.Parent;
                }
            }
            return false;
        }

        /// <summary>
        /// resets to beginning / root node
        /// </summary>
        public void Reset()
        {
            while (node.Parent != null)
            {
                node = node.Parent;
            }
        }
        #endregion
    }
}
