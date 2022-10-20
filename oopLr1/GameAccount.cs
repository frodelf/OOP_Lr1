using System;
using System.Collections.Generic;

namespace oopLr1
{
    public class GameAccount
    {
        private string _userName;
        private int _currentRating;
        private static int _gamesCount;
        private List<Game> _histiryGame = new List<Game>();

        public GameAccount(string userName, int currentRating)
        {
            if (currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(currentRating), "Rating cannot be less than one");
            }

            _userName = userName;
            _currentRating = currentRating;
        }

        public void WinGame(GameAccount account, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "The rating for which they are playing cannot be negative");
            }

            this._currentRating += rating;
            account._currentRating -= rating;

            if (account._currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(this._currentRating), "Rating cannot be less than one");
            }
            
            _histiryGame.Add(new Game((++_gamesCount), account, "Winner", rating, _currentRating));
        }

        public void LoseGame(GameAccount account, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "The rating for which they are playing cannot be negative");
            }

            this._currentRating -= rating;
            account._currentRating += rating;

            if (this._currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(this._currentRating), "Rating cannot be less than one");
            }
            
            _histiryGame.Add(new Game((++_gamesCount), account, "Defeat", rating, _currentRating));
        }

        public void GetStats()
        {
            for (int i = 0; i < _histiryGame.Count; i++)
            {
                Console.WriteLine("ID:"+_histiryGame[i].GamesCount);
                Console.WriteLine("Opponent: "+_histiryGame[i].Opponent._userName);
                Console.WriteLine(_histiryGame[i].Result);
                Console.WriteLine("Rating: "+_histiryGame[i].Rating);
                Console.WriteLine(_userName+"'s current rating = " + _histiryGame[i].CurrentRating);
                Console.WriteLine(_histiryGame[i].Opponent._userName+"'s current rating = " + _histiryGame[i].Opponent._currentRating+"\n");

            }
        }
    }
}