using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();
            Console.WriteLine("First player what is your name?");
            game.Player1.Name = Console.ReadLine();
            


            Console.WriteLine("Second player what is your name?");
            game.Player2.Name = Console.ReadLine();


            Console.WriteLine("Welcome {0} and {1}", game.Player1.Name, game.Player2.Name);
            
              Console.WriteLine("Player 1 Where do you want your ship on the Y axis");
            game.Player1.Board.Ship.Y = int.Parse(Console.ReadLine());

                  Console.WriteLine("Player 1 Where do you want your ship on the X axis");
            game.Player1.Board.Ship.X = int.Parse(Console.ReadLine());

              Console.WriteLine("Player 2 Where do you want your ship on the Y axis");
            game.Player2.Board.Ship.Y = int.Parse(Console.ReadLine());

                  Console.WriteLine("Player 2 Where do you want your ship on the X axis");
            game.Player2.Board.Ship.X = int.Parse(Console.ReadLine());

            Console.WriteLine("Player 1 which way do you want your ship to face.");
            string direction = Console.ReadLine();
            if(direction == "horizontal")
            {
                game.Player1.Board.Ship.Direction = Direction.horizontal;
            }
            else
            {
                game.Player1.Board.Ship.Direction = Direction.vertial;
            }


              Console.WriteLine("Player 2 which way do you want your ship to face.");
            direction = Console.ReadLine();
            if(direction == "horizontal")
            {
                game.Player2.Board.Ship.Direction = Direction.horizontal;
            }
            else
            {
                game.Player2.Board.Ship.Direction = Direction.vertial;
            }
            Console.WriteLine(" Player 1 where do you wanna shoot on the y axis");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Player 1 where do you wanna shoot on the x axis");
            int x = int.Parse(Console.ReadLine());

            bool ishit = game.Shoot(x, y);

            if(ishit)
            {
                Console.WriteLine("You hit");
            }
            
            else{
                Console.WriteLine("You missed, better luck next time.");
            }
        }
    }
}
