namespace Lesson22.Tests;

[Parallelizable(ParallelScope.All)]
public class SimpleAssertion : BaseTest
{
    [TestCase(1, 2, 3)]
    [TestCase(4, 5, 9)]
    [TestCase(6, 7, 13)]
    public void SimpleAssertionSum(int a, int b, int c)
    {
        Assert.That(a+b, Is.EqualTo(c));
    }

    [TestCase(1, 2, 2)]
    [TestCase(4, 5, 20)]
    public void SimpleAssertionMultiplication(int a, int b, int c)
    {
        Assert.That(a * b, Is.EqualTo(c));
    }
    public static int [] Numbers = {2, 4, 6, 8};
    [TestCaseSource(nameof(Numbers))]
    public void NumberIsEven (int  number)
    {
        Assert.That(number % 2, Is.EqualTo(0)); //проверка на четность
    }
}