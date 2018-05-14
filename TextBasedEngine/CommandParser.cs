using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedEngine.Items;
using TextBasedEngine.Locations;
using static TextBasedEngine.Locations.LocationManager;
using static TextBasedEngine.Player;

namespace TextBasedEngine
{
    static class CommandParser
    {
        public static void LocationParse(string input)
        {
            var token = input.ToLower().Trim().Split(' ');
            int locationIndex = locations.IndexOf(locations.Where(x => x.ID == currentLocationID).First());

            switch(token[0])
            {
                case "look":
                    if(token.Count() == 1)
                    {
                        locations[locationIndex].ShowDescription();
                    }
                    else
                    {
                        Console.WriteLine("I don't understand \"{0}\".", input);
                    }
                    break;

                case "take": case "grab":
                    if(token.Count() == 1)
                    {
                        Console.WriteLine("What will you {0}?", token[0]);
                    }
                    else if (token.Count() == 2)
                    {
                        if(locations[locationIndex].ItemExistsInLocation(token[1]))
                        {
                            InventoryManager.AddItemToInventory(token[1]);
                            locations[locationIndex].RemoveItem(token[1]);
                            InventoryManager.Inventory.Sort((x, y) => x.ID.CompareTo(y.ID));
                            Console.Write("You take the ");
                            ItemManager.items.Where(x => x.Name.ToLower() == token[1]).First().PrintName();
                            Console.WriteLine(".");

                        }
                        else
                        {
                            Console.WriteLine("There is no \"{0}\" here.", token[1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("I don't understand \"{0}\".", input);
                    }
                    break;

                case "inventory": case "i":
                    if (token.Count() == 1)
                    {
                        foreach(var item in InventoryManager.Inventory)
                        {
                            item.PrintName();
                            Console.Write(": ");
                            item.PrintInventoryDescription();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("I don't understand \"{0}\".", input);
                    }
                    break;

                case "combine":
                    break;

                case "n": case "north":
                    break;
                case "s": case "south":
                    break;
                case "e": case "east":
                    break;
                case "w": case "west":
                    break;
                default:
                    Console.WriteLine("I don't understand \"{0}\".", input);
                    break;
            }
        }
    }
}
