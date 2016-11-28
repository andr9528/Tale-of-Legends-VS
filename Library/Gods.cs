using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Gods
    {
        Storage store = new Storage();
        private string favoring;

        List<double> XpModifier = new List<double>(); 
        public string Favoring
        {
            get { return favoring; }
            internal set
            {
                favoring = value;
            }
        }
        public string Divine { get; internal set; }
        public int GodID { get; internal set; }

        
        public Gods()
        {

        }
        public Gods(string _favoring, string _divine, int _godID)
        {
            Favoring = _favoring;
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
    }

}
