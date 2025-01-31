public class Magic
{
    public static void Sword(Token token)
    {
        Console.Clear();
        Console.WriteLine("Congrats!!\n\nYou've won the Sword of the Depths, it will upgrade your attack by 20 points\n\nNow go save us warrior\n\n!");
        token.attack += 20;
        Console.WriteLine("Press a key to continue..");
        Console.ReadKey(true);
        Console.Clear();
        Console.WriteLine("NEW OBJECT: \n");

        Console.WriteLine(@"       )");
        Console.WriteLine(@"           (");
        Console.WriteLine(@"         '    }");
        Console.WriteLine(@"       (    '  ");
        Console.WriteLine(@"      '      ( ");
        Console.WriteLine(@"       )  |    ) ");
        Console.WriteLine(@"     '   /|\    `");
        Console.WriteLine(@"    )   / | \  ` ) ");
        Console.WriteLine(@"   {    | | |  {");
        Console.WriteLine(@"  }     | | |  .");
        Console.WriteLine(@"   '    | | |    )");
        Console.WriteLine(@"  (    /| | |\    .");
        Console.WriteLine(@"   .  / | | | \  (");
        Console.WriteLine(@" }    \ \ | / /  .");
        Console.WriteLine(@"  (    \ `-' /    }");
        Console.WriteLine(@"  '    / ,-. \    '");
        Console.WriteLine(@"   }  / / | \ \  }");
        Console.WriteLine(@"  '   \ | | | /   }");
        Console.WriteLine(@" ' (   \| | |/  (");
        Console.WriteLine(@"     )  | | |  )");
        Console.WriteLine(@"     .  | | |  '");
        Console.WriteLine(@"        J | L");
        Console.WriteLine(@"  /|    J_|_L    |\ ");
        Console.WriteLine(@"  \ \___/ o \___/ /");
        Console.WriteLine(@"   \_____ _ _____/");
        Console.WriteLine(@"         |-|");
        Console.WriteLine(@"         |-|");
        Console.WriteLine(@"         |-|");
        Console.WriteLine(@"        ,'-'.");
        Console.WriteLine(@"        '---'");
        Console.WriteLine();

        Console.WriteLine(@" █▀ █░█░█ █▀█ █▀█ █▀▄  █▀█ █▀▀  ▀█▀ █░█ █▀▀  █▀▄ █▀▀ █▀█ ▀█▀ █░█ █▀");
        Console.WriteLine(@" ▄█ ▀▄▀▄▀ █▄█ █▀▄ █▄▀  █▄█ █▀░  ░█░ █▀█ ██▄  █▄▀ ██▄ █▀▀ ░█░ █▀█ ▄█ \n\nPress a key to continue");
        Console.ReadKey(true);
    }

    public static void Elixir(Token token)
    {
        Console.Clear();
        Console.WriteLine("Congrats!!\n\nYou've won the Elixir of life, it will upgrade your health by 20 points\n\nNow go save us warrior!\n\n!");
        token.life += 20;
        Console.WriteLine("Press a key to continue..");
        Console.ReadKey(true);
        Console.Clear();
        Console.WriteLine("NEW OBJECT:\n");
        Console.WriteLine(@"              __ ");
        Console.WriteLine(@"            [()()]");
        Console.WriteLine(@"           ///  \\\");
        Console.WriteLine(@"          //      \\");
        Console.WriteLine(@"          //      \\");
        Console.WriteLine(@"           \      /");
        Console.WriteLine(@"           _\\\///_");
        Console.WriteLine(@"         /          \");
        Console.WriteLine(@"         \\   0    //");
        Console.WriteLine(@"       | \\\      /// |");
        Console.WriteLine(@"       |_[==========]_|\n");

        Console.WriteLine(" █▀▀ █░░ █ ▀▄▀ █ █▀█   █▀█ █▀▀   █░░ █ █▀▀ █▀▀");
        Console.WriteLine(" ██▄ █▄▄ █ █░█ █ █▀▄   █▄█ █▀░   █▄▄ █ █▀░ ██▄\n\n");

        Console.WriteLine($"{token.name}'s life:{token.life}\n\nPress a key to continue..");
        Console.ReadKey(true);

    }

    public static void Parchment(Token token)
    {
        Console.Clear();
        Console.WriteLine($"Congrats!!\n\nYou've won the Wisdom Parchment, it will upgrade your token's health by 5 points for each cell {token.name} visits\n\nNow go save us warrior\n\nPres a key to continue!");
        Console.ReadKey(true);
        //logica
        Console.Clear();
        Console.WriteLine("NEW OBJECT:\n");

        Console.WriteLine(@"(\");
        Console.WriteLine(@" \'\");
        Console.WriteLine(@"  \'\     __________");
        Console.WriteLine(@"  / '|   ()_________)");
        Console.WriteLine(@"  \ '/    \ ~~~~~~~~ \");
        Console.WriteLine(@"    \       \ ~~~~~~   \");
        Console.WriteLine(@"    ==).      \__________\");
        Console.WriteLine(@"   (__)       ()__________)");
        Console.WriteLine();
        Console.WriteLine(" █░█░█ █ █▀ █▀▄ █▀█ █▀▄▀█    █▀█ ▄▀█ █▀█ █▀ █░█ █▀▄▀█ █▀▀ █▄░█ ▀█▀");
        Console.WriteLine(" ▀▄▀▄▀ █ ▄█ █▄▀ █▄█ █░▀░█    █▀▀ █▀█ █▀▄ ▄█ █▀█ █░▀░█ ██▄ █░▀█ ░█░\n\nPress a key to contiue");
        Console.ReadKey(true);
    }

    public static void Charm(Token token)
    {
        Console.Clear();
        Console.WriteLine($"Congrats!!\n\nYou've won the Lucky Charm, it will upgrade your token's attack by 8 points for each cell {token.name} visits\n\nNow go save us warrior\n\nPres a key to continue!");
        Console.ReadKey(true);
        //logica
        Console.Clear();
        Console.WriteLine("NEW OBJECT:\n");

        Console.WriteLine(@"    o--o--=g=--o--o");
        Console.WriteLine(@"   /      .'       \");
        Console.WriteLine(@"   o      '.       o");
        Console.WriteLine(@"    \             /");
        Console.WriteLine(@"     o           o");
        Console.WriteLine(@"      \         /");
        Console.WriteLine(@"       o       o");
        Console.WriteLine(@"        \     /");
        Console.WriteLine(@"         o   o");
        Console.WriteLine(@"          \_/");
        Console.WriteLine(@"           =");
        Console.WriteLine(@"          .^.");
        Console.WriteLine(@"         '   '");
        Console.WriteLine(@"         '. .'");
        Console.WriteLine(@"           !  ");
        Console.WriteLine();
        Console.WriteLine("█░░ █░█ █▀▀ █▄▀ █▄█    █▀▀ █░█ ▄▀█ █▀█ █▀▄▀█");
        Console.WriteLine("█▄▄ █▄█ █▄▄ █░█ ░█░    █▄▄ █▀█ █▀█ █▀▄ █░▀░█\n\nPress a key to continue");
        Console.ReadKey(true);
    }

    public static void implementMagic(Boxes[,] maze)
    {
        List<int[]> paths = new List<int[]>();

        for (int i = 0; i < Maze.size; i++)
        {
            for (int j = 0; j < Maze.size; j++)
            {
                if (maze[i, j] == Boxes.path)
                {
                    paths.Add(new int[] { i, j });
                }
            }
        }
        Random random = new Random();

        //sword:
        int sword = random.Next(paths.Count);
        maze[paths[sword][0], paths[sword][1]] = Boxes.sword;
        paths.RemoveAt(sword);

        //elixir:
        int elixir = random.Next(paths.Count);
        //para que ninguna objeto caiga al lado del otro
        if (maze[paths[elixir][0] - 1, paths[elixir][1]] == Boxes.sword ||
        maze[paths[elixir][0] + 1, paths[elixir][1]] == Boxes.sword ||
        maze[paths[elixir][0], paths[elixir][1] - 1] == Boxes.sword ||
         maze[paths[elixir][0], paths[elixir][1] + 1] == Boxes.sword)
        {
            elixir = random.Next(paths.Count);
            maze[paths[elixir][0], paths[elixir][1]] = Boxes.elixir;
        }
        else { maze[paths[elixir][0], paths[elixir][1]] = Boxes.elixir; }
        paths.RemoveAt(elixir);

        //parchment:
        int parchment = random.Next(paths.Count);
        if (maze[paths[parchment][0] - 1, paths[parchment][1]] == Boxes.sword ||
        maze[paths[parchment][0] + 1, paths[parchment][1]] == Boxes.sword ||
        maze[paths[parchment][0], paths[parchment][1] - 1] == Boxes.sword ||
        maze[paths[parchment][0], paths[parchment][1] + 1] == Boxes.sword)
        {
            parchment = random.Next(paths.Count);
            maze[paths[parchment][0], paths[parchment][1]] = Boxes.parchment;
        }
        else if (maze[paths[parchment][0] - 1, paths[parchment][1]] == Boxes.elixir ||
         maze[paths[parchment][0] + 1, paths[parchment][1]] == Boxes.elixir ||
         maze[paths[parchment][0], paths[parchment][1] - 1] == Boxes.elixir ||
         maze[paths[parchment][0], paths[parchment][1] + 1] == Boxes.elixir)
        {
            parchment = random.Next(paths.Count);
            maze[paths[parchment][0], paths[parchment][1]] = Boxes.parchment;
        }
        else { maze[paths[parchment][0], paths[parchment][1]] = Boxes.parchment; }
        paths.RemoveAt(parchment);

        //charm:
        int charm = random.Next(paths.Count);
        if (maze[paths[charm][0] - 1, paths[charm][1]] == Boxes.sword ||
        maze[paths[charm][0] + 1, paths[charm][1]] == Boxes.sword ||
        maze[paths[charm][0], paths[charm][1] - 1] == Boxes.sword ||
        maze[paths[charm][0], paths[charm][1] + 1] == Boxes.sword)
        {
            charm = random.Next(paths.Count);
            maze[paths[charm][0], paths[charm][1]] = Boxes.charm;
        }
        else if (maze[paths[charm][0] - 1, paths[charm][1]] == Boxes.elixir ||
        maze[paths[charm][0] + 1, paths[charm][1]] == Boxes.elixir ||
        maze[paths[charm][0], paths[charm][1] - 1] == Boxes.elixir ||
        maze[paths[charm][0], paths[charm][1] + 1] == Boxes.elixir)
        {
            charm = random.Next(paths.Count);
            maze[paths[charm][0], paths[charm][1]] = Boxes.charm;
        }
        else if (maze[paths[charm][0] - 1, paths[charm][1]] == Boxes.parchment ||
         maze[paths[charm][0] + 1, paths[charm][1]] == Boxes.parchment || 
         maze[paths[charm][0], paths[charm][1] - 1] == Boxes.parchment || 
         maze[paths[charm][0], paths[charm][1] + 1] == Boxes.parchment)
        {
            charm = random.Next(paths.Count);
            maze[paths[charm][0], paths[charm][1]] = Boxes.charm;
        }
        else { maze[paths[charm][0], paths[charm][1]] = Boxes.charm; }
        paths.RemoveAt(charm);
    }
}


