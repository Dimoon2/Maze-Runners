
using System.Security.Cryptography.X509Certificates;

public class Programs
{
  static void Main(string[] args)
  {
    while (true)
    {
      //inicio del juego:
      Console.Clear();
      Console.WriteLine("꧁༺ 𝓣𝓱𝓮 𝓢𝓹𝓲𝓻𝓲𝓽 𝓣𝓻𝓪𝓲𝓵 ༻꧂");
      Console.WriteLine();
      Console.WriteLine(".                                       ,           .:'                                  `:.");
      Console.WriteLine(")).               -===-               ,((          ::'                                    `::");
      Console.WriteLine("))).                                 ,(((          :: :.                                  .: ::");
      Console.WriteLine("))))).            .:::.           ,((((((           `:. `:.             .             .:'  .:'");
      Console.WriteLine("))))))))).        :. .:        ,(((((((('             `::. `::          !           ::' .::'");
      Console.WriteLine("`))))))))))).     : - :    ,((((((((((((                 `::.`::.    .' ! `.    .::'.::'");
      Console.WriteLine(" ))))))))))))))))_:' ':_((((((((((((((('                   `:.  `::::'':!:``::::'   ::'");
      Console.WriteLine(" `)))))))))))).-' |___/ '-._(((((((((((                    :'*:::.  .:' ! `:.  .:::*`:");
      Console.WriteLine("  `))))_._.-' __)(     )(_  '-._._(((('                   :: HHH::.   ` ! '   .::HHH ::");
      Console.WriteLine("   `))'---)___)))'|_ _/'((((__(---'(('                   ::: `H TH::.  `!'  .::HT H' :::");
      Console.WriteLine("     `))))))))))))|' '|(((((((((((('                     ::..  `THHH:`:   :':HHHT'  ..::");
      Console.WriteLine("       `)))))))))/'   '|((((((((('                       `::      `T: `. .' :T'      ::'");
      Console.WriteLine("        `)))))))|       |((((((('                          `:. .   :         :   . .:'");
      Console.WriteLine("          `))))))|     |(((((('                              `::'               `::'");
      Console.WriteLine("                /'      '                                      :'  .`.  .  .'.  `:");
      Console.WriteLine("               /'        '                                     :' ::.       .:: `:");
      Console.WriteLine("              /'          '                                    :' `:::     :::' `:");
      Console.WriteLine("             /'            '                                    `.  ``     ''  .'");
      Console.WriteLine("            /'              '                                     :`...........':");
      Console.WriteLine("           /'                '                                    ` :`.     .': '");
      Console.WriteLine("             '---..___..---'                                       `:  `'''''  :' ");
      Console.WriteLine();
      Console.WriteLine("Press a key to continue");
      Console.ReadKey(true);

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
      Console.WriteLine("For each turn, your tokens cooldown will be 1 time bigger");
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

      // //inicializando tokens:
      // Force Forcetoken = new Token("Force", "Demon", 20, 8, "Breaks an obstacle", 0, 1, [1, 1]);
      // Token Shield = new Token("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", 0, 1, [1, 15]);
      // Token Vous = new Token("Vous", "Demon", 20, 6, "Leaves a trap behind", 0, 1, [1, 16]);
      // Token Vitality = new Token("Vitality", "Angel", 22, 5, "Regenerates its life", 0, 1, [16, 2]);
      // Token Crow = new Token("Crow", "Demon", 20, 6, "Upgrades 2 points of his attack", -1, 1, [16, 1]);
      // Token Cass = new Token("Cass", "Angel", 20, 6, "Disables a trap", 0, 1, [16, 16]);
      //creacion de los tokens:

      List<Token> tokens = new List<Token>();
      Force force = new Force("Force", "Demon", 20, 8, "Breaks an obstacle", 0, 1, [1, 1], Boxes.Force);
      tokens.Add(force);
      force.stepLog.Add(new int[] { 1, 1 });
      //spawn force:
      maze[1, 1] = Boxes.Force;

      Shield shield = new Shield("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", 0, 1, [1, 15], Boxes.Shield);
      tokens.Add(shield);
      shield.stepLog.Add(new int[] { 1, 15 });
      //spawn shield:
      maze[1, 15] = Boxes.Shield;

      Vous vous = new Vous("Vous", "Demon", 20, 6, "Leaves a trap behind", 0, 1, [1, 16], Boxes.Vous);
      tokens.Add(vous);
      vous.stepLog.Add(new int[] { 1, 16 });
      //spawn vous:
      maze[1, 16] = Boxes.Vous;

      Vitality vitality = new Vitality("Vitality", "Angel", 22, 5, "This token regenerates its life", 0, 1, [16, 2], Boxes.Vitality);
      tokens.Add(vitality);
      vitality.stepLog.Add(new int[] { 16, 2 });
      //spawn vitality:
      maze[16, 2] = Boxes.Vitality;

      Crow crow = new Crow("Crow", "Demon", 20, 6, "his attack upgrades 2 points", 0, 1, [16, 1], Boxes.Crow);
      tokens.Add(crow);
      crow.stepLog.Add(new int[] { 16, 1 });
      //spawn crow:
      maze[16, 1] = Boxes.Crow;

      Cass cass = new Cass("Cass", "Angel", 20, 6, "Disables a trap", 0, 1, [16, 16], Boxes.Cass);
      tokens.Add(cass);
      cass.stepLog.Add(new int[] { 16, 16 });
      //spawn cass:
      maze[16, 16] = Boxes.Cass;

      // Mostrar información de los tokens
      Console.Clear();
      Console.WriteLine("TOKENS AVAILABLE: \n");
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

      Console.Clear();
      Console.WriteLine("Let the game begin...");
      Console.WriteLine();
      Console.WriteLine("⡷⠂𝙶𝙴𝙽𝙴𝚁𝙰𝚃𝙸𝙽𝙶 𝚃𝙷𝙴 𝙻𝙰𝙱𝙴𝚁𝙸𝙽𝚃𝙷 ...⠐⢾");
      GameActions.PrintMaze(maze);
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
          Console.WriteLine("CURRENT MAZE: \n");
          GameActions.PrintMaze(maze);

          Console.WriteLine("Please write: \n W if you wanna move up \nS if you wanna move down \nA if you wanna move left \nD if you wanna move right \n or E if you want to activate your super");
          Console.WriteLine();
          Console.WriteLine($"You are currently playing with {currentToken.name}");

          string action = string.Empty; // Inicializa action
          bool validMove = true;

          while (validMove)
          {
            action = Console.ReadLine()?.ToLower() ?? string.Empty;

            // Verificar si la entrada es válida
            validMove = action == "w" || action == "s" || action == "a" || action == "d" || action == "e";

            while (!validMove)
            {
              Console.WriteLine("Not valid selection. Please write: W, S, A, D, or E.");
              action = Console.ReadLine()?.ToLower() ?? string.Empty;
              validMove = action == "w" || action == "s" || action == "a" || action == "d" || action == "e";
              if (validMove)
              {
                break;
              }
            }


            // Intentar mover
            int[] tokenSelectedPosition = Player1.SelectedAction(action, currentToken.currentPosition[0], currentToken.currentPosition[1], currentToken, maze);

            // Verificar si puede moverse
            bool wishPosition = Player1.ValidPosition(maze, tokenSelectedPosition[0], tokenSelectedPosition[1]);

            if (wishPosition)
            {
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.trap)
              {

                //se mueve a la trap
                maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                currentToken.currentPosition = tokenSelectedPosition;
                maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                currentToken.trapped = true;
                GameActions.fellInTrap(currentToken, maze);

              }
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.path)
              {
                if (currentToken.trapped)
                {
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.trap;
                  currentToken.currentPosition = tokenSelectedPosition;
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  currentToken.trapped = false;
                }
                else
                {
                  //si no cayo en una trampa:
                  Console.WriteLine("No trap in this position");
                  Console.WriteLine("Press a key to continue");
                  Console.ReadKey(true);
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                  currentToken.currentPosition = tokenSelectedPosition;
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                }
              }

              //utilizar steplog:
              currentToken.stepLog.Add(new int[] { currentToken.currentPosition[0], currentToken.currentPosition[1] });

              Console.Clear();
              Console.WriteLine("You have move successfully!!");
              Console.WriteLine();
              Console.WriteLine($"The current position of {currentToken.name} is now: {currentToken.currentPosition[0]},{currentToken.currentPosition[1]}");

              //mostrar maze 3:
              GameActions.PrintMaze(maze);
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
              Console.WriteLine("Please write: \n W if you wanna move up \nS if you wanna move down \nA if you wanna move left \n D if you wanna move right \nor E if you want yo activate your super");
              Console.WriteLine();
              Console.WriteLine($"You are currently playing with {currentToken.name}");

              GameActions.PrintMaze(maze);
            }
          }

