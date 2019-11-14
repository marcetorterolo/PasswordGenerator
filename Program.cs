using System;
using System.Text;

namespace PasswordGenerator
{
   class Program
   {
      static string generatePswd(int length)
      {
         const string validChars = "0123456789!@#$%^&*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
         StringBuilder res = new StringBuilder();

         Random rnd = new Random((int)DateTime.Now.Ticks);
         while (0 < length--)
         {
            res.Append(validChars[rnd.Next() % validChars.Length]);
         }
         return res.ToString();
      }

      static void Main(string[] args)
      {
         //password length
         int length = 8;

         string pass = generatePswd(length);
         Console.Write(pass);
         Console.ReadKey();
      }
   }
}
