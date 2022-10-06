namespace SpaceBattle.Lib.Test;
using Moq;
public class UnitTest1
{
    [Fact]
    public void TestPositiveMove()
    {
        Mock<IMovable> movableMock = new Mock<IMovable>();
        movableMock.SetupGet<Vector>(m=>m.Position).Returns(new Vector(1, 2));

        //movableMock GetVelocity
        //movableMock SetPosition

        Assert.Equal(new Vector(1,2), movableMock.Object.Position);

        ICommand c = new MoveCommand(movableMock.Object);
        c.Execute();

        Assert.Equal(new Vector(2, 4), movableMock.Object.Position);
        //ICommand c = new MoveCommand(movableMock.Object);
        //c.Execute();
    }
}