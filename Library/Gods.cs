using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Gods
    {

        List<double> XpModifier = new List<double>(); 
        public string Favoring { get; internal set; }
        public string Divine { get; internal set; }
        public int GodID { get; internal set; }

        
        public Gods()
        {

        }
        public Gods(string _favoring, string _divine, int _godID)
        {
            Favoring = _favoring;
            Storage store = new Storage();
            if (store.GreekGodsS.Contains(_divine)
                || store.EgyptianGodsS.Contains(_divine)
                || store.NordicGodsS.Contains(_divine)
                || store.AtlanticTitansS.Contains(_divine))
            {
                Divine = _divine;
            }
            GodID = _godID;
        }

        public void xpModifierSetup()
        {
            Storage store = new Storage();
            foreach (Gods divine in store.GreekGods)
            {
                for (int i = 0; i < divine.Favoring.Split(',').Count(); i++)
                {
                    if (int.Parse(divine.Favoring.Split(',')[i]) > 5)
                    {
                        divine.XpModifier.Add((int.Parse(divine.Favoring.Split(',')[i]) - 5) * 5 / 100);
                    }
                }
            }
            foreach (Gods divine in store.EgyptianGods)
            {
                for (int i = 0; i < divine.Favoring.Split(',').Count(); i++)
                {
                    if (int.Parse(divine.Favoring.Split(',')[i]) > 5)
                    {
                        divine.XpModifier.Add((int.Parse(divine.Favoring.Split(',')[i]) - 5) * 5 / 100);
                    }
                }
            }
            foreach (Gods divine in store.NordicGods)
            {
                for (int i = 0; i < divine.Favoring.Split(',').Count(); i++)
                {
                    if (int.Parse(divine.Favoring.Split(',')[i]) > 5)
                    {
                        divine.XpModifier.Add((int.Parse(divine.Favoring.Split(',')[i]) - 5) * 5 / 100);
                    }
                }
            }
            foreach (Gods divine in store.AtlanticTitans)
            {
                for (int i = 0; i < divine.Favoring.Split(',').Count(); i++)
                {
                    if (int.Parse(divine.Favoring.Split(',')[i]) > 5)
                    {
                        divine.XpModifier.Add((int.Parse(divine.Favoring.Split(',')[i]) - 5) * 5 / 100);
                    }
                }
            }
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
            Storage store = new Storage();
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
