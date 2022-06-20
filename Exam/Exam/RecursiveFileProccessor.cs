using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace Exam
{
    class RecursiveFileProccessor : Form1
    {

        // не стал специально удалять нерабочий код, чтобы вы видели ход работы

        public static void Mainly(string[] args)
        {
            //    foreach(string path in args)
            //        if (File.Exists(path))
            //        {
            //            ProcessFile(path);
            //        }
            //    else if (Directory.Exists(path))
            //        {
            //            ProcessDirectory(path);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} is not a valid file or directjry", path);
            //        }
            //}
            //public static void ProcessDirectory(string targetDirectory)
            //{
            //    string[] fileEntries = Directory.GetFiles(targetDirectory);
            //    foreach (string fileName in fileEntries)
            //        ProcessFile(fileName);

            //    string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            //    foreach (string subdirectory in subdirectoryEntries)
            //        ProcessDirectory(subdirectory);
            //}
            //public static void ProcessFile(string path)
            //{
            //    Console.WriteLine("Processed file '{0}'.", path);
        }

    }
}
