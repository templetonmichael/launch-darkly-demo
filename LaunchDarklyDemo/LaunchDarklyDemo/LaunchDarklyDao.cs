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
            client = await LdClient.InitAsync("mob-0c2f306c-1842-474f-bbc2-930b5da6617c", user);
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
