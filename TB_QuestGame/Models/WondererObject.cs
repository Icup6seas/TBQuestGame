using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public class WondererObject : GameObject
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Description { get; set; }
        //public override int HomeLocationId { get; set; }
        public WondererObjectType Type { get; set; }
        public bool CanInventory { get; set; }
        public bool IsConsumable { get; set; }
        public bool IsVisible { get; set; }
        public int Value { get; set; }
        public event EventHandler ObjectAddedToInventory;
        public event EventHandler ObjectDeletedFromInventory;

        public void OnObjectAddedToInventory()
        {
            if (ObjectAddedToInventory != null)
            {
                ObjectAddedToInventory(this, EventArgs.Empty);
            }
        }

        public void OnObjectDeletedFromInventory()
        {
            if (ObjectDeletedFromInventory != null)
            {
                ObjectDeletedFromInventory(this, EventArgs.Empty);
            }
        }

        private int _homeLocation;
        public override int HomeLocationId
        {
            get
            {
                return _homeLocation;
            }
            set
            {
                if (_homeLocation == 0 && value != 0)
                {
                    OnObjectDeletedFromInventory();
                }
                _homeLocation = value;
                if (value == 0)
                {
                    OnObjectAddedToInventory();
                }
            }
        }
    }
}
