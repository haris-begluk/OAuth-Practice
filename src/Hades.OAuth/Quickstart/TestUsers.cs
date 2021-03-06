﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Hades.OAuth
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7", Username = "Haris", Password = "haris",
                Claims = new List<Claim>
                {
                    new Claim ("given_name", "Haris"),
                    new Claim ( "family_name", "Neko"),
                    new Claim("role", "FreeUser"),
                    new Claim("subscriptionlevel", "FreeUser"),
                    new Claim("country", "nl")
                }
            },
            new TestUser{SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7", Username = "Lejla", Password = "lejla",
                Claims = new List<Claim>
                {
                    new Claim ( "given_name", "Lejla"),
                    new Claim ( "family_name", "Neko"),
                    new Claim ( "address", "Covid 19 street"),
                    new Claim("role", "PayingUser"),
                    new Claim("subscriptionlevel", "PayingUser"),
                    new Claim("country", "be")
                }
            }
        };
    }
}