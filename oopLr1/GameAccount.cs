using System;

namespace oopLr1
{
    public class GameAccount : Game
    {
        private string userName;
        private int currentRating;
        private static int gamesCount = 0;
        public GameAccount(string userName, int currentRating)
        {
            if (currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(currentRating), "Rating cannot be less than one");
            }

            this.userName = userName;
            this.currentRating = currentRating;
        }

        public void WinGame(GameAccount account, int Rating)
        {
            if (Rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating), "The rating for which they are playing cannot be negative");
            }

            this.currentRating += Rating;
            account.currentRating -= Rating;

            if (account.currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(this.currentRating), "Rating cannot be less than one");
            }

            stats.Add(this.userName.ToString());
            stats.Add("Index: "+ (++gamesCount).ToString());
            stats.Add("Opponennt: "+account.userName.ToString());
            stats.Add("Victory");
            stats.Add("Rating = "+Rating.ToString());
            stats.Add(this.userName.ToString()+"'s current rating = " + this.currentRating.ToString());
            stats.Add(account.userName.ToString()+"'s current rating = " + account.currentRating.ToString());
            stats.Add("");

        }

        public void LoseGame(GameAccount account, int Rating)
        {
            if (Rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating), "The rating for which they are playing cannot be negative");
            }

            this.currentRating -= Rating;
            account.currentRating += Rating;

            if (this.currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(this.currentRating), "Rating cannot be less than one");
            }

            stats.Add(this.userName.ToString());
            stats.Add("Index: "+ (++gamesCount).ToString());
            stats.Add("Opponennt: "+account.userName.ToString());
            stats.Add("Defeat");
            stats.Add("Rating = "+Rating.ToString());
            stats.Add(this.userName.ToString()+"'s current rating = " + this.currentRating.ToString());
            stats.Add(account.userName.ToString()+"'s current rating = " + account.currentRating.ToString());
            stats.Add("");
        }

        public void GetStats()
        {
            for (int i = 0; i < stats.Count; i++)
            {
                if (stats[i].Equals(this.userName.ToString()))
                {
                    for(int j = i + 1; j < i + 8; j++)Console.WriteLine(stats[j]);
                }
            }
        }
    }
}