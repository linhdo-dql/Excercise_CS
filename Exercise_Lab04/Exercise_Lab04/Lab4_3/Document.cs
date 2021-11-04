using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_3
{
    class Document : IStorage, IEncryptable
    {
        public object data => throw new NotImplementedException();

        public string content;
        public void Decrypt()
        {
            Console.WriteLine("Decryting....");
        }

        public void Encrypt()
        {
            Console.WriteLine("Encryting....");
        }

        public void Read(string fileName)
        {
            Console.WriteLine("Reading....");
        }

        public void Write(string fileName)
        {
            Console.WriteLine("Writing....");
        }
    }
}
