namespace Tetris;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        loadCanvas();
    }

    private Bitmap canvasBitmap;
    private Graphics graphics;
    int canvasWidth = 15, canvasHeight = 20;
    private int[,] canvasDotArray;
    private int dotSize = 20;

    private void loadCanvas()
    {
        pictureBox1.Width = canvasWidth * dotSize;
    }
}