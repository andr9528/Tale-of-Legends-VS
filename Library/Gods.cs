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
        private string favoring;
        private string divine;
        private int godID;

        public string Favoring { get { return favoring; } internal set { favoring = value; } }
        public string Divine { get { return divine; } internal set { divine = value; } }
        public int GodID { get { return godID; } internal set { godID = value; } }
        public Storage store { get; }


        public Gods()
        {

        }
        public Gods(string _favoring, string _divine, int _godID)
        {
            Favoring = _favoring;
            if (store.GodGreekString.Contains(_divine)
                || store.GodEgyptianString.Contains(_divine)
                || store.GodNordicString.Contains(_divine)
                || store.GodAtlanticString.Contains(_divine))
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
