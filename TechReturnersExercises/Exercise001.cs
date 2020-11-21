using System;
using System.Collections.Generic;
using System.Reflection;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
        }

        public static String GenerateInitials(String firstName, String lastName)
        {
            return firstName.Substring(0, 1) + "." + lastName.Substring(0, 1);
        }

        public static double AddVat(double originalPrice, double vatRate)
        {
            double vat = (originalPrice / 100) * vatRate;
            return Math.Round(Convert.ToDouble(vat + originalPrice), 2);
        }

        public static String Reverse(String sentence)
        {
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int CountLinuxUsers(List<User> users)
        {
            int counter = 0;
            foreach (var user in users)
            {
                foreach (PropertyInfo prop in user.GetType().GetProperties())
                {
                    {
                        if (prop.GetValue(user, null).ToString() == "Linux")
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }
    }
}
