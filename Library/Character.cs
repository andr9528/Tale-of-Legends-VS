using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Character
    {
        Skill Archery = new Skill(0, 1, 10, 1.00, "Archery");
        Skill OneHanded = new Skill(1, 1, 10, 1.00, "OneHanded");
        Skill TwoHanded = new Skill(2, 1, 10, 1.00, "TwoHanded");
        Skill LightArmor = new Skill(3, 1, 10, 1.00, "LightArmor");
        Skill HeavyArmor = new Skill(4, 1, 10, 1.00, "HeavyArmor");
        Skill Stealth = new Skill(5, 1, 10, 1.00, "Stealth");
        Skill Agility = new Skill(6, 1, 10, 1.00, "Agility");
        Skill Smighting = new Skill(7, 1, 10, 1.00, "Smighting");
        Skill Enchanting = new Skill(8, 1, 10, 1.00, "Enchanting");
        Skill Alchemy = new Skill(9, 1, 10, 1.00, "Alchemy");
        Skill Blocking = new Skill(10, 1, 10, 1.00, "Blocking");
        Skill WildMagic = new Skill(11, 1, 10, 1.00, "WildMagic");
        Skill InfernoMagic = new Skill(12, 1, 10, 1.00, "InfernoMagic");
        Skill BlizzMagic = new Skill(13, 1, 10, 1.00, "BlizzMagic");
        Skill Skymagic = new Skill(14, 1, 10, 1.00, "Skymagic");
        Skill PureMagic = new Skill(15, 1, 10, 1.00, "PureMagic");

        string[] Genders = new string[] { "Male", "Female" };
        List<Skill> skillList = new List<Skill>();

        public int FavorPoints { get; internal set; }
        public string Name { get; internal set; }
        public string Gender { get; internal set; }
        public string GodParent { get; internal set; }

        public void setup()
        {
            Skill[] skillArray = new Skill[] 
            {
                Archery, OneHanded, TwoHanded, LightArmor,
                HeavyArmor, Stealth, Agility, Smighting, 
                Enchanting, Alchemy, Blocking, WildMagic,
                InfernoMagic, BlizzMagic, Skymagic, PureMagic
            };

            FavorPoints = 64;
            skillList.AddRange(skillArray);
            
        }
        public void increseSelection(int choice)
        {
            if (FavorPoints >= 1 && skillList[choice].startup <= 9)
            {
                skillList[choice-1].startup++;
                FavorPoints--;
            }
            else
            {
                throw new Exception("you are out of Favoring Points or you already have 10 points in this selection, try another one");
            }
        }
        public void decresesSelection(int choice)
        {
            if (FavorPoints < 64 || skillList[choice].startup > 1)
            {
                skillList[choice].startup--;
                FavorPoints++;
            }
            else
            {
                throw new Exception("you haven't invested any Favoring Points or you are trying to go below one which is not allow, try another one");
            }
        }
        public void basicCharacterCreation(string name, string gender)
        {
            Name = name;

            if (Genders.Contains(gender))
            {
                Gender = gender;
            }
            else
            {
                throw new Exception("Invalid Gender");
            }
        }
        public string parentSelector()
        {
            throw new NotImplementedException();
        }

        public string ToStringParent()
        {
            return "Your parent is" + GodParent ;
        }
    }
}
