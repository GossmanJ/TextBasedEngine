using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedEngine.Locations;

namespace TextBasedEngine.Scenes
{
    class LocationScene : Scene
    {
        public override void Tick()
        {
            var input = Console.ReadLine();
            CommandParser.LocationParse(input);
        }
    }
}
