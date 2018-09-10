using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("C:\\Test");
            //DirIter iter = new DirIter(dir);

            //while (iter != null)
            //{
            //    Console.WriteLine(iter.CurrentDir.FullName);
            //    iter = iter.MoveNext();
            //}

            DirectoryInfo info = new DirectoryInfo("C:\\test");
            
            Node nodes = new Node(null, info);
            foreach (Node n in nodes)
            {
                Console.WriteLine(n.Info.FullName);
            }
        }
    }
}
