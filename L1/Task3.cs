using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace L1
{
    static class Task3
    {
        static byte[] virusSum = null;
        static int virusByteSize = 16;
        public static void Task()
        {
            File.Create("VIRUS.exe").Dispose();
            using (Stream stream = new FileStream("VIRUS.exe", FileMode.Open, FileAccess.Write))
            {
                for (int i = 0; i < virusByteSize; i++)
                    stream.WriteByte((byte)i);
            }
            FileInfo virus = new FileInfo("VIRUS.exe");
            Console.WriteLine("Spreading the virus.."); 
            Spread(new DirectoryInfo(@"D:\").Root, virus);
            Console.WriteLine("Virus has been spread. Press any key to delete it");
            Console.ReadKey(true);
            Console.WriteLine("Deleting the virus...");
            virusSum = CalcMD5(virus);
            Destroy(new DirectoryInfo(@"D:\").Root);
            Console.WriteLine("Virus has been deleted"); ;
        }
        static void Spread(DirectoryInfo directory, FileInfo virus)
        {
            {
                try
                {
                    virus.CopyTo(directory.FullName + @"\" + virus.Name, true);
                    foreach (var fold in directory.GetDirectories())
                    {
                        Spread(fold, virus);
                    }
                }
                catch (System.UnauthorizedAccessException) { }
            }
        }
        static void Destroy(DirectoryInfo directory)
        {
            try
            {
                foreach (var file in directory.EnumerateFiles())
                {
                    bool sumsEqual = false;
                    if (Path.GetExtension(file.Name) == ".exe")
                    {
                        var fileSum = CalcMD5(file);
                        if (fileSum.Length == virusSum.Length)
                        {
                            int i = 0;
                            while (i < fileSum.Length && fileSum[i] == virusSum[i])
                                i++;
                            if (i == fileSum.Length) sumsEqual = true;
                        }
                    }
                    if (sumsEqual) file.Delete();
                }
                foreach (var fold in directory.GetDirectories())
                {
                    Destroy(fold);
                }
            }
            catch (System.UnauthorizedAccessException)
            { }
        }
        static byte[] CalcMD5(FileInfo file)
        {
            using (StreamReader fileReader = new StreamReader(file.FullName))
            {
                MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider();
                byte[] data = Encoding.UTF8.GetBytes(fileReader.ReadToEnd());
                return mD5.ComputeHash(data);
            }
        }
    }
}

