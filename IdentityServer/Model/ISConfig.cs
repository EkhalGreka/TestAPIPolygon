using IdentityServer4.Models;
using Microsoft.AspNetCore.DataProtection;

namespace IdentityServer.Model
{
    public static class ISConfig
    {
        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope> {
            new ApiScope("testapis", "Test API Scope")
        };
        public static IEnumerable<Client> Clients => new List<Client> {
            new Client {
                ClientId = "testclient",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {
                        new IdentityServer4.Models.Secret("testsecret".Sha256())
                    },
                    AllowedScopes = {
                        "testapis"
                    }
            }
        };
    }
}
