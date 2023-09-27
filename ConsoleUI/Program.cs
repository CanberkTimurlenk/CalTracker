using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KaloriTakipDbContext context = new KaloriTakipDbContext();

            foreach (var item in context.UserDatas)
            {
                Console.WriteLine(item.BmiStatus.ToString());
            }
        }
    }
}