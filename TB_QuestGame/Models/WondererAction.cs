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
        LookAt,
        PickUp,
        PutDown,
        Inventory,
        Travel,
        WondererLocationsVisited,
        WondererInfo,
        ListHomeLocations,
        ListGameObjects,
        AdminMenu,
        ReturnToMainMenu,
        Exit
    }
}
