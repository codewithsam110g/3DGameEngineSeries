using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using GLFW;

namespace _3DGameEngine.src.engine
{
    class MainComponent
    {

        public static readonly double FRAME_CAP = 5000.0;

        private bool isRunning;
        private Game game;

        public MainComponent() { 
            
            isRunning = false;
            game = new Game();
        
        }

        public void start() {

            if (isRunning)
                return;

            run(); 
        
        }

        public void stop() {

            if (!isRunning)
                return;

            isRunning = false;
        
        }

        private void run() {

            isRunning = true;

            int frames = 0;
            long frameCounter = 0;

            double frameTime = 1.0 / FRAME_CAP;

            long lastTime = Time.getTime();
            double unprocessedTime = 0;

            while (isRunning)
            {
                bool render = false;

                long startTime = Time.getTime();
                long passedTime = startTime - lastTime;
                lastTime = startTime;

                unprocessedTime += passedTime / (double)Time.SECOND;
                frameCounter += passedTime;

                while (unprocessedTime > frameTime)
                {
                    render = true;

                    unprocessedTime -= frameTime;

                    if (Window.isCloseRequested())
                        stop();

                    Time.setDelta(frameTime);

                    Input.Update();

                    game.input();
                    game.update();

                    if (frameCounter >= Time.SECOND)
                    {
                        
                        Console.WriteLine(frames);
                        frames = 0;
                        frameCounter = 0;

                    }

                    

                }
                

                Glfw.PollEvents();

                if (render)
                {
                    Render();
                    frames++;
                }

                else
                {

                    Thread.Sleep(1);

                }
                
            }

            cleanUp();

            

        }

        private void Render() {

            game.render();
            Window.render();

        }

        private void cleanUp() { Window.closeWindow(); }

    }
}
