
using System.Security.Cryptography.X509Certificates;

public class Programs
{
  static void Main(string[] args)
  {
    while (true)
    {
      //inicio del juego:
      Menu.MainMenu();
      ConsoleKeyInfo key = Console.ReadKey(true);
      if (key.KeyChar == '1')
      {
        break;
      }
      Menu.Intro();

      //jugadores:
      Console.Clear();
      Console.WriteLine("Player 1 fill your name");
      Player Player1 = new Player(Console.ReadLine() ?? string.Empty, false);
      while (Player1.name == string.Empty)
      {
        Console.WriteLine("Not valid name, please write another\nPlayer 1 fill your name");
        Player1 = new Player(Console.ReadLine() ?? string.Empty, true);
      }
      Console.WriteLine($"{Player1.name} you are Player 1\n\nPress a key to continue");
      Console.ReadKey(true);

      Console.Clear();
      Console.WriteLine("Player 2 fill your name");
      Player Player2 = new Player(Console.ReadLine() ?? string.Empty, true);
      while (Player1.name == Player2.name || Player2.name == string.Empty)
      {
        Console.WriteLine("Not valid name, please write another\nPlayer 2 fill your namer");
        Player2 = new Player(Console.ReadLine() ?? string.Empty, true);
      }
      Console.WriteLine($"{Player2.name}, you are Player 2\n\nPress a key to continue");
      Console.ReadKey();

      //Reglas:
      Console.Clear();
      Console.WriteLine($"🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣\n{Player1.name}, you lead the firt group");
      Console.WriteLine($"🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣\n{Player2.name}, you lead the second\n🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣🟣\n\nPress any key to continue");
      Console.ReadKey(true);

      //inicializacion del mapa:<3
      Maze mazes = new Maze();
      Boxes[,] maze = mazes.GenerateMaze();

      //Inicializando tokens:
      List<Token> tokens = new List<Token>();
      Force force = new Force("Force", "Demon", 20, 8, "Breaks an obstacle", 0, 1, [1, 1], Boxes.Force, "😡");
      tokens.Add(force);
      force.stepLog.Add(new int[] { 1, 1 });
      //spawn force:
      maze[1, 1] = Boxes.Force;

      Shield shield = new Shield("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", 0, 1, [1, Maze.size / 2], Boxes.Shield, "🛡️");
      tokens.Add(shield);
      shield.stepLog.Add(new int[] { 1, Maze.size / 2 });
      //spawn shield:
      maze[1, Maze.size / 2] = Boxes.Shield;

      Vous vous = new Vous("Vous", "Demon", 20, 6, "Leaves a trap behind", 0, 1, [1, Maze.size - 2], Boxes.Vous, "🌀");
      tokens.Add(vous);
      vous.stepLog.Add(new int[] { 1, Maze.size - 2 });
      //spawn vous:
      maze[1, Maze.size - 2] = Boxes.Vous;

      Vitality vitality = new Vitality("Vitality", "Angel", 22, 5, "This token regenerates its life", 0, 1, [Maze.size - 2, Maze.size / 2], Boxes.Vitality, "🤍");
      tokens.Add(vitality);
      vitality.stepLog.Add(new int[] { Maze.size - 2, Maze.size / 2 });
      //spawn vitality:
      maze[Maze.size - 2, Maze.size / 2] = Boxes.Vitality;

      Crow crow = new Crow("Crow", "Demon", 20, 6, "his attack upgrades 2 points", 0, 1, [Maze.size - 2, 1], Boxes.Crow, "🦅");
      tokens.Add(crow);
      crow.stepLog.Add(new int[] { Maze.size - 2, 1 });
      //spawn crow:
      maze[Maze.size - 2, 1] = Boxes.Crow;

      Cass cass = new Cass("Cass", "Angel", 20, 6, "Disables a trap", 0, 1, [Maze.size - 2, Maze.size - 2], Boxes.Cass, "🎇");
      tokens.Add(cass);
      cass.stepLog.Add(new int[] { Maze.size - 2, Maze.size - 2 });
      //spawn cass:
      maze[Maze.size - 2, Maze.size - 2] = Boxes.Cass;

      //creando objeto Boss:
      Boss boss = new Boss("Astharoth", 40, 10, [Maze.size / 2, Maze.size / 2]);
      maze[Maze.size / 2, Maze.size / 2] = Boxes.Astharoth;
     
      //agregar trampas:
      Trap.implementedTraps(maze);
      int NumOfTraps = mazes.NumTraps(maze);

      // //agregar objetos:
     Magic.implementMagic(maze);

      Console.Clear();
      Console.WriteLine("Whoever kills the beast first, wins the game, you will start in oposite places and have the same chances to win");
      Console.WriteLine("It looks like you are in luck, there are four hidden objects in the maze that can help you give an end to this\n");
      Thread.Sleep(1000); Thread.Sleep(1000);

      Console.WriteLine($"But be cautious, there are {NumOfTraps} traps in the maze");
      Thread.Sleep(1000); Thread.Sleep(1000);

      Console.WriteLine("WARNING: For each turn, your tokens cooldown will be 1 time bigger\n\nPress any key to continue");
      Console.ReadKey(true);
      Console.Clear();

      Console.WriteLine("To select the tokens you must input the number of the one you want\n\nPress any key to continue");
      Console.ReadKey(true);

      //llamar a los tokens:
      Console.WriteLine("There are six tokens, select wisely\nWARNING: no token can be selected twice\n\nPress a key to continue");
      Console.ReadKey();

      // Mostrar información de los tokens
      Console.Clear();
      Console.WriteLine("TOKENS AVAILABLE: \n");
      foreach (var token in tokens)
      {
        token.DisplayInfo();
        Console.ReadKey(true);
        Console.Clear();
      }

      // Selección de tokens:
      for (int turn = 0; turn < 3; turn++)
      {
        foreach (Player currentPlayer in new[] { Player1, Player2 })
        {
          Console.WriteLine($"\nIt's {currentPlayer.name} turn:");
          Console.WriteLine("Select your adventure companion:");

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
              Console.Clear();
              selectedToken.DisplayInfo();

              tokens.RemoveAt(selection);
              Console.Clear();
              Console.WriteLine($"{selectedToken.name}{selectedToken.visual} has been selected by {currentPlayer.name} and is no longer available!");

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
                Console.Clear();
                Console.WriteLine($"{i} {tokens[i].name}");
              }
            }
          }
        }
      }

      // Resultados finales:
      Console.Clear();
      Console.WriteLine("\nSELECTED TOKENS:\n");
      Player1.DisplayTokens();
      Console.ReadKey(true);
      Console.Clear();
      Player2.DisplayTokens();
      Console.WriteLine("\nPress a key to continue");

      Console.ReadKey(true);

      //mostrar maze en terminal 1:
      Console.Clear();
      Console.WriteLine("Let the game begin...\n");
      Console.WriteLine("⡷⠂𝙶𝙴𝙽𝙴𝚁𝙰𝚃𝙸𝙽𝙶 𝚃𝙷𝙴 𝙻𝙰𝙱𝙴𝚁𝙸𝙽𝚃𝙷 ...⠐⢾");
      GameActions.PrintMaze(maze);
      Console.WriteLine();

      Console.WriteLine("Press a key to continue");
      Console.ReadKey(true);

      //Turnos en juego:
      Player1.playerTurn = true;
      Player2.playerTurn = false;

      while (true)
      {
        if (Player1.playerTurn)
        {
          Console.Clear();
          Console.WriteLine($"It's {Player1.name}'s turn!\n");
          Player1.DisplayTokens();
          Console.ReadKey();
          bool playerSelection = false;
          int selectedToken = 0;

          //para seleccionar el currentToken:
          while (!playerSelection)
          {
            Console.Clear();
            Console.WriteLine("Select the token you wish to use!");
            for (int i = 0; i < Player1.SelectedToken.Count; i++)
            {
              Console.WriteLine(Player1.SelectedToken[i] + (selectedToken == i ? "⬅️" : ""));
            }
            ConsoleKeyInfo move = Console.ReadKey(true);

            if (move.Key == ConsoleKey.UpArrow)
            {
              selectedToken--;
              if (selectedToken < 0) selectedToken = Player1.SelectedToken.Count - 1;
            }
            else if (move.Key == ConsoleKey.DownArrow)
            {
              selectedToken++;
              if (selectedToken >= Player1.SelectedToken.Count) selectedToken = 0;
            }
            else if (move.Key == ConsoleKey.Enter)
            {
              playerSelection = true;
            }
          }
          Console.Clear();
          Console.WriteLine("VALID SELECTION!!\nPress a key to continue");
          Console.ReadKey(true);

          Console.Clear();
          Console.WriteLine("◽◽◽◽LEYEND◽◽◽◽");
          Console.WriteLine("😡 represents FORCE\n🛡️ represents SHIELD\n🌀 represents VOUS\n🤍 represents VITALITY\n🦅 represents CROW\n🎇 represents CASS\nPress a key to continue");
          Console.ReadKey(true);

          // Asignar el token actual basado en la decisión
          var currentToken = Player1.SelectedToken[selectedToken];
          // Mostrar opciones de movimiento
          Console.Clear();
          Console.WriteLine($"You are currently playing with {currentToken.name}{currentToken.visual}\n-Life🧬:{currentToken.life} \n-Attack💥:{currentToken.attack} \n-Cooldoown⌛:{currentToken.cooldown} \n-Ability❤️‍🔥:{currentToken.ability}\n\n");
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);

          Console.Clear();
          //Mostrar maze 2:
          Console.WriteLine("CURRENT MAZE: \n");
          GameActions.PrintMaze(maze);

          Console.WriteLine("Please write: \n W if you wanna move up \nS if you wanna move down \nA if you wanna move left \nD if you wanna move right \n or E if you want to activate your super\n");
          Console.WriteLine($"You are currently playing with {currentToken.name} {currentToken.visual}");

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
            if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.wall)
            {
              Console.WriteLine("You can't move there!\nSelect a valid answer\n\nPress a key to continue");
              Console.ReadKey(true);
            }
            if (wishPosition)
            {
              //si cayo en una trampa:
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.trap)
              {
                //se mueve a la trap
                maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                currentToken.currentPosition = tokenSelectedPosition;
                maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                currentToken.trapped = true;
                GameActions.fellInTrap(currentToken, maze);
              }

              //si es un camino libre
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
                  Console.WriteLine("Lucky one! No trap in this position\nPress a key to continue");
                  Console.ReadKey(true);
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                  currentToken.currentPosition = tokenSelectedPosition;
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                }
              }

              //si va a recoger un objeto:
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.sword || maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.elixir || maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.parchment || maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.charm)
              {
                //verificar en cual cayo:
                //si cayo en la espada:
                if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.sword)
                {
                  if (currentToken.haveElixir == true || currentToken.haveParchment == true || currentToken.haveCharm == true)
                  {
                    Console.Clear();
                    Console.WriteLine($"{currentToken.name} has just find The sword of the depths\n\nBut he already has another magic object so he can't pick it!");
                    Console.WriteLine("Press a key to continue..");
                    Console.ReadKey(true);

                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                    currentToken.isInASword = true;
                  }
                  else
                  {
                    currentToken.haveSword = true;
                    Magic.Sword(currentToken);
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  }
                }
                else if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.elixir)
                {
                  if (currentToken.haveSword == true || currentToken.haveParchment == true || currentToken.haveCharm == true)
                  {
                    Console.Clear();
                    Console.WriteLine($"{currentToken.name} has just find the Elixir of life\n\nBut he already has another magic object so he can't pick it!");
                    Console.WriteLine("Press a key to continue..");
                    Console.ReadKey(true);

                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                    currentToken.isInAElixir = true;
                  }
                  else
                  {
                    currentToken.haveElixir = true;
                    Magic.Elixir(currentToken);
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  }
                }
                //si encontro el pergamino:
                else if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.parchment)
                {
                  if (currentToken.haveSword == true || currentToken.haveElixir == true || currentToken.haveCharm == true)
                  {
                    Console.Clear();
                    Console.WriteLine($"{currentToken.name} has just find the Wisdom Parchment\n\nBut he already has another magic object so he can't pick it!\n");
                    Console.WriteLine("Press a key to continue..");
                    Console.ReadKey(true);

                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                    currentToken.isInAParchment = true;
                  }
                  else
                  {
                    currentToken.haveParchment = true;
                    Magic.Parchment(currentToken);
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  }
                }
                //si encontro el amuleto:
                else if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.charm)
                {
                  if (currentToken.haveSword == true || currentToken.haveParchment == true || currentToken.haveElixir == true)
                  {
                    Console.Clear();
                    Console.WriteLine($"{currentToken.name} has just find the Lucky Charm\n\nBut he already has another magic object so he can't pick it!");
                    Console.WriteLine("Press a key to continue..");
                    Console.ReadKey(true);

                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                    currentToken.isInACharm = true;
                  }
                  else
                  {
                    currentToken.haveCharm = true;
                    Magic.Charm(currentToken);
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  }
                }

              }
              if (currentToken.haveCharm || currentToken.haveSword || currentToken.haveElixir || currentToken.haveParchment)
              {
                currentToken.haveMagic = true;
              }
              //si llego a Astharoth:
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.Astharoth)
              {
                currentToken.inBoss = true;
                
                //llamar al metodo estatico IntroductionBoss:
                Boss.PresentationBoss(currentToken, maze);
                //metodo fight
                Boss.Fight(currentToken, boss, maze, Player1);
                //condicion de victoria:
                if (boss.life <= 0)
                {
                  Boss.Victory(Player1);
                  currentToken.won = true;
                  break;
                }
              }

              //utilizar steplog:
              currentToken.stepLog.Add(new int[] { currentToken.currentPosition[0], currentToken.currentPosition[1] });

              //verificar si estaba en un objeto:
              if (currentToken.isInASword)
              {
                maze[currentToken.stepLog[currentToken.stepLog.Count - 2][0], currentToken.stepLog[currentToken.stepLog.Count - 2][1]] = Boxes.sword;
                currentToken.isInASword = false;
              }
              else if (currentToken.isInAElixir)
              {
                maze[currentToken.stepLog[currentToken.stepLog.Count - 2][0], currentToken.stepLog[currentToken.stepLog.Count - 2][1]] = Boxes.elixir;
                currentToken.isInAElixir = false;
              }
              else if (currentToken.isInAParchment)
              {
                maze[currentToken.stepLog[currentToken.stepLog.Count - 2][0], currentToken.stepLog[currentToken.stepLog.Count - 2][1]] = Boxes.parchment;
                currentToken.isInAParchment = false;
              }
              else if (currentToken.isInACharm)
              {
                maze[currentToken.stepLog[currentToken.stepLog.Count - 2][0], currentToken.stepLog[currentToken.stepLog.Count - 2][1]] = Boxes.charm;
                currentToken.isInACharm = false;
              }

              //Si tiene los objetos que suben por turno:
              if (currentToken.haveParchment)
              {
                Console.Clear();
                currentToken.life += 5;
                Console.WriteLine($"{currentToken.name}'s current health is now of: {currentToken.life} points\n\nPress a key to continue");
                Console.ReadKey(true);
              }
              else if (currentToken.haveCharm)
              {
                Console.Clear();
                currentToken.attack += 5;
                Console.WriteLine($"{currentToken.name}'s current attack is now of: {currentToken.attack} points\n\nPress a key to continue");
                Console.ReadKey(true);
              }

              Console.Clear();
              Console.WriteLine($"You have move successfully!! \n{currentToken.name}'s current life is {currentToken.life}\n\n");
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
              Console.WriteLine("You can't move there!\nPlease move to a valid position\n\nPress any key to continue");
              Console.ReadKey(true);

              Console.Clear();
              Console.WriteLine("Please write: \n W if you wanna move up \nS if you wanna move down \nA if you wanna move left \n D if you wanna move right \nor E if you want yo activate your super\n");
              Console.WriteLine($"You are currently playing with {currentToken.name}");

              GameActions.PrintMaze(maze);
            }
          }

          if (currentToken.won) //condicion de victoria :)
          {
            break;
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
          Player2.DisplayTokens();
          Console.ReadKey(true);
          bool playerSelection = false;
          int selectedToken = 0;

          //current token:
          while (!playerSelection)
          {
            Console.Clear();
            Console.WriteLine("Select the token you wish to use!\n");
            for (int i = 0; i < Player2.SelectedToken.Count; i++)
            {
              Console.WriteLine(Player2.SelectedToken[i] + (selectedToken == i ? "⬅️" : ""));
            }
            ConsoleKeyInfo move = Console.ReadKey(true);

            if (move.Key == ConsoleKey.UpArrow)
            {
              selectedToken--;
              if (selectedToken < 0) selectedToken = Player2.SelectedToken.Count - 1;
            }
            else if (move.Key == ConsoleKey.DownArrow)
            {
              selectedToken++;
              if (selectedToken >= Player2.SelectedToken.Count) selectedToken = 0;
            }
            else if (move.Key == ConsoleKey.Enter)
            {
              playerSelection = true;
            }
          }
          Console.Clear();
          Console.WriteLine("VALID SELECTION!!\nPress a key to continue");
          Console.ReadKey(true);

          Console.Clear();
          Console.WriteLine("◽◽◽◽LEYEND◽◽◽◽");
          Console.WriteLine("😡 represents FORCE\n🛡️ represents SHIELD\n🌀 represents VOUS\n🤍 represents VITALITY\n🦅 represents CROW\n🎇 represents CASS\nPress a key to continue");
          Console.ReadKey(true);

          // Asignar el token actual basado en la decisión
          var currentToken = Player2.SelectedToken[selectedToken];

          // Mostrar opciones de movimiento
          Console.Clear();
          Console.WriteLine($"You are currently playing with {currentToken.name}{currentToken.visual}\n-Life🧬:{currentToken.life} \n-Attack💥:{currentToken.attack} \n-Cooldoown⌛:{currentToken.cooldown} \n-Ability❤️‍🔥:{currentToken.ability}\n\n");
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);

          Console.Clear();
          //Mostrar maze 2:
          Console.WriteLine("CURRENT MAZE: \n");
          GameActions.PrintMaze(maze);

          Console.WriteLine("Please write: \n W if you wanna move up \nS if you wanna move down \nA if you wanna move left \nD if you wanna move right \nor E if you want to activate your super\n");
          Console.WriteLine($"You are currently playing with {currentToken.name} {currentToken.visual}");

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
            if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.wall)
            {
              Console.WriteLine("You can't move there!\nSelect a valid answer\n\nPress a key to continue");
              Console.ReadKey(true);
            }
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

              //si es camino libre:
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
                  Console.WriteLine("Lucky one! No trap in this position\nPress a key to continue");
                  Console.ReadKey(true);
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                  currentToken.currentPosition = tokenSelectedPosition;
                  maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                }
              }

              //si va a recoger un objeto:
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.sword || maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.elixir || maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.parchment || maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.charm)
              {
                //verificar en cual cayo:
                //si cayo en la espada:
                if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.sword)
                {
                  if (currentToken.haveElixir == true || currentToken.haveParchment == true || currentToken.haveCharm == true)
                  {
                    Console.Clear();
                    Console.WriteLine($"{currentToken.name} has just find The sword of the depths\n\nBut he already has another magic object so he can't pick it!");
                    Console.WriteLine("Press a key to continue..");
                    Console.ReadKey(true);

                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                    currentToken.isInASword = true;
                  }
                  else
                  {
                    currentToken.haveSword = true;
                    Magic.Sword(currentToken);
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  }
                }
                else if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.elixir)
                {
                  if (currentToken.haveSword == true || currentToken.haveParchment == true || currentToken.haveCharm == true)
                  {
                    Console.Clear();
                    Console.WriteLine($"{currentToken.name} has just find the Elixir of life\n\nBut he already has another magic object so he can't pick it!");
                    Console.WriteLine("Press a key to continue..");
                    Console.ReadKey(true);

                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                    currentToken.isInAElixir = true;
                  }
                  else
                  {
                    currentToken.haveElixir = true;
                    Magic.Elixir(currentToken);
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  }
                }
                //si encontro el pergamino:
                else if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.parchment)
                {
                  if (currentToken.haveSword == true || currentToken.haveElixir == true || currentToken.haveCharm == true)
                  {
                    Console.Clear();
                    Console.WriteLine($"{currentToken.name} has just find the Wisdom Parchment\n\nBut he already has another magic object so he can't pick it!\n");
                    Console.WriteLine("Press a key to continue..");
                    Console.ReadKey(true);

                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                    currentToken.isInAParchment = true;
                  }
                  else
                  {
                    currentToken.haveParchment = true;
                    Magic.Parchment(currentToken);
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  }
                }
                //si encontro el amuleto:
                else if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.charm)
                {
                  if (currentToken.haveSword == true || currentToken.haveParchment == true || currentToken.haveElixir == true)
                  {
                    Console.Clear();
                    Console.WriteLine($"{currentToken.name} has just find the Lucky Charm\n\nBut he already has another magic object so he can't pick it!");
                    Console.WriteLine("Press a key to continue..");
                    Console.ReadKey(true);

                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                    currentToken.isInACharm = true;
                  }
                  else
                  {
                    currentToken.haveCharm = true;
                    Magic.Charm(currentToken);
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = Boxes.path;
                    currentToken.currentPosition = tokenSelectedPosition;
                    maze[currentToken.currentPosition[0], currentToken.currentPosition[1]] = currentToken.value;
                  }
                }

              }
              if (currentToken.haveCharm || currentToken.haveSword || currentToken.haveElixir || currentToken.haveParchment)
              {
                currentToken.haveMagic = true;
              }

              //si llego a Astharoth:
              if (maze[tokenSelectedPosition[0], tokenSelectedPosition[1]] == Boxes.Astharoth)
              {
                currentToken.inBoss = true;
                if (!currentToken.haveMagic)
                {
                  Console.WriteLine("Mmmm it looks like you don't have any of the magic objects, be careful, Astharoth is a dangerous demon...");
                }

                //llamar al metodo estatico IntroductionBoss:
                Boss.PresentationBoss(currentToken, maze);
                //metodo fight
                Boss.Fight(currentToken, boss, maze, Player2);
                //condicion de victoria:
                if (boss.life <= 0)
                {
                  Boss.Victory(Player2);
                  currentToken.won = true;
                  break;
                }
              }

              //utilizar steplog:
              currentToken.stepLog.Add(new int[] { currentToken.currentPosition[0], currentToken.currentPosition[1] });

              //verificar si estaba en un objeto:
              if (currentToken.isInASword)
              {
                maze[currentToken.stepLog[currentToken.stepLog.Count - 2][0], currentToken.stepLog[currentToken.stepLog.Count - 2][1]] = Boxes.sword;
                currentToken.isInASword = false;
              }
              else if (currentToken.isInAElixir)
              {
                maze[currentToken.stepLog[currentToken.stepLog.Count - 2][0], currentToken.stepLog[currentToken.stepLog.Count - 2][1]] = Boxes.elixir;
                currentToken.isInAElixir = false;
              }
              else if (currentToken.isInAParchment)
              {
                maze[currentToken.stepLog[currentToken.stepLog.Count - 2][0], currentToken.stepLog[currentToken.stepLog.Count - 2][1]] = Boxes.parchment;
                currentToken.isInAParchment = false;
              }
              else if (currentToken.isInACharm)
              {
                maze[currentToken.stepLog[currentToken.stepLog.Count - 2][0], currentToken.stepLog[currentToken.stepLog.Count - 2][1]] = Boxes.charm;
                currentToken.isInACharm = false;
              }

              //Si tiene los objetos que suben por turno:
              if (currentToken.haveParchment)
              {
                Console.Clear();
                currentToken.life += 5;
                Console.WriteLine($"{currentToken.name}'s current health is now of: {currentToken.life} points\n\nPress a key to continue");
                Console.ReadKey(true);
              }
              else if (currentToken.haveCharm)
              {
                Console.Clear();
                currentToken.attack += 5;
                Console.WriteLine($"{currentToken.name}'s current attack is now of: {currentToken.attack} points\n\nPress a key to continue");
                Console.ReadKey(true);
              }

              Console.Clear();
              Console.WriteLine("You have move successfully!!\n");
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
              Console.WriteLine("You can't move there!\nPlease move to a valid position\n\n");
              Console.ReadKey();

              Console.Clear();
              Console.WriteLine("Please write: \n W if you wanna move up \nS if you wanna move down \nA if you wanna move left \nD if you wanna move right \nor E if you want to activate your super\n");
              Console.WriteLine($"You are currently playing with {currentToken.name} {currentToken.visual}");

              GameActions.PrintMaze(maze);
            }
          }

          if (currentToken.won) //condicion de victoria :)
          {
            break;
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
      break;
    }
  }
}






