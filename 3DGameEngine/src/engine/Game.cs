using System;
using System.Collections.Generic;
using GLFW;
using System.Windows.Input;

namespace _3DGameEngine.src.engine
{
    class Game
    {

        public Game() { }

        public void input()
        {

            if (Input.getKey(Keys.Up))
                Console.WriteLine("You just pressed Up");
            if (Input.getKeyUp(Keys.Up))
                Console.WriteLine("You just Released Up");

        }

        public void update() { }

        public void render() { }

    }
}
