using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Fanfan
{
    internal class DeskQuote
    {
        // the minimum and maximum rush order days
        public const int MAX_RUSH_ORDER_DAYS = 7;
        public const int MIN_RUSH_ORDER_DAYS = 0;

        // the desk quote object with customer name, desk object, rush order, and the quote price.
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int RushOrderDays { get; set; }
        public int QuotePrice { get; set; }

        // constructor to initialize the desk quote object
        public DeskQuote(string customerName, Desk desk, int rushOrderDays, int quotePrice)
        {
            CustomerName = customerName;
            Desk = desk;
            RushOrderDays = rushOrderDays;
            QuotePrice = quotePrice;
        }
        // constructor to initialize the desk quote object with default values
        public DeskQuote()
        {
            CustomerName = "Unknown";
            Desk = new Desk(0, 0, 0);
            RushOrderDays = 0;
            QuotePrice = 0;
        }
        // method to calculate the quote price based on the desk dimensions, number of drawers, and rush order
        public void CalculateQuote()
        {
            // base price calculation
            int basePrice = 200;
            int surfaceArea = Desk.Width * Desk.Depth;
            if (surfaceArea > 1000)
            {
                basePrice += (surfaceArea - 1000) * 1;
            }
            // drawer price calculation
            basePrice += Desk.NumberOfDrawers * 50;
            // surface material price calculation
            switch (Desk.SurfaceMaterial)
            {
                case "Pine":
                    basePrice += 50;
                    break;
                case "Laminate":
                    basePrice += 100;
                    break;
                case "Veneer":
                    basePrice += 125;
                    break;
                case "Oak":
                    basePrice += 200;
                    break;
                case "Rosewood":
                default:
                    basePrice += 0;
                    break;
            }
            // rush order price calculation
            if (RushOrderDays > 0)
            {
                if (surfaceArea < 1000)
                {
                    if (RushOrderDays == 3)
                    {
                        basePrice += 60;
                    }
                    else if (RushOrderDays == 5)
                    {
                        basePrice += 40;
                    }
                    else if (RushOrderDays == 7)
                    {
                        basePrice += 30;
                    }
                    else
                    {
                        basePrice += 20;
                    }
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    if (RushOrderDays == 3)
                    {
                        basePrice += 70;
                    }
                    else if (RushOrderDays == 5)
                    {
                        basePrice += 50;
                    }
                    else if (RushOrderDays == 7)
                    {
                        basePrice += 35;
                    }
                    else
                    {
                        basePrice += 20;
                    }
                }
                else if (surfaceArea > 2000)
                {
                    if (RushOrderDays == 3)
                    {
                        basePrice += 80;
                    }
                    else if (RushOrderDays == 5)
                    {
                        basePrice += 60;
                    }
                    else if (RushOrderDays == 7)
                    {
                        basePrice += 40;
                    }
                    else
                    {
                        basePrice += 40;
                    }
                }
            }
            
            QuotePrice = basePrice;
        }
    }
}
