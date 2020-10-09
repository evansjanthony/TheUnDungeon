using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnDungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }
        }
        public Monster(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description)
        : base(name, hitChance, block, life, maxLife)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format("Hey! There's a {0} in here!\nName: {0}\nInfo: {1}\nHP: {2} of {3}\n",
                Name,
                Description,
                Life,
                MaxLife);
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
    }
}
