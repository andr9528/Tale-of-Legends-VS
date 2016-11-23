using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Character
    {

        string[] Genders = new string[] { "Male", "Female" };
        List<int> ClosenessHits = new List<int>();
        List<int> Favoring = new List<int>();

        public int FavorPoints { get; internal set; }
        public string Name { get; internal set; }
        public string Gender { get; internal set; }
        public string GodParent { get; internal set; }
        public int DesiredMythology { get; internal set; }
        


        public void incSelection(int choice)
        {
            if (FavorPoints >= 1 && Favoring[choice] <= 9)
            {
                Favoring[choice]++;
                FavorPoints--;
            }
            else
            {
                throw new Exception("You are out of Favoring Points or you already have 10 points in this selection, try another one");
            }
        }
        public void decSelection(int choice)
        {
            if (FavorPoints < 64 || Favoring[choice] != 1)
            {
                Favoring[choice]--;
                FavorPoints++;
            }
            else
            {
                throw new Exception("You haven't invested any Favoring Points or you are trying to go below one which is not allow, try another one");
            }
        }
        public Character()
        {
            Storage store = new Storage();

            store.setup();
        }
        public Character(string name, string gender, int desiredMythology)
        {
            Storage store = new Storage();

            store.setup();

            Name = name;

            if (Genders.Contains(gender))
            {
                Gender = gender;
            }
            else
            {
                throw new Exception("Invalid Gender");
            }

            if (desiredMythology <= 4 && desiredMythology >= 1)
            {
                DesiredMythology = desiredMythology;
            }
            else
            {
                throw new Exception("Invalid Desired Mythology");
            }
            FavorPoints = 64;
            for (int i = 0; i < store.SkillList.Count(); i++)
            {
                Favoring.Add(1);
            }
        }
        public string parentSelector()
        {
            throw new NotImplementedException();
        }

        public bool checkIfClose(Skill skill, Gods divine)
        {
            if (skill.startup >= int.Parse(divine.Favoring.Split(',')[skill.ID])-1 
                && skill.startup <= int.Parse(divine.Favoring.Split(',')[skill.ID]) + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CountCloseness()
        {
            Storage store = new Storage();
            if (FavorPoints != 0)
            {
                ClosenessHits.Clear();
                int count = 0;

                if (DesiredMythology == 1)
                {
                    foreach (Gods divine in store.GreekGods)
                    {
                        foreach (Skill skill in store.SkillList)
                        {
                            if (checkIfClose(skill, divine) == true)
                            {
                                count++;
                            }
                        }
                    }
                    ClosenessHits.Add(count);
                }
                else if (DesiredMythology == 2)
                {
                    foreach (Gods divine in store.EgyptianGods)
                    {
                        foreach (Skill skill in store.SkillList)
                        {
                            if (checkIfClose(skill, divine) == true)
                            {
                                count++;
                            }
                        }
                    }
                    ClosenessHits.Add(count);
                }
                else if (DesiredMythology == 3)
                {
                    foreach (Gods divine in store.NordicGods)
                    {
                        foreach (Skill skill in store.SkillList)
                        {
                            if (checkIfClose(skill, divine) == true)
                            {
                                count++;
                            }
                        }
                    }
                    ClosenessHits.Add(count);
                }
                else if (DesiredMythology == 4)
                {
                    foreach (Gods divine in store.AtlanticTitans)
                    {
                        foreach (Skill skill in store.SkillList)
                        {
                            if (checkIfClose(skill, divine) == true)
                            {
                                count++;
                            }
                        }
                    }
                    ClosenessHits.Add(count);
                }
                else
                {
                    throw new Exception("How did you get to this point?");
                }
            }
            else
            {
                throw new Exception("You have left over points to invest");
            }
        }

        public string ToStringParent()
        {
            return "Your parent is" + GodParent ;
        }
    }
}
