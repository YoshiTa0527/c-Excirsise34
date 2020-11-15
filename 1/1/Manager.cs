using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    /// <summary>
    /// マネージャー
    /// </summary>
    class Manager
    {
        /// <summary>
        /// 管理する
        /// </summary>
        /// <param name="human"></param>

        public void Manage(Human human)
        {
            Console.WriteLine(human.GetName());
        }
    }
}
