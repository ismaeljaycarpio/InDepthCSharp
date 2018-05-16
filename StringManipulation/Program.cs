using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string originalStr = "Ismael Jay Carpio";

            //foreach (char c in originalStr)
            //{
            //    Console.WriteLine(c);
            //}

            //char[] delim = {' '};
            //string[] strArr = originalStr.Split(delim);

            //foreach(string s in strArr)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine(originalStr.Substring(1));
            //Console.WriteLine(originalStr.Length);

            string strInput = @"Username:1234\Password:abcd\Name:Ismael";
            strInput = @"Password:abcd\Name:Ismael\Username:1234";
            Console.WriteLine(strInput);
            char[] delim = {'\\'};
            string[] strArr = strInput.Split(delim);

            string strUsername = "";
            string strPassword = "";
            string strName = "";

            foreach(string s in strArr)
            {
                //username
                if(s.Contains("Username"))
                {
                    strUsername = s.Substring(s.IndexOf(':'));
                }

                //username
                if (s.Contains("Password"))
                {
                    strPassword = s.Substring(s.IndexOf(':'));
                }

                //username
                if (s.Contains("Name"))
                {
                    strName = s.Substring(s.IndexOf(':'));
                }
            }

            Console.WriteLine("Username is {0} \nPassword is {1} \nName is {2}",
                strUsername, strPassword, strName);
            Console.ReadLine();
        }
    }
}
