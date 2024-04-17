/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 12/04/2024
 */
namespace Challenge2;

class Card
{
    private const int ValidLength = 16;

    private string _cardNumber;

    public Card(string cardNumber) { _cardNumber = cardNumber ?? ""; }

    public string CardNumber { get => _cardNumber; }

    private int _SumOfEvenPosDigits(ulong cardNumber)
    {
        bool isEven = false;
        ulong number = cardNumber;
        int result = 0;

        int subResult;

        while (number > 0)
        {
            subResult = (int) (number % 10 * (isEven ? 2ul : 1ul));
            result += (subResult > 9) ? subResult % 10 + subResult / 10 : subResult;
            number /= 10;
            isEven = !isEven;
        }

        return result;
    }

    public bool Validate()
    {
        ulong cardNumber;

        try
        {
            cardNumber = Convert.ToUInt64(CardNumber);
        }
        catch (Exception exception)
        {
            return false;
        }

        if (CardNumber.Length != ValidLength) return false;
        if (_SumOfEvenPosDigits(cardNumber) % 10 > 0) return false;

        return true;
    }
}
