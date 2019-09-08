using System;
using FileSystem.source;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperator fileOperator = new FileOperator();
            fileOperator.DriveTest();

            fileOperator.DirectoryTest();

            fileOperator.TestFile();
        }
    }
}
