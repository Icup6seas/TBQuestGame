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
                    { '3', WondererAction.Travel },
                    { '4', WondererAction.WondererLocationsVisited },
                    { '5', WondererAction.ListHomeLocations },
                    { '6', WondererAction.ListGameObjects },
                    { '0', WondererAction.Exit }
                }
        };

        //public static Menu ManageWonderer = new Menu()
        //{
        //    MenuName = "ManageWonderer",
        //    MenuTitle = "Manage Wonderer",
        //    MenuChoices = new Dictionary<char, PlayerAction>()
        //            {
        //                PlayerAction.MissionSetup,
        //                PlayerAction.WondererInfo,
        //                PlayerAction.Exit
        //            }
        //};
    }
}
