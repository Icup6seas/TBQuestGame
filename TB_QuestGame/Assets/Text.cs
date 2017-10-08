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

        public static string CurrrentLocationInfo()
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

        public static string InitializeMissionGetWondererRace(Wonderer gameWonderer)
        {
            string messageBoxText =
                $"{gameWonderer.Name}...I can't stop saying that, it makes me happy. Now how would I \n" +
                "What am I? \n" +
                " \n" +
                "...Enter your race...\n";

            string raceList = null;

            foreach (Character.RaceType race in Enum.GetValues(typeof(Character.RaceType)))
            {
                if (race != Character.RaceType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

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

        //public static string InitializeMissionGetWondererSanity(Wonderer gameWonderer)
        //{
        //    string messageBoxText =
        //        $"{gameWonderer.Name}...Take some deep breaths, I need to focus. \n" +
        //        "What's my mindset? \n" +
        //        " \n" +
        //        "...Enter your sanity...\n";

        //    string sanityList = null;

        //    foreach (Character.SanityType sanity in Enum.GetValues(typeof(Character.SanityType)))
        //    {
        //        if (sanity != Character.SanityType.None)
        //        {
        //            sanityList += $"\t{sanity}\n";
        //        }
        //    }

        //    messageBoxText += sanityList;

        //    return messageBoxText;
        //}

        public static string InitializeMissionEchoWondererInfo(Wonderer gameWonderer)
        {
            string messageBoxText =
                "I just have to let myself know what I am to keep up my moral:\n" +
                " \n" +
                $"\tMy name is {gameWonderer.Name}\n" +
                $"\tTime goes by so fast but I think I'm {gameWonderer.Age}\n" +
                $"\tMost importantly, I am still a {gameWonderer.Race}\n" +
                //$"\and that I am {gameWonderer.Sanity}\n" +
                $"\tI feel like I am an average {gameWonderer.Race} and going to say I am fairly {gameWonderer.Height}\n" +
                " \n" +
                "...Press any key to continue my struggle...";

            return messageBoxText;
        }

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string WondererInfo(Wonderer gameWonderer)
        {
            string messageBoxText =
                $"\tWonderer Name... {gameWonderer.Name}\n" +
                $"\tWonderer Age... {gameWonderer.Age}\n" +
                $"\tWonderer Race... {gameWonderer.Race}\n" +
                $"\tWonderer Height... {gameWonderer.Height}\n" +
                //$"\tWonderer Height... {gameWonderer.Sanity}\n" +
                " \n";

            return messageBoxText;
        }

        public static List<string> StatusBox(Wonderer wonderer)
        {
            List<string> statusBoxText = new List<string>();

            //statusBoxText.Add($"Mindset: {wonderer.Sanity}\n");
            //statusBoxText.Add($"Health: {wonderer.Health}\n");

            return statusBoxText;
        }

        //public static string Travel(int currentSpaceTimeLocationId, List<SpaceTimeLocation> spaceTimeLocations)
        //{
        //    string messageBoxText =
        //        $"{gameWonderer.Name}, Aion Base will need to know the name of the new location.\n" +
        //        " \n" +
        //        "Enter the ID number of your desired location from the table below.\n" +
        //        " \n";


        //    string spaceTimeLocationList = null;

        //    foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
        //    {
        //        if (race != Character.RaceType.None)
        //        {
        //            raceList += $"\t{race}\n";
        //        }
        //    }

        //    messageBoxText += raceList;

        //    return messageBoxText;
        //}

        #endregion
    }
}