          //actualizar cooldown de los tokens
          Player1.SelectedToken[0].cooldown++;
          Player1.SelectedToken[1].cooldown++;
          Player1.SelectedToken[2].cooldown++;

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
          Console.WriteLine("CURRENT MAZE: \n");
          GameActions.PrintMaze(maze);

          Console.WriteLine("Please write: \n W if you wanna move up \nS if you wanna move down \nA if you wanna move left \nD if you wanna move right \nor E if you want to activate your super");
          Console.WriteLine();
          Console.WriteLine($"You are currently playing with {currentToken.name}");

          string action = string.Empty; // Inicializa action
          bool validMove = true;

          while (validMove)
          {
            action = Console.ReadLine()?.ToLower() ?? string.Empty;

            // Verificar si la entrada es válida
            validMove = action == "w" || action == "s" || action == "a" || action == "d" || action == "e";

            while (!validMove)
            {
              Console.WriteLine("Not valid selection. Please write: W, S, A, D, or E.");
              action = Console.ReadLine()?.ToLower() ?? string.Empty;
              validMove = action == "w" || action == "s" || action == "a" || action == "d" || action == "e";
              if (validMove)
              {
                break;
              }
            }


            // Intentar mover
            int[] tokenSelectedPosition = Player2.SelectedAction(action, currentToken.currentPosition[0], currentToken.currentPosition[1], currentToken, maze);

            // Verificar si puede moverse
            bool wishPosition = Player2.ValidPosition(maze, tokenSelectedPosition[0], tokenSelectedPosition[1]);

            if (wishPosition)
            {
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.trap)
              {

                //se mueve a la trap
                maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                currentToken.currentPosition = tokenSelectedPosition;
                maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                currentToken.trapped = true;
                GameActions.fellInTrap(currentToken, maze);

              }
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.path)
              {
                if (currentToken.trapped)
                {
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.trap;
                  currentToken.currentPosition = tokenSelectedPosition;
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  currentToken.trapped = false;
                }
                else
                {
                  //si no cayo en una trampa:
                  Console.WriteLine("No trap in this position");
                  Console.WriteLine("Press a key to continue");
                  Console.ReadKey(true);
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                  currentToken.currentPosition = tokenSelectedPosition;
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                }
              }
              //utilizar steplog:
              currentToken.stepLog.Add(new int[] { currentToken.currentPosition[0], currentToken.currentPosition[1] });

              Console.Clear();
              Console.WriteLine("You have move successfully!!");
              Console.WriteLine();
              Console.WriteLine($"The current position of {currentToken.name} is now: {currentToken.currentPosition[0]},{currentToken.currentPosition[1]}");

              //mostrar maze 3:
              GameActions.PrintMaze(maze);
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
              Console.WriteLine("Please write: \n W if you wanna move up \nS if you wanna move down \nA if you wanna move left \nD if you wanna move right \nor E if you want to activate your super");
              Console.WriteLine();
              Console.WriteLine($"You are currently playing with {currentToken.name}");

              GameActions.PrintMaze(maze);
            }
          }

          //actualizar cooldown de los tokens:
          Player2.SelectedToken[0].cooldown++;
          Player2.SelectedToken[1].cooldown++;
          Player2.SelectedToken[2].cooldown++;

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






