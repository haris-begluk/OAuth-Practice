﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Hades.OAuth
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),
                new IdentityResource("roles", "Your role(s)", new List<string>(){ "role"}),
                new IdentityResource("country", "The country zou're living in", new List<string>(){ "country"}) ,
                new IdentityResource("subsctiptionlevel", "Your subscription level", new List<string>(){ "subsctiptionlevel"})

            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                    new ApiResource("imagegalleryapi", "Image Gallery API", new List<string>{ "role" })
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            { new Client{
            //IdentityTokenLifetime
            //AuthorizationCodeLifetime
            AccessTokenLifetime =20,
            AllowOfflineAccess = true,
            UpdateAccessTokenClaimsOnRefresh = true,
            //RefreshTokenExpiration //Sliding
            //AbsoluteRefreshTokenLifetime
                ClientName = "Image Gallery",
            ClientId = "imagegalleryclient",
            AllowedGrantTypes = GrantTypes.Code,
            RedirectUris = new List<string>(){ "https://localhost:44389/signin-oidc" },
            PostLogoutRedirectUris = new List<string>(){ "https://localhost:44389/signout-callback-oidc" },
            AllowedScopes = {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                IdentityServerConstants.StandardScopes.Address,
                "roles",
                "imagegalleryapi",
                "country",
                "subsctiptionlevel"
                },
            ClientSecrets = { new Secret("secret".Sha256()) }
            } };

    }
}