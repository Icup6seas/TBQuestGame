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

        private List<int> _homeLocationsVisited;

        #endregion
        
        #region PROPERTIES
        
        public List<int> HomeLocationsVisited
        {
            get { return _homeLocationsVisited; }
            set { _homeLocationsVisited = value; }
        }

        #endregion
        
        #region CONSTRUCTORS

        public Wonderer()
        {

        }

        public Wonderer(string name, RaceType race, HeightType height, SanityType sanity) : base(name, race, height, sanity)
        {

        }

        #endregion
        
        #region METHODS
        

        #endregion
    }
}
