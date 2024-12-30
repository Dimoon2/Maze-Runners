class GameActions
{
  public static void PrintMaze(Boxes[,] maze, List<Token> tokens)
  {
    for (int i = 0; i < Maze.size; i++)
    {
      for (int j = 0; j < Maze.size; j++)
      {
        //utilizo el switch como expresion en vez de casos como lo es su sintaxis basica
        string displayString = " ";
        Token currentToken = tokens.FirstOrDefault(t => t.currentPosition[0] == i && t.currentPosition[1] == j);
            if (currentToken != null)
            {
                // Imprimir el símbolo del token
                displayString = currentToken.name 
                switch
                {
                    "Force" => "⚔️",
                    "Shield" => "🛡️",
                    "Vous" => "🌀",
                    "Vitality" => "🤍",
                    "Crow" => "🦅",
                    "Cass" => "✨",
                    _ => displayString
                };
            }
            else
            {
                displayString = maze[i, j]
                switch
                {
                    Boxes.obstacle => "🟪",
                    Boxes.path => "⬛",
                    Boxes.trap => "⬛",
                    Boxes.Astharoth => "😈",
                    _ => displayString
                };
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
//   public void AbilityForce(Token token)
//   {
// if (token.name == "Force")
// {
  
// }
//   }
}