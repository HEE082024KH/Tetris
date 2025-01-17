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
    private PictureBox pictureBox1;
    
    private void loadCanvas()
    {
        // Resize the picture box based on the dotsize and canvas size
        pictureBox1.Width = canvasWidth * dotSize;
        pictureBox1.Height = canvasHeight * dotSize;
        
        // Create Bitmap with picture box's size
        canvasBitmap = new Bitmap(canvasWidth, canvasHeight);
        canvasGraphics = Graphics.FromImage(canvasBitmap);
        canvasGraphics.FillRectangle(Brushes.LightGray, 0, 0, canvasWidth, canvasHeight);
        
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
}