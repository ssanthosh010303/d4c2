/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 12/04/2024
 *
 * Day-4 Challenge-2: Card Validator
 */
namespace Challenge2;

class Program
{
    static void Main()
    {
        string? cardNumber;

        Console.Write("Enter card number: ");
        cardNumber = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(cardNumber))
        {
            Card cardHandle = new Card(cardNumber);

            Console.WriteLine("\nResult");
            Console.WriteLine("  Valid: " + cardHandle.Validate());
        }
    }
}
