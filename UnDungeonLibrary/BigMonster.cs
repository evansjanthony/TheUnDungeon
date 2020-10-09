using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnDungeonLibrary
{
    public class BigMonster : Monster
    {
        public bool IsFlying { get; set; }

        public BigMonster(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description, bool isFlying)
            : base(name, hitChance, block, life, maxLife, minDamage, maxDamage, description)
        {
            IsFlying = isFlying;
        }

        public override string ToString()
        {
            return base.ToString() + (IsFlying ? "\nIt's hovering just over the ground." : "It crawls toward you on its clawed feet.");
        }

        public override int CalcBlock()
        {
            return IsFlying ? Block + Block / 2 : Block;
        }
    }
}
