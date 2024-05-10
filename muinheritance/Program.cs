namespace muinheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MX-5 VS E31. Kes võidab? Panusta! Esimene või teine!");
            Console.WriteLine("----------------------------------------------------");
            int a = Convert.ToInt32(Console.ReadLine());
            versus Versus = new versus();// versus päringuse kasutamine meethodis
            versus1 Versus1 = new versus1();// versus1 päringuse kasutamine selles meethodis
            Console.WriteLine("MX-5 on {0} HP ja E31 on {1} HP.", Versus1.hp, Versus.hp);
            int e = Versus.hp - Versus1.hp;
            if (a == 1)
            {
                Console.WriteLine("Sa kaotasid. MX-5 "+Versus1.motor +" mootor kaotub E31 "+Versus.motor+". E31 on "+e+" HP rohkem");

            }
            if (a == 2)
            {
                Console.WriteLine("Sa võitsid. MX-5 " + Versus1.motor + " mootor kaotub E31 " + Versus.motor + ". E31 on " + e + " HP rohkem");
            }
        }
    }
    class mx5 //vanem
    {
        public string motor = "2.0L Incline 4";
        public string power = "181-hp";
        
    }
    class E31 // vanem
    {
        public string motor = "4.0L V8";
        public string power = "286-hp";
        
    }

    class versus : E31 //päring mx5st
    {
        public int hp = 286;
    }
    class versus1 : mx5 //päring E31st
    {
        public int hp = 181;
    }
}
