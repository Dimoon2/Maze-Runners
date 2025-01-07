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