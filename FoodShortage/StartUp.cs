namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
           
            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 4)
                {
                    buyers.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else
                {
                    buyers.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                buyers.FirstOrDefault(x => x.Name == input)?.BuyFood();
            }
            int sum = buyers.Sum(x => x.Food);
            Console.WriteLine(sum);
        }
    }
}