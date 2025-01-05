class Trap
{
    public virtual void Traps(Token token, int[,] laberinth)
    {
        Console.WriteLine("You have fallen into a trap 💥");
        Console.WriteLine();
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);
    }

    class Boom : Trap
    {
        public override void Traps(Token token, int[,] laberinth)
        {
            Console.Clear();
            Console.WriteLine("A strange artefact fell of the sky, it looks like a bomb");
            Console.WriteLine("💣");
            Console.WriteLine("OH NO, the bomb exploted, your token's life is now 5 points smaller");
            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);

            token.life -= 5;
            Console.WriteLine($"Actual life: {token.life}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
    }
    class Teleport : Trap
    {
        public override void Traps(Token token, int[,] laberinth)
        {
           Console.Clear();
           Console.WriteLine("A huge bird appears from the sky and takes your token away");
           Console.WriteLine();
           Console.WriteLine("Press any key to continue");
           Console.ReadKey(true);

           Console.Clear();
        //    if ()
        //    {
            
        //    }
           
        }
    }





}