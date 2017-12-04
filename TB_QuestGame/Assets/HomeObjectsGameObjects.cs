using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public static partial class HomeObjects
    {

        public static List<GameObject> GameObject = new List<GameObject>()
        {
            new WondererObject
            {
                Id = 1,
                Name = "Wood Support Beam",
                HomeLocationId = 1,
                Description = "Almost tripping over it when breaking in, there is a wood beam I can use to barricade the door (used upon pickup).",
                Type = WondererObjectType.Stuff,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 2,
                Name = "Fireplace",
                HomeLocationId = -1,
                Description = "Full of ash but no wood for a fire, there is something that catches your eye though...",
                Type = WondererObjectType.Stuff,
                Value = 0,
                CanInventory = false,
                IsConsumable = false,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 3,
                Name = "Picture",
                HomeLocationId = 1,
                Description = "An old warn photo of my family, reminds you of your own (used upon pickup).",
                Type = WondererObjectType.Stuff,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
            },

            new WondererObject
            {
                Id = 4,
                Name = "Opium",
                HomeLocationId = 1,
                Description = "Small pouch of an Opiate extract used as a painkiller (used upon pickup).",
                Type = WondererObjectType.Medicine,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true  
            },

            new WondererObject
            {
                Id = 5,
                Name = "Canned Cream Corn",
                HomeLocationId = 2,
                Description = "Of course this would be the last kind of food around...I would take Spam over this. Found in a top cabinet (used upon pickup).",
                Type = WondererObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 6,
                Name = "Sink Pipe",
                HomeLocationId = 2,
                Description = "Can be used to pry open the Master Bedroom. Ripped from under the sink (used upon pickup).",
                Type = WondererObjectType.Key,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 7,
                Name = "Bed",
                HomeLocationId = 3,
                Description = "You lay on this to just try to remember what the comfort of a bed feels like...(used upon pickup)",
                Type = WondererObjectType.Key,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 8,
                Name = "Wood and Rope",
                HomeLocationId = 4,
                Description = "This can be used as a splint for my arm (used upon pickup).",
                Type = WondererObjectType.Medicine,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 9,
                Name = "Really Old Halloween Candy",
                HomeLocationId = 4,
                Description = "This can be used to gain more energy (used upon pickup).",
                Type = WondererObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 10,
                Name = "Old Towel",
                HomeLocationId = 5
                ,
                Description = "You can use this to further help your wounds (used upon pickup).",
                Type = WondererObjectType.Medicine,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 11,
                Name = "Bandages",
                HomeLocationId = 1,
                Description = "Used to dress wounds (used upon pickup).",
                Type = WondererObjectType.Medicine,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new WondererObject
            {
                Id = 12,
                Name = "Cocain",
                HomeLocationId = 1,
                Description = "Sometimes you need that extra KICK to survive (used upon pickup).",
                Type = WondererObjectType.Medicine,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },
        };
    }
}
