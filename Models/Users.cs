﻿using Microsoft.AspNetCore.Identity;
namespace Webtaskapp.Models
{
    public class Users:IdentityUser
    {
       public string ? FullName {  get; set; }
    }
}
