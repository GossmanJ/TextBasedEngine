using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedEngine.Scenes
{
    static class SceneManager
    {
        public static Stack<Scene> currentScene = new Stack<Scene>();

        public static void TickScene()
        {
            currentScene.Peek().Tick();
        }

        public static void AddScene(Scene scene)
        {
            currentScene.Push(scene);
        }

        public static void EndScene()
        {
            currentScene.Pop();
        }
    }
}
