// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace AuthService
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
            };

        public static IEnumerable<ApiResource> GetApis() => new ApiResource[]{
            new ApiResource("library_api","library api"),
            new ApiResource("qc_api","qc api"),
        };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("library_api"),
                new ApiScope("qc_api"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                // qc client code flow client
                new Client
                {
                    ClientId = "qc_client_id",
                    ClientName = "QC Client balzor WASM (Code with PKCE)",
                    RequireClientSecret = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowedScopes = { "openid", "profile" ,"email", "library_api"},
                    RequirePkce = true,
                    AllowedCorsOrigins = { "https://localhost:6001" },
                    RedirectUris = { "https://localhost:6001/authentication/login-callback" },
                    PostLogoutRedirectUris = { "https://localhost:6001/" },
                    RefreshTokenUsage = TokenUsage.ReUse,
                }
            };
    }
}