# Boilerplate for .NET Core Console applications with AutoFac
A basic boilerplate to learn how to use AutoFac as IoC in .NET Core console applications.

## How to setup a basic AutoFac configuration
You have to register "Application" since this is the part where the scope in which you are able to use dependency injection is created. That is already done in this project so all you have to do is register your code the same way as "Application" and start injecting stuff throughout your project.
```
builder.RegisterType<Application>().As<IApplication>();
```
For more advanced ways to configure AutoFac, see [autofac.org](https://autofac.org/).

## How to run
```
dotnet run
```