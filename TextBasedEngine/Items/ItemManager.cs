using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedEngine.Items
{
    static class ItemManager
    {
        public static readonly List<Item> items = new List<Item>();
        public static void PopulateItems()
        {
            items.Add(new Item(1, "gun", "Gun", "A solitary gun sits on a nearby counter.", "An old pistol.", ConsoleColor.Magenta, "gun"));
            items.Add(new Item(2, "coat", "Coat", "An old coat was thrown against the door.", "A dirty, tattered coat.", ConsoleColor.DarkCyan, "coat"));
        }
    }
}
