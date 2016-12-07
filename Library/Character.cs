using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Character
    {
        public Storage store = new Storage();
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
            store.setup();
        }
        public Character(string name, string gender, int desiredMythology)
        {
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
        public int calcFavoring(int godID)
        {
            int output = 0;

            foreach (Gods divine in SearchAndRetriveG(godID))
            {
                for (int i = 0; i < divine.Favoring.Split(',').Count(); i++)
                {
                    output = output + int.Parse(divine.Favoring.Split(',')[i]);
                }
            }
            return output;
        }
        public List<Gods> SearchAndRetriveG(int searchTerm)
        {
            List<Gods> output = new List<Gods>();
            List<Gods> searchList = new List<Gods>();

            searchList.AddRange(store.GreekGods);
            searchList.AddRange(store.EgyptianGods);
            searchList.AddRange(store.NordicGods);
            searchList.AddRange(store.AtlanticTitans);


            foreach (Gods divine in searchList)
            {
                if (divine.GodID == searchTerm)
                {
                    output.Add(divine);
                }
            }
            if (output.Count == 0)
            {
                throw new Exception("Search term did not match anything");
            }
            return output;
        }

    }
}
