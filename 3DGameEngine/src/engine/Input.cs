using System;
using System.Collections.Generic;
using System.Text;
using GLFW;

namespace _3DGameEngine.src.engine
{
    
    class Input
    {

        private static List<int> currentKeys = new List<int>();
        private static List<int> downKeys = new List<int>();
        private static List<int> upKeys = new List<int>();
        
        
        
        public static void Update()
        {

            currentKeys.Clear();
            downKeys.Clear();
            upKeys.Clear();


            for (int i = 65; i < 90; i++)
            {
                if (getKey((Keys)i))
                    currentKeys.Add(i);
                if (getKey((Keys)i) && !currentKeys.Contains(i))
                    downKeys.Add(i);
                if (!getKey((Keys)i) && currentKeys.Contains(i))
                    upKeys.Add(i);
            }

        }

        public static bool getKey(Keys keyCode)
        {
            if ((int)keyCode != 1 && Glfw.GetKey(Window.window,keyCode) == InputState.Press)
                return true;
            else
                return false;

        }

        public static bool getKeyDown(Keys keyCode)
        {
            if (downKeys.Contains((int)keyCode))
                return true;
            else
                return false;
        }

        public static bool getKeyUp(Keys keyCode)
        {
            if (upKeys.Contains((int)keyCode))
                return true;
            else
                return false;
        }
    }
}
