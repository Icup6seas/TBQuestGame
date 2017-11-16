using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "The Wonderer" };
        public static List<string> FooterText = new List<string>() { "Evil Odin, 2017" };

        #region INTITIAL GAME SETUP

        public static string MissionIntro()
        {
            string messageBoxText =
            "Keep running!!! Keep running!!! Save yourself!\n" +
            "That was the last thing I remember hearing before they got him.\n" +
            "There was no time to save him, no one has enough strength anymore...\n" +
            " \n" +
            "It's a dark typical night, rainy, stormy night, the kind of night\n" +
            "a nice warm bed would be something to kill for.\n" +
            " \n" +
            "Those days are behind us now, no more warm beds, homes demolished,\n" +
            "that is what you see, everywhere. There are things out there, things only\n" +
            "a post apocalyptic world would bring, things that will not hesitate making you\n" +
            "its meal.\n" +
            " \n" +
            " \n" +
            "...You made it to the nearest house and slammed the door behind you. All you can \n" +
            "do now is wait and hope the deadbolt holds...\n" +
            " \n";
            return messageBoxText;
        }

        public static string InitialLocationInfo()
        {
            string messageBoxText =
            "After racheting the deadbolt, you brace the door with your body, readying " +
            "for impact. " +
            " \n" +
            "Nothing happened...they must have gone away.\n" +
            " \n" +
            "\t...Choose from the menu options to proceed...\n";

            return messageBoxText;
        }
        #endregion

        #region Initialize Wonderer Text

        public static string InitializeMissionIntro()
        {
            string messageBoxText =
                "Too many nights in this cold damp damned place, maybe I should just let them get me...\n" +
                " \n" +
                "I can't, I need to make it, being one of the last might not be so bad.\n" +
                " \n" +
                "\t...Press any key to begin...";

            return messageBoxText;
        }

        public static string InitializeMissionGetWondererName()
        {
            string messageBoxText =
                "It has been a long time since I have been called by my real name \n" +
                "but they call me...\n" +
                " \n" +
                "\t...PLease enter your nickname...";

            return messageBoxText;
        }

        public static string InitializeMissionGetWondererAge(Wonderer gameWonderer)
        {
            string messageBoxText =
                $"Yes, it's {gameWonderer.Name}, it feels good to say that name out loud.\n" +
                "Gives me hope...one day at a time.\n" +
                "I have missed several birthdays but I can do my best.\n" +
                " \n" +
                "...Enter your age below...\n";

            return messageBoxText;
        }

        public static string InitializeMissionGetWondererHeight(Wonderer gameWonderer)
        {
            string messageBoxText =
                $"{gameWonderer.Name}...How would I describe how tall I am? \n" +
                " \n" +
                "Enter your height.\n";

            string heightList = null;

            foreach (Character.HeightType height in Enum.GetValues(typeof(Character.HeightType)))
            {
                if (height != Character.HeightType.None)
                {
                    heightList += $"\t{height}\n";
                }
            }

            messageBoxText += heightList;

            return messageBoxText;
        }

        public static string InitializeMissionEchoWondererInfo(Wonderer gameWonderer)
        {
            string messageBoxText =
                "I just have to let myself know what I am to keep up my moral:\n" +
                " \n" +
                $"\tMy name is {gameWonderer.Name}\n" +
                $"\tTime goes by so fast but I think I'm {gameWonderer.Age}\n" +
                $"\tI am fairly {gameWonderer.Height}\n" +
                " \n" +
                "...Press any key to continue my struggle...";

            return messageBoxText;
        }

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string WondererInfo(Wonderer gameWonderer, HomeUnivLocation currentHomeLocation)
        {
            string messageBoxText =
                $"\tWonderer Name... {gameWonderer.Name}\n" +
                $"\tWonderer Age... {gameWonderer.Age}\n" +
                $"\tWonderer Height... {gameWonderer.Height}\n" +
                $"\tCurrent Location... {currentHomeLocation.CommonName}\n" +
                " \n";

            return messageBoxText;
        }

        public static string CurrentHomeLocationInfo(HomeUnivLocation homeUnivLocation)
        {
            string messageBoxText = $"Current Location: {homeUnivLocation.CommonName}\n" +
                " \n" + homeUnivLocation.Description;

            return messageBoxText;
        }

        public static string LookAround(HomeUnivLocation homeUnivLocation)
        {
            string messageBoxText = $"Current Location: {homeUnivLocation.CommonName}\n" +
                " \n" + homeUnivLocation.GeneralContents;

            return messageBoxText;
        }

        public static string ListHomeLocations(IEnumerable<HomeUnivLocation> homeLocations)
        {
            string messageBoxText = "I need to make a choice now! I can't stay here for long...\n" +
                " \n" +
                "Enter the ID number of the place you want to visit next, you don't have much time. \n" +
                " \n" +

                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "\n";

            string homeLocationList = null;
            foreach (HomeUnivLocation homeLocation in homeLocations)
            {
                homeLocationList +=
                    $"{homeLocation.HomeLocationID}".PadRight(10) +
                    $"{homeLocation.CommonName}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += homeLocationList;

            return messageBoxText;
        }

        public static string ListAllGameObjects(IEnumerable<GameObject> gameObjects)
        {
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Home Location Id".PadRight(10) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) +
                "----------------------".PadRight(10) + "\n";

            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjectRows += 
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    $"{gameObject.HomeLocationId}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        public static string GameObjectsChooseList(IEnumerable<GameObject> gameObjects)
        {
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                "ID".PadRight(10) +
                "Name".PadRight(30) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) + "\n";

            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;

        }


        public static string LookAt(GameObject gameObject)
        {
            string messageBoxText = "";

            messageBoxText =
                $"{gameObject.Name}\n" +
                " \n" +
                gameObject.Description + " \n" +
                " \n";

            if (gameObject is WondererObject)
            {
                WondererObject wondererObject = gameObject as WondererObject;

                messageBoxText += $"The {wondererObject.Name} has a value of {wondererObject.Value} and ";

                if (wondererObject.CanInventory)
                {
                    messageBoxText += "may be added to your bag.";
                }
                else
                {
                    messageBoxText += "cannot be added to your bag.";
                }
            }
            else
            {
                messageBoxText += $"The {gameObject.Name} cannot be added to your bad.";
            }

            return messageBoxText;
        }

        public static string VisitedLocations(IEnumerable<HomeUnivLocation> homeLocations)
        {
            string messageBoxText = "Home Locations Visited\n" +
                " \n" +

                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "\n";

            string homeLocationList = null;
            foreach (HomeUnivLocation homeLocation in homeLocations)
            {
                homeLocationList +=
                    $"{homeLocation.HomeLocationID}".PadRight(10) +
                        $"{homeLocation.CommonName}".PadRight(30) +
                        Environment.NewLine;
            }

            messageBoxText += homeLocationList;

            return messageBoxText;
        }

        public static string Travel(Wonderer gamewonderer, List<HomeUnivLocation> homeUnivLocations)
        {
            string messageBoxText =
                $"{gamewonderer.Name}, wake up!!! I need to move, but where to?! \n" +
                " \n" +
                "Enter the numnber location you want to run to. \n" +
                " \n" +

                "ID".PadRight(10) + "Name".PadRight(30) + "Accessible".PadRight(10) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "-------".PadRight(10) + "\n";

            string homeLocationList = null;
            foreach (HomeUnivLocation homeUnivLocation in homeUnivLocations)
            {
                if (homeUnivLocation.HomeLocationID != gamewonderer.HomeLocationID)
                {
                    homeLocationList +=
                        $"{homeUnivLocation.HomeLocationID}".PadRight(10) +
                        $"{homeUnivLocation.CommonName}".PadRight(30) +
                        $"{homeUnivLocation.Accessable}".PadRight(10) +
                        Environment.NewLine;
                }
            }

            messageBoxText += homeLocationList;

            return messageBoxText;
        }

        public static string CurrentLocationInfo(HomeUnivLocation homeUnivLocation)
        {
            string messageBoxText =
                $"I am in the {homeUnivLocation.CommonName} \n" +
                " \n" +
                homeUnivLocation.Description;

            return messageBoxText;
        }

        public static string CurrentInventory(IEnumerable<WondererObject> inventory)
        {
            string messageBoxText = "";

            messageBoxText =
            "ID".PadRight(10) +
            "Name".PadRight(30) +
            "Type".PadRight(10) +
            "\n" +
            "---".PadRight(10) +
            "----------------------------".PadRight(30) +
            "----------------------".PadRight(10) +
            "\n";
            
            string inventoryObjectRows = null;
            foreach (WondererObject inventoryObject in inventory)
            {
                inventoryObjectRows +=
                    $"{inventoryObject.Id}".PadRight(10) +
                    $"{inventoryObject.Name}".PadRight(30) +
                    $"{inventoryObject.Type}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += inventoryObjectRows;

            return messageBoxText;
        }

        public static List<string> StatusBox(Wonderer wonderer)
        {
            List<string> statusBoxText = new List<string>();

            statusBoxText.Add($"Sanity: {wonderer.Sanity}\n");
            statusBoxText.Add($"Health: {wonderer.Health}\n");
            statusBoxText.Add($"Lives: {wonderer.Lives}\n");

            return statusBoxText;
        }

        #endregion
    }
}
