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
                    { 1, 1 }
                }
            },
            new Shape
            {
                Width = 1,
                Height = 4,
                Dots = new int[,]
                {
                    { 1 },
                    { 1 }
                }
            },
            new Shape
            {
                Width = 3,
                Height = 2,
                Dots = new int[,]
                {
                    { 0, 1, 0 },
                    { 1, 1, 1 },
                }
            },
            new Shape
            {
                Width = 3,
                Height = 2,
                Dots = new int[,]
                {
                    { 0, 0, 1 },
                    { 1, 1, 1 },
                }
            },
            new Shape
            {
                Width = 3,
                Height = 2,
                Dots = new int[,]
                {
                    { 1, 0, 0 },
                    { 1, 1, 1 },
                }
            },
            new Shape
            {
                Width = 3,
                Height = 2,
                Dots = new int[,]
                {
                    { 1, 1, 0 },
                    { 0, 1, 1 },
                }
            },
            new Shape
            {
                Width = 3,
                Height = 2,
                Dots = new int[,]
                {
                    { 0, 1, 1 },
                    { 1, 1, 0 },
                }
            },
            // new shapes can be added here..
        };
    }
    // Get a shape form the array in a random basis
    public static Shape GetRandomShape()
    {
        var Shape = shapesArray[new Random().Next(shapesArray.Length)];
        return Shape;
    }
}