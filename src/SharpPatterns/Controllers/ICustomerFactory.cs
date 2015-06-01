using System.Collections.Generic;
using SharpPatterns.ViewModels;

namespace SharpPatterns.Controllers
{
    public interface ICustomerFactory
    {
        CustomerViewModel Create();
    }

    internal class CustomerFactory : ICustomerFactory
    {
        private List<string> FirstNames = new List<string>
        {
            "Alice",
            "Bob",
            "Charlie",
            "Dan",
            "Eric",
            "Faythe",
            "Mallet",
            "Oscar",
            "Peggy",
            "Sam",
            "Walter"
        };

        private List<string> LastNames = new List<string>
        {
            "Aagard",
            "Bailly",
            "Callas",
            "Dagen",
            "Entin",
            "Fousek",
            "Hoogland",
            "Mounger",
            "Ruedy",
            "Tremper",
            "Wishon"
        };
        public CustomerViewModel Create()
        {
            return new CustomerViewModel
            {
                FirstName = FirstNames[RandomSingleton.Get().Next(FirstNames.Count)],
                LastName = LastNames[RandomSingleton.Get().Next(LastNames.Count)],
                Address = "123 Anyplace Lane",
                Age = RandomSingleton.Get().Next(18, 99),
                City = "NY",
                State = "NY"
            };
        }
    }
}