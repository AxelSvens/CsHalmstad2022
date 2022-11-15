namespace CoolMath;

public class BigInteger
{
    private string _number;

    public BigInteger(uint i)
    {
        _number = i.ToString();
    }
    
    public BigInteger(string number)
    {
        _number = number;
    }


    public BigInteger Add(BigInteger other)
    {
        var r = uint.Parse(_number) + uint.Parse(other._number);
        return new BigInteger(r);
    }
    
    public BigInteger Sub(BigInteger other)
    {
        var r = uint.Parse(_number) - uint.Parse(other._number);
        return new BigInteger(r);
    }
    
    public override string ToString() => _number;
}