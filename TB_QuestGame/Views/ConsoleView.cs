using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// view class
    /// </summary>
    public class ConsoleView
    {
        #region ENUMS

        private enum ViewStatus
        {
            WondererInitialization,
            PlayingGame
        }

        #endregion

        #region FIELDS

        //
        // declare game objects for the ConsoleView object to use
        //
        Wonderer _gameWonderer;
        Home _gameHome;

        ViewStatus _viewStatus;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// default constructor to create the console view objects
        /// </summary>
        public ConsoleView(Wonderer gameWonderer, Home gameHome)
        {
            _gameWonderer = gameWonderer;
            _gameHome = gameHome;

            _viewStatus = ViewStatus.WondererInitialization;

            InitializeDisplay();
        }

        #endregion

        #region METHODS
        /// <summary>
        /// display all of the elements on the game play screen on the console
        /// </summary>
        /// <param name="messageBoxHeaderText">message box header title</param>
        /// <param name="messageBoxText">message box text</param>
        /// <param name="menu">menu to use</param>
        /// <param name="inputBoxPrompt">input box text</param>
        public void DisplayGamePlayScreen(string messageBoxHeaderText, string messageBoxText, Menu menu, string inputBoxPrompt)
        {
            //
            // reset screen to default window colors
            //
            Console.BackgroundColor = ConsoleTheme.WindowBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.WindowForegroundColor;
            Console.Clear();

            ConsoleWindowHelper.DisplayHeader(Text.HeaderText);
            ConsoleWindowHelper.DisplayFooter(Text.FooterText);

            DisplayMessageBox(messageBoxHeaderText, messageBoxText);
            DisplayMenuBox(menu);
            DisplayInputBox();
            DisplayStatusBox();
        }

        /// <summary>
        /// wait for any keystroke to continue
        /// </summary>
        public void GetContinueKey()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// get a action menu choice from the user
        /// </summary>
        /// <returns>action menu choice</returns>
        public WondererAction GetActionMenuChoice(Menu menu)
        {
            WondererAction choosenAction = WondererAction.None;
            Console.CursorVisible = false;

            //creates a array of valid keys from the dictionary
            char[] validKeys = menu.MenuChoices.Keys.ToArray();

            //validation of key pressed in MenuChoices dictionary
            char keyPressed;
            do
            {
                ConsoleKeyInfo keyPressedInfo = Console.ReadKey(true);
                keyPressed = keyPressedInfo.KeyChar;
            } while (!validKeys.Contains(keyPressed));

            choosenAction = menu.MenuChoices[keyPressed];
            Console.CursorVisible = false;

            return choosenAction;
        }

        /// <summary>
        /// get a string value from the user
        /// </summary>
        /// <returns>string value</returns>
        public string GetString()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// get an integer value from the user
        /// </summary>
        /// <returns>integer value</returns>
        public bool GetInteger(string prompt, int minimumValue, int maximumValue, out int integerChoice)
        {
            bool validResponse = false;
            integerChoice = 0;

            DisplayInputBoxPrompt(prompt);
            while (!validResponse)
            {
                if (int.TryParse(Console.ReadLine(), out integerChoice))
                {
                    if (integerChoice >= minimumValue && integerChoice <= maximumValue)
                    {
                        validResponse = true;
                    }
                    else
                    {
                        ClearInputBox();
                        DisplayInputErrorMessage($"You must enter an integer value between {minimumValue} and {maximumValue}. Please try again.");
                        DisplayInputBoxPrompt(prompt);
                    }
                }
                else
                {
                    ClearInputBox();
                    DisplayInputErrorMessage($"You must enter an integer value between {minimumValue} and {maximumValue}. Please try again.");
                    DisplayInputBoxPrompt(prompt);
                }
            }

            return true;
        }

        /// <summary>
        /// get a character race value from the user
        /// </summary>
        /// <returns>character race value</returns>
        public Character.RaceType GetRace()
        {
            Character.RaceType raceType;
            Enum.TryParse<Character.RaceType>(Console.ReadLine(), out raceType);

            return raceType;
        }

        /// <summary>
        /// get a character height value from the user
        /// </summary>
        /// <returns></returns>
        public Character.HeightType GetHeight()
        {
            Character.HeightType heightType;
            Enum.TryParse<Character.HeightType>(Console.ReadLine(), out heightType);

            return heightType;
        }

        //public Character.SanityType GetSanity()
        //{
        //    Character.SanityType sanityType;
        //    Enum.TryParse<Character.SanityType>(Console.ReadLine(), out sanityType);

        //    return sanityType;
        //}

        /// <summary>
        /// display splash screen
        /// </summary>
        /// <returns>player chooses to play</returns>
        public bool DisplaySpashScreen()
        {
            bool playing = true;
            ConsoleKeyInfo keyPressed;

            Console.BackgroundColor = ConsoleTheme.SplashScreenBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.SplashScreenForegroundColor;
            Console.Clear();
            Console.CursorVisible = false;


            Console.SetCursorPosition(0, 10);
            string tabSpace = new String(' ', 25);
            Console.WriteLine(tabSpace + @" _____   _   _   _____        _          __  _____   __   _   _____   _____   _____    _____   _____ ");
            Console.WriteLine(tabSpace + @"|_   _| | | | | | ____|      | |        / / /  _  \ |  \ | | |  _  \ | ____| |  _  \  | ____| |  _  \");
            Console.WriteLine(tabSpace + @"  | |   | |_| | | |__        | |  __   / /  | | | | |   \| | | | | | | |__   | |_| |  | |__   | |_| |");
            Console.WriteLine(tabSpace + @"  | |   |  _  | |  __|       | | /  | / /   | | | | | |\   | | | | | |  __|  |  _  /  |  __|  |  _  /");
            Console.WriteLine(tabSpace + @"  | |   | | | | | |___       | |/   |/ /    | |_| | | | \  | | |_| | | |___  | | \ \  | |___  | | \ \");
            Console.WriteLine(tabSpace + @"  |_|   |_| |_| |_____|      |___/|___/     \_____/ |_|  \_| |_____/ |_____| |_|  \_\ |_____| |_|  \_\");

            Console.SetCursorPosition(87, 16);
            Console.Write("Press any key to continue or Esc to exit");
            keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Escape)
            {
                playing = false;
            }

            return playing;
        }

        /// <summary>
        /// initialize the console window settings
        /// </summary>
        private static void InitializeDisplay()
        {
            //
            // control the console window properties
            //
            ConsoleWindowControl.DisableResize();
            ConsoleWindowControl.DisableMaximize();
            ConsoleWindowControl.DisableMinimize();
            Console.Title = "The Wonderer";

            //
            // set the default console window values
            //
            ConsoleWindowHelper.InitializeConsoleWindow();

            Console.CursorVisible = false;
        }

        /// <summary>
        /// display the correct menu in the menu box of the game screen
        /// </summary>
        /// <param name="menu">menu for current game state</param>
        private void DisplayMenuBox(Menu menu)
        {
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuBorderColor;

            //
            // display menu box border
            //
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.MenuBoxPositionTop,
                ConsoleLayout.MenuBoxPositionLeft,
                ConsoleLayout.MenuBoxWidth,
                ConsoleLayout.MenuBoxHeight);

            //
            // display menu box header
            //
            Console.BackgroundColor = ConsoleTheme.MenuBorderColor;
            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;
            Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 2, ConsoleLayout.MenuBoxPositionTop + 1);
            Console.Write(ConsoleWindowHelper.Center(menu.MenuTitle, ConsoleLayout.MenuBoxWidth - 4));

            //
            // display menu choices
            //
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;
            int topRow = ConsoleLayout.MenuBoxPositionTop + 3;

            foreach (KeyValuePair<char, WondererAction> menuChoice in menu.MenuChoices)
            {
                if (menuChoice.Value != WondererAction.None)
                {
                    string formatedMenuChoice = ConsoleWindowHelper.ToLabelFormat(menuChoice.Value.ToString());
                    Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 3, topRow++);
                    Console.Write($"{menuChoice.Key}. {formatedMenuChoice}");
                }
            }
        }

        /// <summary>
        /// display the text in the message box of the game screen
        /// </summary>
        /// <param name="headerText"></param>
        /// <param name="messageText"></param>
        private void DisplayMessageBox(string headerText, string messageText)
        {
            //
            // display the outline for the message box
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxBorderColor;
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.MessageBoxPositionTop,
                ConsoleLayout.MessageBoxPositionLeft,
                ConsoleLayout.MessageBoxWidth,
                ConsoleLayout.MessageBoxHeight);

            //
            // display message box header
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBorderColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxForegroundColor;
            Console.SetCursorPosition(ConsoleLayout.MessageBoxPositionLeft + 2, ConsoleLayout.MessageBoxPositionTop + 1);
            Console.Write(ConsoleWindowHelper.Center(headerText, ConsoleLayout.MessageBoxWidth - 4));

            //
            // display the text for the message box
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxForegroundColor;
            List<string> messageTextLines = new List<string>();
            messageTextLines = ConsoleWindowHelper.MessageBoxWordWrap(messageText, ConsoleLayout.MessageBoxWidth - 4);

            int startingRow = ConsoleLayout.MessageBoxPositionTop + 3;
            int endingRow = startingRow + messageTextLines.Count();
            int row = startingRow;
            foreach (string messageTextLine in messageTextLines)
            {
                Console.SetCursorPosition(ConsoleLayout.MessageBoxPositionLeft + 2, row);
                Console.Write(messageTextLine);
                row++;
            }

        }

        public void DisplayStatusBox()
        {
            Console.BackgroundColor = ConsoleTheme.InputBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.InputBoxBorderColor;

            //
            // display the outline for the status box
            //
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.StatusBoxPositionTop,
                ConsoleLayout.StatusBoxPositionLeft,
                ConsoleLayout.StatusBoxWidth,
                ConsoleLayout.StatusBoxHeight);

            //
            // display the text for the status box if playing game
            //
            if (_viewStatus == ViewStatus.PlayingGame)
            {
                //
                // display status box header with title
                //
                Console.BackgroundColor = ConsoleTheme.StatusBoxBorderColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
                Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 2, ConsoleLayout.StatusBoxPositionTop + 1);
                Console.Write(ConsoleWindowHelper.Center("Health and Sanity", ConsoleLayout.StatusBoxWidth - 4));
                Console.BackgroundColor = ConsoleTheme.StatusBoxBackgroundColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;

                //
                // display stats
                //
                int startingRow = ConsoleLayout.StatusBoxPositionTop + 3;
                int row = startingRow;
                foreach (string statusTextLine in Text.StatusBox(_gameWonderer))
                {
                    Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 3, row);
                    Console.Write(statusTextLine);
                    row++;
                }
            }
            else
            {
                //
                // display status box header without header
                //
                Console.BackgroundColor = ConsoleTheme.StatusBoxBorderColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
                Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 2, ConsoleLayout.StatusBoxPositionTop + 1);
                Console.Write(ConsoleWindowHelper.Center("", ConsoleLayout.StatusBoxWidth - 4));
                Console.BackgroundColor = ConsoleTheme.StatusBoxBackgroundColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
            }
        }

        /// <summary>
        /// draw the input box on the game screen
        /// </summary>
        public void DisplayInputBox()
        {
            Console.BackgroundColor = ConsoleTheme.InputBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.InputBoxBorderColor;

            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.InputBoxPositionTop,
                ConsoleLayout.InputBoxPositionLeft,
                ConsoleLayout.InputBoxWidth,
                ConsoleLayout.InputBoxHeight);
        }

        /// <summary>
        /// display the prompt in the input box of the game screen
        /// </summary>
        /// <param name="prompt"></param>
        public void DisplayInputBoxPrompt(string prompt)
        {
            Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + 1);
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
            Console.Write(prompt);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// display the error message in the input box of the game screen
        /// </summary>
        /// <param name="errorMessage">error message text</param>
        public void DisplayInputErrorMessage(string errorMessage)
        {
            Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + 2);
            Console.ForegroundColor = ConsoleTheme.InputBoxErrorMessageForegroundColor;
            Console.Write(errorMessage);
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
            Console.CursorVisible = true;
        }

        /// <summary>
        /// clear the input box
        /// </summary>
        private void ClearInputBox()
        {
            string backgroundColorString = new String(' ', ConsoleLayout.InputBoxWidth - 4);

            Console.ForegroundColor = ConsoleTheme.InputBoxBackgroundColor;
            for (int row = 1; row < ConsoleLayout.InputBoxHeight - 2; row++)
            {
                Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + row);
                DisplayInputBoxPrompt(backgroundColorString);
            }
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
        }

        /// <summary>
        /// get the player's initial information at the beginning of the game
        /// </summary>
        /// <returns>Wonderer object with all properties updated</returns>
        public Wonderer GetInitialWondererInfo()
        {
            Wonderer Wonderer = new Wonderer();

            //
            // intro
            //
            DisplayGamePlayScreen("I can't die, I mustn't die", Text.InitializeMissionIntro(), ActionMenu.MissionIntro, "");
            GetContinueKey();

            //
            // get Wonderer's name
            //
            DisplayGamePlayScreen("Long Lost Name", Text.InitializeMissionGetWondererName(), ActionMenu.MissionIntro, "");
            DisplayInputBoxPrompt("Enter your name: ");
            Wonderer.Name = GetString();

            //
            // get Wonderer's age
            //
            DisplayGamePlayScreen("Too many birthdays gone by, too little presents", Text.InitializeMissionGetWondererAge(Wonderer), ActionMenu.MissionIntro, "");
            int gameWondererAge;

            GetInteger($"Enter your age {Wonderer.Name}: ", 0, 1000000, out gameWondererAge);
            Wonderer.Age = gameWondererAge;

            //
            // get height
            //
            DisplayGamePlayScreen("They can't take away who I am, but they might be able to change what I will become.", Text.InitializeMissionGetWondererHeight(Wonderer), ActionMenu.MissionIntro, "");
            DisplayInputBoxPrompt($"Enter your height {Wonderer.Name}: ");
            Wonderer.Height = GetHeight();

            //
            // get sanity
            //
            //DisplayGamePlayScreen("A mind is a terrible thing to waste.", Text.InitializeMissionGetWondererSanity(Wonderer), ActionMenu.MissionIntro, "");
            //DisplayInputBoxPrompt($"{Wonderer.Name}, I can only describe myself as feeling... ");
            //Wonderer.Sanity = GetSanity();

            //
            // get Wonderer's race
            //
            DisplayGamePlayScreen("They can't take away who I am, but they might be able to change what I will become.", Text.InitializeMissionGetWondererRace(Wonderer), ActionMenu.MissionIntro, "");
            DisplayInputBoxPrompt($"Enter your race {Wonderer.Name}: ");
            Wonderer.Race = GetRace();

            //
            // echo the Wonderer's info
            //
            DisplayGamePlayScreen("My life flashes before my eyes, often", Text.InitializeMissionEchoWondererInfo(Wonderer), ActionMenu.MissionIntro, "");
            GetContinueKey();

            _viewStatus = ViewStatus.PlayingGame;

            return Wonderer;
        }

        public void DisplayLookAround()
        {
            HomeUnivLocation currentHomeLocation = _gameHome.GetHomeLocationByID(_gameWonderer.HomeLocationID);
            DisplayGamePlayScreen("I am currently in the ", Text.LookAround(currentHomeLocation), ActionMenu.MainMenu, "");
        }

        public int DisplayGetNextHomeLocation()
        {
            int homeLocationID = 0;
            bool validHomeLocationID = false;

            DisplayGamePlayScreen("Go to another location", Text.Travel(_gameWonderer, _gameHome.HomeLocations),
                ActionMenu.MainMenu, "");

            while (!validHomeLocationID)
            {
                GetInteger($"{_gameWonderer.Name}! Wake up! Where am I going to go!?: ", 1,
                    _gameHome.GetMaxHomeLocationID(), out homeLocationID);

                if (_gameHome.IsValidHomeLocationID(homeLocationID))
                {


                    if (_gameHome.GetHomeLocationByID(homeLocationID).Accessable)
                    {
                        validHomeLocationID = true;
                    }
                    else
                    {
                        ClearInputBox();
                        DisplayInputErrorMessage("I can't go there! Try again! Quickly!!!");
                    }
                }
                else
                {
                    DisplayInputErrorMessage("{Please! I need to enter a correct Location ID, Try again!");
                }
            }

            return homeLocationID;
        }

        public void DisplayLocationsVisited()
        {
            List<HomeUnivLocation> visitedHomeLocations = new List<HomeUnivLocation>();
            foreach (int homeLocationID in _gameWonderer.HomeLocationsVisited)
            {
                visitedHomeLocations.Add(_gameHome.GetHomeLocationByID(homeLocationID));
            }

            DisplayGamePlayScreen("Home Locations Visited", Text.VisitedLocations(visitedHomeLocations), ActionMenu.MainMenu, "");
        }

            public void DisplayListOfHomeLocations()
            {
                DisplayGamePlayScreen("List: Home Locations", Text.ListHomeLocations(_gameHome.HomeLocations), ActionMenu.MainMenu, "");
            }

            #region ----- display responses to menu action choices -----

            public void DisplayWondererInfo()
            {
                HomeUnivLocation currentHomeLocation = _gameHome.GetHomeLocationByID(_gameWonderer.HomeLocationID);
                DisplayGamePlayScreen("Wonderer Information", Text.WondererInfo(_gameWonderer, currentHomeLocation), ActionMenu.MainMenu, "");
            }

            #endregion

            #endregion
        }
    }
