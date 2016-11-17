using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Gods
    {
        // Greek Gods
        Gods Zeus = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                             "Zeus", 0);
        Gods Hades = new Gods("7, 6, 4, 2, 8, 10, 5, 5, 5, 7, 3, 4, 10, 1, 1, 6",
                              "Hades", 1);
        Gods Poseidon = new Gods("1, 4, 8, 6, 9, 2, 3, 2, 8, 7, 7, 6, 2, 10, 3, 7", // <- working on this one - calculate favoring
                                 "Poseidon", 2);
        Gods Aphrodite = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                                  "Aphrodite", 3);
        Gods Hephaestus = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                                   "Hephaestus", 4);
        Gods Hera = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                             "Hera", 5);
        Gods Athena = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                               "Athena", 6);
        Gods Ares = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                             "Ares", 7);
        Gods Hermes = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                               "Hermes", 8);
        Gods Artemis = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                                "Artemis", 9);
        Gods Apollo = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                               "Apollo", 10);
        Gods Dionysus = new Gods("1, 8, 3, 8, 1, 4, 7, 6, 8, 3, 8, 5, 1, 1, 10, 6",
                                 "Dionysus", 11);
        // Egyptian Gods

        // Nordic Gods

        // Atlantic Titans


        List<double> XpModifier = new List<double>(); 
        public string Favoring { get; internal set; }
        public string Divine { get; internal set; }
        public int GodID { get; internal set; }

        List<Gods> GreekGods = new List<Gods>();
        List<string> GreekGodsS = new List<string>()
        {
            "Zeus", "Hades", "Poseidon", "Aphrodite",
            "Hephaestus", "Hera", "Athena", "Ares",
            "Hermes", "Artemis", "Apollo", "Dionysus"
        };
        List<Gods> EgyptianGods = new List<Gods>();
        List<string> EgyptianGodsS = new List<string>()
        {
            "Ra", "Isis", "Set", "Horus",
            "Osiris", "Anubis", "Bast", "Ptah",
            "Hathor", "Thoth", "Sekhmet", "Nephthys"
        };
        List<Gods> NordicGods = new List<Gods>();
        List<string> NordicGodsS = new List<string>()
        {
            "Thor", "Odin", "Loki", "Forseti",
            "Freyja", "Hel", "Baldr", "Tyr",
            "Heimdall", "Skadi", "Bragi", "Njord"
        };
        List<Gods> AtlanticTitans = new List<Gods>();
        List<string> AtlanticTitansS = new List<string>()
        {
            "Kronos", "Oranos", "Gaia", "Hekate",
            "Atlas", "Helios", "Theia", "Rheia",
            "Hyperion", "Oceanus", "Prometheus", "Leto"

        };
        public Gods()
        {

        }
        public Gods(string _favoring, string _divine, int _godID)
        {
            Favoring = _favoring;

            if (GreekGodsS.Contains(_divine)
                || EgyptianGodsS.Contains(_divine)
                || NordicGodsS.Contains(_divine)
                || AtlanticTitansS.Contains(_divine))
            {
                Divine = _divine;
            }
            GodID = _godID;
        }

        public void godsSetup()
        {
            Gods[] greekGods = new Gods[]
            {
                Zeus, Hades, Poseidon, Aphrodite,
                Hephaestus, Hera, Athena, Ares,
                Hermes, Artemis, Apollo, Dionysus
            };
            //Gods[] egyptianGods = new Gods[]
            //{
            //    Ra, Isis, Set, Horus,
            //    Osiris, Anubis, Bast, Ptah,
            //    Hathor, Thoth, Sekhmet, Nephthys
            //};
            //Gods[] nordicGods = new Gods[]
            //{
            //    Thor, Odin, Loki, Forseti,
            //    Freyja, Hel, Baldr, Tyr,
            //    Heimdall, Skadi, Bragi, Njord
            //};
            //Gods[] atlanticTitans = new Gods[]
            //{
            //    Kronos, Oranos, Gaia, Hekate,
            //    Atlas, Helios, Theia, Rheia,
            //    Hyperion, Oceanus, Prometheus, Leto
            //};

            GreekGods.AddRange(greekGods);
            //EgyptianGods.AddRange(egyptianGods);
            //NordicGods.AddRange(nordicGods);
            //AtlanticTitans.AddRange(atlanticTitans);
        }
        public void xpModifierSetup()
        {
            foreach (Gods divine in GreekGods)
            {
                for (int i = 0; i < divine.Favoring.Split(',').Count(); i++)
                {
                    if (int.Parse(divine.Favoring.Split(',')[i]) > 5)
                    {
                        divine.XpModifier.Add((int.Parse(divine.Favoring.Split(',')[i]) - 5) * 5 / 100);
                    }
                }
            }
            foreach (Gods divine in EgyptianGods)
            {
                for (int i = 0; i < divine.Favoring.Split(',').Count(); i++)
                {
                    if (int.Parse(divine.Favoring.Split(',')[i]) > 5)
                    {
                        divine.XpModifier.Add((int.Parse(divine.Favoring.Split(',')[i]) - 5) * 5 / 100);
                    }
                }
            }
            foreach (Gods divine in NordicGods)
            {
                for (int i = 0; i < divine.Favoring.Split(',').Count(); i++)
                {
                    if (int.Parse(divine.Favoring.Split(',')[i]) > 5)
                    {
                        divine.XpModifier.Add((int.Parse(divine.Favoring.Split(',')[i]) - 5) * 5 / 100);
                    }
                }
            }
            foreach (Gods divine in AtlanticTitans)
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
            List<Gods> output = new List<Gods>();
            List<Gods> searchList = new List<Gods>();

            searchList.AddRange(GreekGods);
            searchList.AddRange(EgyptianGods);
            searchList.AddRange(NordicGods);
            searchList.AddRange(AtlanticTitans);


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
