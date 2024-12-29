class ShowInTerminal
{
  public static void PrintMaze(Boxes[,] maze)
  {
    for (int i = 0; i < Maze.size; i++)
    {
      for (int j = 0; j < Maze.size; j++)
      {
        string displayString;
        switch (maze[i, j])
        {
          case Boxes.obstacle:
            displayString = "🟪";

            break;
          case Boxes.path:
            displayString = "⬛";

            break;
          case Boxes.trap:
            displayString = "💥";

            break;
          case Boxes.Astharoth:
            displayString = "😈";

            break;
          default:
            displayString = " ";
            break;
        }
        Console.Write(displayString);
        if (j == Maze.size - 1)
        {
          Console.WriteLine();
        }
      }
    }
  }


  //habilidades de los tokens
  public void abilityForce(Token.ability token)
  {}
}