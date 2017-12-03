using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// controller for the MVC pattern in the application
    /// </summary>
    public class Controller
    {
        #region FIELDS

        private ConsoleView _gameConsoleView;
        private Wonderer _gameWonderer;
        private Home _gameHome;
        private HomeUnivLocation _currentLocation;
        private bool _playingGame;

        #endregion

        #region PROPERTIES


        #endregion

        #region CONSTRUCTORS

        public Controller()
        {
            //
            // setup all of the objects in the game
            //
            InitializeGame();

            //
            // begins running the application UI
            //
            ManageGameLoop();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initialize the major game objects
        /// </summary>
        private void InitializeGame()
        {
            _gameWonderer = new Wonderer();
            _gameHome = new Home();
            _gameConsoleView = new ConsoleView(_gameWonderer, _gameHome);
            WondererObject wondererObject;
            _playingGame = true;

            _gameWonderer.Inventory.Add(_gameHome.GetGameObjectById(11) as WondererObject);
            _gameWonderer.Inventory.Add(_gameHome.GetGameObjectById(12) as WondererObject);

            foreach (GameObject gameObject in _gameHome.GameObjects)
            {
                if (gameObject is WondererObject)
                {
                    // casting
                    wondererObject = gameObject as WondererObject;
                    wondererObject.ObjectAddedToInventory += HandleObjectAddedToInventory;
                    wondererObject.ObjectDeletedFromInventory += HandleObjectDeletedFromInventory;
                }
            }

            Console.CursorVisible = false;
        }

        private void HandleObjectAddedToInventory(object gameObject, EventArgs e)
        {
            if (gameObject.GetType() == typeof(WondererObject))
            {
                WondererObject wondererObject = gameObject as WondererObject;
                switch (wondererObject.Type)
                {
                    case WondererObjectType.Food:
                        _gameWonderer.Health += wondererObject.Value;

                        if (_gameWonderer.Health >= 100)
                        {
                            _gameWonderer.Health = 100;
                            _gameWonderer.Lives += 1;
                        }
                        if (wondererObject.IsConsumable)
                        {
                            wondererObject.HomeLocationId = -1;
                        }
                        break;

                    case WondererObjectType.Medicine:
                        _gameWonderer.Sanity += wondererObject.Value;

                        if (_gameWonderer.Sanity >= 100)
                        {
                            _gameWonderer.Sanity = 100;
                        }
                        if (wondererObject.IsConsumable)
                        {
                            wondererObject.HomeLocationId = -1;
                        }
                        
                        break;
                    case WondererObjectType.Weapon:
                        break;
                    case WondererObjectType.Stuff:
                        break;
                    case WondererObjectType.Key:
                        if (wondererObject.Id == 6)
                        {
                            _gameHome.GetHomeLocationByID(3).Accessable = true;
                        }
                        if (wondererObject.Id == 7)
                        {
                            _gameHome.GetHomeLocationByID(4).Accessable = true;
                        }
                        if (wondererObject.IsConsumable)
                        {
                            wondererObject.HomeLocationId = -1;
                        }
                        break;
                    case WondererObjectType.Information:
                        break;
                    default:
                        break;
                }
            }
        }

        private void HandleObjectDeletedFromInventory(object gameObject, EventArgs e)
        {
            if (gameObject.GetType() == typeof(WondererObject))
            {
                WondererObject wondererObject = gameObject as WondererObject;
                switch (wondererObject.Type)
                {
                    case WondererObjectType.Key:
                        if (wondererObject.Id == 6)
                        {
                            _gameHome.GetHomeLocationByID(3).Accessable = false;
                        }
                        if (wondererObject.Id == 7)
                        {
                            _gameHome.GetHomeLocationByID(4).Accessable = false;
                        }
                        //if (wondererObject.IsConsumable)
                        //{
                        //    wondererObject.HomeLocationId = -1;
                        //}
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// method to manage the application setup and game loop
        /// </summary>
        private void ManageGameLoop()
        {
            WondererAction WondererActionChoice = WondererAction.None;

            //
            // display splash screen
            //
            _playingGame = _gameConsoleView.DisplaySpashScreen();

            //
            // player chooses to quit
            //
            if (!_playingGame)
            {
                Environment.Exit(1);
            }

            //
            // display introductory message
            //
            _gameConsoleView.DisplayGamePlayScreen("Run!!!", Text.MissionIntro(), ActionMenu.MissionIntro, "");
            _gameConsoleView.GetContinueKey();

            //
            // initialize the mission Wonderer
            // 
            InitializeMission();

            //
            // prepare game play screen
            //
            _currentLocation = _gameHome.GetHomeLocationByID(_gameWonderer.HomeLocationID);
            _gameConsoleView.DisplayGamePlayScreen("The House", Text.CurrentLocationInfo(_currentLocation), ActionMenu.MainMenu, "");

            //
            // game loop
            //
            while (_playingGame)
            {

                UpdateGameStatus();

                WondererActionChoice = GetNextWondererAction();
                

                //
                // choose an action based on the user's menu choice
                //
                switch (WondererActionChoice)
                {
                    case WondererAction.None:
                        break;

                    case WondererAction.WondererInfo:
                        _gameConsoleView.DisplayWondererInfo();
                        break;

                    case WondererAction.Inventory:
                        _gameConsoleView.DisplayInventory();
                        break;

                    case WondererAction.TalkTo:
                        TalkToAction();
                        break;

                    case WondererAction.ListHomeLocations:
                        _gameConsoleView.DisplayListOfHomeLocations();
                        break;

                    case WondererAction.ListGameObjects:
                        _gameConsoleView.DisplayListOfAllGameObjects();
                        break;

                    case WondererAction.ListNonPlayerCharacters:
                        _gameConsoleView.DisplayListOfAllNpcObjects();
                        break;

                    case WondererAction.WondererMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.WondererMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Wonderer Menu", "Select an operation from the menu.", ActionMenu.WondererMenu, "");
                        break;

                    case WondererAction.ObjectMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.ObjectMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Object Menu", "Select an operation from the menu.", ActionMenu.ObjectMenu, "");
                        break;

                    case WondererAction.NonPlayerCharacterMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.NpcMenu;
                        _gameConsoleView.DisplayGamePlayScreen("NPC Menu", "Select an operation from the menu.", ActionMenu.NpcMenu, "");
                        break;

                    case WondererAction.AdminMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.AdminMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Admin Menu", "Select an operation from the menu.", ActionMenu.AdminMenu, "");
                        break;

                    case WondererAction.ReturnToMainMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.MainMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentHomeLocationInfo(_currentLocation),ActionMenu.MainMenu, "");
                        break;

                    case WondererAction.LookAround:
                        _gameConsoleView.DisplayLookAround();
                        break;

                    case WondererAction.Travel:

                        _gameWonderer.HomeLocationID = _gameConsoleView.DisplayGetNextHomeLocation();
                        _currentLocation = _gameHome.GetHomeLocationByID(_gameWonderer.HomeLocationID);

                        _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentHomeLocationInfo(_currentLocation),
                            ActionMenu.MainMenu, "");
                        break;

                    case WondererAction.WondererLocationsVisited:
                        _gameConsoleView.DisplayLocationsVisited();
                        break;

                    case WondererAction.LookAt:
                        LookAtAction();
                        break;

                    case WondererAction.PickUp:
                        PickUpAction();
                        break;

                    case WondererAction.PutDown:
                        PutDownAction();
                        break;

                    case WondererAction.Exit:
                        _playingGame = false;
                        break;

                    default:
                        break;
                }
            }

            //
            // close the application
            //
            Environment.Exit(1);
        }

        private WondererAction GetNextWondererAction()
        {
            WondererAction wondererActionChoice = WondererAction.None;

            switch (ActionMenu.currentMenu)
            {
                case ActionMenu.CurrentMenu.MainMenu:
                    wondererActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.MainMenu);
                    break;

                case ActionMenu.CurrentMenu.ObjectMenu:
                    wondererActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.ObjectMenu);
                    break;

                case ActionMenu.CurrentMenu.NpcMenu:
                    wondererActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.NpcMenu);
                    break;

                case ActionMenu.CurrentMenu.WondererMenu:
                    wondererActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.WondererMenu);
                    break;

                case ActionMenu.CurrentMenu.AdminMenu:
                    wondererActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.AdminMenu);
                    break;

                default:
                    break;
            }

            return wondererActionChoice;
        }

        private void LookAtAction()
        {
            int gameObjectToLookAtID = _gameConsoleView.DisplayGetGameObjectToLookAt();

            if (gameObjectToLookAtID != 0)
            {
                GameObject gameObject = _gameHome.GetGameObjectById(gameObjectToLookAtID);

                _gameConsoleView.DisplayGameObjectInfo(gameObject);
            }
        }

        private void PickUpAction()
        {
            int wondererObjectToPickUpId = _gameConsoleView.DisplayGetWondererObjectToPickUp();

            if (wondererObjectToPickUpId != 0)
            {
                WondererObject wondererObject = _gameHome.GetGameObjectById(wondererObjectToPickUpId) as WondererObject;

                _gameWonderer.Inventory.Add(wondererObject);
                wondererObject.HomeLocationId = 0;

                _gameConsoleView.DisplayConfirmTravelerObjectAddedToInventory(wondererObject);
            }
        }

        private void PutDownAction()
        {
            int inventoryObjectToPutDownId = _gameConsoleView.DisplayGetInventoryObjectToPutDown();

            WondererObject wondererObject = _gameHome.GetGameObjectById(inventoryObjectToPutDownId) as WondererObject;

            _gameWonderer.Inventory.Remove(wondererObject);
            wondererObject.HomeLocationId = _gameWonderer.HomeLocationID;

            _gameConsoleView.DisplayConfirmTravelerObjectAddedToInventory(wondererObject);
        }

        private void TalkToAction()
        {
            int npcToTalkToId = _gameConsoleView.DisplayGetNpcToTalkTo();

            if (npcToTalkToId != 0)
            {
                Npc npc = _gameHome.GetNpcById(npcToTalkToId);

                _gameConsoleView.DisplayTalkTo(npc);
            }
        }

        /// <summary>
        /// initialize the player info
        /// </summary>
        private void InitializeMission()
        {
            Wonderer Wonderer = _gameConsoleView.GetInitialWondererInfo();

            _gameWonderer.Name = Wonderer.Name;
            _gameWonderer.Age = Wonderer.Age;
            _gameWonderer.Height = Wonderer.Height;
            _gameWonderer.Sanity = 100;
            _gameWonderer.Health = 100;
            _gameWonderer.Lives = 3;
        }

        private void UpdateGameStatus()
        {
            if (!_gameWonderer.HasVisited(_currentLocation.HomeLocationID))
            {
                _gameWonderer.HomeLocationsVisited.Add(_currentLocation.HomeLocationID);

            }

            if (_gameWonderer.HomeLocationID >= 2)
            {
                _gameWonderer.Sanity -= 2;

                if (_gameWonderer.Health <= 0 || _gameWonderer.Sanity <= 0)
                {
                    _gameWonderer.Lives -= 1;
                    Console.WriteLine("You have body has been too tortured, you have died!");

                    if (_gameWonderer.Health <= 0)
                    {
                        _gameWonderer.Health += 100;
                        _gameWonderer.Sanity += 100;
                    }
                }
            }
        }

        #endregion
    }
}
