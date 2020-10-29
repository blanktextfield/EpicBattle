using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Gordon Freeman", "pepe", "Aang", "Lara Croft", "JOE" };
            string[] villains = { "BIG Smoke", "Darth Vader", "Plankton", "Joker", "Jeff" };


            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            Console.WriteLine($"{hero} will fight {villain}");

            Random rnd = new Random();
            int heroHP = rnd.Next(5, 11);
            int villainHP = rnd.Next(5, 11);
            Console.WriteLine($" {hero} with {heroHP} HP will fight {villain}" + $"{villainHP} HP");

            while (heroHP > 0 && villainHP > 0)
            {
                Random rmd = new Random();
                heroHP = heroHP - rnd.Next(0, 4);
                villainHP = villainHP - rnd.Next(0, 4);
                heroHP = heroHP - Hit(hero);
                villainHP = villainHP - Hit(villain);
            }
            
            GetWinner(heroHP, villainHP);
        }   

        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;
        }
        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        }

        public static int Hit(string character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character} hit {strike}!");
            if (strike == 3)
            {
                Console.WriteLine($"Awesome! {character} made a critical hit!");
            } else if (strike == 0)
            {
                Console.WriteLine($"Bad luck! {character} missed the target!");
            }
            return strike;
        }   
       
         public static void GetWinner(int hHP, int vHP)
        {
           if(hHP == 0)
            {
                Console.WriteLine("Dark Side wins!");
            } else
            {
                Console.WriteLine("Hero saves the day!");
            }
        }
             
    }   

}
