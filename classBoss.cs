public class Boss
{
    public string name { get; set; }
    public float life { get; set; }
    public float attack { get; set; }
    public int[] position { get; set; }

    public virtual void Power()
    {
        Console.WriteLine("The maze has started to trumble...");
        Console.WriteLine("Look out");
        Console.WriteLine();


        Console.WriteLine("Astharoth double attacks by making an expansive wave");
        //metodo de ataque
    }

    public Boss(string name, float life, float attack, int[] position)
    {
        this.name = name;
        this.life = life;
        this.attack = attack;
        this.position = position;

    }

    public static void PresentationBoss(Token token, Boxes[,] maze)
    {
        if (token.inBoss == true)
        {
            Console.Clear();
            Console.WriteLine("He is close, they can feel it\n");
            Console.WriteLine(@" \                           /                 88888888888888888888888888888888888888888888888888888888888888888888888");
            Console.WriteLine(@"  \                         /                  88.._|      | `-.  | `.  -_-_ _-_  _-  _- -_ -  .'|   |.'|     |  _..88");
            Console.WriteLine(@"   \                       /                   88   `-.._  |    |`!  |`.  -_ -__ -_ _- _-_-  .'  |.;'   |   _.!-'|  88");
            Console.WriteLine(@"    ]                     [    ,'|             88      | `-!._  |  `;!  ;. _______________ ,'| .-' |   _!.i'     |  88");
            Console.WriteLine(@"    ]                     [   /  |             88..__  |     |`-!._ | `.| |_______________||.''|  _!.;'   |     _|..88");
            Console.WriteLine(@"    ]___               ___[ ,'   |             88  |``'..__ |    |`'';.| i|_|MMMMMMMMMMM|_|'| _!-|   |   _|..-|'    88");
            Console.WriteLine(@"    ]  ]\             /[  [ |:   |             88   |      |``--..|_ | `;!|l|MMoMMMMoMMM|1|.'j   |_..!-'|     |     88");
            Console.WriteLine(@"    ]  ] \           / [  [ |:   |             88   |      |    |   |`-,!_|_|MMMMP'YMMMM|_||.!-;'  |    |     |     88");
            Console.WriteLine(@"    ]  ]  ]         [  [  [ |:   |             88___|______|____!.,.!,.!,!|d|MMMo * loMM|p|,!,.!.,.!..__|_____|_____88");
            Console.WriteLine(@"    ]  ]  ]__     __[  [  [ |:   |             88      |     |    |  |  | |_|MMMMb,dMMMM|_|| |   |   |    |      |  88");
            Console.WriteLine(@"    ]  ]  ] ]\|_|/[ [  [  [ |:   |             88      |     |    |..!-;'i|r|MPYMoMMMMoM|r| |`-..|   |    |      |  88");
            Console.WriteLine(@"    ]  ]  ] ] (#) [ [  [  [ :===='             88      |    _!.-j'  | _!,'|_|M<>MMMMoMMM|_||!._|  `i-!.._ |      |  88");
            Console.WriteLine(@"    ]  ]  ]_].nHn.[_[  [  [                    88     _!.-'|    | _.'|  !;|1|MbdMMoMMMMM|l|`.| `-._|    |``-.._  |  88");
            Console.WriteLine(@"    ]  ]  ]  HHHHH. [  [  [                    88..-i'     |  _.''|  !-| !|_|MMMoMMMMoMM|_|.|`-. | ``._ |     |``'..88");
            Console.WriteLine(@"    ]  ] /   `HH(N  \ [  [                     88   |      |.|    |.|  !| |u|MoMMMMoMMMM|n||`. |`!   | `'.    |     88");
            Console.WriteLine(@"    ]__]/     HHH    \[__[                     88   |  _.-'  |  .'  |.' |/|_|MMMMoMMMMoM|_|! |`!  `,.|    |-._|     88");
            Console.WriteLine(@"    ]         N/'         [                    88   |  _.-'  |  .'  |.' |/|_|MMMMoMMMMoM|_|! |`!  `,.|    |-._|     88");
            Console.WriteLine(@"    ]         N H         [                    88-'    |   .'   |.|  |/| /                 \|`.  |`!    |.|      |`-88 ");
            Console.WriteLine(@"   /          N            \                   88      |_.'|   .' | .' |/                   \  \ |  `.  | `._-Lee|  88 ");
            Console.WriteLine(@"  /           q,            \                  88     .'   | .'   |/|  /                     \ |`!   |`.|    `.  |  88 ");
            Console.WriteLine(@" /                           \                 88  _.'     !'|   .' | /                       \|  `  |  `.    |`.|  88 ");
            Console.WriteLine(@"/                             \                888888888888888888888888888888888888888888888888888888888888888888888888");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Great warrior, you've made it! \nRemember, Astharoth is a powerful deamon, so you must be cautios\n\nPress any key to continue");
            Console.ReadKey(true);
        }
    }


    public void Attack(Token actualToken)
    {
        Console.WriteLine("Be careful!"); //?
        Console.WriteLine("💥💥💥💥💥💥💥💥💥💥💥💥");
        Console.WriteLine();
        Console.WriteLine("Astharoth attacks!!");

        actualToken.GetDamage(attack);
    }

    public void GetDamage(float damage)
    {
        life -= damage;
        Console.WriteLine($"YOUR TOKEN ATTACKS ATHAROTH AND DEALS HIM {attack} OF DAMAGE!! ");
        Console.WriteLine($"Astharoth current life: {life}");
        Console.WriteLine();
    }

    // public static string Fight(Token token, Boss boss)
    // {
    //     while (true)
    //     {

    //     }
    // }

    //en program:
    //crear al objeto boss: new Boss(name,damage...)
    //llamar al metodo: Astharoth.Power()


    //                                              ,--,  ,.-.
    //                ,                   \,       '-,-`,'-.' | ._
    //               /|           \    ,   |\         }  )/  / `-,',
    //               [ ,          |\  /|   | |        /  \|  |/`  ,`
    //               | |       ,.`  `,` `, | |  _,...(   (      .',
    //               \  \  __ ,-` `  ,  , `/ |,'      Y     (   /_L\
    //                \  \_\,``,   ` , ,  /  |         )         _,/
    //                 \  '  `  ,_ _`_,-,<._.<        /         /
    //                  ', `>.,`  `  `   ,., |_      |         /
    //                    \/`  `,   `   ,`  | /__,.-`    _,   `\
    //                -,-..\  _  \  `  /  ,  / `._) _,-\`       \
    //                 \_,,.) /\    ` /  / ) (-,, ``    ,        |
    //                ,` )  | \_\       '-`  |  `(               \
    //               /  /```(   , --, ,' \   |`<`    ,            |
    //              /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)
    //        ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`
    //       (-, \           ) \ ('_.-._)/ /,`    /
    //       | /  `          `/ \\ V   V, /`     /
    //    ,--\(        ,     <_/`\\     ||      /
    //   (   ,``-     \/|         \-A.A-`|     /
    //  ,>,_ )_,..(    )\          -,,_-`  _--`
    // (_ \|`   _,/_  /  \_            ,--`
    //  \( `   <.,../`     `-.._   _,-`








}