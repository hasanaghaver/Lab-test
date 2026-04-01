using Lab_31._03.Models;

namespace Lab_31._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new()
            {
                Balance = 360000,
                CardNumber = "4169738812345678",
                Bank = EBank.Kapital,
            };
            Card card2 = new()
            {
                Balance = 1200000,
                CardNumber = "5239151758679821",
                Bank = EBank.Leo
            };

            CardService cardService = new();
            try
            {
                cardService.AddCard(card);
                cardService.AddCard(card2);
                cardService.AddCard(card);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            cardService.MaskCardNumber(card2);
            
            
            
        }
    }
}
