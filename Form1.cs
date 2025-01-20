using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        loadCanvas();
    }

    private Bitmap canvasBitmap;
    private Graphics canvasGraphics;
    int canvasWidth = 15, canvasHeight = 20;
    private int[,] canvasDotArray;
    private int dotSize = 20;
    
    private void loadCanvas()
    {
        // Resize the picture box based on the dotsize and canvas size
        pictureBox1.Width = canvasWidth * dotSize;
        pictureBox1.Height = canvasHeight * dotSize;
        
        // Create Bitmap with picture box's size
        canvasBitmap = new Bitmap(canvasWidth, canvasHeight);
        canvasGraphics = Graphics.FromImage(canvasBitmap);
        canvasGraphics.FillRectangle(Brushes.Black, 0, 0, canvasWidth, canvasHeight);
        
        // Load bitmap into picture box
        pictureBox1.Image = canvasBitmap;
        
        // Initialize canvas dot array. by default all elements are zero
        canvasDotArray = new int[canvasWidth, canvasHeight];
    }

    private int currentX;
    private int currentY;

    private Shape getRandomShapeWithCenterAligned()
    {
        var shape = ShapesHandler.GetRandomShape();
        
        // Calculate the x and y values as if the shape lies in the center
        currentX = 7;
        currentY = -shape.Height;
        return shape;
    }
    
    // returns if it reaches the bottom or touches any other blocks
    private bool moveShapeIfPossible(int moveDown = 0, int moveSide = 0)
    {
        var newX = currentX + moveDown;
        var newY = currentY + moveSide;
        
        // check if it reaches the bottom or side bar
        if (newX < 0 || newX + currentShape.Width > canvasWidth || newY + currentShape.Height > canvasHeight)
            return false;
        
        // check if it touches any other blocks 
        for (int i = 0; i < currentShape.Width; i++)
        {
            for (int j = 0; j < currentShape.Height; j++)
            {
                if (newY + j > 0 && canvasDotArray[newX + i, newY + j] == 1 && currentShape.Dots[j, i] == 1)
                    return false;
            }
        }
        
        currentX = newX;
        currentY = newY;
        
        drawShape();
        
        return true;
    }

    private Bitmap workingBitmap;
    private Graphics workingGraphics;

    private void drawShape()
    {
        workingBitmap = new Bitmap(canvasBitmap);
        workingGraphics = Graphics.FromImage(workingBitmap);

        for (int i = 0; i < currentShape.Width; i++)
        {
            for (int j = 0; j < currentShape.Height; j++)
            {
                if (currentShape.Dots[j, i] == 1)
                    workingGraphics.FillRectangle(Brushes.Blue, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
            }
        }
    }
    pictureBox1.Image = workingBitmap;
}