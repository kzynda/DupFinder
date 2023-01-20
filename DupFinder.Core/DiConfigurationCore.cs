using Autofac;

namespace DupFinder.Core;

public class DiConfigurationCore
{
	public static void Configure(ContainerBuilder builder)
	{
		builder.RegisterType<Class1>().As<IInterface1>();
	}
}