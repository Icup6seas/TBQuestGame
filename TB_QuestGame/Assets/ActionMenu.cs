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

        public enum CurrentMenu
        {
            MissionIntro,
            InitializeMission,
            MainMenu,
            ObjectMenu,
            NpcMenu,
            WondererMenu,
            AdminMenu
        }

        public static CurrentMenu currentMenu = CurrentMenu.MainMenu;

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
                    { '1', WondererAction.LookAround },
                    { '2', WondererAction.Travel },
                    { '3', WondererAction.ObjectMenu },
                    { '4', WondererAction.NonPlayerCharacterMenu },
                    { '5', WondererAction.WondererMenu },
                    { '6', WondererAction.AdminMenu },
                    { '0', WondererAction.Exit }
                }
        };

        public static Menu WondererMenu = new Menu()
        {
            MenuName = "WondererMenu",
            MenuTitle = "Wonderer Menu",
            MenuChoices = new Dictionary<char, WondererAction>()
                {
                    { '1', WondererAction.WondererInfo },
                    { '2', WondererAction.Inventory},
                    { '3', WondererAction.WondererLocationsVisited},
                    { '0', WondererAction.ReturnToMainMenu }
                }
        };

        public static Menu ObjectMenu = new Menu()
        {
            MenuName = "ObjectMenu",
            MenuTitle = "Object Menu",
            MenuChoices = new Dictionary<char, WondererAction>()
                {
                    { '1', WondererAction.LookAt },
                    { '2', WondererAction.PickUp},
                    { '3', WondererAction.PutDown},
                    { '0', WondererAction.ReturnToMainMenu }
                }
        };

        public static Menu NpcMenu = new Menu()
        {
            MenuName = "NpcMenu",
            MenuTitle = "NPC Menu",
            MenuChoices = new Dictionary<char, WondererAction>()
                {
                    { '1', WondererAction.TalkTo},
                    { '0', WondererAction.ReturnToMainMenu }
                }
        };

        public static Menu AdminMenu = new Menu()
        {
            MenuName = "AdminMenu",
            MenuTitle = "Admin Menu",
            MenuChoices = new Dictionary<char, WondererAction>()
            {
                {'1', WondererAction.ListHomeLocations },
                {'2', WondererAction.ListGameObjects },
                {'3', WondererAction.ListNonPlayerCharacters },
                {'0', WondererAction.ReturnToMainMenu }
            }
        };
    }
}
