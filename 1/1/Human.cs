using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    /// <summary>
    /// 人間
    /// </summary>
    class Human
    {
        /// <summary>
        /// 名前
        /// </summary>
       public  string name;

        /// <summary>
        /// 名前を設定する
        /// </summary>
        /// <param name="name"></param>
       public Human(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 名前を返す
        /// </summary>
        /// <returns></returns>
        public string GetName() //prop使っているならいらぬ
        {
            return this.name;
        }

        /// <summary>
        /// 自身をマネージャーの管理に加える
        /// </summary>
        /// <param name="m"></param>
       public void Join(Manager m)
        {
            m.Manage(this);
        }
    }
}
