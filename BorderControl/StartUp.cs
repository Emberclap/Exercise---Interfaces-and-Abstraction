namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<IIdentifiable> inhabitants = new List<IIdentifiable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 3)
                {
                    inhabitants.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));

                }
                else
                {
                    inhabitants.Add(new Robot(tokens[0], tokens[1]));
                }
            }
            string lastDigits = Console.ReadLine();

            inhabitants.Where(x => x.Id.EndsWith(lastDigits))
                .Select(x => x.Id)
                .ToList()
                .ForEach(Console.WriteLine);
            
        }
    }
}