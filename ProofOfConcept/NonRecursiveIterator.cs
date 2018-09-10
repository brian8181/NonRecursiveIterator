using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ProofOfConcept
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
        /// 
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
            return new NonRecursiveEnumerator(di);
        }

        #endregion
    }

   
    // THIS IS WORKING!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    class NonRecursiveIterator
    {
        public List<Node> nodes = new List<Node>();
        public void Start(DirectoryInfo di)
        {
            Node node = new Node(null, di);
            DirectoryInfo[] dirs = di.GetDirectories();
            nodes.Add(node);

            while (true)
            {
                DirectoryInfo current_dir = node.NextChild();
                if (current_dir != null)
                {
                    node = new Node(node, current_dir);
                    nodes.Add(node);
                    continue;
                }
                else
                {
                    node = node.Parent;
                    if (node == null)   
                        break;
                }
            }
        }

        
    }

    public class NonRecursiveEnumerator : IEnumerator<Node>
    {
        #region IEnumerator<Node> Members
        //public List<Node> nodes = new List<Node>();
        private DirectoryInfo di = null;
        private Node node = null;

        public NonRecursiveEnumerator(DirectoryInfo di)
        {
            this.di = di;
            Node new_node = new Node(null, di);
            DirectoryInfo[] dirs = di.GetDirectories();
            //nodes.Add(new_node);
            node = new_node;
        }

        public Node Current
        {
            get { return node; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        #endregion

        #region IEnumerator Members

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            while (true)
            {
                DirectoryInfo current_dir = node.NextChild();
                if (current_dir != null)
                {
                    node = new Node(node, current_dir);
                    return true;
                    //nodes.Add(node);
                }
                else
                {
                    node = node.Parent;
                    if (node == null)
                        return false;
                }
            }
        }

        public void Reset()
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}
