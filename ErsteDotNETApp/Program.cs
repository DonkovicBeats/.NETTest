const int WIDTH = 4;
const int HEIGHT = WIDTH;

char[,] board = new char[WIDTH, HEIGHT];


Console.Clear();


System.Console.WriteLine("+++++++Start 1+++++++");

for (int i = 0; i < HEIGHT; i++)
{

    //System.Console.Write("\n");
    for (int j = 0; j < WIDTH; j++)
    {
        board[i, j] = 'X';
        PrintBoard(board, i, j);
        Thread.Sleep(150);

    }
    System.Console.Write("\n");


}






System.Console.WriteLine("+++++++End+++++++");

void PrintBoard(char[,] inp, int row, int col)
{
    System.Console.Write(inp[row, col]);

}
