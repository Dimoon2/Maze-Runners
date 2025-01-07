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
}
public class Boom : Trap
{
    public override void Activate(Token token, Boxes[,] laberinth)
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
}
public class Teleport : Trap
{
    public override void Activate(Token token, Boxes[,] laberinth)
    {
        Console.Clear();
        Console.WriteLine("A huge bird appears from the sky and takes your token away");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey(true);

        if (token.stepLog.Count < 6)
        {
            token.currentPosition[0] = token.stepLog[0][0];
            token.currentPosition[1] = token.stepLog[0][1];

            if (token.name == "Force")
            {
                token.currentPosition = [1, 1];
            }
            else if (token.name == "Shield")
            {
                token.currentPosition = [1, 15];
            }
            else if (token.name == "Vous")
            {
                token.currentPosition = [1, 16];
            }
            else if (token.name == "Vitality")
            {
                token.currentPosition = [16, 2];
            }
            else if (token.name == "Crow")
            {
                token.currentPosition = [16, 1];
            }
            else if (token.name == "Cass")
            {
                token.currentPosition = [16, 16];
            }
        }
        else
        {
            token.currentPosition[0] = token.stepLog[token.stepLog.Count - 6][0];
            token.currentPosition[0] = token.stepLog[token.stepLog.Count - 6][1];
        }
        Console.WriteLine($"Your token moved 5 boxes back, he is now in:{token.currentPosition[0]}, {token.currentPosition[1]}");
        Console.WriteLine();
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);
    }
}

public class BadLuck : Trap
{
    public override void Activate(Token token, Boxes[,] laberinth)
    {
        Console.Clear();
        Console.WriteLine("It looks like you have bad luck today, your token will teleport to the begining :(");
        Console.WriteLine();
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);

        if (token.name == "Force")
        {
            token.currentPosition = [1, 1];
        }
        else if (token.name == "Shield")
        {
            token.currentPosition = [1, 15];
        }
        else if (token.name == "Vous")
        {
            token.currentPosition = [1, 16];
        }
        else if (token.name == "Vitality")
        {
            token.currentPosition = [16, 2];
        }
        else if (token.name == "Crow")
        {
            token.currentPosition = [16, 1];
        }
        else if (token.name == "Cass")
        {
            token.currentPosition = [16, 16];
        }

        Console.WriteLine("(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)(┬┬﹏┬┬)");
        Console.WriteLine($"The current position of your token is now:{token.currentPosition[0]},{token.currentPosition[1]}");
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);

    }
}