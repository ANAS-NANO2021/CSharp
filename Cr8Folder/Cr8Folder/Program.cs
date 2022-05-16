using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr8Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] folder = { "My2","My1","My3"};

         /*   Tools.CreateFolders(folder);
            Tools.CreateEmptyFile("My new File ");
            string[] files = { "File1", "File2", "File3" }; 
            Tools.StrCreateEmptyFile(files);*/
            Tools.CreateDataFile("My new File ", new string []  { "ANAS", "HANAN" });
            string[] FileName = { " My File1 ", " My File2 ", " My File1 " };
            string[] line1 = { " My File1 ", " My File1 ", " My File1 " };
            string[] line2 = { " My File1 ", " My File1 ", " My File1 " };
            string[][] allLines = { line1, line2 };
            Tools.CreateDataFiles(FileName, allLines);
        }
    }
}
