using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
   class Program
   {
      static void Main(string[] args)
      {
         const string _alphanum = "0123456789!@#$%^&*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
         int _size = _alphanum.Length;

         //password length
         int length = 8;

         //srand(time(0));
         Random rnd = new Random((int)DateTime.Now.Ticks);

         for (int i = 0; i < length; i++)
         {
            Console.Write(_alphanum[rnd.Next() % _size]);
         }
         Console.ReadKey();
      }
   }
}
