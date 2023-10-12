class Fraction{
    private double _numerator;
    private double _denominator;
        // Constructor
    public Fraction(){
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(double numerator){
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction (double numerator, double denominator){
        _numerator = numerator;
        _denominator = denominator;
    }
        // Getters & Setters
    public void setNumerator(double numerator){
        _numerator = numerator;
    }
    public double getNumerator(){
        return _numerator;
    }
    public void setDenominator(double denominator){
        _denominator = denominator;
    }
    public double getDenominator(){
        return _denominator;
    }
    public double calculateAndReturnDecimal(){
        double doubleValue = _numerator/_denominator;
        return doubleValue;
    }
    public string getAndReturnFraction(){
        string fractionString = $"{_numerator}/{_denominator}";
        return fractionString; 
    }
}