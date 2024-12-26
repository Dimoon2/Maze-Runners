
public class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      ConsoleKeyInfo key = Console.ReadKey();

      if (key.KeyChar == 'A' || key.KeyChar == 'a')
      {
        Console.WriteLine("In a world where the celestial realm of Elysium and the infernal depths of the Abyss have long been at war");
        Console.WriteLine("A fragile truce is shattered when a poweful artifact known as the Celestial Heart is stolen from the Archangels");
        Console.WriteLine("This heart, said to contain the essence of creation itself, has fallen into the hands of a cunning demon, Astharoth, who seeks chaos upon both realms");
        Console.WriteLine("It is known that lord Astharoth hides in a dangerous maze called The Spirit Trail full of mortal traps");
        Console.WriteLine("It is your quest, if you dare, to help the angels and demons recover the weapon and face The Spirit Trail");
        Console.WriteLine("We shall wish you luck, you'll need it ...`");
      }
      else if (key.KeyChar == '1')
      {
        break;
      }
      else
      {
        Console.WriteLine("What are you doing with your life :/, press A to start or press 1 to exit");
      }
      //inicializacion del mapa
      Maze mazes = new Maze();
      Boxes[,] maze = mazes.GenerateMaze();

      //pedir movimiento
      Console.WriteLine("Please enter: W if you wanna move up, S if you wanna move down, A if you wanna move left and S if you wanna move right");
      string position = Console.ReadLine() ?? string.Empty;

    }
  }
}