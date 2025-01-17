using System;
namespace Tetris;

static class ShapesHandler
{
    private static Shape[] shapesArray;
    // static constructor : No need to manually initialize
    static ShapesHandler()
    {
        // Create shapes add into the array.
        shapesArray = new Shape[]
        {
            new Shape
            {
                Width = 2,
                Height = 2,
                Dots = new int[,]
                {
                    { 1, 1 },
                    { 1, 1 },
                }
            },
            new Shape
            {
                Width = 1,
                Height = 4,
                Dots = new int[,]
                {
                    { 1},
                    { 1},
                }
            },
        };
    }
}