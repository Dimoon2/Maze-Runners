
public class Programs
{
  static void Main(string[] args)
  {
    while (true)
    {
      //inicio del juego:
      Console.Clear();
      Console.WriteLine("Welcome to: The Sprit Trail by Diana, press A if you want to start this adventure or 1 if you want to exit");
      ConsoleKeyInfo key = Console.ReadKey(true);

      if (key.KeyChar == 'A' || key.KeyChar == 'a')
      {
        Console.Clear();
        Console.WriteLine("In a world where the celestial realm of Elysium and the infernal depths of the Abyss have long been at war");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey(true);
        if (key.KeyChar == 'A' || key.KeyChar == 'a')
        {
          Console.Clear();
          Console.WriteLine("A fragile truce is shattered when a poweful artifact known as the Celestial Heart is stolen from the Archangels");
          Console.WriteLine("This heart, said to contain the essence of creation itself, has fallen into the hands of a cunning demon, Astharoth, who seeks chaos upon both realms");


          Console.WriteLine("Press any key to continue");
          Console.ReadKey(true);
          if (key.KeyChar == 'A' || key.KeyChar == 'a')
          {
            Console.Clear();
            Console.WriteLine("It is known that lord Astharoth hides in a dangerous maze called The Spirit Trail full of mortal traps");
            Console.WriteLine("It is your quest, if you dare, to help the angels and demons recover the weapon and face The Spirit Trail by meeting Astharoth at the middle of the trail");

            Console.WriteLine("Press any key to contine");
            Console.ReadKey(true);


            if (key.KeyChar == 'A' || key.KeyChar == 'a')
            {
              Console.Clear();
              Console.WriteLine("We shall wish you luck, you'll need it ...`");

            }
          }
        }
      }

      else if (key.KeyChar == '1')
      {
        break;
      }
      else
      {
        throw new Exception("What are you doing with your life :/, press A to start or press 1 to exit");
      }

      //personajes
      Console.WriteLine("Player 1 fill your name");
      Player namePlayer1 = new Player(Console.ReadLine() ?? string.Empty);
      Console.WriteLine($"{namePlayer1.name} you are Player 1");

      Console.Clear();
      Console.WriteLine("Player 2 fill your name");
      Player namePlayer2 = new Player(Console.ReadLine() ?? string.Empty);
      Console.WriteLine($"{namePlayer2.name}, you are Player 2");



      //inicializacion del mapa:<3
      Maze mazes = new Maze();
      Boxes[,] maze = mazes.GenerateMaze();
      int NumOfTraps = mazes.NumTraps(maze);


      //Reglas:
      Console.Clear();
      Console.WriteLine($"{namePlayer1.name}, you lead the firt group");
      Console.WriteLine($"{namePlayer2.name}, you lead the second");


      Console.WriteLine("Press any key to continue");
      ConsoleKeyInfo key4 = Console.ReadKey(true);
      if (key.KeyChar == 'A' || key.KeyChar == 'a')
      {
        Console.Clear();
        Console.WriteLine("Whoever kills the beast first, wins the game, you will start in oposite places and have the same chances to win");
        Console.WriteLine($"But be cautious, there are {NumOfTraps} traps in the maze");


        Console.WriteLine("Press any key to continue");
        ConsoleKeyInfo key5 = Console.ReadKey(true);
        Console.Clear();
        if (key.KeyChar == 'A' || key.KeyChar == 'a')
        {
          Console.WriteLine("To select the tokens you must input the number of the one you want0");

          //llamar a los tokens:
          Console.WriteLine("There are six tokens, select wisely");
          Console.WriteLine("WARNING: no token can be selected twice");


          List<Token> tokens = new List<Token>
      {
      new Token("Force", "Demon", 5, 2, "Breaks an obstacle", 5),
      new Token("Shield", "Angel", 6, 1, "If this token falls into a trap, it won't hurt him", -1),
      new Token("Vous", "Demon", 4, 2, "Leaves a trap behind", -1),
      new Token("Vitality", "Angel", 4, 2, "Regenerates its life", 12),
      new Token("Crow", "Demon", 5, 2, "Upgrades 2 points of his attack", -1),
      new Token("Cass", "Angel", 5, 2, "Disables a trap", -1)
      };

          // Mostrar información de los tokens
          foreach (var token in tokens)
          {
            token.DisplayInfo();
          }

          System.Console.WriteLine("Press any key to continue");
          ConsoleKeyInfo key6 = Console.ReadKey(true);
          if (key.KeyChar == 'A' || key.KeyChar == 'a')
          {
            Console.WriteLine("Please select your tokens");
            //seleccion de tokens:
            for (int turn = 0; turn < 3; turn++)
            {
              foreach (Player currentPlayer in new[] { namePlayer1, namePlayer2 })
              {
                Console.WriteLine($"\nIt's {currentPlayer.name} turn:");
                Console.WriteLine("Select a token:");

                // Mostrar los tokens disponibles
                for (int i = 0; i < tokens.Count; i++)
                {
                  Console.WriteLine($"{i} {tokens[i].name}");
                }


                int selection = int.Parse(Console.ReadLine() ?? string.Empty);

                //validar seleccion:
                if (selection >= 0 && selection < tokens.Count)
                {
                  Token SelectedToken = tokens[selection];
                  currentPlayer.AddToken(SelectedToken);
                  SelectedToken.DisplayInfo();

                  tokens.RemoveAt(selection);
                  Console.WriteLine($"{SelectedToken.name} has been selected by {currentPlayer.name} and is no longer available.");
                }
                else
                {
                  Console.WriteLine("Not valid selection.");
                  turn--;
                }

              }
            }


            //resultados finales:
            Console.WriteLine("\nThis are your tokens:");
            namePlayer1.DisplayTokens();
            namePlayer2.DisplayTokens();

          }
        }
      }
      else
      {
        throw new Exception("Please press any key to continue");
      }

      //mostrar maze en terminal:
      Console.Clear();
      List<Token> tokens1 = Token.CreateTokens();
      GameActions.PrintMaze(maze, tokens1);
      Console.WriteLine("Let the game begin...");


      //pedir movimiento
      Console.WriteLine("Please enter: W if you wanna move up, S if you wanna move down, A if you wanna move left and S if you wanna move right");
      string position = Console.ReadLine() ?? string.Empty;

    }
  }
}
