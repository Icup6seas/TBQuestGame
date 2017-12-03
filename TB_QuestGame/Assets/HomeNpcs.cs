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
                HomeLocationID = 0,
                Description = "Listening to yourself might be your key to survival.",
                Messages = new List<string>
                {
                    "Breath, slow down and think."
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
                HomeLocationID = 2,
                Description = "Listening to yourself might be your key to survival.",
                Messages = new List<string>
                {
                    "That Bed might be a nice place to rest your feet for a few minutes,",
                    "It does look a bit shaky, so be careful."
                }
            }
        };
    }
}
