namespace DupFinder.Core.Tests;

public class Class1Tests
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void Test1()
	{
		var result = Class1.TestFunc();
		
		Assert.That(result, Is.EqualTo(1));
	}
}