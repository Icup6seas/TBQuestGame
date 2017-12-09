using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame.Assets
{
    public static partial class HomeObjectLocations
    {
        public static List<HomeUnivLocation> HomeLocations = new List<HomeUnivLocation>()
        {
            new HomeUnivLocation
            {
                CommonName = "Front Enterance",
                HomeLocationID = 0,
                HomeLocation = "Decrepit Main Enterance",
                Description = "Slamming the door shut. You brace it with your back and you instinctively " +
                    "scan the room for your next plan, where to run, where to hide, what you can use as a " +
                    "weapon. It's very dark and hard to see but you notice that you're close to the living room, " +
                    "one that would have had a loving family, one that would have celebrated many holdays over " +
                    "the years. \n",
                GeneralContents = "You see a large room, filled with old disty spider webs, small shrubs and " +
                "other vegitation rittled the place. What was left of the carpet is now decompsing under your " +
                "feet. The subfloor is creaking, any moment could give. You see a fireplace to your far right " +
                "a severly splintered entertainment center to your left, against the wall. Also, what you think " +
                "looks like a couch left over towards the wall ahead of you. \n",
                Accessable = true,

            },

            new HomeUnivLocation
            {
                CommonName = "Living Room",
                HomeLocationID = 1,
                HomeLocation = "North-east corner of the room",
                Description = "Hidden in the far right corner of the room is a well used fireplace. \n",
                GeneralContents = "A standard, well used, fireplace, " +
                    "no wood left to light " +
                    "these dark times. \n",
                Accessable = true,
            },

            new HomeUnivLocation
            {
                CommonName = "Kitchen",
                HomeLocationID = 2,
                HomeLocation = "An open kitchen, battered island in the middle, it's a little dark to see.",
                Description = "No running water, hasn't been running for a long while now. Lots of drawers around, I should take a look.",
                GeneralContents = "Fixtures, cabinets, broken table",
                Accessable = true,
            },

            new HomeUnivLocation
            {
                CommonName = "Master Bedroom",
                HomeLocationID = 3,
                HomeLocation = "First Door on the left, down the hallway.",
                Description = "The door seems to be battered and broke, there might be something good in here. You use the sink pipe to pry the door open.",
                GeneralContents = "Useless furnature but lots of drawers, I should take a look, there might be something of use...there is a bed",
                Accessable = false,
            },

            new HomeUnivLocation
            {
                CommonName = "Childrens Bedroom",
                HomeLocationID = 4,
                HomeLocation = "Second Door on the left, down the hallway",
                Description = "Where children used to sleep, they are long gone by now.",
                GeneralContents = "There are family photos on the ground, claw marks on the walls covered in what looks like old blood... wood, rope",
                Accessable = false,
            },

            new HomeUnivLocation
            {
                CommonName = "Restroom",
                HomeLocationID = 5,
                HomeLocation = "Down the hall to the right of the Guest Bedroom.",
                Description = "The breaking bed shook the door open. Looks like is has been used...a lot. Not much to use here but it is still worth the look. The opened when the bed was broken.",
                GeneralContents = "old towel",
                Accessable = false,
            },

            new HomeUnivLocation
            {
                CommonName = "Back Door",
                HomeLocationID = 6,
                HomeLocation = "Back of the house, behind the kitchen",
                Description = "You hear a stampede of beasts outside, frantically searching for human flesh and shelter...the sun is coming up.",
                GeneralContents = "Nothing here but a door and some old shoes.",
                Accessable = false,
            }
        };
    }
}
