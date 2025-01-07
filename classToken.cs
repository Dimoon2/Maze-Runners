using System.Diagnostics.CodeAnalysis;

class Token
{
    public string name { get; set; }
    public string type { get; set; }
    public float life { get; set; }
    public float attack { get; set; }
    public string ability { get; set; }
    public int cooldown { get; set; }
    public int speed { get; set; }
    public int[] currentPosition { get; set; }
    public List<int[]> stepLog = new List<int[]>();
    public virtual void Power()
    {
        Console.WriteLine("Using power");
    }
    public Token(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition)
    {
        this.name = name;
        this.type = type;
        this.life = life;
        this.attack = attack;
        this.ability = ability;
        this.cooldown = cooldown;
        this.speed = speed;
        this.currentPosition = currentPosition;
    }
    // Common method for all tokens
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Token: {name}, Type: {type}, Life: {life}, Attack: {attack}, Ability: {ability}, Speed: {speed} Cooldown: {cooldown}");
    }

    //creacion de los tokens:
    public static List<Token> CreateTokens()
    {
        List<Token> Tokens = new List<Token>();
        {
            Force ForceToken = new Force("Force", "Demon", 20, 8, "Breaks an obstacle", 0, 1, [1, 1]); //cada 10 celdas
            Tokens.Add(ForceToken);
            ForceToken.stepLog.Add(new int[] { 1, 1 });

            Shield ShieldToken = new Shield("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", 0, 1, [1, 15]); //solo una vez
            Tokens.Add(ShieldToken);
            ShieldToken.stepLog.Add(new int[] { 1, 15 });

            Vous VousToken = new Vous("Vous", "Demon", 20, 6, "Leaves a trap behind", 0, 1, [1, 16]);
            Tokens.Add(VousToken);
            VousToken.stepLog.Add(new int[] { 1, 16 });

            Vitality VitalityToken = new Vitality("Vitality", "Angel", 22, 5, "This token regenerates its life", 0, 1, [16, 2]);
            Tokens.Add(VitalityToken);
            VitalityToken.stepLog.Add(new int[] { 16, 2 });

            Crow CrowToken = new Crow("Crow", "Demon", 20, 6, "his attack upgrades 2 points", 0, 1, [16, 1]);
            Tokens.Add(CrowToken);
            CrowToken.stepLog.Add(new int[] { 16, 1 });

            Cass CassToken = new Cass("Cass", "Angel", 20, 6, "Disables a trap", 0, 1, [16, 16]);
            Tokens.Add(CassToken);
            CassToken.stepLog.Add(new int[] { 16, 16 });
        }
        return Tokens;
    }
    Maze mazes = new Maze();
    Boxes[,] maze;
    class Force : Token
    {

        public Force(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Token force = new Token("Force", "Demon", 20, 8, "Breaks an obstacle", 5, 1, [1, 1]);
            Console.WriteLine("You have activaded Force's power \nPress W,A,S,D depending of where you want to use it\n\nPress any key to continue");
            ConsoleKeyInfo key = Console.ReadKey(true);
            int[] breakWish = new int[2];
            breakWish[0] = force.currentPosition[0];
            breakWish[1] = force.currentPosition[1];

            while (key.KeyChar == 'W' || key.KeyChar == 'S' || key.KeyChar == 'A' || key.KeyChar == 'D')
            {
                if (key.KeyChar == 'W')
                {
                    breakWish[0] = breakWish[0] - 1;
                    breakWish[1] = breakWish[1];
                    if (maze[breakWish[0], breakWish[1]] == Boxes.obstacle)
                    {
                        maze[breakWish[0], breakWish[1]] = Boxes.path;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("There is nothing to break! \nChoose another coordinate");
                            break;
                        }
                    }
                    break;
                }
                else if (key.KeyChar == 'S')
                {
                    breakWish[0] = breakWish[0] + 1;
                    breakWish[1] = breakWish[1];
                    if (maze[breakWish[0], breakWish[1]] == Boxes.obstacle)
                    {
                        maze[breakWish[0], breakWish[1]] = Boxes.path;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("There is nothing to break! \nChoose another coordinate");
                            break;
                        }
                    }
                    break;
                }
                else if (key.KeyChar == 'A')
                {
                    breakWish[0] = breakWish[0];
                    breakWish[1] = breakWish[1] - 1;
                    if (maze[breakWish[0], breakWish[1]] == Boxes.obstacle)
                    {
                        maze[breakWish[0], breakWish[1]] = Boxes.path;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("There is nothing to break! \nChoose another coordinate");
                            break;
                        }
                    }
                    break;
                }
                else if (key.KeyChar == 'D')
                {
                    breakWish[0] = breakWish[0];
                    breakWish[1] = breakWish[1] + 1;
                    if (maze[breakWish[0], breakWish[1]] == Boxes.obstacle)
                    {
                        maze[breakWish[0], breakWish[1]] = Boxes.path;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("There is nothing to break! \nChoose another coordinate");
                            break;
                        }
                    }
                    break;
                }
            }
            while (key.KeyChar != 'W' || key.KeyChar != 'S' || key.KeyChar != 'A' || key.KeyChar != 'D')
            {
                Console.WriteLine("Not a valid anwser!");
                Console.WriteLine("Press W,A,S,D depending of where you want to use it\n\nPress any key to continue");
                Console.ReadKey(true);
                continue;
            }

            Console.WriteLine("I do not like this wall, let's bring it downnnn!!!! 😡 \n\nPress any key to continue");
            Console.ReadKey(true);

        }
    }


    class Shield : Token
    {
        public Shield(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }

        public override void Power()
        {
            Token shield = new Token("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", -1, 1, [1, 15]);
            Console.WriteLine("You have activated Shield's power\nStarting now if he falls into a trap, it won't hurt him\n\nPress any key to continue");
            Console.ReadKey(true);
            if (maze[shield.currentPosition[0], shield.currentPosition[1]] == Boxes.trap)
            {
                Console.WriteLine("You are safe now\nCurrent trap won't do anything to your token \n\nPress a key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Right now you are not in a trap, use your hability when you are in one \n\nPress a key to continue");
                Console.ReadKey(true);
            }
        }

    }

    class Vous : Token
    {
        public Vous(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Token vous = new Token("Vous", "Demon", 20, 6, "Leaves a trap behind", -1, 1, [1, 16]);
            Console.WriteLine("You have activated Vous's power\nHe will leave a random trap behind\nCareful not to step it!\n\nPress any key to continue");
            int[] newTrap = new int[2];
            //aqui quiero usar stepLog para acceder a la ultima posicion registrada y poner una trampa ahi
            //como accedo a el? :(
            newTrap[0] = vous.currentPosition[0] - 1;
            newTrap[1] = vous.currentPosition[0] - 1;

            Console.WriteLine($"Vous has leave a trap in {newTrap[0]},{newTrap[1]} \n\nPress a key to continue");
            Console.ReadKey(true);
        }

    }

    class Vitality : Token
    {
        public Vitality(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Token vitality = new Token("Vitality", "Angel", 22, 5, "This token regenerates its life", 12, 1, [16, 2]);
            Console.WriteLine("Vitality uses it's angelical power to regenerate it's life \n");
            if (vitality.life <= 22)
            {
                vitality.life = 22;
            }
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);
        }

    }

    class Crow : Token
    {
        public Crow(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Crow crow = new Crow("Crow", "Demon", 20, 6, "his attack upgrades 2 points", -1, 1, [16, 1]);
            Console.WriteLine("A strange smoke aprears from behind your token, he seems to absorve it \n");
            crow.attack += 2;
            Console.WriteLine($"Crow is now 2 points stronger \nCurrent attack power:{crow.attack}\n\nPress a key to continue");
            Console.ReadKey(true);
        }

    }

    class Cass : Token
    {
        public Cass(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Cass cass = new Cass("Cass", "Angel", 20, 6, "Disables a trap", -1, 1, [16, 16]);
            int[] disableTrap = new int[2];
            disableTrap[0] = cass.currentPosition[0];
            disableTrap[1] = cass.currentPosition[1];
            if (maze[disableTrap[0], disableTrap[1]] == Boxes.trap)
            {
                Console.WriteLine("A light appears from the sky and hits the trap \nIt looks like now tis gone");
                maze[disableTrap[0], disableTrap[1]] = Boxes.path;
                Console.WriteLine("Cass has just turn a trap into a free Box!! \n\nPress a key to continue");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("There is nothing to disable \n\nPress a key to continue");
                Console.ReadKey(true);
            }
        }

    }

    public void Attack(Boss Astharoth)
    {
        Console.WriteLine("Your token seeks for a chance to attack");
        Astharoth.GetDamage(attack);
        Console.WriteLine("💥💥💥💥💥💥💥💥💥💥💥💥 \n\nTURN ENDED");
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);
    }

    public void GetDamage(float damage)
    {
        life -= damage;
        Console.WriteLine();

        Console.WriteLine($"Your token recibes {damage} of damage");
        Console.WriteLine($"Current life: {life}");
    }
}

//metodo fight