namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var phones = new Phone(phoneNumbers, websites);

            phones.Call();
            phones.Browse();
        }
    }
}