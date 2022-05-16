using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr8Folder
{
    class Tools
    {
        public static object Create { get; private set; }

        public static void  CreateFolder(string path)
        {
            Directory.CreateDirectory(path);

        }

        public static void CreateFolders(string[] paths)
        {
            foreach (string folder in paths)
            {
                CreateFolder(folder);
            }
        }

        public static void CreateEmptyFile(string path)
        {
            if (!File.Exists(path))
            File.Create(path).Close();
        }
        public static void StrCreateEmptyFile(string[] pathes)
        {
            foreach (string files in pathes)
            {
                CreateEmptyFile(files);
            }
        }
            public  static void CreateDataFile(string path, string [] lines)
            {
                StreamWriter stw = new StreamWriter(path);
            foreach (string line in lines)
            {
                stw.WriteLine(line);
            }
                        stw.Close();
                        
            }
        public static void CreateDataFiles(string [] paths, string[][] allLines)
        {
            for (int x = 0; x < paths.Count(); x++)
            {
                CreateDataFile(paths[x], allLines[x]);
            }
        }
        }

    }

