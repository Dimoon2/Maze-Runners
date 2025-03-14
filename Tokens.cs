using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32.SafeHandles;

public class Token
{
    public string name { get; set; }
    public string type { get; set; }
    public float life { get; set; }
    public float attack { get; set; }
    public string ability { get; set; }
    public int cooldown { get; set; }
    public int speed { get; set; }
    public string visual { get; set; }
    public Boxes value;
    public int[] currentPosition { get; set; }
    public List<int[]> stepLog = new List<int[]>();

    //para el movimiento:(no van en el contructor)
    public bool trapped { get; set; }
    public bool inBoss { get; set; }
    public bool haveMagic { get; set; }
    public bool haveSword { get; set; }
    public bool isInASword { get; set; }
    public bool haveElixir { get; set; }
    public bool isInAElixir { get; set; }
    public bool haveParchment { get; set; }
    public bool isInAParchment { get; set; }
    public bool haveCharm { get; set; }
    public bool isInACharm { get; set; }
    public bool won { get; set; }

    //Power para override:
    public virtual void Power(Boxes[,] maze)
    {
        Console.WriteLine("Using power");
    }
    public Token(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition, Boxes value, string visual)
    {
        this.name = name;
        this.type = type;
        this.life = life;
        this.attack = attack;
        this.ability = ability;
        this.cooldown = cooldown;
        this.speed = speed;
        this.currentPosition = currentPosition;
        this.value = value;
        this.visual = visual;
    }
    // Metodo comun para todos los tokens:
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"꧁༺ 𝓣𝓞𝓚𝓔𝓝: {name} {visual} ༻꧂\n");
        Console.WriteLine($"𝓣𝔂𝓹𝓮: {type}\n 𝓛𝓲𝓯𝓮 🧬: {life}\n 𝓐𝓽𝓽𝓪𝓬𝓴 💣: {attack}\n 𝓐𝓫𝓲𝓵𝓲𝓽𝔂 ✨: {ability}\n 𝓢𝓹𝓮𝓮𝓭 🚄: {speed}\n 𝓒𝓾𝓻𝓻𝓮𝓷𝓽 𝓬𝓸𝓸𝓵𝓭𝓸𝔀𝓷 ❄️: {cooldown}\n\n");
    }
    public bool canISuper(Token token)
    {
        if (token.name == "Force")
        {
            if (token.cooldown >= 6) { return true; }
            else { return false; }
        }
        if (token.name == "Shield")
        {
            if (token.cooldown >= 10) { return true; }
            else { return false; }
        }
        if (token.name == "Vous")
        {
            if (token.cooldown >= 12) { return true; }
            else { return false; }
        }
        if (token.name == "Vitality")
        {
            if (token.cooldown >= 6) { return true; }
            else { return false; }
        }
        if (token.name == "Crow")
        {
            if (token.cooldown >= 6) { return true; }
            else { return false; }
        }
        if (token.name == "Cass")
        {
            if (token.cooldown >= 5) { return true; }
            else { return false; }
        }
        else { return false; }
    }

    public static void Attack(Boss boss, Token token)
    {
        Console.Clear();
        Console.WriteLine("Your token seeks for a chance to attack...");
        Boss.GetDamage(boss, token);
        Console.WriteLine("💥💥💥💥💥💥💥💥💥💥💥💥 \n\nTURN ENDED");
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);

    }

    public static void GetDamage(Boss boss, Token token)
    {
        Console.Clear();
        token.life -= boss.attack;
        Console.WriteLine($"Your token recibes {boss.attack} of damage");
        Console.WriteLine($"Current life: {token.life} :(\n\nPress a key to continue");
        Console.ReadKey(true);
    }
}

//CLASES QUE HEREDAN:
public class Force : Token
{

