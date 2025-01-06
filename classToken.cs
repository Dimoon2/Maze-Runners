class Token
{
    public string name { get; set; }
    public string type { get; set; }
    public float life { get; set; }
    public float attack { get; set; }
    public string ability { get; set; }
    public int cooldown { get; set; } // implementar cada cuantas celdas se usa
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
            Force ForceToken = new Force("Force", "Demon", 20, 8, "Breaks an obstacle", 5, 1, [1, 1]); //cada 10 celdas
            Tokens.Add(ForceToken);
            ForceToken.stepLog.Add(new int[] { 1, 1 });

            Shield ShieldToken = new Shield("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", -1, 1, [1, 15]); //solo una vez
            Tokens.Add(ShieldToken);
            ShieldToken.stepLog.Add(new int[] { 1, 15 });

            Vous VousToken = new Vous("Vous", "Demon", 20, 6, "Leaves a trap behind", -1, 1, [1, 16]);
            Tokens.Add(VousToken);
            VousToken.stepLog.Add(new int[] { 1, 16 });

            Vitality VitalityToken = new Vitality("Vitality", "Angel", 22, 5, "This token regenerates its life", 12, 1, [16, 2]);
            Tokens.Add(VitalityToken);
            VitalityToken.stepLog.Add(new int[] { 16, 2 });

            Crow CrowToken = new Crow("Crow", "Demon", 20, 6, "his attack upgrades 2 points", -1, 1, [16, 1]);
            Tokens.Add(CrowToken);
            CrowToken.stepLog.Add(new int[] { 16, 1 });

            Cass CassToken = new Cass("Cass", "Angel", 20, 6, "Disables a trap", -1, 1, [16, 16]);
            Tokens.Add(CassToken);
            CassToken.stepLog.Add(new int[] { 16, 16 });
        }
        return Tokens;
    }

    class Force : Token
    {
        public Force(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {

        }
    }


    class Shield : Token
    {
        public Shield(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Console.WriteLine();
        }

    }

    class Vous : Token
    {
        public Vous(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Console.WriteLine();
        }

    }

    class Vitality : Token
    {
        public Vitality(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Console.WriteLine();
        }

    }

    class Crow : Token
    {
        public Crow(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Console.WriteLine();
        }

    }

    class Cass : Token
    {
        public Cass(string name, string type, float life, int attack, string ability, int cooldown, int speed, int[] currentPosition) : base(name, type, life, attack, ability, cooldown, speed, currentPosition)
        { }
        public override void Power()
        {
            Console.WriteLine();
        }

    }

    //metodo para actualizar la posicion de los tokens:
    // public void RefreshTokenPosition(Token currentToken, int[] wantedPosition)
    // {
    //     currentToken.currentPosition = wantedPosition;
    //     List<Token> tokens1 = Token.CreateTokens();

    //     foreach (var token in tokens1)
    //     {
    //         if (token.name == currentToken.name)
    //         {
    //             token.currentPosition = wantedPosition;
    //         }
    //     }
    // }

    public void Attack(Boss Astharoth)
    {
        Console.WriteLine("Your token seeks for a chance to attack");
        Console.WriteLine();
        Astharoth.GetDamage(attack);
        Console.WriteLine("💥💥💥💥💥💥💥💥💥💥💥💥");
        //Console.WriteLine($"Atharoth's current life is: {life}"); como hacer que sea la de Atharoth
        Console.WriteLine();
        Console.WriteLine("TURN ENDED");
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