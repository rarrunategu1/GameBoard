using System;

public class Program
{
    public static void Main()
    {
        GameBoard tictactoe = new GameBoard(3, 3);
        GameBoard connectfour = new GameBoard(6, 7);

        //create Game
        Game myGame = new Game(6, 7);
        myGame.debug_display();

        //tictactoe.drawBoard();
        Console.WriteLine();
        connectfour.drawBoard(myGame);

        //create move creating an inline array
        Move myMove = new Move(new[] {5,3}, "@");

        //apply move
        myGame.applyMove(myMove);
        myGame.debug_display();
        Move oopMove = new Move(new[] { 1,6}, "#");
       


    }
}

public class GameBoard
{
    public int height { get; set; }
    public int width { get; set; }

    public GameBoard(int height, int width)
    {
        this.height = height;
        this.width = width;
    }
    public void drawBoard(Game aGame)
    {
        for (int row = 0; row < this.height; row++)
        {
            for (int part = 0; part < 3; part++)
            {
                for (int column = 0; column < width; column++)
                {
                    switch (part)
                    {
                        case 1:
                            Console.Write("|{0}|", aGame.board[row, column]);
                            break;
                        case 0:
                        case 2:
                            Console.Write("+-+");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

//GameData
public class Game
{
    public String[,] board { get; set; }

    //initialize array
    public Game(int height, int width)
    {
        this.board = new String[height, width];

        //initialize board
        for(int row = 0; row < height; row++)
        {
            for(int column = 0; column < width; column++)
            {
                // if empty write a "." else leave what's in there
                Console.Write(board[row,column] == " " ? ".": board[row,column]);
            }
        }
    }

    public void applyMove(Move move)
    {
        this.board[move.location[0], move.location[1]] = move.player;
    }

    public void debug_display()
    {
        for (int row = 0; row < this.board.GetLength(0); row++)
        {
            for(int column = 0; column < this.board.GetLength(1); column++);
        }
        Console.WriteLine();
    }

}

//apply move
public class Move
{
    public int[] location { get; set;}
    public String player { get; set;}

    public Move(int[] location, String player)
    {
        this.location = location;
        this.player = player;
    }
}

//using static class is good if you're only dealing with one game
public static class ConnectFour
{
    public static int height = 6;
    public static int width = 7;

    public static void drawBoard()
    {
        for (int row = 0; row < height; row++)
        {
            for (int part = 0; part < 3; part++)
            {
                for (int column = 0; column < width; column++)
                {
                    switch (part)
                    {
                        case 1:
                            Console.Write("| |");
                            break;
                        case 0:
                        case 2:
                            Console.Write("+-+");
                            break;
                    }


                }
                Console.WriteLine();
            }
        }
    }
}

