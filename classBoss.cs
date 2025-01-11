using System.Security.Cryptography.X509Certificates;

public class Boss
{
    public string name { get; set; }
    public float life { get; set; }
    public float attack { get; set; }
    public int[] position { get; set; }

    public virtual void Power(Boxes[,] maze)
    {
        Console.WriteLine("The maze has started to trumble...");
        Console.WriteLine("Look out");
        Console.WriteLine();


        Console.WriteLine("Astharoth double attacks by making an expansive wave");
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

            Console.WriteLine("Great! warrior, you've made it! \nRemember, Astharoth is a powerful deamon, so you must be Cautious\n\nPress any key to continue");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("THE POWERFUL ASTHAROTH APEARS\n!!");
            Console.WriteLine("Astharoth: How dare you enter my mazeeee!!??\n");
            Console.WriteLine(@"                                              ,--,  ,.-.");
            Console.WriteLine(@"                ,                   \,       '-,-`,'-.' | ._");
            Console.WriteLine(@"               /|           \    ,   |\         }  )/  / `-,',");
            Console.WriteLine(@"               [ ,          |\  /|   | |        /  \|  |/`  ,`");
            Console.WriteLine(@"               | |       ,.`  `,` `, | |  _,...(   (      .',");
            Console.WriteLine(@"               \  \  __ ,-` `  ,  , `/ |,'      Y     (   /_L\");
            Console.WriteLine(@"                \  \_\,``,   ` , ,  /  |         )         _,/");
            Console.WriteLine(@"                 \  '  `  ,_ _`_,-,<._.<        /         /");
            Console.WriteLine(@"                  ', `>.,`  `  `   ,., |_      |         /");
            Console.WriteLine(@"                    \/`  `,   `   ,`  | /__,.-`    _,   `\");
            Console.WriteLine(@"                -,-..\  _  \  `  /  ,  / `._) _,-\`       \");
            Console.WriteLine(@"                 \_,,.) /\    ` /  / ) (-,, ``    ,        |");
            Console.WriteLine(@"                ,` )  | \_\       '-`  |  `(               \");
            Console.WriteLine(@"               /  /```(   , --, ,' \   |`<`    ,            |");
            Console.WriteLine(@"              /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)");
            Console.WriteLine(@"        ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`");
            Console.WriteLine(@"       (-, \           ) \ ('_.-._)/ /,`    /");
            Console.WriteLine(@"       | /  `          `/ \\ V   V, /`     /");
            Console.WriteLine(@"    ,--\(        ,     <_/`\\     ||      /");
            Console.WriteLine(@"   (   ,``-     \/|         \-A.A-`|     /");
            Console.WriteLine(@"  ,>,_ )_,..(    )\          -,,_-`  _--`");
            Console.WriteLine(@" (_ \|`   _,/_  /  \_            ,--`");
            Console.WriteLine(@"  \( `   <.,../`     `-.._   _,-`");
            Console.WriteLine("\n\nPress a key to continue");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Cautious! The fight will now beging \n\nPress a key to continue");
            Console.ReadKey(true);
        }
    }


    public static void Attack(Token actualToken, Boss boss)
    {
        Console.Clear();
        Console.WriteLine("Be careful!"); //?
        Console.WriteLine("💥💥💥💥💥💥💥💥💥💥💥💥\n");
        Console.WriteLine("Astharoth attacks!!\n\nPress a key to continue");
        Console.ReadKey(true);

        Token.GetDamage(boss, actualToken);
    }

    public static void GetDamage(Boss boss, Token token)
    {
        Console.Clear();
        boss.life -= token.attack;
        Console.WriteLine($"{token.name} ATTACKS ATHAROTH AND DEALS HIM {token.attack} POINTS OF DAMAGE!! ");
        Console.WriteLine($"Astharoth current life: {boss.life}\n\nPress a key to continue");
        Console.ReadKey(true);
    }

    public static void Fight(Token token, Boss boss, Boxes[,] maze, Player player)
    {
        while (true)
        {
            Console.Clear();
            //llamar al metodo attack de token
            Token.Attack(boss, token);
            //llamar al metodo GetDamage de boss
            //Boss.GetDamage(boss, token);
            //llamar al metodo attack de boss
            Boss.Attack(token, boss);
            //llamar al metodo GetDamage de token
            // Token.GetDamage(boss, token);

            if (token.life <= 0)
            {
                //llevar a los tokens a la posicon inicial: 
                token.currentPosition[0] = token.stepLog[0][0];
                token.currentPosition[1] = token.stepLog[0][1];
                token.inBoss = false;
                Console.Clear();
                Console.WriteLine($"Oh no, it looks like we underestimate the power of the demon \nBut don't worry, {token.name} will recover his strength in the starting point.\nYou will have better luck next time, Astharoth health is now of:{boss.life} \n\nPress a key to continue");

                //subirle la vida a mis tokens :"(
                if (token.name == "Force")
                {
                    token.life = 20;
                }
                else if (token.name == "Shield")
                {
                    token.life = 22;
                }
                else if (token.name == "Vous")
                {
                    token.life = 20;
                }
                else if (token.name == "Vitality")
                {
                    token.life = 22;
                }
                else if (token.name == "Crow")
                {
                    token.life = 20;
                }
                else if (token.name == "Cass")
                {
                    token.life = 20;
                }

                Console.ReadKey(true);
                Console.WriteLine("CURRENT MAZE:");
                GameActions.PrintMaze(maze);
                Console.WriteLine("\nPress a key to continue");
                Console.ReadKey(true);
                break;
            }
            //Condicion de victoria
            if (boss.life <= 0)
            {
                Console.Clear();
                Console.WriteLine("Atharoth is dead...\nThe Celestial heart is now yours\n\nPress a key to continue");
                Console.ReadKey(true);
                Console.WriteLine("A bright light apears \nEverything is silent..\n\nPress a key to continue");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("Then.....");
                Console.WriteLine(@"                                    .''.       ");
                Console.WriteLine(@"        .''.      .        *''*    :_\/_:     . ");
                Console.WriteLine(@"       :_\/_:   _\(/_  .:.*_\/_*   : /\ :  .'.:.'.");
                Console.WriteLine(@"   .''.: /\ :   ./)\   ':'* /\ * :  '..'.  -=:o:=-");
                Console.WriteLine(@"  :_\/_:'.:::.    ' *''*    * '.\'/.' _\(/_'.':'.'");
                Console.WriteLine(@"  : /\ : :::::     *_\/_*     -= o =-  /)\    '  *");
                Console.WriteLine(@"   '..'  ':::'     * /\ *     .'/.\'.   '");
                Console.WriteLine(@"       *            *..*         :");
                Console.WriteLine(@"        *");
                Console.WriteLine(@"         *\n\nPress a key to continue");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine($"{player.name} YOU'VE WONNN!!!!!!!!!\nWe have a huge debt with you warrior, honor will grow within your generation, if you ever need anything, don't ever doubt to call\n\nPress a key to continue");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine($"And that's how the leyend of {player.name} was born\n By the mysteries of 𝓣𝓱𝓮 𝓢𝓹𝓲𝓻𝓲𝓽 𝓣𝓻𝓪𝓲𝓵...\n\nPress a key to continue");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("𝓣𝓱𝓮 𝓮𝓷𝓭\n\nPress a key to continue");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("Thank you so much for playing my game :)");
                Console.ReadKey(true);
                break;
            }
        }
    }

    










}