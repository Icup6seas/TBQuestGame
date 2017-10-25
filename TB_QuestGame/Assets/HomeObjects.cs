using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame.Assets
{
    public static class HomeObjects
    {
        public static IEnumerable<HomeUnivLocation> HomeLocations = new List<HomeUnivLocation>()
        {
            new HomeUnivLocation
            {
                CommonName = "Front Enterance",
                HomeLocationID = 0,
                HomeLocation = "Decrepit Main Enterance",
                Description = "Slamming the door shut. You brace it with your back and you instinctively " +
                    "scan the room for your next plan, where to run, where to hide, what you can use as a " +
                    "weapon. It's very dark and hard to see but you notice that you're in a living room, " +
                    "one that would have had a loving family, one that would have celebrated many holdays over " +
                    "the years. \n",
                GeneralContents = "You see a large room, filled with old disty spider webs, small shrubs and " +
                "other vegitation rittled the place. What was left of the carpet is now decompsing under your " +
                "feet. The subfloor is creaking, any moment could give. You see a fireplace to your far right " +
                "a severly splintered entertainment center to your left, against the wall. Also, what you think " +
                "looks like a couch left over towards the wall ahead of you. \n",
                Accessable = true,
                //SanityPoints = -10

            },

            new HomeUnivLocation
            {
                CommonName = "Living Room",
                HomeLocationID = 1,
                HomeLocation = "North-east corner of the room",
                Description = "Hidden in the far right corner of the room is a well used fireplace. \n",
                GeneralContents = "In the mound of ashes you see a handle of a metal fire poker. " +
                    "In the mound of ashes you see a handle of a metal fire poker. No wood left to light " +
                    "these dark times. \n",
                Accessable = true,
                //SanityPoints = -10
            },

            new HomeUnivLocation
            {
                CommonName = "Master Bedroom",
                HomeLocationID = 2,
                HomeLocation = "",
                Description = "",
                GeneralContents = "",
                Accessable = false,
                //SanityPoints = -10
            },

            new HomeUnivLocation
            {
                CommonName = "Guest Bedroom",
                HomeLocationID = 3,
                HomeLocation = "",
                Description = "",
                GeneralContents = "",
                Accessable = false,
                //SanityPoints = -10
            },

            new HomeUnivLocation
            {
                CommonName = "Office",
                HomeLocationID = 4,
                HomeLocation = "",
                Description = "",
                GeneralContents = "",
                Accessable = false,
                //SanityPoints = -10
            },

            new HomeUnivLocation
            {
                CommonName = "Restroom",
                HomeLocationID = 5,
                HomeLocation = "",
                Description = "",
                GeneralContents = "",
                Accessable = false,
                //SanityPoints = -10
            },

            new HomeUnivLocation
            {
                CommonName = "Back Door",
                HomeLocationID = 7,
                HomeLocation = "",
                Description = "",
                GeneralContents = "",
                Accessable = false,
                //SanityPoints = -10
            }
        };
    }
}
