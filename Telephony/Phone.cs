using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Phone : ISmartphone, IStationaryPhone
    {
        private List<string> phoneNumbers;
        private List<string> webSites;
        public Phone(List<string> phoneNumbers, List<string> webSites)
        {
            PhoneNumbers = phoneNumbers;
            WebSites = webSites;
        }

        public List<string> PhoneNumbers { get; set; }
        public List<string> WebSites { get; set; }

        public void Calling(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
        public void Browsing(string website)
        {

            Console.WriteLine($"Browsing: {website}!");
        }

        public void Dialing(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }

        public void Call()
        {
            foreach (var phone in PhoneNumbers)
            {
                if (phone.Any(x => char.IsLetter(x)))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                if (phone.Length == 10)
                {
                    Calling(phone);
                }
                else
                {
                    Dialing(phone);
                }
            }
        }
        public void Browse()
        {
            foreach(var website in WebSites)
            {
                if (website.Any(x => char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                Browsing(website);

            }
        }
    }
}
