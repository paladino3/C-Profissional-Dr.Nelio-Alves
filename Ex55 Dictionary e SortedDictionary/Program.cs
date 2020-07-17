using System;
using System.Collections.Generic;

namespace Ex55
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            //chave , valor
            cookies["user"] = "wesley";
            cookies["email"] = "rolim.r@icloud.com";
            cookies["phone"] = "998190737";
            cookies["phone"] = "99748085";


            Console.WriteLine(cookies["email"]);

            Console.WriteLine("phone number: " + cookies["phone"]);

            //cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("All Cookies: ");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine("Chave: " + item.Key + " | Valor: " + item.Value);
            }


        }
    }
}
