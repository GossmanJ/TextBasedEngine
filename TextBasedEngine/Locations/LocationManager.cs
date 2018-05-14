using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedEngine.Items;

namespace TextBasedEngine.Locations
{
    static class LocationManager
    {

        public static readonly List<Location> locations = new List<Location>();
        
        //use an XML eventually bc this is inefficient but I also don't want to deal with the 1000000 errors visual studio gives me when I make an xml

        public static void PopulateLocations()
        {
            locations.Add(new Location(1, "House", "It's a dirty house.", 0, 0, 0, 0, ItemManager.items[0], ItemManager.items[1]));
        }
    }
}
