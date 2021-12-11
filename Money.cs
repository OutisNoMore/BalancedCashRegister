using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedCashRegister
{
    public enum Country
    {
        United_States,
        Canada,
        Invalid
    }

    public class US_Currency
    {
        public const Country COUNTRY = Country.United_States;
        public const String CURRENCY = "US Dollar";
        // bills
        public const int ONE     = 1;
        public const int TWO     = 2;
        public const int FIVE    = 5;
        public const int TEN     = 10;
        public const int TWENTY  = 20;
        public const int FIFTY   = 50;
        public const int HUNDRED = 100;
        // coins
        public const double QUARTER = 0.25;
        public const double DIME    = 0.10;
        public const double NICKEL  = 0.05;
        public const double PENNY   = 0.01;
        
        // bills quantity
        public int oneQuantity     { get; set; }
        public int twoQuantity     { get; set; }
        public int fiveQuantity    { get; set; }
        public int tenQuantity     { get; set; }
        public int twentyQuantity  { get; set; }
        public int fiftyQuantity   { get; set; }
        public int hundredQuantity { get; set; }
        // coins quantities
        public int quarterQuantity { get; set; }
        public int dimeQuantity    { get; set; }
        public int nickelQuantity  { get; set; }
        public int pennyQuantity   { get; set; }


    }

    public struct Canada_Currency
    {
        public const Country COUNTRY = Country.Canada;
        public const String CURRENCY = "Canadian Dollar";
        // bills
        public const int FIVE    = 5;
        public const int TEN     = 10;
        public const int TWENTY  = 20;
        public const int FIFTY   = 50;
        public const int HUNDRED = 100;
        // coins
        public const double TOONIE  = 2.00;
        public const double LOONIE  = 1.00;
        public const double QUARTER = 0.25;
        public const double DIME    = 0.10;
        public const double NICKEL  = 0.05;
        public const double PENNY   = 0.01;
    }

    class Money
    {
        private readonly Country country = Country.Invalid;
        private readonly US_Currency us;
        private readonly Canada_Currency ca;

        public Money(Country country)
        {
            this.country = country;
        }

        public String Dbg()
        {
            String output = "";
            switch (country)
            {
                case Country.United_States:
                    output = US_Currency.CURRENCY;
                    US_Currency us = new US_Currency();
                    output += "\r\n";
                    output += ++us.oneQuantity; 
                    break;
                case Country.Canada:
                    output = Canada_Currency.CURRENCY;
                    break;
            }

            return output;
        }
    }

    class Sales
    {
            x
    }
}
