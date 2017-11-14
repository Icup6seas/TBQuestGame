using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// the character class the player uses in the game.
    /// </summary>
    public class Wonderer : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private int _health;
        private int _lives;
        private int _sanity;
        private List<int> _homeLocationsVisited;

        #endregion
        
        #region PROPERTIES
        
        public List<int> HomeLocationsVisited
        {
            get { return _homeLocationsVisited; }
            set { _homeLocationsVisited = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public int Sanity
        {
            get { return _sanity; }
            set { _sanity = value; }
        }
        #endregion

        #region CONSTRUCTORS

        public Wonderer()
        {
            _homeLocationsVisited = new List<int>();
        }

        public Wonderer(string name, /*RaceType race,*/ HeightType height /*SanityType sanity*/) : base(name, /*race,*/ height /*sanity*/)
        {
            _homeLocationsVisited = new List<int>();
        }

        #endregion
        
        #region METHODS
        
        public bool HasVisited(int _homeLocationID)
        {
            if (HomeLocationsVisited.Contains(_homeLocationID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
