using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class FlyingRobot:Robot
    {
        // フィールド

        public FlyingRobot(string name)
        {
            this.name = name;
        }

        // 爆弾を落とす
        public void DropBomb()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は、爆弾を落とした",name);
            }
            else
            {
                Console.WriteLine("{0}は、電源offなので爆弾投下使えません..", name);
            }
        }

    }
}
