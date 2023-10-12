using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        // Fraction fractionObject = new Fraction();
        // fractionObject.setNumerator(1);
        // fractionObject.setDenominator(5);
        var f = new Fraction(1);
        System.Console.WriteLine(f.getAndReturnFraction());
        System.Console.WriteLine(f.calculateAndReturnDecimal());
        var f2 = new Fraction(5);
        System.Console.WriteLine(f2.getAndReturnFraction());
        System.Console.WriteLine(f2.calculateAndReturnDecimal());
        var f3 = new Fraction(3,4);
        System.Console.WriteLine(f3.getAndReturnFraction());
        System.Console.WriteLine(f3.calculateAndReturnDecimal());
        var f4 = new Fraction(1,3);
        System.Console.WriteLine(f4.getAndReturnFraction());
        System.Console.WriteLine(f4.calculateAndReturnDecimal());
    }
}