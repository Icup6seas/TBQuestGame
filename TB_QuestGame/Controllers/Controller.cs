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
        private HomeUnivLocation _homeLocation;
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
            _playingGame = true;

            Console.CursorVisible = false;
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
            _homeLocation = _gameHome.GetHomeLocationByID(_gameWonderer.HomeLocationID);
            _gameConsoleView.DisplayGamePlayScreen("The House", Text.CurrentLocationInfo(_homeLocation), ActionMenu.MainMenu, "");

            //
            // game loop
            //
            while (_playingGame)
            {
                WondererActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.MainMenu);

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

                    case WondererAction.ListHomeLocations:
                        _gameConsoleView.DisplayListOfHomeLocations();
                        break;

                    case WondererAction.LookAround:
                        _gameConsoleView.DisplayLookAround();
                        break;

                    case WondererAction.Travel:

                        _gameWonderer.HomeLocationID = _gameConsoleView.DisplayGetNextHomeLocation();
                        _homeLocation = _gameHome.GetHomeLocationByID(_gameWonderer.HomeLocationID);

                        _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentHomeLocationInfo(_homeLocation),
                            ActionMenu.MainMenu, "");
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

        /// <summary>
        /// initialize the player info
        /// </summary>
        private void InitializeMission()
        {
            Wonderer Wonderer = _gameConsoleView.GetInitialWondererInfo();

            _gameWonderer.Name = Wonderer.Name;
            _gameWonderer.Age = Wonderer.Age;
            _gameWonderer.Race = Wonderer.Race;
            _gameWonderer.Height = Wonderer.Height;
            _gameWonderer.Sanity = Wonderer.Sanity;
        }

        #endregion
    }
}
