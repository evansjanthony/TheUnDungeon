using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnDungeonLibrary
{
    public class Area
    {
        public static string AreaDescription()
        {
            string[] areas =
            {
                "You open the door to a scene of carnage. Two male humans, a male elf, and a female dwarf lie in drying pools of their blood. It seems that they might once have been wearing armor, except for the elf, who remains dressed in a blue robe. Clearly they lost some battle and victors stripped them of their valuables.",
                "A stone throne stands on a foot-high circular dais in the center of this cold chamber. The throne and dais bear the simple adornments of patterns of crossed lines -- a pattern also employed around each door to the room.",
                "You open the door to reveal a 10-foot-by-10-foot room with a floor studded with spikes. The bones of some creature lie among the spikes and some insects scuttle away from the desiccated remains. No other doors are in the room, and it appears the door you opened was created to blend in with the walls. Additionally, you see no ceiling. You must be at the bottom of a very deep spiked pit.",
                "This otherwise bare room has one distinguishing feature. The stone around one of the other doors has been pulled over its edges, as though the rock were as soft as clay and could be moved with fingers. The stone of the door and wall seems hastily molded together.",
                "Burning torches in iron sconces line the walls of this room, lighting it brilliantly. At the room's center lies a squat stone altar, its top covered in recently spilled blood. A channel in the altar funnels the blood down its side to the floor where it fills grooves in the floor that trace some kind of pattern or symbol around the altar. Unfortunately, you can't tell what it is from your vantage point.",
                "Several white marble busts that rest on white pillars dominate this room. Most appear to be male or female humans of middle age, but one clearly bears small horns projecting from its forehead and another is spread across the floor in a thousand pieces, leaving one pillar empty.",
                "As the door opens, it scrapes up frost from a floor covered in ice. The room before you looks like an ice cave. A tunnel wends its way through solid ice, and huge icicles and pillars of frozen water block your vision of its farthest reaches.",
                "You open the door to confront a room of odd pillars. Water rushes down from several holes in the ceiling, and each hole is roughly a foot wide. The water pours in columns that fall through similar holes in the floor, flowing down to some unknown depth. Each of the eight pillars of water drops as much liquid as a stream in winter thaw. The floor is damp and looks slippery.",
                "You enter a small room and your steps echo. Looking about, you're uncertain why, but then a wall vanishes and reveals an enormous chamber. The wall was an illusion and whoever cast it must be nearby!",
                "A wall that holds a seat with a hole in it is in this chamber. It's a privy! The noisome stench from the hole leads you to believe that the privy sees regular use.",
            };

            return areas[new Random().Next(areas.Length)];
        }
    }
}
