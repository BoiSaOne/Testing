﻿using System.Security.Cryptography;
using System.Text;

namespace Web.Testing.Helpers
{
    public static class HashPasswordHelper
    {
        public static string GetHashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = BitConverter.ToString(bytes).Replace("-", "").ToLower();
                return hash;
            }
        }
    }
}
