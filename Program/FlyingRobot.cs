using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class FlyingRobot:Robot
    {
        // メソッド
        // コンストラクタ
        public FlyingRobot(string name) : base(name)
        {
        }

        // 爆弾を落とす
        public override void Attack()
        {
            Console.WriteLine("{0}は、爆弾を落とした！", name);
        }
    }
}
