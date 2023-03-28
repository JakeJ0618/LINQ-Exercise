namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameNames = new List<string> 
            { 
                "Call of Duty", 
                "Star Wars: Battlefront 2", 
                "Dead by Daylight", 
                "Gears of War",
                "Dishonored 2"
            };

            var listOfGames = videoGameNames.OrderBy(name => name.Length);

            foreach(var gameName in listOfGames)
            {
                Console.WriteLine(gameName);
            }
        }
    }
}
