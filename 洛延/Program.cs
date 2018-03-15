using Dapper.Data;
using LibraryCreateDatabase;
using LibraryCreateDatabase.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace 洛延
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new DataUtils();
            var init = new InitData();
            var efUtils = new EFUtils();
            var users = init.GetUsers(10000);
            //DateTime strtime = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    utils.Add(init.GetUser());
            //}
            //DateTime endtime = DateTime.Now;
            //Console.WriteLine($"dapper添加10000个用户:{endtime - strtime}");
            //DateTime efstrtime = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    efUtils.Add(init.GetUser());
            //}
            //DateTime efendTime = DateTime.Now;
            //Console.WriteLine($"EF添加10000个用户：{efendTime - efstrtime}");

            //DateTime strtime = DateTime.Now;
            //utils.AddRange(users);
            //DateTime endtime = DateTime.Now;
            //Console.WriteLine($"dapper批量添加10000个用户:{endtime - strtime}");
            //var users2 = init.GetUsers(10000);
            //DateTime efstrtime = DateTime.Now;
            //efUtils.AddRange(users2);
            //DateTime efendtime = DateTime.Now;
            //Console.WriteLine($"EF批量添加10000个用户：{efendtime - efstrtime}");
            //utils.InitArea();
            DateTime dpselectStrTime = DateTime.Now;
            for (int i = 0; i < 1000; i++)
            {
                var area = utils.SelectAreaByCode("130500");
            }
            DateTime dpselectEndTime = DateTime.Now;
           

            DateTime efselectStrTime = DateTime.Now;
            for (int i = 0; i < 1000; i++)
            {
                var area = efUtils.LinqSelectArea("130500");
            }
            DateTime efselectEndTime = DateTime.Now;
            Console.WriteLine($"dapper查询1000次：{dpselectEndTime - dpselectStrTime}");
            Console.WriteLine($"EF查询1000次：{efselectEndTime - efselectStrTime}");
            Console.ReadKey();
        }
    }
}
