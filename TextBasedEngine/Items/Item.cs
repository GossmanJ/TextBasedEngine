using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedEngine.Items
{
    class Item
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string DisplayName { set; get; }
        public ConsoleColor ItemColor { set; get; }

        public string LocationDescription { set; get; }
        private string InventoryDescription { set; get; }
        private List<string> ColoredWords = new List<string>();

        public Item(int id, string name, string displayName, string locationDescription, string inventoryDescription, ConsoleColor itemColor = ConsoleColor.White, params string[] coloredWords)
        {
            ID = id;
            Name = name;
            DisplayName = displayName;
            LocationDescription = locationDescription;
            InventoryDescription = inventoryDescription;
            ItemColor = itemColor;
            foreach(var word in coloredWords)
            {
                ColoredWords.Add(word);
            }
        }

        public void PrintDescription()
        {
            string[] description = LocationDescription.Split(' ');
            for(int i = 0; i < description.Count(); i++)
            {
                if (ColoredWords.Exists(x => x.ToLower() == description[i].ToLower()))
                {
                    Console.ForegroundColor = ItemColor;
                    Console.Write(description[i]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write(description[i]);
                }
                Console.Write(' ');
            }
        }

        public void PrintInventoryDescription()
        {
            Console.Write(InventoryDescription);
        }

        public void PrintName()
        {
            if (ColoredWords.Exists(x => x.ToLower() == Name.ToLower()))
            {

                Console.ForegroundColor = ItemColor;
                Console.Write(DisplayName);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.Write(DisplayName);
            }
        }
    }
}
