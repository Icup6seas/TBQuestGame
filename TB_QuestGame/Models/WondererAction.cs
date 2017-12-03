using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// enum of all possible player actions
    /// </summary>
    public enum WondererAction
    {
        None,
        MissionSetup,
        LookAround,
        Travel,

        WondererMenu,
        WondererInfo,
        Inventory,
        WondererLocationsVisited,

        ObjectMenu,
        LookAt,
        PickUp,
        PutDown,

        NonPlayerCharacterMenu,
        TalkTo,

        AdminMenu,
        ListHomeLocations,
        ListGameObjects,
        ListNonPlayerCharacters,
        
        ReturnToMainMenu,
        Exit
    }
}
