using System;
using System.Linq;
using Task1.Interfaces;

namespace Task1
{
    public class NameCheckerService : ICheckerService
    {
        private IRepository repository;

        public NameCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public Tuple<bool, string> Verify(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException($"{name}");

            if (name == string.Empty)
                return Tuple.Create(false, $"{name} is empty ");

            if (name.Length >= 15)
                return Tuple.Create(false, $"{name} length too long");

            if (name.Any(char.IsNumber))
                throw new ArgumentException($"{name} must not have number.Only Letters");

            repository.Create(name);

            return Tuple.Create(true, "Name is Ok. User was created");
        }
    }
}
