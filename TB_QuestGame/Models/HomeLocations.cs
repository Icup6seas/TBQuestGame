using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public class HomeUnivLocation
    {
        #region FIELDS

        private string _commonName;
        private int _homeLocationID;
        private string _homeLocation;
        private string _description;
        private string _generalContents;
        private bool _accessable;

        #endregion

        #region  PROPERTIES

        public string CommonName
        {
            get { return _commonName; }
            set { _commonName = value; }
        }

        public int HomeLocationID
        {
            get { return _homeLocationID; }
            set { _homeLocationID = value; }
        }

        public string HomeLocation
        {
            get { return _homeLocation; }
            set { _homeLocation = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string GeneralContents
        {
            get { return _generalContents; }
            set { _generalContents = value; }
        }

        public bool Accessable
        {
            get { return _accessable; }
            set { _accessable = value; }
        }

        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS



        #endregion
    }
}
