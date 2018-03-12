using Dapper.Data;
using System;

namespace 洛延
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new DataUtils().Execute();
            foreach (var item in users)
            {
                Console.WriteLine(item.PhoneNum);
            }
            Console.ReadKey();
        }
    }
}
