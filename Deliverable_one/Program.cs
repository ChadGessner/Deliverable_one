namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            int humans = 0;
            while (true)
            {
                Console.WriteLine("How many people are we making PB and J sandwiches for?");
                var peoples = Console.ReadLine();
                if (peoples == null || peoples.Length == 0 || !int.TryParse(peoples, out int something))
                {
                    continue;
                }
                humans += something;
                Console.WriteLine(BuildOutput(humans));
                var decision = Console.ReadLine();
                if (string.Equals(decision, "y", StringComparison.CurrentCultureIgnoreCase) || string.Equals(decision, "yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    humans = 0;
                    continue;
                }
                else
                {
                    Console.WriteLine("\nGoodbye!");
                    break;
                }
            }
            static string BuildOutput(int humans)
            {
                int loaf = (int)Math.Ceiling((double)(humans * 2) / 28);
                int pBJars = (int)Math.Ceiling((double)(humans * 2) / 32);
                int jJars = (int)Math.Ceiling((double)(humans * 4) / 48);
                int slices = humans * 2;
                int pBSpoons = humans * 2;
                int JSpoons = humans * 4;
                string loafString = loaf == 1 ? "loaf" : "loaves";
                string pbJarString = pBJars == 1 ? "jar" : "jars";
                string jJarString = jJars == 1 ? "jar" : "jars";
                string output = $"You need: \n\n " +
                    $"       {slices} slices of bread \n " +
                    $"       {pBSpoons} tablespoons of peanut butter \n " +
                    $"       {JSpoons} teaspoons of jelly \n\n " +
                    $"       which is... \n\n " +
                    $"       {loaf} {loafString} of bread \n " +
                    $"       {pBJars} {pbJarString} of peanut butter \n " +
                    $"       {jJars} {jJarString} of jelly \n\n" +
                    $"Would you like to restart? Enter yes or y to continue, or enter any other key to exit.";
                return output;
            }
        }
    }
}
