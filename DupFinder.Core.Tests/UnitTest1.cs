using Autofac;

namespace DupFinder.Core.Tests;

public class Class1Tests
{
	IContainer _container;
	
	[SetUp]
	public void Setup()
	{
		var builder = new ContainerBuilder();
		DiConfigurationCore.Configure(builder);
		
		_container = builder.Build();
	}

	[Test]
	public void Test1()
	{
		var c = _container.Resolve<IInterface1>();

		var result = c.TestFunc();       
		
		Assert.That(result, Is.EqualTo(1));
	}
}