using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class TankRobot:Robot
    {
        // フィールド

        public TankRobot(string name)
        {
            this.name = name;
        }

        // キャノン砲を撃つ
        public void ShootCannon()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は、キャノン砲を撃った!", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源offなのでキャノン砲は使えません..", name);
            }
        }
    }
}
