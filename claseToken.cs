class Token
{
    //player asignado, cell donde se encuentra
    public string color { get; set; }
    public float life { get; set; }
    public float attack { get; set; }
    public string hability { get; set; }


    public Token(string color, int life, int attack, string hability)
    {
        this.color = color;
        this.life = life;
        this.attack = attack;
        this.hability = hability;

    }
}
