// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
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
            new TestUser{SubjectId = "2645BD94-3624-43FC-B21F-1209D730FC71", Username = "Haris", Password = "haris",
                Claims = new List<Claim>
                {
                    new Claim ("given_name", "Haris"),
                    new Claim ( "family_name", "Neko")
                }
            },
            new TestUser{SubjectId = "3F41DC87-E8DE-42EE-AC8D-355E4D3E1A2D", Username = "Lejla", Password = "lejla",
                Claims = new List<Claim>
                {
                    new Claim ( "given_name", "Lejla"),
                    new Claim ( "family_name", "Neko"),
                    new Claim ( "address", "Covid 19 street")
                }
            }
        };
    }
}