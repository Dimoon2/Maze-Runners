class GameActions
{
  public static void fellInTrap(Token currentToken, Boxes[,] maze)
  {
    List<Trap> allTraps = new List<Trap>
              {
                new Boom(),
                new Teleport(),
                new BadLuck()
              };
    Random randomIndex = new Random();
    int index = randomIndex.Next(allTraps.Count);

    Console.WriteLine("OH NO");
    Console.WriteLine("You have fallen into a trap 💥\nDo you wish to use your super?\nPress 1 if yes");
    ConsoleKeyInfo key1 = Console.ReadKey(true);

    //ver si quiere activar el super:
    if (key1.KeyChar == '1')
    {
      bool super = currentToken.canISuper(currentToken);

      if (!super)
      {
        Console.WriteLine("Given that you could not activate your super, the trap will affect your token :(");
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);
        allTraps[index].Activate(currentToken, maze);

      }
      else if (super)
      {
        if (currentToken.name == "Force")
        {
          //currentToken.Power(maze);
          Console.WriteLine("Sorry, it looks like Force's super does not do much in a trap");
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
          allTraps[index].Activate(currentToken, maze);
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
        }
        else if (currentToken.name == "Shield")
        {
          //currentToken.Power(maze);
          Console.WriteLine("You are safe now\nCurrent trap won't do anything to your token \n\nPress a key to continue");
          Console.ReadKey();
          currentToken.cooldown -= 10;

          Console.WriteLine("Your token uses his shield \nThis trap won't affect him \nPress a key to continue");
          Console.ReadKey(true);
        }
        else if (currentToken.name == "Vous")
        {
          //currentToken.Power(maze);
          Console.WriteLine("Sorry, it looks like Vous's super does not do much in a trap");
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
          allTraps[index].Activate(currentToken, maze);
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
        }
        else if (currentToken.name == "Vitality")
        {
          //currentToken.Power(maze);
          Console.WriteLine("Sorry, it looks like Vitality's super does not do much in a trap");
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
          allTraps[index].Activate(currentToken, maze);
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
        }
        else if (currentToken.name == "Crow")
        {
          //currentToken.Power(maze);
          Console.WriteLine("Sorry, it looks like Crow's super does not do much in a trap");
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
          allTraps[index].Activate(currentToken, maze);
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
        }
        else if (currentToken.name == "Cass")
        {
          currentToken.Power(maze);
          Console.WriteLine("Cass has been saved by this much!!");
          Console.WriteLine("Press a key to continue");
          Console.ReadKey(true);
        }
      }
    }
    else //no activo el super
    {
      Console.WriteLine("You are in a trap \nPress a key to continue");
      Console.ReadKey(true);
      allTraps[index].Activate(currentToken, maze);
    }
  }
  public static void PrintMaze(Boxes[,] maze)
  {
    for (int i = 0; i < Maze.size; i++)
    {
      for (int j = 0; j < Maze.size; j++)
      {
        switch (maze[i, j])
        {
          case Boxes.path:
            Console.Write("⬛");
            break;

          case Boxes.obstacle:
            Console.Write("🟪");
            break;

          case Boxes.trap:
            Console.Write("💥");
            break;

          case Boxes.Astharoth:
            Console.Write("😈");
            break;

          case Boxes.Force:
            Console.Write("😡");
            break;

          case Boxes.Shield:
            Console.Write("🛡️");
            break;

          case Boxes.Vous:
            Console.Write("🌀");
            break;

          case Boxes.Vitality:
            Console.Write("🤍");
            break;

          case Boxes.Crow:
            Console.Write("🦅");
            break;

          case Boxes.Cass:
            Console.Write("🎇");
            break;


          default:
            Console.Write("");
            break;
        }
        //Imprimir el símbolo en la consola
        if (j == Maze.size - 1)
        {
          Console.WriteLine();
        }
      }
    }
  }

  // public static void PrintMaze(Boxes[,] maze, List<Token> tokens)
  // {
  //   for (int i = 0; i < Maze.size; i++)
  //   {
  //     for (int j = 0; j < Maze.size; j++)
  //     {
  //       //utilizo el switch como expresion en vez de casos como lo es su sintaxis basica
  //       string displayString = " ";
  //       Token currentToken = tokens.FirstOrDefault(t => t.currentPosition[0] == i && t.currentPosition[1] == j);
  //       if (currentToken != null)
  //       {
  //         // Imprimir el símbolo del token
  //         displayString = currentToken.name
  //         switch
  //         {
  //           "Force" => "😡",
  //           "Shield" => "🛡️",
  //           "Vous" => "🌀",
  //           "Vitality" => "🤍",
  //           "Crow" => "🦅",
  //           "Cass" => "🎇",
  //           _ => displayString
  //         };
  //       }
  //       else
  //       {
  //         displayString = maze[i, j]
  //         switch
  //         {
  //           Boxes.obstacle => "🟪",
  //           Boxes.path => "⬛",
  //           Boxes.trap => "💥",
  //           Boxes.Astharoth => "😈",
  //           _ => displayString
  //         };
  //       }

  //       Console.Write(displayString);
  //       if (j == Maze.size - 1)
  //       {
  //         Console.WriteLine();
  //       }
  //     }
  //   }
  // }
}
// \                           /
//  \                         /
//   \                       /                           
//    ]                     [    ,'|
//    ]                     [   /  |
//    ]___               ___[ ,'   |
//    ]  ]\             /[  [ |:   |
//    ]  ] \           / [  [ |:   |
//    ]  ]  ]         [  [  [ |:   |
//    ]  ]  ]__     __[  [  [ |:   |
//    ]  ]  ] ]\|_|/[ [  [  [ |:   |
//    ]  ]  ] ] (#) [ [  [  [ :===='
//    ]  ]  ]_].nHn.[_[  [  [
//    ]  ]  ]  HHHHH. [  [  [
//    ]  ] /   `HH("N  \ [  [
//    ]__]/     HHH  "  \[__[
//    ]         NNN         [
//    ]         N/"         [
//    ]         N H         [
//   /          N            \
//  /           q,            \
// /                           \
// 88888888888888888888888888888888888888888888888888888888888888888888888
// 88.._|      | `-.  | `.  -_-_ _-_  _-  _- -_ -  .'|   |.'|     |  _..88
// 88   `-.._  |    |`!  |`.  -_ -__ -_ _- _-_-  .'  |.;'   |   _.!-'|  88
// 88      | `-!._  |  `;!  ;. _______________ ,'| .-' |   _!.i'     |  88
// 88..__  |     |`-!._ | `.| |_______________||."'|  _!.;'   |     _|..88
// 88   |``"..__ |    |`";.| i|_|MMMMMMMMMMM|_|'| _!-|   |   _|..-|'    88
// 88   |      |``--..|_ | `;!|l|MMoMMMMoMMM|1|.'j   |_..!-'|     |     88
// 88   |      |    |   |`-,!_|_|MMMMP'YMMMM|_||.!-;'  |    |     |     88
// 88___|______|____!.,.!,.!,!|d|MMMo * loMM|p|,!,.!.,.!..__|_____|_____88
// 88      |     |    |  |  | |_|MMMMb,dMMMM|_|| |   |   |    |      |  88
// 88      |     |    |..!-;'i|r|MPYMoMMMMoM|r| |`-..|   |    |      |  88
// 88      |    _!.-j'  | _!,"|_|M<>MMMMoMMM|_||!._|  `i-!.._ |      |  88
// 88     _!.-'|    | _."|  !;|1|MbdMMoMMMMM|l|`.| `-._|    |``-.._  |  88
// 88..-i'     |  _.''|  !-| !|_|MMMoMMMMoMM|_|.|`-. | ``._ |     |``"..88
// 88   |      |.|    |.|  !| |u|MoMMMMoMMMM|n||`. |`!   | `".    |     88
// 88   |  _.-'  |  .'  |.' |/|_|MMMMoMMMMoM|_|! |`!  `,.|    |-._|     88
// 88  _!"'|     !.'|  .'| .'|[@]MMMMMMMMMMM[@] \|  `. | `._  |   `-._  88
// 88-'    |   .'   |.|  |/| /                 \|`.  |`!    |.|      |`-88
// 88      |_.'|   .' | .' |/                   \  \ |  `.  | `._-Lee|  88
// 88     .'   | .'   |/|  /                     \ |`!   |`.|    `.  |  88
// 88  _.'     !'|   .' | /                       \|  `  |  `.    |`.|  88
// 88 vanishing point 888888888888888888888888888888888888888888888(FL)888