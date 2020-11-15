using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("タナカ");
            Manager manager = new Manager();

            manager.Manage(human);
            human.Join(manager);

            Console.Read();
        }
    }
}
