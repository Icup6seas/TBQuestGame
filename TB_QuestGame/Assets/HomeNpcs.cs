using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public static partial class HomeObjects
    {
        public static List<Npc> Npcs = new List<Npc>()
        {
            new Civilian
            {
                Id = 1,
                Name = "Inner Voice",
                HomeLocationID = 1,
                Description = "Listening to yourself might be your key to survival.",
                Messages = new List<string>
                {
                    "Breath, slow down and think. My Health and Sanity are not doing well..."
                }
            },

            new Civilian
            {
                Id = 2,
                Name = "Inner Voice 2",
                HomeLocationID = 2,
                Description = "Listening to yourself might be your key to survival.",
                Messages = new List<string>
                {
                    "The Sink Pipe seems like it might come in handy"
                }
            },

            new Civilian
            {
                Id = 3,
                Name = "Inner Voice 3",
                HomeLocationID = 3,
                Description = "Listening to yourself might be your key to survival.",
                Messages = new List<string>
                {
                    "That Bed might be a nice place to rest your feet for a few minutes, something about it is odd."
                }
            },

            new Civilian
            {
                Id = 4,
                Name = "Inner Voice 4",
                HomeLocationID = 4,
                Description = "Listening to yourself might be your key to survival.",
                Messages = new List<string>
                {
                    "When laying on the Bed, it must have shifted the wall enough to loosen the Childrens Room door.",
                    "You notice claw marks on the walls, old blood stains. There might be something I need here..."
                }
            },

            new Civilian
            {
                Id = 5,
                Name = "Inner Voice 4",
                HomeLocationID = 5,
                Description = "Listening to yourself might be your key to survival.",
                Messages = new List<string>
                {
                    "You hear rustling outside. Wait here until you feel it's safe..."
                }
            }
        };
    }
}
