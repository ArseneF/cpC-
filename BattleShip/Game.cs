namespace BattleShip
{
    class Game
    {
        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
        }
        
        public Player Player1;
        public Player Player2;
        public int Turn;
        
        public bool Shoot(int x, int y)
        {
            if(Player1.Board.Ship.X == x && Player1.Board.Ship.Y == y)
            {
                return true;

            }
            return false;
        }
    }
}