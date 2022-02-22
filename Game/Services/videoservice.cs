using System.Collections.Generic;
using Raylib_cs;


namespace greed.Game.Casting
{
    public class VideoService
    {
        private int cellsize = 15;
        private string caption = "";
        private int  width = 640;
        private int height = 480;
        private int framerate = 0;
        private bool debug = false;

        public VideoService(int width, int height, int cellsize, int framerate, bool debug)
        {
            
            this.width  = width;
            this.height = height;
            this.cellsize = cellsize;
            this.framerate = framerate;
            this.debug = debug;
        }

        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if (debug)
            {
                DrawGrid();
            }
        }

        public void DrawActor(Actor actor)
        {
            string text = actor.GetText();
            int x = actor.GetPosition().GetX();
            int y = actor.GetPosition().GetY();
            int fontsize = actor.GetFontSize();
            Casting.Color c = actor.GetColor();
            Raylib_cs.Color color = ToRaylibColor(c);
            Raylib.DrawText(text, x, y, fontsize, color);
        }

        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }

        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }

        public int GetCellSize()
        {
            return cellsize;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetWidth()
        {
            return width;
        }

        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        public void OpenWindow()
        {
            Raylib.InitWindow(width, height, caption);
            Raylib.SetTargetFPS(framerate);
        }

        private void DrawGrid()
        {
            for (int x = 0; x < width; x += cellsize)
            {
                Raylib.DrawLine(x, 0, x, height, Raylib_cs.Color.GRAY);
            }
            for (int y = 0; y < height; y += cellsize)
            {
                Raylib.DrawLine(0, y, width, y, Raylib_cs.Color.GRAY);
            }
        }

        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }
    }
}
