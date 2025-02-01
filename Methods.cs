using NAudio.Wave;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.ComponentModel.DataAnnotations;
class GameActions
{

  public static void DisplaySound(string audioPath)
  {
    string folder = "Audios";
    string dirPath = Path.Combine(Directory.GetCurrentDirectory(), folder, audioPath);
    if (!File.Exists(audioPath))
    {
      Console.WriteLine("Audio file not found :(");
    }
    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
      Thread audioThread = new Thread(() => PlayAudioLoopW(dirPath));
      audioThread.Start();
    }
    static void PlayAudioLoopW(string audio)
    {
      while (true)
      {
        using (var audioFile = new AudioFileReader(audio))
        using (var outputDevice = new WaveOutEvent())
        {
          outputDevice.Init(audioFile);
          outputDevice.Play();
          while (outputDevice.PlaybackState == PlaybackState.Playing)
          {
            Thread.Sleep(100);
          }
        }
      }
    }
  }
  public static void fellInTrap(Token currentToken, Boxes[,] maze)
  {
    List<Trap> allTraps = new List<Trap>
     {
     new Boom(), new Teleport(), new BadLuck()
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
        Console.WriteLine($"Sorry {currentToken.name} cooldown is not enough! \n\nPress a key to continue");
        Console.ReadKey(true);
        Console.Clear();
        Console.WriteLine("Given that you could not activate your super, the trap will affect your token :( \n\nPress a key to continue");
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
          currentToken.Power(maze);
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
    //no activo el super:
    else
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
            Console.Write("  ");
            break;

          case Boxes.obstacle:
            Console.Write("🟪");
            break;

          case Boxes.wall:
            Console.Write("⬛");
            break;

          case Boxes.trap:
            Console.Write("  ");
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

          case Boxes.sword:
            Console.Write("⚔️");
            break;

          case Boxes.elixir:
            Console.Write("🍵");
            break;

          case Boxes.parchment:
            Console.Write("📖");
            break;

          case Boxes.charm:
            Console.Write("📿");
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
}

