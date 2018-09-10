using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProofOfConcept
{
    public class DirectoryNode
    {
        private DirectoryInfo current = null;
        private DirectoryInfo parent = null;
        private DirectoryInfo[] infos = null;
        private int? current_idx = 0;

        public DirectoryNode(DirectoryInfo current)
        {
            this.current = current;
            infos = current.GetDirectories();
            if (Infos.Length == 0)
            {
                current_idx = null;
            }
        }
        
        public DirectoryInfo Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public DirectoryInfo Current
        {
            get { return current; }
            set { current = value; }
        }
       
        public DirectoryInfo[] Infos
        {
            get { return infos; }
            set { infos = value; }
        }
        
        public int? Current_Index
        {
            get { return current_idx; }
            set { current_idx = value; }
        }
        
    }

    public class DirectoryEnumerator : IEnumerator<DirectoryNode>
    {
        public DirectoryNode current = null;
        
        public DirectoryEnumerator(DirectoryNode current)
        {
            this.current = current;
        }

        public DirectoryNode Current
        {
            get
            {
                return null;
            }
        }
        
        public DirectoryNode MoveNext()
        {
           return null;
        }

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerator Members

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        bool System.Collections.IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public class DirectoryExt : IEnumerable<DirectoryEnumerator>
    {
        private DirectoryInfo di = null;

        #region IEnumerable<DirectoryEnumerator> Members
        public IEnumerator<DirectoryEnumerator> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
