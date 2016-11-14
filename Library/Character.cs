using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Character
    {
        Skill Archery = new Skill(1, 10, "Archery");
        Skill OneHanded = new Skill(1, 10, "OneHanded");
        Skill TwoHanded = new Skill(1, 10, "TwoHanded");
        Skill LightArmor = new Skill(1, 10, "LightArmor");
        Skill HeavyArmor = new Skill(1, 10, "HeavyArmor");
        Skill Stealth = new Skill(1, 10, "Stealth");
        Skill Agility = new Skill(1, 10, "Agility");
        Skill Smighting = new Skill(1, 10, "Smighting");
        Skill Enchanting = new Skill(1, 10, "Enchanting");
        Skill Alchemy = new Skill(1, 10, "Alchemy");
        Skill Blocking = new Skill(1, 10, "Blocking");
        Skill WildMagic = new Skill(1, 10, "WildMagic");
        Skill InfernoMagic = new Skill(1, 10, "InfernoMagic");
        Skill BlizzMagic = new Skill(1, 10, "BlizzMagic");
        Skill Skymagic = new Skill(1, 10, "Skymagic");
        Skill PureMagic = new Skill(1, 10, "PureMagic");

        string[] Genders = new string[] { "Male", "Female" };
        List<Skill> skillList = new List<Skill>();

        public int FavorPoints { get; internal set; }
        public string Name { get; internal set; }
        public string Gender { get; internal set; }
        public string GodParent { get; internal set; }

        public void setup()
        {
            Skill[] skillArray = new Skill[] 
            {Archery, OneHanded, TwoHanded, LightArmor,
            HeavyArmor, Stealth, Agility, Smighting, 
            Enchanting, Alchemy, Blocking, WildMagic,
            InfernoMagic, BlizzMagic, Skymagic, PureMagic};

            FavorPoints = 64;
            skillList.AddRange(skillArray);
        }

        public void increseSelection(int choice)
        {
            if (FavorPoints >= 1 && skillList[choice].startup <= 9)
            {
                skillList[choice].startup++;
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

        public override string ToString()
        {
            return "Your parent is" + GodParent ;
        }
    }
}
