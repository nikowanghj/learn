using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

ServiceCollection service = new ServiceCollection();
ConfigurationBuilder configuration = new ConfigurationBuilder();
service.BuildServiceProvider();

