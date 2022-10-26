namespace SpaceBattle.Lib.Test;

public class AngleTest
{
    [Fact]
    public void Positive()
    {
        Angle a = new Angle(45, 1);
        Angle b = new Angle(90, 2);
        Assert.Equal(a,b);

    }

    [Fact]
    public void PositivSum()
    {
        Angle a = new Angle(45, 1);
        Angle b = new Angle(90, 2);
        Assert.Equal(a + b, new Angle(90, 1));

    }   
    [Fact]
    public void NegativeSum()
    {
        Angle a = new Angle(45, 1);
        Angle b = new Angle(90, 2);
        Assert.False(a + b == new Angle(90, 2));

    }

    [Fact]
    public void DivizionByZeroException()
    {
        Assert.Throws<Exception>(()=> new Angle(99,0)); 

    }



    



}