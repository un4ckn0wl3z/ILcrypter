using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Stub
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader(System.Reflection.Assembly.GetEntryAssembly().Location))
            {
                using (BinaryReader binaryReader = new BinaryReader(streamReader.BaseStream))
                {
                    byte[] stubBytes = binaryReader.ReadBytes(Convert.ToInt32(streamReader.BaseStream.Length));
                    string stubSettings = Encoding.ASCII.GetString(stubBytes).Substring(Encoding.ASCII.GetString(stubBytes).IndexOf("***")).Replace("***", "");
                    Console.WriteLine(stubSettings);
                    Console.ReadLine();
                }
            }
        }
    }
}
