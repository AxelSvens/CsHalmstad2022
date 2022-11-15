namespace CoolMath;

// p/q  p and q integers q != 0

public class Rational
{
    private int _numerator;     // convention
    private int _denominator;

    public Rational() : this(0,1)
    {
    }
    
    public Rational(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public Rational Multiply(Rational other)
    {
        var printer = new Printer();
        
        return new Rational(
            _numerator * other._numerator,
            _denominator * other._denominator
        );
    }

    public static Rational operator *(Rational x, Rational y)
    {
        return x.Multiply(y);
    }
    public static Rational operator *(Rational x, int y)
    {
        return new Rational(x._numerator * y, x._denominator);
    }
    
    public override string ToString() => $"{_numerator}/{_denominator}";
}
