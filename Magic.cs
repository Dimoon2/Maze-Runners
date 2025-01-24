public class Magic
{
    public int[] position { get; set; }

    public Magic(int[] position)
    {
        this.position = position;
    }
    public static void Sword(Token token)
    {
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
}


