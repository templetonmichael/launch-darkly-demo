using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Client;
using LaunchDarklyDemo;

await LaunchDarklyDao.InitiateClient();

Console.WriteLine($"\nLaunch Darkly Feature Flag Result: {LaunchDarklyDao.GetTestBool()}");