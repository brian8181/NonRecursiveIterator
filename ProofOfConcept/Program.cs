using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProofOfConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo info = new DirectoryInfo("C:\\test");
            //NonRecursiveIterator iter = new NonRecursiveIterator();
            //iter.Start(info);


            Node nodes = new Node(null, info);
            foreach (Node n in nodes)
            {
                Console.WriteLine(n.Info.FullName);
            }
        }
    }
}
