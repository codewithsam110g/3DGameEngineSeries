using System;

namespace _3DGameEngine.src.engine
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
       {
            Window.createWindow(800, 600, "3DGameEngine");

            MainComponent game = new MainComponent();

            game.start();
        }
    }
}
