using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Player
    {
        private string name;
        private int level;

        public Player(string name,int level)
        {
            this.name = name;
            this.level = level;
        }
        public void Attack()
        {
            Console.WriteLine("攻撃!!");
        }
        public void Defence()
        {
            Console.WriteLine("防御した");
        }
        public void LevelUp()
        {
            level++;        
        }
        public string GetName()
        {
            return name;
        }
        public int GetLevel()
        {
            return level;
        }
    }
}
