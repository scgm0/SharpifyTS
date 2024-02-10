namespace SharpifyTS.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CompilerOptionsValueTest1()
    {
        CompilerOptionsValue b = 1;
        int a = b;
        b = "";
        Assert.Multiple(() =>
        {
            Assert.That(a, Is.EqualTo(1));
            Assert.That(b.Value is string);
        });
        Assert.Pass();
    }
}