    public Force(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition, Boxes value, string visual) :
     base(name, type, life, attack, ability, cooldown, speed, currentPosition, value, visual)
    { }
    public override void Power(Boxes[,] maze)
    {
        int[] breakWish = new int[2];
        breakWish[0] = currentPosition[0];
        breakWish[1] = currentPosition[1];

        if (cooldown >= 6)
        {
            Console.WriteLine("You have activaded Force's power \nPress W,A,S,D depending of where you want to use it\n");
            Console.WriteLine("WARNING:If you don't choose a valid answer you will lose your turn");
            ConsoleKeyInfo key = Console.ReadKey(true);

            while (!(key.KeyChar == 'w' || key.KeyChar == 's' || key.KeyChar == 'a' || key.KeyChar == 'd'))
            {
                Console.WriteLine("Not a valid anwser!");
                Console.WriteLine("Press W,A,S,D depending of where you want to use it");
                ConsoleKeyInfo key1 = Console.ReadKey(true);
                if (key1.KeyChar == 'w' || key1.KeyChar == 's' || key1.KeyChar == 'a' || key1.KeyChar == 'd')
                {
                    break;
                }
            }
            while (key.KeyChar == 'w' || key.KeyChar == 's' || key.KeyChar == 'a' || key.KeyChar == 'd')
            {
                if (key.KeyChar == 'w')
                {
                    breakWish[0] = breakWish[0] - 1;
                    breakWish[1] = breakWish[1];
                    if (maze[breakWish[0], breakWish[1]] == Boxes.obstacle)
                    {
                        maze[breakWish[0], breakWish[1]] = Boxes.path;
                        Console.Clear();
                        Console.WriteLine("YEAHH!");
                        cooldown -= 6;
                        Console.Clear();
                        Console.WriteLine("I do not like this wall, let's bring it downnnn!!!! 😡");
                        GameActions.PrintMaze(maze);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing to break! Turn lost");
                        Console.ReadKey(true);
                        break;
                    }

                }
                else if (key.KeyChar == 's')
                {
                    breakWish[0] = breakWish[0] + 1;
                    breakWish[1] = breakWish[1];
                    if (maze[breakWish[0], breakWish[1]] == Boxes.obstacle)
                    {
                        maze[breakWish[0], breakWish[1]] = Boxes.path;
                        Console.Clear();
                        Console.WriteLine("YEAHH!");
                        cooldown -= 6;
                        Console.Clear();
                        Console.WriteLine("I do not like this wall, let's bring it downnnn!!!! 😡");
                        GameActions.PrintMaze(maze);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing to break! \n Turn lost\n\nPress a key to continue");
                        Console.ReadKey(true);
                        break;
                    }
                }
                else if (key.KeyChar == 'a')
                {
                    breakWish[0] = breakWish[0];
                    breakWish[1] = breakWish[1] - 1;
                    if (maze[breakWish[0], breakWish[1]] == Boxes.obstacle)
                    {
                        maze[breakWish[0], breakWish[1]] = Boxes.path;
                        Console.Clear();
                        Console.WriteLine("YEAHH!");
                        cooldown -= 6;
                        Console.Clear();
                        Console.WriteLine("I do not like this wall, let's bring it downnnn!!!! 😡");
                        GameActions.PrintMaze(maze);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing to break! \n Turn lost\n\nPress a key to continue");
                        Console.ReadKey(true);
                        break;
                    }
                }
                else if (key.KeyChar == 'd')
                {
                    breakWish[0] = breakWish[0];
                    breakWish[1] = breakWish[1] + 1;
                    if (maze[breakWish[0], breakWish[1]] == Boxes.obstacle)
                    {
                        maze[breakWish[0], breakWish[1]] = Boxes.path;
                        Console.Clear();
                        Console.WriteLine("YEAHH!");
                        cooldown -= 6;
                        Console.Clear();
                        Console.WriteLine("I do not like this wall, let's bring it downnnn!!!! 😡");
                        GameActions.PrintMaze(maze);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing to break! \n Turn lost\n\nPress a key to continue");
                        Console.ReadKey(true);
                        break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine($"Sorry you can't activate Force's super yet \nHis cooldown must be of: 6 \nCurrent cooldown: {cooldown}\n\nPress a key to continue");
            Console.ReadKey(true);
        }
    }
}


public class Shield : Token
{
    public Shield(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition, Boxes value, string visual) : base(name, type, life, attack, ability, cooldown, speed, currentPosition, value, visual)
    { }

    public override void Power(Boxes[,] maze)
    {
        if (cooldown >= 10)
        {
            Console.WriteLine("You have activated Shield's power\nStarting now if he falls into a trap, it won't hurt him\n\nPress any key to continue");
            Console.ReadKey(true);
            if (trapped)
            {
                Console.WriteLine("You are safe now\nCurrent trap won't do anything to your token \n\nPress a key to continue");
                Console.ReadKey();
                cooldown -= 10;
            }
            else
            {
                Console.WriteLine("Right now you are not in a trap, use your hability when you are in one \n\nPress a key to continue");
                Console.ReadKey(true);
            }
        }
        else
        {
            Console.WriteLine($"Sorry you can't activate Shield's super yet \nHis cooldown must be of: 10\nCurrent cooldown: {cooldown} \n\nPress a key to continue");
            Console.ReadKey(true);
        }
    }

}

public class Vous : Token
{
    public Vous(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition, Boxes value, string visual) : base(name, type, life, attack, ability, cooldown, speed, currentPosition, value, visual)
    { }
    public override void Power(Boxes[,] maze)
    {
        if (cooldown >= 12)
        {
            Console.WriteLine("You have activated Vous's power\nHe will leave a random trap behind\nCareful not to step it!\n\nPress any key to continue");
            int[] newTrap = new int[2];
            int[] vouslog = stepLog[stepLog.Count - 1];
            newTrap[0] = vouslog[0];
            newTrap[1] = vouslog[1];
            // maze[newTrap[0], newTrap[1]] = Boxes.trap;
            trapped = true;
            Console.WriteLine($"Vous has leave a trap in {newTrap[0]},{newTrap[1]} \n\nPress a key to continue");
            Console.ReadKey(true);
            cooldown -= 12;
        }
        else
        {
            Console.WriteLine($"Sorry you can't activate Vous's super yet \nHis cooldown must be of: 12 \nCurrent cooldown: {cooldown} \n\nPress a key to continue");
            Console.ReadKey(true);
        }
    }

}

public class Vitality : Token
{
    public Vitality(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition, Boxes value, string visual) : base(name, type, life, attack, ability, cooldown, speed, currentPosition, value, visual)
    { }
    public override void Power(Boxes[,] maze)
    {
        if (cooldown >= 6)
        {
            Console.WriteLine("Vitality uses it's angelical power to regenerate it's life \n");
            if (life <= 22)
            {
                life = 22;
            }
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);
            cooldown -= 12;
        }
        else
        {
            Console.WriteLine($"Sorry you can't activate Vitality's super yet \nHis cooldown must be of: 6 \nCurrent cooldown: {cooldown}\n\nPress a key to continue");
            Console.ReadKey(true);
        }
    }

}

public class Crow : Token
{
    public Crow(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition, Boxes value, string visual) : base(name, type, life, attack, ability, cooldown, speed, currentPosition, value, visual)
    { }
    public override void Power(Boxes[,] maze)
    {
        if (cooldown >= 6)
        {
            Console.WriteLine("A strange smoke aprears from behind your token, he seems to absorve it \n");
            attack += 2;
            Console.WriteLine($"Crow is now 2 points stronger \nCurrent attack power:{attack}\n\nPress a key to continue");
            Console.ReadKey(true);
        }
        else
        {
            Console.WriteLine($"Sorry you can't activate Crow's super yet \nHis cooldown must be of: 6 \nCurrent cooldown: {cooldown} \n\nPress a key to continue");
            Console.ReadKey(true);
        }
    }

}

public class Cass : Token
{
    public Cass(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition, Boxes value, string visual) : base(name, type, life, attack, ability, cooldown, speed, currentPosition, value, visual)
    { }
    public override void Power(Boxes[,] maze)
    {
        if (cooldown >= 5)
        {

            int[] disableTrap = new int[2];
            disableTrap[0] = currentPosition[0];
            disableTrap[1] = currentPosition[1];
            if (trapped)
            {
                Console.WriteLine("A light appears from the sky and hits the trap \nIt looks like now tis gone");
                // maze[disableTrap[0], disableTrap[1]] = Boxes.path;
                trapped = false;
                Console.WriteLine("Cass has just turn a trap into a free Box!! \n\nPress a key to continue");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("There is nothing to disable \n\nPress a key to continue");
                Console.ReadKey(true);
            }
        }
        else
        {
            Console.WriteLine($"Sorry you can't activate Cass's super yet \nHis cooldown must be of: 5 \nCurrent cooldown: {cooldown} \n\nPress a key to continue");
            Console.ReadKey(true);
        }
    }

}

