using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Client;

namespace LaunchDarklyDemo
{
    public static class LaunchDarklyDao
    {
        private static LdClient? client;
        private static User user = User.WithKey("valid_user");

        public static async Task InitiateClient()
        {
            client = await LdClient.InitAsync("YOUR MOBILE SDK KEY HERE", user);
        }
        
        public static bool? GetTestBool()
        {
            if(client != null)
            {
                return client.BoolVariation("test-bool", false);
            }
            return null;
        }
    }
}
