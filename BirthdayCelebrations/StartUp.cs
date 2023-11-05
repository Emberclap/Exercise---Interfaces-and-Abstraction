namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<IIdentifiable> inhabitants = new List<IIdentifiable>();
            List<IBirthable> birthables = new List<IBirthable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Citizen")
                {
                    inhabitants.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                    birthables.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                }
                else if (tokens[0] == "Robot")
                {
                    inhabitants.Add(new Robot(tokens[1], tokens[2]));
                }
                else if (tokens[0] == "Pet")
                {
                    birthables.Add(new Pet(tokens[1], tokens[2]));
                }
            }
            string specificYear = Console.ReadLine();

            birthables.Where(x => x.Birthdate.EndsWith(specificYear))
                .Select(x => x.Birthdate)
                .ToList()
                .ForEach(Console.WriteLine);
            
        }
    }
}