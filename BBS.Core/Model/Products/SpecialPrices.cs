using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    public static class SpecialPrices
    {
        public static int GetNumFree(DiscountType type, int amount)
        {
            int numFree = 0;

            switch (type)
            {
                case DiscountType.None:
                    break;

                case DiscountType.DrieHalenTweeBetalen:
                    float numTriplesFloat = amount / 3f;
                    numFree = (int)Math.Floor(numTriplesFloat);
                    break;

                case DiscountType.ElfHalenTienBetalen:
                    float numMetersFloat = amount / 11f;
                    numFree = (int)Math.Floor(numMetersFloat);
                    break;

                default:
                    Logger.Log("Unknown discount type");
                    break;
            }

            return numFree;
        }

        public static Decimal CalculateDiscount(DiscountType type, Product product, int amount)
        {
            int numFree = GetNumFree(type, amount);
            return numFree * product.Price;
        }
    }
}
