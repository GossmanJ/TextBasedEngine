using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Items.ItemManager.PopulateItems();
            Locations.LocationManager.PopulateLocations();

            var startingScene = new Scenes.LocationScene();

            Player.currentLocationID = 1;

            Scenes.SceneManager.AddScene(startingScene);

            while(true)
            {
                Scenes.SceneManager.TickScene();
            }
        }
    }
}
