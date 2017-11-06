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
            //_homeLocations = HomeObjectLocations.HomeLocations as List<HomeUnivLocation>;
            _gameObjects = HomeObjects.gameObject;
        }

        #endregion

        #region ***** define methods to return game element objects and information *****

        public bool IsValidHomeLocationID(int homeLocationID)
        {
            List<int> homeLocationIDs = new List<int>();

            foreach (HomeUnivLocation stl in _homeLocations)
            {
                homeLocationIDs.Add(stl.HomeLocationID);
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

        public int GetMaxHomeLocationID()
        {
            int MadID = 0;

            foreach (HomeUnivLocation homeLocation in HomeLocations)
            {
                if (homeLocation.HomeLocationID > MadID)
                {
                    MadID = homeLocation.HomeLocationID;
                }
            }

            return MadID;
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

        #endregion
    }
}
