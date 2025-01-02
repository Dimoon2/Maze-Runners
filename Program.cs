
public class Programs
{
  static void Main(string[] args)
  {
    while (true)
    {
      //inicio del juego:
      Console.Clear();
      Console.WriteLine("◽◽◽◽MAIN MENU◽◽◽◽");

      Console.WriteLine("Welcome to: The Sprit Trail by Diana, press A if you want to start this adventure or 1 if you want to exit");
      Console.WriteLine("WARNING: if you don't press any the game will close");
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
        throw new Exception("What are you doing with your life :/, game over");
      }

      //personajes
      Console.WriteLine("Player 1 fill your name");
      Player Player1 = new Player(Console.ReadLine() ?? string.Empty, false);
      Console.WriteLine($"{Player1.name} you are Player 1");

      Console.Clear();
      Console.WriteLine("Player 2 fill your name");
      Player Player2 = new Player(Console.ReadLine() ?? string.Empty, true);
      while (Player1.name == Player2.name)
      {
        Console.WriteLine("Not valid name, please write another");
        Console.WriteLine("Player 2 fill your name");
        Player2 = new Player(Console.ReadLine() ?? string.Empty, true);
      }
      Console.WriteLine($"{Player2.name}, you are Player 2");



      //inicializacion del mapa:<3
      Maze mazes = new Maze();
      Boxes[,] maze = mazes.GenerateMaze();
      int NumOfTraps = mazes.NumTraps(maze);


      //Reglas:
      Console.Clear();
      Console.WriteLine($"{Player1.name}, you lead the firt group");
      Console.WriteLine($"{Player2.name}, you lead the second");


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
          Console.WriteLine("To select the tokens you must input the number of the one you want");

          //llamar a los tokens:
          Console.WriteLine("There are six tokens, select wisely");
          Console.WriteLine("WARNING: no token can be selected twice");

          //inicializando tokens:
          Token Force = new Token("Force", "Demon", 5, 2, "Breaks an obstacle", 5, 2, [1, 1]);
          Token Shield = new Token("Shield", "Angel", 6, 1, "If this token falls into a trap, it won't hurt him", -1, 2, [1, 15]);
          Token Vous = new Token("Vous", "Demon", 4, 2, "Leaves a trap behind", -1, 3, [1, 16]);
          Token Vitality = new Token("Vitality", "Angel", 4, 2, "Regenerates its life", 12, 3, [16, 2]);
          Token Crow = new Token("Crow", "Demon", 5, 2, "Upgrades 2 points of his attack", 2, -1, [16, 1]);
          Token Cass = new Token("Cass", "Angel", 5, 2, "Disables a trap", -1, 3, [16, 16]);

          List<Token> tokens = new List<Token>
      {
      new Token("Force", "Demon", 5, 2, "Breaks an obstacle", 5, 2, [1,1]),
      new Token("Shield", "Angel", 6, 1, "If this token falls into a trap, it won't hurt him", -1, 2, [1,15]),
      new Token("Vous", "Demon", 4, 2, "Leaves a trap behind", -1, 3, [1,16]),
      new Token("Vitality", "Angel", 4, 2, "Regenerates its life", 12 ,3, [16,2]),
      new Token("Crow", "Demon", 5, 2, "Upgrades 2 points of his attack",2, -1, [16,1]),
      new Token("Cass", "Angel", 5, 2, "Disables a trap", -1, 3, [16,16])
      };

          // Mostrar información de los tokens
          foreach (var token in tokens)
          {
            token.DisplayInfo();
          }

          System.Console.WriteLine("Press any key to continue");
          if (key.KeyChar == 'A' || key.KeyChar == 'a')
          {
            Console.WriteLine("Please select your tokens");
            // Selección de tokens:
            for (int turn = 0; turn < 3; turn++)
            {
              foreach (Player currentPlayer in new[] { Player1, Player2 })
              {
                Console.WriteLine($"\nIt's {currentPlayer.name} turn:");
                Console.WriteLine("Select a token:");

                // Mostrar los tokens disponibles
                for (int i = 0; i < tokens.Count; i++)
                {
                  Console.WriteLine($"{i} {tokens[i].name}");
                }

                int selection;
                bool validSelection = false;

                // Bucle para validar la selección
                while (!validSelection)
                {
                  string written = Console.ReadLine() ?? string.Empty;
                  if (int.TryParse(written, out selection) && selection >= 0 && selection < tokens.Count)
                  {
                    Token selectedToken = tokens[selection];
                    currentPlayer.AddToken(selectedToken);
                    selectedToken.DisplayInfo();

                    tokens.RemoveAt(selection);
                    Console.WriteLine($"{selectedToken.name} has been selected by {currentPlayer.name} and is no longer available.");
                    validSelection = true;
                  }
                  else
                  {
                    Console.WriteLine("Not valid selection. Please select a valid token index:");
                    // Mostrar nuevamente los tokens disponibles
                    for (int i = 0; i < tokens.Count; i++)
                    {
                      Console.WriteLine($"{i} {tokens[i].name}");
                    }
                  }
                }
              }
            }

            // Resultados finales:
            Console.Clear();
            Console.WriteLine("\nThese are your tokens:");
            Player1.DisplayTokens();
            Player2.DisplayTokens();

            //mostrar maze en terminal:
            List<Token> tokens1 = Token.CreateTokens();
            Console.WriteLine("Let the game begin...");
            GameActions.PrintMaze(maze, tokens1);

            while (true)
            {
              if (Player1.playerTurn)
              {
                Console.WriteLine($"It's {Player1}'s turn");
                Player1.DisplayTokens();
                Console.WriteLine("Please write correctly the name of the token you wish to use");

                string tokenDesition = Console.ReadLine() ?? string.Empty;

                while (tokenDesition != Player1.SelectedToken[0].name || tokenDesition != Player1.SelectedToken[1].name || tokenDesition != Player1.SelectedToken[3].name)
                {
                  Console.WriteLine("Not valid name");
                  Console.WriteLine("Please write correctly the name of the token you wish to use");
                  Player1.DisplayTokens();
                  tokenDesition = Console.ReadLine() ?? string.Empty;
                }

                Console.WriteLine("VALID SELECTION!!");
                var currentToken = Force;
                if (tokenDesition.ToLower() == "force")
                {
                  currentToken = Force;
                }
                else if (tokenDesition.ToLower() == "shield")
                {
                  currentToken = Shield;
                }
                else if (tokenDesition.ToLower() == "vous")
                {
                  currentToken = Vous;
                }
                 else if (tokenDesition.ToLower() == "vitality")
                {
                  
                  currentToken = Vitality;
                }
                 else if (tokenDesition.ToLower() == "crow" )
                {
                  currentToken = Crow;
                }
                else if (tokenDesition.ToLower() == "cass")
                {
                  currentToken = Cass;
                }
                  //Show maze 2:
                  GameActions.PrintMaze(maze, tokens1);

                //pedir movimiento
                Console.WriteLine("Please enter: W if you wanna move up, S if you wanna move down, A if you wanna move left and S if you wanna move right");
                string newPosition = Console.ReadLine() ?? string.Empty;
              //  Player1.GetPosition(newPosition,int)



                //cambiar el turno
                Player1.playerTurn = false;
                Player2.playerTurn = true;

              }
              else
              {
                Console.WriteLine($"It's {Player2}'s turn");
                Player2.DisplayTokens();
                Console.WriteLine("Please write correctly the name of the token you wish to use");

                string tokenDesition = Console.ReadLine() ?? string.Empty;

                // Cambiar el turno
                Player1.playerTurn = true;
                Player2.playerTurn = false;
              }

              Console.WriteLine("Do you wish to continue?");
              Console.WriteLine("Write Yes or No");
              string wishToContinue = Console.ReadLine() ?? string.Empty;

              if (wishToContinue == "NO" || wishToContinue == "No" || wishToContinue == "no")
              {
                Console.WriteLine("Game over :()");
                break;
              }
              while (wishToContinue != "NO" || wishToContinue != "No" || wishToContinue != "no" || wishToContinue != "YES" || wishToContinue != "Yes" || wishToContinue != "yes")
              {
                Console.WriteLine("Please write a valid answer");
                Console.WriteLine("Do you wish to continue?, Write Yes or No");
                wishToContinue = Console.ReadLine() ?? string.Empty;

              }
            }
          }
        }
      }
    }
  }
}

