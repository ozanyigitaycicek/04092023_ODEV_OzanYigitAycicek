using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _04092023_ODEV_OzanYigitAycicek
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region ODEV
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz : \n");
            string UserName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Kullanıcı Adınız" + " " + "'" + UserName + "'" + " " + "olarak kayıt edilmiştir. \n");
            Console.WriteLine("Kullanıcı Şifre 1 Giriniz : \n");
            string UserPassword1 = Console.ReadLine();
            
            //SecureString UserPassword1 = new SecureString();
            //ConsoleKeyInfo key;
            //do
            //{
            //    key = Console.ReadKey(true);
            //    if (key.Key != ConsoleKey.Backspace)
            //    {
            //        UserPassword1.AppendChar(key.KeyChar);
            //        Console.Write("*");
            //    }
            //    else
            //    {
            //        UserPassword1.RemoveAt(UserPassword1.Length - 1);
            //        Console.Write("\b \b");
            //    }
            //}
            //while (key.Key != ConsoleKey.Enter);

            Console.WriteLine("");

            Console.WriteLine("Kullanıcı Şifre 2 Giriniz : \n");
            string UserPassword2 = Console.ReadLine();

            //SecureString UserPassword2 = new SecureString();
            //ConsoleKeyInfo key2;
            //do
            //{
            //    key2 = Console.ReadKey(true);
            //    if (key2.Key != ConsoleKey.Backspace)
            //    {
            //        UserPassword2.AppendChar(key2.KeyChar);
            //        Console.Write("*");
            //    }
            //    else
            //    {
            //        UserPassword2.RemoveAt(UserPassword2.Length - 1);
            //        Console.Write("\b \b");
            //    }
            //}
            //while (key2.Key != ConsoleKey.Enter);

            Console.WriteLine("");

            Console.WriteLine("Kullanıcı Adı ve Şifreleriniz Başarıyla Kaydedilmiştir. \n");

            Console.WriteLine("Lütfen Karşılaştırmak İçin Kullanıcı Adınızı Tekrardan Giriniz : \n");
            string UserNameCheck = Console.ReadLine();
            Console.WriteLine("");
            bool result = UserName == UserNameCheck;
            Console.WriteLine(result);

            Console.WriteLine("");

            Console.WriteLine("Lütfen Karşılaştırmak İçin Kullanıcı Şifresi 1 ve Kullanıcı Şifresi 2 Giriniz : \n");
            string UserPassword1Check = Console.ReadLine();
            Console.WriteLine("");
            string UserPassword2Check = Console.ReadLine();
            Console.WriteLine("");
            bool result2 = UserPassword1  == UserPassword1Check;
            Console.WriteLine(result2);
            bool result3 = UserPassword2 == UserPassword2Check;
            Console.WriteLine(result3);

            #endregion




        }
    }
}
