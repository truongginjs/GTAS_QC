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
            new ApiResource("library.api","library Api")
        };

        // public static IEnumerable<ApiScope> ApiScopes =>
        //     new ApiScope[]
        //     {
        //         new ApiScope("library.api"),
        //         new ApiScope("qc.api"),
        //     };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                // qc client code flow client
                new Client
                {
                    ClientId = "qc.client",
                    ClientSecrets = { new Secret("qc_client_blazor_wasm_secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowedScopes = { "openid", "profile" ,"email","library.api"},
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowedCorsOrigins = { "https://localhost:6001" },
                    RedirectUris = { "https://localhost:6001/authentication/login-callback" },
                    PostLogoutRedirectUris = { "https://localhost:6001/" },
                    Enabled = true                
                }
            };
    }
}