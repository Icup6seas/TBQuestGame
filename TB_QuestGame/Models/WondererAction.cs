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
        PickUpItem,
        PickUpTreasure,
        PutDownItem,
        PutDownTreasure,
        Travel,
        WondererLocationsVisited,
        WondererInfo,
        WondererInventory,
        WondererTreasure,
        ListHomeLocations,
        ListItems,
        ListTreasures,
        Exit
    }
}
