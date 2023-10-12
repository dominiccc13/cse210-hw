using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        // Fraction fractionObject = new Fraction();
        // fractionObject.setNumerator(1);
        // fractionObject.setDenominator(5);
        var fractionObject = new Fraction(1);
        System.Console.WriteLine(fractionObject.getAndReturnFraction());
        System.Console.WriteLine(fractionObject.calculateAndReturnDecimal());
        var fractionObject2 = new Fraction(5);
        System.Console.WriteLine(fractionObject2.getAndReturnFraction());
        System.Console.WriteLine(fractionObject2.calculateAndReturnDecimal());
        var fractionObject3 = new Fraction(3,4);
        System.Console.WriteLine(fractionObject3.getAndReturnFraction());
        System.Console.WriteLine(fractionObject3.calculateAndReturnDecimal());
        var fractionObject4 = new Fraction(1,3);
        System.Console.WriteLine(fractionObject4.getAndReturnFraction());
        System.Console.WriteLine(fractionObject4.calculateAndReturnDecimal());
    }
}