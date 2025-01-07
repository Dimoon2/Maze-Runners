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
            "Force" => "😡",
            "Shield" => "🛡️",
            "Vous" => "🌀",
            "Vitality" => "🤍",
            "Crow" => "🦅",
            "Cass" => "🎇",
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
            Boxes.trap => "💥",
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