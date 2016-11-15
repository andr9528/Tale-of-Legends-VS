using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Skill
    {
        List<string> Skills = new List<string>()
        {
            "Archery", "OneHanded", "TwoHanded", "LightArmor",
            "HeavyArmor", "Stealth", "Agility", "Smighting",
            "Enchanting", "Alchemy", "Blocking", "WildMagic",
            "InfernoMagic", "BlizzMagic", "Skymagic", "PureMagic"
        };
        public string type;
        public int startup;
        public int level;
        public double xpMultiplier;

        public Skill()
        {

        }
        public Skill(int _startup, int _level, double _xpMultiplier , string _type)
        {
            if (_startup <= 10)
            {
                startup = _startup;
            }
            else
            {
                throw new Exception("Too High Favoring");
            }
            if (_level <= 100)
            {
                level = _level;
            }
            else
            {
                throw new Exception("Too High Level");
            }
            if (_xpMultiplier > 0.50)
            {
                xpMultiplier = _xpMultiplier;
            }
            else
            {
                throw new Exception("can't go below 50% XP gain on a skill");
            }

            if (Skills.Contains(_type))
            {
                type = _type;
            }
            else
            {
                throw new Exception("Unknown SKill");
            }
        }
    }
}
