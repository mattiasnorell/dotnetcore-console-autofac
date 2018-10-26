using Autofac;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
                        
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run(args);
            }
        }
    }
}
