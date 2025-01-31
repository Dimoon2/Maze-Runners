public class Trap
{
    Maze mazes = new Maze();
    
    public virtual void Activate(Token token, Boxes[,] laberinth)
    {
        Console.WriteLine("You have fallen into a trap 💥");
        Console.WriteLine();
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);
    }

    public static void implementedTraps(Boxes[,] maze)
    {
     List<int[]> paths = Maze.PathList(maze);

      Random random = new Random();
      for (int i = 0; i < 16; i++)
      {
        int index = random.Next(paths.Count);
        //para que ninguna trampa caiga al lado de la otra
        if (maze[paths[index][0] - 1, paths[index][1]] == Boxes.trap || maze[paths[index][0], paths[index][1] + 1] == Boxes.trap || maze[paths[index][0], paths[index][1] - 1] == Boxes.trap || maze[paths[index][0], paths[index][1] + 1] == Boxes.trap)
        {
          index = random.Next(paths.Count);
          maze[paths[index][0], paths[index][1]] = Boxes.trap;
        }
        else { maze[paths[index][0], paths[index][1]] = Boxes.trap; }
        paths.RemoveAt(index);
      }
    }
}
public class Boom : Trap
{
    public override void Activate(Token token, Boxes[,] maze)
    {
        if (token.life > 5)
        {
            Console.Clear();
            Console.WriteLine("A strange artefact fell of the sky, it looks like a bomb");
            Console.WriteLine("💣");
            Console.WriteLine("OH NO, the bomb exploted, your token's life is now 5 points smaller");
            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);

            token.life -= 5;
            Console.WriteLine($"Actual life: {token.life}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
        else
        {
            Console.WriteLine("Oh no, your token's life is almost over, he must go to his spawn point to recover");
            token.currentPosition[0] = token.stepLog[0][0];
            token.currentPosition[1] = token.stepLog[0][1];
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);
        }

    }
}
public class Teleport : Trap
{
    public override void Activate(Token token, Boxes[,] maze)
    {
        Console.Clear();
        Console.WriteLine("A huge bird appears from the sky and takes your token away");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey(true);

        if (token.stepLog.Count < 6)
        {
            maze[token.currentPosition[0], token.currentPosition[1]] = Boxes.trap;
            token.currentPosition[0] = token.stepLog[0][0];
            token.currentPosition[1] = token.stepLog[0][1];
            maze[token.currentPosition[0], token.currentPosition[1]] = token.value;
            token.trapped = false;

        }
        else
        {
            maze[token.currentPosition[0], token.currentPosition[1]] = Boxes.trap;
            token.currentPosition[0] = token.stepLog[token.stepLog.Count - 6][0];
            token.currentPosition[1] = token.stepLog[token.stepLog.Count - 6][1];
            maze[token.currentPosition[0], token.currentPosition[1]] = token.value;
            token.trapped = false;

        }
        Console.WriteLine($"Your token moved 5 boxes back, he is now in:{token.currentPosition[0]}, {token.currentPosition[1]}");
        Console.WriteLine();
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);
    }
}

public class BadLuck : Trap
{
    public override void Activate(Token token, Boxes[,] maze)
    {
        Console.Clear();
        Console.WriteLine("It looks like you have bad luck today, your token will teleport to the begining :(");
        Console.WriteLine();
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);

        maze[token.currentPosition[0], token.currentPosition[1]] = Boxes.trap;
        token.currentPosition[0] = token.stepLog[0][0];
        token.currentPosition[1] = token.stepLog[0][1];
        maze[token.currentPosition[0], token.currentPosition[1]] = token.value;
        token.trapped = false;

        Console.WriteLine("(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)");
        Console.WriteLine($"The current position of your token is now:{token.currentPosition[0]},{token.currentPosition[1]}");
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);

    }

    
}