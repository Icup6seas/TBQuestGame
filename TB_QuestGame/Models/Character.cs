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

        public enum HeightType
        {
            None,
            Short,
            Mediam,
            Tall,
            Giant
        }

        #endregion

        #region FIELDS

        private string _name;
        private int _homeLocationID;
        private int _age;
        private HeightType _height;

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

        public HeightType Height
        {
            get { return _height; }
            set { _height = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, HeightType height)
        {
            _name = name;
            _height = height;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
