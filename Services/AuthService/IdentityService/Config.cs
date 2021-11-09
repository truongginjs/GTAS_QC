// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityService
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            { };

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
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Address,
                        IdentityServerConstants.StandardScopes.Email,
                        "library_api"},
                    RequirePkce = true,
                    AllowedCorsOrigins = { "https://localhost:6001" },
                    RedirectUris = { "https://localhost:6001/authentication/login-callback" },
                    PostLogoutRedirectUris = { "https://localhost:6001/" },
                    RefreshTokenUsage = TokenUsage.ReUse,
                                        AllowAccessTokensViaBrowser =true,
                    AllowOfflineAccess =true,
                    Enabled=true
                },
                new Client{
                    ClientId = "test_api_id",
                    ClientName = "test api",
                    RequireClientSecret = false,
                    AllowedGrantTypes = GrantTypes.Code,
                                        RedirectUris = { "https://www.getpostman.com/oauth2/callback" },

                    // RefreshTokenUsage = TokenUsage.ReUse,                    
                    AllowAccessTokensViaBrowser =true,
                    UpdateAccessTokenClaimsOnRefresh=true,
                    AllowOfflineAccess =true,
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                           IdentityServerConstants.StandardScopes.Profile,
                           IdentityServerConstants.StandardScopes.Address,
                           IdentityServerConstants.StandardScopes.Email,
                           "library_api"
                    },
                    RequirePkce = true,
                    Enabled=true

                }

            };
    }
}