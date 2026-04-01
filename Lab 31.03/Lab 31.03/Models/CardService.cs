using Lab_31._03.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_31._03.Models
{
    class CardService : ICardService
    {
        public static Card[] Cards = [];

        public void AddCard(Card card)
        {
            #region men yazan
            //if (FindIndex(card.CardNumber))
            //{
            //    throw new ConflictException();
            //}
            //else
            //{
            //    Card[] newCards = new Card[Cards.Length + 1];
            //    for (int i = 0; i < Cards.Length; i++)
            //    {
            //        newCards[i] = Cards[i];
            //    }
            //    newCards[newCards.Length - 1] = card;
            //    Cards = newCards;
            //} 
            #endregion
            var exsist = FindIndex(card.CardNumber);
            if (exsist is null)
            {
                Array.Resize(ref Cards, Cards.Length+1);
                Cards[Cards.Length-1]= card;
            }
            else
            {
                throw new ConflictException();
            }
        }

        public Card FindIndex(string cartNumber)
        {
            #region men yazan
            //for (int i = 0; i < Cards.Length; i++)
            //{
            //    if (cartNumber == Cards[i].CardNumber)
            //    {
            //        return i;
            //    }
            //} 
            #endregion
            foreach (var item in Cards)
            {
                if (item.CardNumber == cartNumber)
                {
                    return item;
                }
            }
            return null;
        }
        public void MaskCardNumber(Card card)
        {
            for (int i = 0; i < card.CardNumber.Length; i++)
            {
                if (i < 4 || i > 11)
                {
                    Console.Write(card.CardNumber[i]);
                }
                else
                {
                    Console.Write("*");
                }
            }
        }


    }
}
