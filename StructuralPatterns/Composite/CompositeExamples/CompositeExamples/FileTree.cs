using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeExamples
{
    public static class FileTree
    {
        public static void PrintTree()
        {
            var folder1 = new Directory("Folder1");
            folder1.Add(new File("File1.txt", 7));

            var folder2 = new Directory("Folder2");
            folder2.Add(new File("File2.txt", 2));
            folder2.Add(new File("File3.txt", 11));

            var folder3 = new Directory("Folder3.txt");
            folder3.Add(new File("File5.txt", 13));
            folder3.Add(new File("File6.txt", 5));

            var file4 = new File("File4.txt", 6);

            var root = new Directory("C");
            root.Add(folder1);
            root.Add(folder2);
            root.Add(file4);
            root.Add(folder3);

            root.Print();
        }
    }
}
