namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() {"Halo", "Call of Duty", "Apex", "Grand theft auto 5" };
            var gameNames = games.OrderBy(games => games.Length).ToList();
            foreach (var game in gameNames) 
            {
                Console.WriteLine(game);
            }
            
            
            
            
        }
    }
}
