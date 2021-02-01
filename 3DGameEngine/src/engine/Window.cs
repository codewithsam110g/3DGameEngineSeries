using System;
using System.Collections.Generic;
using System.Text;
using OpenGL;
using GLFW;
using static OpenGL.GL;
using System.Drawing;

namespace _3DGameEngine.src.engine
{
    class Window
    {
        public static GLFW.Window window;
        static string tittle;

        public static void createWindow(int width, int height, string tittle) {

            Glfw.Init();
            Window.tittle = tittle;

            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);

            Glfw.WindowHint(Hint.Focused, true);
            Glfw.WindowHint(Hint.Resizable, false);
            

            window = Glfw.CreateWindow(width, height, tittle, Monitor.None, GLFW.Window.None);

            if (window == GLFW.Window.None)
            {
                Console.WriteLine("Cannot Create The Window");
                return;
            }

            Rectangle screen = Glfw.PrimaryMonitor.WorkArea;

            int x = (screen.Width - width) / 2;
            int y = (screen.Height - height) / 2;

            Glfw.SetWindowPosition(window, x, y);

            Glfw.MakeContextCurrent(window);
            Import(Glfw.GetProcAddress);

            glViewport(0,0, width, height);
            Glfw.SwapInterval(0);

        }

        public static void render()
        {

            //Todo window.update() method to redraw things 
            
            

        }

        public static bool isCloseRequested() {

            return Glfw.WindowShouldClose(window);

        }

        public static int getWidth() {

            int width, height; 
            
            Glfw.GetWindowSize(window,out width,out height);

            return width;

        }
        public static int getHeight()
        {

            int width, height;

            Glfw.GetWindowSize(window, out width, out height);

            return height;

        }

        public static string getTittle() {

            return tittle;

        }

        public static void closeWindow() {

            Glfw.Terminate();

        }

    }
}
