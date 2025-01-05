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
    // step ??
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
        return new List<Token>
        {
      new Token("Force", "Demon", 20, 8, "Breaks an obstacle", 5, 1, [1,1]), //cada 10 celdas
      new Token("Shield", "Angel", 22, 5, "If this token falls into a trap, it won't hurt him", -1, 1, [1,15]), //solo una vez
      new Token("Vous", "Demon", 20, 6, "Leaves a trap behind", -1, 1, [1,16]),
      new Token("Vitality", "Angel", 22, 5, "This token regenerates its life", 12, 1, [16,2]),
      new Token("Crow", "Demon", 20, 6, "his attack upgrades 2 points", -1, 1, [16,1]),
      new Token("Cass", "Angel", 20, 6, "Disables a trap",-1, 1, [16,16])
       };
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