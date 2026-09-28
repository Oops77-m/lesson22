namespace Lesson22;

public class BaseTest
{
    [OneTimeSetUp]
    public void OneTimeSetup() // один раз перед всеми тестами
    {
        Console.WriteLine("OneTimeSetup");
    }
    [SetUp]
    public void Setup() // перед каждым тестом
    {
        Console.WriteLine("Setup");
    }

    [Test]
    public void Test()
    {
        Console.WriteLine("Test");
    }

    [TearDown] // после каждого теста
    public void TearDown()
    {
        Console.WriteLine("TearDown");
    }

    [OneTimeTearDown] // один раз после всех тестов
    public void OneTimeTearDown()
    {
        Console.WriteLine("OneTimeTearDown");
    }
}