using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedEngine.Items
{
    static class InventoryManager
    {
        public static List<Item> Inventory = new List<Item>();

        public static void AddItemToInventory(int itemID)
        {
            Inventory.Add(ItemManager.items.Where(x => x.ID == itemID).First());
        }

        public static void AddItemToInventory(string itemName)
        {
            Inventory.Add(ItemManager.items.Where(x => x.Name == itemName).First());
        }

        public static void RemoveItemFromInventory(int itemID)
        {
            Inventory.Remove(Inventory.Where(x => x.ID == itemID).First());
        }

        public static bool ItemExistsInInventory(int itemID)
        {
            return Inventory.Exists(x => x.ID == itemID);
        }

        public static void RemoveItemFromInventory(string itemName)
        {
            Inventory.Remove(Inventory.Where(x => x.Name == itemName).First());
        }

        public static bool ItemExistsInInventory(string itemName)
        {
            return Inventory.Exists(x => x.Name == itemName);
        }
    }
}
