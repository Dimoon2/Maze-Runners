public class Player
{
    public string name { get; set; }
    public List<Token> SelectedToken { get; set; }
    public bool playerTurn { get; set; }

    //constructor:
    public Player(string name, bool playerTurn)
    {
        this.name = name;
        this.SelectedToken = new List<Token>();
        this.playerTurn = playerTurn;
    }

    public void AddToken(Token token)
    {
        SelectedToken.Add(token);
    }

    //mostrar tokens:
    public void DisplayTokens()
    {
        Console.WriteLine($"{name}'s Tokens:");
        foreach (var token in SelectedToken)
        {
            token.DisplayInfo();
        }
    }

    //turno de jugadores


    //para verificar si la posicion es valida:
    public bool ValidPosition(Boxes[,] maze, int x, int y)
    {
        if (maze[x, y] == Boxes.path || maze[x, y] == Boxes.trap)
        { return true; }
        else
        {
            return false;
        }
    }

    //

    //dado un string el usuario me dice a que posicion quiere ir:
    public int[] SelectedAction(string action, int positionActualX, int positionActualY, Token token, Boxes[,] maze)
    {
        int x = positionActualX;
        int y = positionActualY;
        int[] positionFinal = new int[2];

        if (action == "W" || action == "w")
        {
            x = positionActualX - 1;
            y = positionActualY;
            positionFinal = new int[2] { x, y };
        }
        else if (action == "S" || action == "s")
        {
            x = positionActualX + 1;
            y = positionActualY;
            positionFinal = new int[2] { x, y };

        }
        else if (action == "D" || action == "d")
        {
            x = positionActualX;
            y = positionActualY + 1;
            positionFinal = new int[2] { x, y };

        }
        else if (action == "A" || action == "a")
        {
            x = positionActualX;
            y = positionActualY - 1;
            positionFinal = new int[2] { x, y };

        }
        else if (action == "E" || action == "e")
        {
            token.Power(maze);
        }
        else
        {
            throw new Exception("Please enter W, S, A, D or E :)");
        }

        return positionFinal;


    }
}