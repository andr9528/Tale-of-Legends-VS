﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Storage
    {
        // Gods
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

        List<Gods> greekGods = new List<Gods>(); 
        List<Gods> egyptianGods = new List<Gods>();
        List<Gods> nordicGods = new List<Gods>();
        List<Gods> atlanticTitans = new List<Gods>();

        List<string> godGreekString = new List<string>();
        List<string> godEgyptianString = new List<string>();
        List<string> godNordicString = new List<string>();
        List<string> godAtlanticString = new List<string>();

        public List<string> GodGreekString { get { return godGreekString; } }
        public List<string> GodEgyptianString { get { return godEgyptianString; } }
        public List<string> GodNordicString { get { return godNordicString; } }
        public List<string> GodAtlanticString { get { return godAtlanticString; } }
        public List<Gods> GreekGods { get { return greekGods; } }
        public List<Gods> EgyptianGods { get { return egyptianGods; } }
        public List<Gods> NordicGods { get { return nordicGods; } }
        public List<Gods> AtlanticTitans { get { return atlanticTitans; } }


        // Skills
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

        List<Skill> skillList = new List<Skill>();
        List<string> skillString = new List<string>();
        public List<string> SkillString { get { return skillString; } }
        public List<Skill> SkillList { get { return skillList; } }
        
        // Functions
        public void setup()
        {
            List<Skill> skillSkillSetup = new List<Skill>()
           {
                Archery, OneHanded, TwoHanded, LightArmor,
                HeavyArmor, Stealth, Agility, Smighting,
                Enchanting, Alchemy, Blocking, WildMagic,
                InfernoMagic, BlizzMagic, Skymagic, PureMagic
           };

            List<Gods> godsGreekSetup = new List<Gods>()
            {
                Zeus, Hades, Poseidon, Aphrodite,
                Hephaestus, Hera, Athena, Ares,
                Hermes, Artemis, Apollo, Dionysus
            };

            //List<Gods> egyptianGodsSetup = new List<Gods>();
            //{
            //    Ra, Isis, Set, Horus,
            //    Osiris, Anubis, Bast, Ptah,
            //    Hathor, Thoth, Sekhmet, Nephthys
            //};

            // List<Gods> nordicGodsSetup = new List<Gods>();
            //{
            //    Thor, Odin, Loki, Forseti,
            //    Freyja, Hel, Baldr, Tyr,
            //    Heimdall, Skadi, Bragi, Njord
            //};

            //List<Gods> atlanticTitansSetup = new List<Gods>();
            //{
            //    Kronos, Oranos, Gaia, Hekate,
            //    Atlas, Helios, Theia, Rheia,
            //    Hyperion, Oceanus, Prometheus, Leto
            //};

            List<string> stringSkillSetup = new List<string>()
        {
            "Archery", "OneHanded", "TwoHanded", "LightArmor",
            "HeavyArmor", "Stealth", "Agility", "Smighting",
            "Enchanting", "Alchemy", "Blocking", "WildMagic",
            "InfernoMagic", "BlizzMagic", "Skymagic", "PureMagic"
        };
            List<string> godGreekStringSetup = new List<string>()
        {
            "Zeus", "Hades", "Poseidon", "Aphrodite",
            "Hephaestus", "Hera", "Athena", "Ares",
            "Hermes", "Artemis", "Apollo", "Dionysus"
        };
            List<string> godEgyptianStringSetup = new List<string>()
        {
            "Ra", "Isis", "Set", "Horus",
            "Osiris", "Anubis", "Bast", "Ptah",
            "Hathor", "Thoth", "Sekhmet", "Nephthys"
        };
            List<string> godNordicStringSetup = new List<string>()
        {
            "Thor", "Odin", "Loki", "Forseti",
            "Freyja", "Hel", "Baldr", "Tyr",
            "Heimdall", "Skadi", "Bragi", "Njord"
        };
            List<string> godAtlanticStringSetup = new List<string>()
        {
            "Kronos", "Oranos", "Gaia", "Hekate",
            "Atlas", "Helios", "Theia", "Rheia",
            "Hyperion", "Oceanus", "Prometheus", "Leto"
        };

            godGreekString = godGreekStringSetup;
            godEgyptianString = godEgyptianStringSetup;
            godNordicString = godNordicStringSetup;
            godAtlanticString = godAtlanticStringSetup;
            greekGods = godsGreekSetup;
            //EgyptianGods = egyptianGodsSetup
            //NordicGods = nordicGodsSetup
            //AtlanticTitans = atlanticTitansSetup
            skillString = stringSkillSetup;
            skillList = skillSkillSetup;
        }

    }
}
