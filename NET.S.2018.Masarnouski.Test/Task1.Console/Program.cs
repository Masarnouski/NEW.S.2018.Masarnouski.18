using Task1.Interfaces;
using System;
namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new SqlRepository();

            PasswordCheckerService psChecker = new PasswordCheckerService(repository);
            NameCheckerService nmChecher = new NameCheckerService(repository);
            psChecker.Verify("12345");
            nmChecher.Verify("Eugene12");
            System.Console.ReadLine();
        }
    }
}
