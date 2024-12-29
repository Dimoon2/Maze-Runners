class Token
{
    //player asignado, cell donde se encuentra
    public string name { get; set; }
    public string type { get; set; }
    public float life { get; set; }
    public float attack { get; set; }
    public string ability { get; set; }
    public int cooldown { get; set; } // implementar cada cuantas celdas se usa
    

        public Token(string name, string type, float life, int attack, string ability, int cooldown)
    {
        this.name = name;
        this.type = type;
        this.life = life;
        this.attack = attack;
        this.ability = ability;
        this.cooldown = cooldown;

    }
    // Common method for all tokens
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Token: {name}, Type: {type}, Life: {life}, Attack: {attack}, Ability: {ability}, Cooldown: {cooldown}");
    }

    //creacion de los tokens:
    public static List<Token> CreateTokens()
    {
        return new List<Token>
        {
      new Token("Force", "Demon", 5, 2, "Breaks an obstacle", 5), //cada 10 celdas
      new Token("Shield", "Angel", 6, 1, "If this token falls into a trap, it won't hurt him", -1), //solo una vez
      new Token("Vous", "Demon", 4, 2, "Leaves a trap behind", -1),
      new Token("Vitality", "Angel", 4, 2, "This token regenerates its life", 12),
      new Token("Crow", "Demon", 5, 2, "his attack upgrades 2 points", -1),
      new Token("Cass", "Angel", 5, 2, "Disables a trap",-1)

       };
    }
}
