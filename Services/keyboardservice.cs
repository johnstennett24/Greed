using System;
using Raylib_cs;

namespace greed.Game.Casting;

public class KeyboardService
{
    private int cellsize = 15;

    public void KeyboardService(int cellsize)
    {
        this.cellsize = cellsize;
    }

    public Point GetDirection()
    {
        int dx = 0;

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            dx = -1;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            dx = +1;
        }

        EntryPointNotFoundException direction = new Point(dx);
        direction = direction.scale(cellsize);

        return direction;

    }
}