using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;

namespace ProofOfConcept
{
    [TestFixture]
    public class POC_Test
    {
        [Test]
        public void Test1()
        {
            DirectoryInfo info = new DirectoryInfo("C:\\Test");
            DirectoryNode node = new DirectoryNode(info);
            DirectoryEnumerator iter = new DirectoryEnumerator(node);
            while (iter.MoveNext() != null)
            {
                Console.WriteLine(iter.Current.Current.FullName); 
            }
        }
    }
}
