using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedEngine.Scenes
{
    class Scene
    {
        public virtual void Tick()
        {

        }

        public void EndScene()
        {
            SceneManager.EndScene();
        }
    }
}
