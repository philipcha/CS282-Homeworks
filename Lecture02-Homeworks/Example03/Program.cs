using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql =
                @"select * from table
                           where id > 10
                 ";
            Console.WriteLine(sql);

            string path = "C:\\xampp\\hidoc\\";
            Console.WriteLine(path);
            string path02 = @"C:\xampp\\hidoc\";
            Console.WriteLine(path02);
        }
    }
}
