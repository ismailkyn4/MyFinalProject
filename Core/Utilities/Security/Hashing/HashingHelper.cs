using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt) //Verdiğimiz paswordun hashini oluşturmaya yarar
        {
            using (var hmac= new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            }
        }
        public static bool VerifyPasswordHash(string password,byte[] passwordHash, byte[] passwordSalt) //Parola ile yeniden sisteme girmek isteyen kullanıcının sistemdeki parola ile eşleşip eşleşmediğini konrtol etmek için
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i]) //sistemden girilen computed hash ile veritabanındaki pasword has eşit değilse 
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}