using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder
{
    class Program
    {
        static void Main(string[] args)
        {
            //args = new string[] { "123", "1234" };    Debug
            if (args != null)
            {
                if (args[0].ToLower() == "--help" || args[0] == "/?")
                {
                    ShowHelpHere();
                }
                else {
                    if (args.Length > 1)
                    {
                        Console.WriteLine("You have entered an invalid input, Since it " +
                            "consists of multiple parameters. \nPlease enter single parameter " +
                            "for correct results. \"");
                    }
                    else
                    {
                        CheckString(args);
                    }

                }
            }
            Console.ReadKey();
        }
        public static string ShowHelpHere()
        {
            string help = "\nNumberWorder  Version 1.0.0 released: November 09, 2017. " +
                "\nCopyright(C) AnAr Solutions Pvt.Ltd.All rights reserved. \n\nUse: " +
                "\nNumberWorder.exe IntegerNumber \n\nThe first argument for " +
                "NumberWorder is an integer number(Eg. 1234). \nYou cannot use " +
                "numbers greater than 2,147,483,647 since the range of " +
                "int datatype is -2,147,483,648 to 2,147,483,647.  " +
                "\nIf you enter input as a string or group of characters or " +
                "alpha characters, the program will assist you with a respective error " +
                "message. \nEg.If you enter multiple inputs, the error message " +
                "will be as: \n\" You have entered an invalid input, Since it " +
                "consists of multiple parameters. Please enter single parameter " +
                "for for correct results. \" ";
            Console.WriteLine(help);
            return help;
        }
        public static string NumberToWords(int numVal, string number)
        {
            // Reverse the input number
            int Reverse = 0;
            while (numVal > 0)
            {
                int remainder = numVal % 10;
                Reverse = (Reverse * 10) + remainder;
                numVal = numVal / 10;
            }
            //Console.WriteLine(Reverse);
           
            StringBuilder words = new StringBuilder();
            
            while (Reverse != 0)
            {
                switch (Reverse % 10)
                {
                    case 0:
                        words.Append("Zero ");
                        break;
                    case 1:
                        words.Append("One ");
                        break;
                    case 2:
                        words.Append("Two ");
                        break;
                    case 3:
                        words.Append("Three ");
                        break;
                    case 4:
                        words.Append("Four ");
                        break;
                    case 5:
                        words.Append("Five ");
                        break;
                    case 6:
                        words.Append("Six ");
                        break;
                    case 7:
                        words.Append("Seven ");
                        break;
                    case 8:
                        words.Append("Eight ");
                        break;
                    case 9:
                        words.Append("Nine ");
                        break;
                }

                Reverse = Reverse / 10;
            }
            Console.WriteLine("Number in words: " + words.ToString());
            return words.ToString();
        }
        public static void CheckString(string[] args) {
            int num = -1;
            if (!int.TryParse(args[0], out num))
            {
                Console.WriteLine("Input you have entered is not an integer number. " +
                    "Please enter an integer number. (Eg. 1234)!!!");
            }
            else
            {
                int numVal = Int32.Parse(args[0]);
                NumberToWords(numVal, args[0]);
            }
        }
    }
    
}
