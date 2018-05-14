using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedEngine.Items;

namespace TextBasedEngine.Locations
{
    class Location
    {
        public int ID { set; get; }
	    //create system to generate ID
        public string Name { set; get; }
        public string Description { set; get; }
        
        public readonly List<Item> Items = new List<Item>();

        public Location(int id, string name, string description, int NorthConnectingID, int SouthConnectingID, int EastConnectingID, int WestConnectingID, params Item[] items)
        {
            ID = id;
            Name = name;
            Description = description;
            foreach(var item in items)
            {
                Items.Add(item);
            }
        }

        public void AddItem(params Item[] items)
        {
            foreach(var item in items)
            {
                Items.Add(item);
            }
        }

        public void RemoveItem(int ID)
        {
            Items.Remove(Items.Where(x => x.ID == ID).First());
        }

        public void RemoveItem(string name)
        {
            Items.Remove(Items.Where(x => x.Name == name).First());
        }

        public void ShowDescription()
        {
            Console.Write(Description + " ");
            foreach (var item in Items)
            {
                item.PrintDescription();
            }
            Console.WriteLine();
        }

        public bool ItemExistsInLocation(int itemID)
        {
            return Items.Exists(x => x.ID == itemID);
        }

        public bool ItemExistsInLocation(string itemName)
        {
            return Items.Exists(x => x.Name == itemName);
        }
    }
}
