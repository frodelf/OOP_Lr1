namespace oopLr1
{
    public class Game
    {
        public int GamesCount;
        public GameAccount Opponent;
        public string Result;
        public int Rating; 
        public int CurrentRating; 

        public Game(int gamesCount, GameAccount opponent, string result, int rating1, int rating2)
        {
            GamesCount = gamesCount;
            Opponent = opponent;
            Result = result;
            Rating = rating1;
            CurrentRating = rating2;
        }
    }
}