using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new Initializer());
            UserContext context = new UserContext();
            System.Console.WriteLine("something");
            System.Console.WriteLine(context.Users.First().UserName);
            System.Console.WriteLine("something");
        }
    }
}
