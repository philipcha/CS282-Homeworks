using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Philip",
                Birthday = "0614",
                Email = "asd456613@gmail.com",
                Orientation = 0.0,
                Pos = Position.Generate()
            };
            Console.Write("請輸入要畫的長方形的短邊長:");
            double width = 0.0;
            bool success = double.TryParse(Console.ReadLine(), out width);
            if (success)
                person.DrawSquare(width);
            else
                Console.WriteLine("輸入錯誤，請重新執行!");
        }
    }
}