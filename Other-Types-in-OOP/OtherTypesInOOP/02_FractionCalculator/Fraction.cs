using System;

public struct Fraction
{
    private  long numinator;
    private  long denominator;

    public Fraction(long numinator, long denominator): this()
    {
        this.Numinator = numinator;
        this.Denominator = denominator;
    }

    public long Numinator 
    { 
        get { return this.numinator; }
        set { this.numinator = value; }
    }

    public long Denominator
    {
        get { return this.denominator; }
        set
        {
            if (value == 0)
            {
                throw new Exception("The denominator can't be 0.");
            }

            this.denominator = value;
        }
    }

    public static Fraction operator +(Fraction fraction1, Fraction fraction2) 
    {
        Fraction resultFraction = new Fraction();
        resultFraction.numinator = fraction1.numinator * fraction2.denominator + fraction2.numinator * fraction1.denominator;
        resultFraction.denominator = fraction1.denominator * fraction2.denominator;
        return resultFraction;
    }

    public static Fraction operator -(Fraction fraction1, Fraction fraction2)
    {
        Fraction resultFraction = new Fraction();
        resultFraction.numinator = fraction1.numinator * fraction2.denominator - fraction2.numinator * fraction1.denominator;
        resultFraction.denominator = fraction1.denominator * fraction2.denominator;
        return resultFraction;
    }

    public override string ToString()
    {
        double result = (double)this.numinator / (double)this.denominator;
        return result.ToString();
    }


}