﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ArchitectureTemplate.Mvc.Controllers.Shared
{
    public class AppUser : ClaimsPrincipal
    {
        public AppUser(ClaimsPrincipal principal)
            : base(principal)
        {
        }

        public long UserId => Convert.ToInt64(FindFirst(ClaimTypes.NameIdentifier).Value);

        public string Country => FindFirst(ClaimTypes.Country).Value ?? string.Empty;

        public string Email => FindFirst(ClaimTypes.Email).Value;
        public long Cpf => Convert.ToInt64(FindFirst("Cpf").Value);

        public string ProfileName => FindFirst(ClaimTypes.Role).Value;

        public string Login => FindFirst("Login").Value;

        public int ProfileId => Convert.ToInt32(FindFirst("ProfileId").Value);

        public long? HierarchyId => Convert.ToInt64(FindFirst("HierarchyId").Value);

        public IEnumerable<int> MenuIds => FindFirst("MenuIds").Value?.Split('|').Select(int.Parse);

        public IEnumerable<long> HierarchyIds => FindFirst("HierarchyIds").Value?.Split('|').Select(long.Parse);

        public string Token => FindFirst("Token").Value;
    }
}