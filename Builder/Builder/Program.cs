using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("Stub.exe", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    fileStream.Position = fileStream.Length + 1;
                    binaryWriter.Write("*** Hello World ***");
                }
            }
        }
    }
}
