using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// static class to hold key/value pairs for menu options
    /// </summary>
    public static class ActionMenu
    {
        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, WondererAction>()
                    {
                        { ' ', WondererAction.None }
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, WondererAction>()
                {
                    { '1', WondererAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, WondererAction>()
                {
                    { '1', WondererAction.WondererInfo },
                    { '2', WondererAction.LookAround },
                    { '3', WondererAction.LookAt },
                    { '4', WondererAction.Travel },
                    { '5', WondererAction.WondererLocationsVisited },
                    { '6', WondererAction.ListHomeLocations },
                    { '7', WondererAction.ListGameObjects },
                    { '0', WondererAction.Exit }
                }
        };

        public static Menu AdminMenu = new Menu()
        {



        };
    }
}
