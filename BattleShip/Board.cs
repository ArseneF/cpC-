namespace BattleShip
{
    class Board
    {
        public Board()
        {
            Ship = new Ship();
        }
        public int Height;
        public int Width;

        public Ship Ship;
    }
}