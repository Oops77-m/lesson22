using NUnit.Framework.Legacy;

namespace Lesson22.Tests;

[Parallelizable(ParallelScope.Children)]
public class ComplexAssertion : BaseTest
{
    [Test]
    public void CheckCollection()
    {
        var c = new [] { 1, 2, 3 };
        var d = new [] { 1, 2, 3 };
        CollectionAssert.AreEqual(c, d); // равны
        Thread.Sleep(2000); //для проверки параллельности
    }
    [Test]
    public void CheckCollectionContains()
    {
        var f = new [] { 1, 2, 3 };
        CollectionAssert.Contains(f, 2); // число есть в массиве
        Thread.Sleep(2000);
    }
    [Test]
    public void CheckCollectionContains2()
    {
        var f = new [] { 1, 2, 3 };
        CollectionAssert.Contains(f, 1); // число есть в массиве
        Thread.Sleep(2000);
    }
    [Test]
    public void CheckCollectionContains3()
    {
        var f = new [] { 1, 2, 3 };
        CollectionAssert.Contains(f, 3); // число есть в массиве
        Thread.Sleep(2000);
    }
}