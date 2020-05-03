using System;

namespace SUT_Library
{
    public class LoanTerm
    {
        public int Years { get; set; }
        public LoanTerm(int years)
        {
            Years = years;
        }
        public int ToMonths() => Years * 12;
    }
}
