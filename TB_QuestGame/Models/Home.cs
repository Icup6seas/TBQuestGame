using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_QuestGame.Assets;

namespace TB_QuestGame
{
    public class Home
    {
        #region ***** define all lists to be maintained by the Universe object *****

        //List of all Home Locations
        private List<HomeUnivLocation> _homeLocations;
        private List<GameObject> _gameObjects;
        private List<Npc> _npcs;

        public List<HomeUnivLocation> HomeLocations
        {
            get { return _homeLocations; }
            set { _homeLocations = value; }
        }

        public List<GameObject> GameObjects
        {
            get { return _gameObjects; }
            set { _gameObjects = value; }
        }

        public List<Npc> Npcs
        {
            get { return _npcs; }
            set { _npcs = value; }
        }

        #endregion

        #region CONSTRUCTOR

        //Default Home Constructor
        public Home()
        {
            //Initialize all of the Home Objects in the game
            InitializeHome();
        }

        #endregion

        #region  ***** define methods to initialize all game elements *****

        private void InitializeHome()
        {
            _homeLocations = HomeObjectLocations.HomeLocations;
            _gameObjects = HomeObjects.GameObject;
            _npcs = HomeObjects.Npcs;
        }

        #endregion

        #region ***** define methods to return game element objects and information *****

        public bool IsValidHomeLocationID(int homeLocationID)
        {
            List<int> homeLocationIDs = new List<int>();

            foreach (HomeUnivLocation homeObj in _homeLocations)
            {
                homeLocationIDs.Add(homeObj.HomeLocationID);
            }

            if (homeLocationIDs.Contains(homeLocationID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsValidGameObjectByLocationId(int gameObjectId, int currentHomeLocation)
        {
            List<int> gameObjectIds = new List<int>();

            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.HomeLocationId == currentHomeLocation)
                {
                    gameObjectIds.Add(gameObject.Id);
                }
            }

            if (gameObjectIds.Contains(gameObjectId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsValidWondererObjectByLocationID(int wondererObjectID, int currentHomeLocation)
        {
            List<int> wondererObjectIds = new List<int>();

            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.HomeLocationId == currentHomeLocation && gameObject is WondererObject)
                {
                    wondererObjectIds.Add(gameObject.Id);
                }
            }

            if (wondererObjectIds.Contains(wondererObjectID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsValidNpcByLocationId(int npcId, int currentHomeLocation)
        {
            List<int> npcIds = new List<int>();

            foreach (Npc npc in _npcs)
            {
                if (npc.HomeLocationID == currentHomeLocation)
                {
                    npcIds.Add(npc.Id);
                }
            }

            if (npcIds.Contains(npcId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public GameObject GetGameObjectById(int Id)
        {
            GameObject gameObjectToReturn = null;

            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.Id == Id)
                {
                    gameObjectToReturn = gameObject;
                }
            }

            if (gameObjectToReturn == null)
            {
                string userMessage = $"The Game Object ID: {Id}, does not exist in the current Home.";
                throw new ArgumentException(userMessage, Id.ToString());
            }

            return gameObjectToReturn;
        }

        public List<GameObject> GetGameObjectsByHomeLocationId(int homeLocationId)
        {
            List<GameObject> gameObjects = new List<GameObject>();

            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.HomeLocationId == homeLocationId)
                {
                    gameObjects.Add(gameObject);
                }
            }

            return gameObjects;
        }

        public List<WondererObject> GetWondererObjectsByHomeLocationId(int homeLocationId)
        {
            List<WondererObject> wondererObjects = new List<WondererObject>();

            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.HomeLocationId == homeLocationId && gameObject is WondererObject)
                {
                    wondererObjects.Add(gameObject as WondererObject);
                }
            }

            return wondererObjects;
        }

        public bool IsAccessibleLocation(int homeLocationID)
        {
            HomeUnivLocation homeLocation = GetHomeLocationByID(homeLocationID);
            if (homeLocation.Accessable == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Npc GetNpcById(int Id)
        {
            Npc npcToReturn = null;

            foreach (Npc npc in _npcs)
            {
                if (npc.Id == Id)
                {
                    npcToReturn = npc;
                }
            }

            if (npcToReturn == null)
            {
                string feedbackMessage = $"The NPC ID {Id} does not exist in the current Home Location.";
                throw new ArgumentException(Id.ToString(), feedbackMessage);
            }

            return npcToReturn;
        }

        public int GetMaxHomeLocationID()
        {
            int MaxID = 0;

            foreach (HomeUnivLocation homeLocation in HomeLocations)
            {
                if (homeLocation.HomeLocationID > MaxID)
                {
                    MaxID = homeLocation.HomeLocationID;
                }
            }

            return MaxID;
        }

        public HomeUnivLocation GetHomeLocationByID(int ID)
        {
            HomeUnivLocation homeLocation = null;

            foreach (HomeUnivLocation location in _homeLocations)
            {
                if (location.HomeLocationID == ID)
                {
                    homeLocation = location;
                }
            }

            if (homeLocation == null)
            {
                string messageResponse = $"The home location {ID} does not exist in the current Home.";
                throw new ArgumentException(ID.ToString(), messageResponse);
            }

            return homeLocation;
        }

        public List<Npc> GetNpcsByHomeLocationId(int homeLocationId)
        {
            List<Npc> npcs = new List<Npc>();

            foreach (Npc npc in _npcs)
            {
                if (npc.HomeLocationID == homeLocationId)
                {
                    npcs.Add(npc);
                }
            }

            return npcs;
        }

        #endregion
    }
}
