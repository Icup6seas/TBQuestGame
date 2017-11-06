using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public static partial class HomeObjects
    {

        public static List<GameObject> gameObject = new List<GameObject>()
        {
            new WondererObject
            {
                Id = 1,
                Name = "Bag of Tokens",
                HomeLocationId = 2,
                Description = "In a tattered pouch, there are some tokens to use for trade",
                Type = WondererObjectType.Stuff,
                Value = 100,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 2,
                Name = "Stones",
                HomeLocationId = 3,
                Description = "Small but dense stones, possibly used with a sling-shot type weapon.",
                Type = WondererObjectType.Stuff,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 3,
                Name = "Opium",
                HomeLocationId = 3,
                Description = "Small pouch of an Opiate extract used as a painkiller.",
                Type = WondererObjectType.Medicine,
                Value = 50,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 4,
                Name = "Picture",
                HomeLocationId = 3,
                Description = "An old warn photo of my family.",
                Type = WondererObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

        };

    }
}
