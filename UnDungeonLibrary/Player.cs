using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnDungeonLibrary
{
    public class Player : Character
    {
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int maxLife, int life,
            Race characterRace, Weapon equippedWeapon)
            : base(name, hitChance, block, life, maxLife)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            switch (CharacterRace)
            {
                case Race.Human:
                    MaxLife += 5;
                    Life += 5;
                    break;

                case Race.Elf:
                    MaxLife -= 5;
                    Life -= 5;
                    HitChance = +10;
                    break;

                case Race.Dwarf:
                    Block -= 5;
                    EquippedWeapon.MaxDamage += 2;
                    break;

                case Race.Halfling:
                    Block += 10;
                    MaxLife -= 5;
                    Life -= 5;
                    break;
            }

        }

        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.Human:
                    description = "You're a human. You know how that feels.";
                    break;

                case Race.Elf:
                    description = "You're an elf. You live forever unless you don't.";
                    break;

                case Race.Dwarf:
                    description = "You're a dwarf. You're short and grumpy, and your wife's beard is as thick as yours.";
                    break;

                case Race.Halfling:
                    description = "You're a halfling, also known as a hobbit. You're short. You're probably a thief, and you have abnormally large and hairy feet.";
                    break;
            }// End switch

            return string.Format("-=-= {0} =-=-\nLife: {1} of {2}\nHit Chance: {3}%\nWeapon: {4}\nBlock: {5}\n{6}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                EquippedWeapon,
                Block,
                description);
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

    }
}
