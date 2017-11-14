using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Character
    {
        #region ENUMERABLES

        //public enum RaceType
        //{
        //    None,
        //    Human,
        //    Beelzebub,
        //    Stolas,
        //    Buer,
        //    Balrog
        //}

        public enum HeightType
        {
            None,
            Short,
            Mediam,
            Tall,
            Giant
        }

        //public enum SanityType
        //{
        //    None,
        //    Calm,
        //    //Fine,
        //    Anxious,
        //    FreakedOut,
        //}
        #endregion

        #region FIELDS

        private string _name;
        private int _homeLocationID;
        private int _age;
        //private RaceType _race;
        private HeightType _height;
        //private SanityType _sanity;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HomeLocationID
        {
            get { return _homeLocationID; }
            set { _homeLocationID = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //public RaceType Race
        //{
        //    get { return _race; }
        //    set { _race = value; }
        //}

        public HeightType Height
        {
            get { return _height; }
            set { _height = value; }
        }

        //public SanityType Sanity
        //{
        //    get { return _sanity; }
        //    set { _sanity = value; }
        //}

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, /*RaceType race,*/ HeightType height/*SanityType sanity*/)
        {
            _name = name;
            //_race = race;
            _height = height;
            //_sanity = sanity;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
