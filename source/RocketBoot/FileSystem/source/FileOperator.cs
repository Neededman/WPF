using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileSystem.source
{
    class FileOperator
    {
        public void DriveTest()
        {
            // 获取当前电脑所有的驱动器
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in driveInfos)
            {
                Console.WriteLine(driveInfo.ToString());
            }

            // 获取C盘驱动器
            DriveInfo driveInfoC = new DriveInfo("C:\\");
            Console.WriteLine(driveInfoC.ToString());
            Console.WriteLine("driveInfoC.DriveFormat is: {0}", driveInfoC.DriveFormat);

            Console.WriteLine("driveInfoC.DriveType is: {0}", driveInfoC.DriveType);
        }

        public void DirectoryTest()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\Test");
            
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            
            Console.WriteLine(directoryInfo.Exists.ToString());
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            
            if (!new DirectoryInfo(@"D:\Test\Test1").Exists)
            {
                // 该函数不能在驱动器（C:\, D:\）目录下建
                directoryInfo.CreateSubdirectory(@"Test1");
            }
            string name = directoryInfo.Name;
            Console.WriteLine("directoryInfo is {0}", name);
            foreach (var dir in dirs)
            {
                Console.WriteLine(dir.ToString());
            }
        }

        public void TestFile()
        {
            string path = @"D:\Test\test.txt";
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine(fileInfo.ToString());
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            fileInfo.Open(FileMode.Append, FileAccess.Read, FileShare.Read);
        }
    }
}
