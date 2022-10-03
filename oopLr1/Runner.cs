namespace oopLr1
{
    public class Runner
    {
        static void Main(string[] args)
        {
            GameAccount account1 = new GameAccount("Stas", 1100);
            GameAccount account2 = new GameAccount("Ivan", 1200);
            GameAccount account3 = new GameAccount("Roma", 1400);
            GameAccount account4 = new GameAccount("Artem", 600);

            account1.WinGame(account2, 30);
            account3.LoseGame(account1, 21);
            account1.WinGame(account4, 12);
            account1.LoseGame(account3, 100);
            account1.WinGame(account2, 630);

            account1.GetStats();
        }
    }
}