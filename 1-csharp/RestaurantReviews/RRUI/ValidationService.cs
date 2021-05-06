using System;
namespace RRUI
{
    public interface IValidationService
    {
        string ValidString(string prompt);
    }

    public class ValidationService : IValidationService
    {
        public string ValidString(string prompt)
        {
            string response;
            do
            {
                Console.WriteLine(prompt);
                response = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(response)) Console.WriteLine("Please input a non empty string");
            } while (String.IsNullOrWhiteSpace(response));
            return response;
        }
    }
}