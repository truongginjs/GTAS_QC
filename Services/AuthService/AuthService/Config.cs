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
                   };

        public static IEnumerable<ApiResource> GetApis()=>new ApiResource[]{
            new ApiResource("library.api","library Api")
        };

        // public static IEnumerable<ApiScope> ApiScopes =>
        //     new ApiScope[]
        //     {
        //         new ApiScope("library.api")
        //     };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                // qc client credentials flow client
                new Client
                {
                    ClientId = "qc.client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("qc_client_blazor_wasm_secret".Sha256()) },
                    AllowedScopes = {"library.api"}
                }
            };
    }
}