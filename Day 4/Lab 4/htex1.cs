using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class htex1
    {
        public static void Main()
        {
            Hashtable users = new Hashtable();
            users.Add("Kabir", "Ahmed");
            users.Add("Sameer", "Ahamed");
            users.Add("Rajini", "Kanth");
            users.Add("Kamal", "Hassan");
            Console.WriteLine("Enter the username: ");
            string username=Console.ReadLine();
            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                string storedpassword = users[username].ToString();
                if (storedpassword == password)
                {
                    Console.WriteLine("Login Successfull");
                }
                else
                {
                    Console.WriteLine("Login failure");
                }
            }
            else
            {
                Console.WriteLine("User not found......");
            }

        }
    }
}
