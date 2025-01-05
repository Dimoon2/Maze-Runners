
public class Programs
{
  static void Main(string[] args)
  {
    while (true)
    {
      //inicio del juego:
      Console.Clear();
      Console.WriteLine("◽◽◽◽MAIN MENU◽◽◽◽");

      Console.WriteLine("Welcome to: The Spirit Trail by Diana, press A if you want to start this adventure or 1 if you want to exit");
      Console.WriteLine("WARNING: if you don't press any the game will close");
      ConsoleKeyInfo key = Console.ReadKey(true);

      if (key.KeyChar == 'A' || key.KeyChar == 'a')
      {
        Console.Clear();
        Console.WriteLine("In a world where the celestial realm of Elysium and the infernal depths of the Abyss have long been at war");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey(true);
        if (key.KeyChar == 'A' || key.KeyChar == 'a')
        {
          Console.Clear();
          Console.WriteLine("A fragile truce is shattered when a poweful artifact known as the Celestial Heart is stolen from the Archangels");
          Console.WriteLine("This heart, said to contain the essence of creation itself, has fallen into the hands of a cunning demon, Astharoth, who seeks chaos upon both realms");
          Console.WriteLine();

          Console.WriteLine("Press any key to continue");
          Console.ReadKey(true);
          if (key.KeyChar == 'A' || key.KeyChar == 'a')
          {
            Console.Clear();
            Console.WriteLine("It is known that lord Astharoth hides in a dangerous maze called The Spirit Trail full of mortal traps");
            Console.WriteLine("It is your quest, if you dare, to help the angels and demons recover the weapon and face The Spirit Trail by meeting Astharoth at the middle of the trail");
            Console.WriteLine();
            Console.WriteLine("Press any key to contine");
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("We shall wish you luck, you'll need it ...`");
            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);

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
      Console.Clear();
      Console.WriteLine("Player 1 fill your name"); //ARREGLAR: QUE NO LO PUEDAN INGRESAR VACIO
      Player Player1 = new Player(Console.ReadLine() ?? string.Empty, false);
      Console.WriteLine($"{Player1.name} you are Player 1");

      Console.WriteLine();
      Console.WriteLine("Press a key to continue");
      Console.ReadKey(true);

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
      Console.WriteLine();
      Console.WriteLine("Press a key to continue");
      Console.ReadKey();


      //inicializacion del mapa:<3
      Maze mazes = new Maze();
      Boxes[,] maze = mazes.GenerateMaze();
      int NumOfTraps = mazes.NumTraps(maze);


      //Reglas:
      Console.Clear();
      Console.WriteLine("◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽");
      Console.WriteLine($"{Player1.name}, you lead the firt group");
      Console.WriteLine("◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽");
      Console.WriteLine($"{Player2.name}, you lead the second");
      Console.WriteLine("◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽");
      Console.WriteLine();


      Console.WriteLine("Press any key to continue");
      Console.ReadKey(true);

      Console.Clear();
      Console.WriteLine("Whoever kills the beast first, wins the game, you will start in oposite places and have the same chances to win");
      Console.WriteLine($"But be cautious, there are {NumOfTraps} traps in the maze");
      Console.WriteLine();

      Console.WriteLine("Press any key to continue");
      Console.ReadKey(true);
      Console.Clear();

      Console.WriteLine("To select the tokens you must input the number of the one you want");
      Console.WriteLine();
      Console.WriteLine("Press any key to continue");
      Console.ReadKey(true);

      //llamar a los tokens:
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("There are six tokens, select wisely");
      Console.WriteLine("WARNING: no token can be selected twice");
      Console.WriteLine();
      Console.WriteLine("Press a key to continue");
      Console.ReadKey();

      //inicializando tokens:
      Token Force = new Token("Force", "Demon", 20, 8, "Breaks an obstacle", 5, 1, [1, 1]);
      Token Shield = new Token("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", -1, 1, [1, 15]);
      Token Vous = new Token("Vous", "Demon", 20, 6, "Leaves a trap behind", -1, 1, [1, 16]);
      Token Vitality = new Token("Vitality", "Angel", 22, 5, "Regenerates its life", 12, 1, [16, 2]);
      Token Crow = new Token("Crow", "Demon", 20, 6, "Upgrades 2 points of his attack", -1, 1, [16, 1]);
      Token Cass = new Token("Cass", "Angel", 20, 6, "Disables a trap", -1, 1, [16, 16]);

      List<Token> tokens = new List<Token>
      {
      new Token("Force", "Demon", 20, 8, "Breaks an obstacle", 5, 1, [1,1]),
      new Token("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", -1, 1, [1,15]),
      new Token("Vous", "Demon", 20, 6, "Leaves a trap behind", -1, 1, [1,16]),
      new Token("Vitality", "Angel", 22, 5, "Regenerates its life", 12 ,1, [16,2]),
      new Token("Crow", "Demon", 20, 6, "Upgrades 2 points of his attack",-1, 1, [16,1]),
      new Token("Cass", "Angel", 20, 6, "Disables a trap", -1, 1, [16,16])
      };

      // Mostrar información de los tokens
      Console.Clear();
      Console.WriteLine("TOKENS AVAILABLE:");
      Console.WriteLine();
      foreach (var token in tokens)
      {
        token.DisplayInfo();
      }

      Console.WriteLine();
      System.Console.WriteLine("Press any key to continue");
      Console.ReadKey(true);

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

          // Validar la selección
          while (!validSelection)
          {
            string written = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(written, out selection) && selection >= 0 && selection < tokens.Count)
            {
              Token selectedToken = tokens[selection];
              currentPlayer.AddToken(selectedToken);
              selectedToken.DisplayInfo();

              tokens.RemoveAt(selection);
              Console.Clear();
              Console.WriteLine($"{selectedToken.name} has been selected by {currentPlayer.name} and is no longer available.");

              Console.WriteLine("Press any key to continue");
              Console.ReadKey(true);
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
      Console.WriteLine("\nTOKENS SELECTED:");
      Console.WriteLine();
      Player1.DisplayTokens();
      Console.WriteLine();
      Player2.DisplayTokens();
      Console.WriteLine();

      Console.WriteLine("Press a key to continue");
      Console.ReadKey(true);

      //mostrar maze en terminal 1:
      List<Token> tokens1 = Token.CreateTokens();
      Console.Clear();
      Console.WriteLine("Let the game begin...");
      Console.WriteLine();
      Console.WriteLine("GENERATING THE MAZE...");
      GameActions.PrintMaze(maze, tokens1);
      Console.WriteLine();

      Console.WriteLine("Press a key to continue");
      Console.ReadKey(true);

      //creando objeto Boss:
      new Boss("Astharoth", 40, 10, [9, 9]);
      //llamar metodo fight:
      

      //Turnos en juego:
      Player1.playerTurn = true;
      Player2.playerTurn = false;
      string tokenDesition = string.Empty;

      while (true)
      {
        if (Player1.playerTurn)
        {
          Console.Clear();
          Console.WriteLine($"It's {Player1.name}'s turn");
          Console.WriteLine();
          Player1.DisplayTokens();
          Console.WriteLine();
          Console.WriteLine();

          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
          Console.WriteLine();
          Console.WriteLine("Please write correctly the name of the token you wish to use");

          bool validToken = false;

          while (!validToken)
          {
            tokenDesition = Console.ReadLine()?.ToLower() ?? string.Empty;

            // Verificar si el token ingresado es válido
            validToken = Player1.SelectedToken.Any(token => token.name.ToLower() == tokenDesition);

            if (!validToken)
            {
              Console.WriteLine("Not valid name. Please write correctly the name of the token you wish to use");
              Player1.DisplayTokens();
            }
          }

          Console.Clear();
          Console.WriteLine("VALID SELECTION!!");
          Console.WriteLine();
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
          Console.WriteLine();

          Console.WriteLine("◽◽◽◽LEYEND◽◽◽◽");
          Console.WriteLine("😡 represents FORCE");
          Console.WriteLine("🛡️ represents SHIELD");
          Console.WriteLine("🌀 represents VOUS");
          Console.WriteLine("🤍 represents VITALITY");
          Console.WriteLine("🦅 represents CROW");
          Console.WriteLine("🎇 represents CASS");
          Console.WriteLine();
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);

          // Asignar el token actual basado en la decisión
          var currentToken = Player1.SelectedToken.First(token => token.name.ToLower() == tokenDesition);

          // Mostrar opciones de movimiento
          Console.WriteLine();
          Console.WriteLine($"You are currently playing with {currentToken.name}");
          Console.WriteLine();
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);

          Console.Clear();
          //Mostrar maze 2:
          Console.WriteLine("CURRENT MAZE:");
          GameActions.PrintMaze(maze, tokens1);
          Console.WriteLine();
          Console.WriteLine("Please write:");
          Console.WriteLine();
          Console.WriteLine("W if you wanna move up");
          Console.WriteLine("S if you wanna move down");
          Console.WriteLine("A if you wanna move left");
          Console.WriteLine("D if you wanna move right");
          Console.WriteLine("And E if you want to activate your super");
          Console.WriteLine();
          Console.WriteLine($"You are currently playing with {currentToken.name}");

          string newPosition = string.Empty; // Inicializa newPosition
          bool validMove = true;

          while (validMove)
          {

            newPosition = Console.ReadLine()?.ToLower() ?? string.Empty;

            // Verificar si la entrada es válida
            validMove = newPosition == "w" || newPosition == "s" || newPosition == "a" || newPosition == "d" || newPosition == "e";

            while (!validMove)
            {
              Console.WriteLine("Not valid selection. Please write: W, S, A, D, or E.");
              newPosition = Console.ReadLine()?.ToLower() ?? string.Empty;
              validMove = newPosition == "w" || newPosition == "s" || newPosition == "a" || newPosition == "d" || newPosition == "e";
              if (validMove)
              {
                break;
              }
            }


            // Intentar mover
            int[] tokenSelectedPosition = Player1.ChangePosition(newPosition, currentToken.currentPosition[0], currentToken.currentPosition[1]);

            // Verificar si puede moverse
            bool wishPosition = Player1.ValidPosition(maze, tokenSelectedPosition[0], tokenSelectedPosition[1]);

            if (wishPosition)
            {
              currentToken.currentPosition = tokenSelectedPosition;
              //lista de tokens basada en la posicion
              List<Token> positionToken = Player1.SelectedToken.Where(token => token.currentPosition.SequenceEqual(tokenSelectedPosition)).ToList();

              //actualizar la lista token1 para imprimir los tokens en su posicion actual:
              for (int i = 0; i < tokens1.Count; i++)
              {
                if (currentToken.name == tokens1[i].name)
                {
                  tokens1[i].currentPosition = tokenSelectedPosition;
                }
              }

              //agregar token a la lista
              positionToken.Add(currentToken);

              Console.Clear();
              Console.WriteLine("You have move successfully!!");
              Console.WriteLine();
              Console.WriteLine($"The current position of {currentToken.name} is now: {currentToken.currentPosition[0]},{currentToken.currentPosition[1]}");

              //mostrar maze 3:
              GameActions.PrintMaze(maze, positionToken); // CAMBIAR: QUE SALGAN TODOS LOS TOKENS!!!
              Console.WriteLine();
              Console.WriteLine("Press any key to continue");
              Console.ReadKey(true);

              break;
            }
            else if (!wishPosition)
            {
              Console.Clear();
              Console.WriteLine("You can't move there!");
              Console.WriteLine();
              Console.WriteLine("Please move to a valid position");
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine("Press any key to continue");
              Console.ReadKey();

              Console.Clear();
              Console.WriteLine("Please write:");
              Console.WriteLine();
              Console.WriteLine(":W if you wanna move up");
              Console.WriteLine("S if you wanna move down");
              Console.WriteLine("A if you wanna move left");
              Console.WriteLine("D if you wanna move right");
              Console.WriteLine("And E if you want to activate your super");
              Console.WriteLine();
              Console.WriteLine($"You are currently playing with {currentToken.name}");

              GameActions.PrintMaze(maze, tokens1);
            }
          }
          // Cambiar el turno
          Player1.playerTurn = false;
          Player2.playerTurn = true;
        }
        else
        {
          Console.Clear();
          Console.WriteLine($"It's {Player2.name}'s turn");
          Console.WriteLine();
          Player2.DisplayTokens();
          Console.WriteLine();
          Console.WriteLine();

          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
          Console.WriteLine();
          Console.WriteLine("Please write correctly the name of the token you wish to use");

          bool validToken = false;

          while (!validToken)
          {
            tokenDesition = Console.ReadLine()?.ToLower() ?? string.Empty;

            // Verificar si el token ingresado es válido
            validToken = Player2.SelectedToken.Any(token => token.name.ToLower() == tokenDesition);

            if (!validToken)
            {
              Console.WriteLine("Not valid name. Please write correctly the name of the token you wish to use");
              Player2.DisplayTokens();
            }
          }

          Console.Clear();
          Console.WriteLine("VALID SELECTION!!");
          Console.WriteLine();
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
          Console.WriteLine();

          Console.WriteLine("◽◽◽◽LEYEND◽◽◽◽");
          Console.WriteLine("😡 represents FORCE");
          Console.WriteLine("🛡️ represents SHIELD");
          Console.WriteLine("🌀 represents VOUS");
          Console.WriteLine("🤍 represents VITALITY");
          Console.WriteLine("🦅 represents CROW");
          Console.WriteLine("🎇 represents CASS");
          Console.WriteLine();
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);

          // Asignar el token actual basado en la decisión
          var currentToken = Player2.SelectedToken.First(token => token.name.ToLower() == tokenDesition);

          // Mostrar opciones de movimiento
          Console.WriteLine();
          Console.WriteLine($"You are currently playing with {currentToken.name}");
          Console.WriteLine();
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);

          Console.Clear();
          //Mostrar maze 2:
          Console.WriteLine("CURRENT MAZE:");
          GameActions.PrintMaze(maze, tokens1);
          Console.WriteLine();
          Console.WriteLine("Please write:");
          Console.WriteLine();
          Console.WriteLine("W if you wanna move up");
          Console.WriteLine("S if you wanna move down");
          Console.WriteLine("A if you wanna move left");
          Console.WriteLine("D if you wanna move right");
          Console.WriteLine("And E if you want to activate your super");
          Console.WriteLine();
          Console.WriteLine($"You are currently playing with {currentToken.name}");

          string newPosition = string.Empty; // Inicializa newPosition
          bool validMove = true;

          while (validMove)
          {

            newPosition = Console.ReadLine()?.ToLower() ?? string.Empty;

            // Verificar si la entrada es válida
            validMove = newPosition == "w" || newPosition == "s" || newPosition == "a" || newPosition == "d" || newPosition == "e";

            while (!validMove)
            {
              Console.WriteLine("Not valid selection. Please write: W, S, A, D, or E.");
              newPosition = Console.ReadLine()?.ToLower() ?? string.Empty;
              validMove = newPosition == "w" || newPosition == "s" || newPosition == "a" || newPosition == "d" || newPosition == "e";
              if (validMove)
              {
                break;
              }
            }


            // Intentar mover
            int[] tokenSelectedPosition = Player2.ChangePosition(newPosition, currentToken.currentPosition[0], currentToken.currentPosition[1]);

            // Verificar si puede moverse
            bool wishPosition = Player2.ValidPosition(maze, tokenSelectedPosition[0], tokenSelectedPosition[1]);

            if (wishPosition)
            {
              currentToken.currentPosition = tokenSelectedPosition;
              //lista de tokens basada en la posicion
              List<Token> positionToken = Player2.SelectedToken.Where(token => token.currentPosition.SequenceEqual(tokenSelectedPosition)).ToList();

              //actualizar la lista token1 para imprimir los tokens en su posicion actual:
              for (int i = 0; i < tokens1.Count; i++)
              {
                if (currentToken.name == tokens1[i].name)
                {
                  tokens1[i].currentPosition = tokenSelectedPosition;
                }
              }

              //agregar token a la lista
              positionToken.Add(currentToken);

              Console.Clear();
              Console.WriteLine("You have move successfully!!");
              Console.WriteLine();
              Console.WriteLine($"The current position of {currentToken.name} is now: {currentToken.currentPosition[0]},{currentToken.currentPosition[1]}");

              //mostrar maze 3:
              GameActions.PrintMaze(maze, positionToken);
              Console.WriteLine();
              Console.WriteLine("Press any key to continue");
              Console.ReadKey(true);

              break;
            }
            else if (!wishPosition)
            {
              Console.Clear();
              Console.WriteLine("You can't move there!");
              Console.WriteLine();
              Console.WriteLine("Please move to a valid position");
              Console.WriteLine();
              Console.WriteLine();
              Console.WriteLine("Press any key to continue");
              Console.ReadKey();

              Console.Clear();
              Console.WriteLine("Please write:");
              Console.WriteLine();
              Console.WriteLine("W if you wanna move up");
              Console.WriteLine("S if you wanna move down");
              Console.WriteLine("A if you wanna move left");
              Console.WriteLine("D if you wanna move right");
              Console.WriteLine("And E if you want to activate your super");
              Console.WriteLine();
              Console.WriteLine($"You are currently playing with {currentToken.name}");

              GameActions.PrintMaze(maze, tokens1);
            }
          }
          // Cambiar el turno
          Player1.playerTurn = true;
          Player2.playerTurn = false;


        }
      }

      // Console.WriteLine("Do you wish to continue?");
      // Console.WriteLine("Write Yes or No");
      // string wishToContinue = Console.ReadLine() ?? string.Empty;
      // while (wishToContinue.ToLower() != "no" || wishToContinue.ToLower() != "yes")
      // {
      //   Console.WriteLine("Please write a valid answer");
      //   Console.WriteLine("Do you wish to continue?, Write Yes or No");
      //   wishToContinue = Console.ReadLine() ?? string.Empty;

      // }
      // if (wishToContinue.ToLower() == "no")
      // {
      //   Console.WriteLine("Game over :()");
      //   break;
      // }

    }
  }
}





