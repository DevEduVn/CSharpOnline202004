using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09._2.InterfaceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            IStorable obj = new Document();
            obj.Read();
            obj.Write();

            Console.ReadLine();
        }
    }
    /// <summary>
    /// Lớp giao diện: Chỉ khai báo các hoạt động của đối tượng
    /// </summary>
    interface IStorable
    {
        void Read();
        void Write();
    }

    class Document : IStorable
    {
        public void Read()
        {
            Console.WriteLine("Read");
        }

        public void Write()
        {
            Console.WriteLine("Ghi");
        }
    }

}
