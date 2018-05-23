using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01Week02
{
    class Program
    {
        enum Gender
        {
            Male,
            Female
        }
        private static Gender? getGender(string gender)
        {
            if (gender == "m")
            {
                return Gender.Male;
            }
            else if (gender == "f")
            {
                return Gender.Female;
            }
            else return null;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your birthdate and gender as follows:");

            Console.WriteLine("Day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Gender m/f:");
            Gender? gender = getGender(Console.ReadLine());

            DateTime birthDay = new DateTime(year, month, day);
            var now = DateTime.Now;
            var age = now.Year - year;
            if (now.Month <= month && now.Day < day)
            {
                age--;
            }
            Console.WriteLine($"You are a {gender} Your birthdate is:{birthDay} and you are {age} years old.");

            if (gender.HasValue)
            {
                if (gender == Gender.Female)
                {
                    if (age > 63)
                    {
                        Console.WriteLine("You are retired!");
                    }
                    else
                    {
                        Console.WriteLine($"You will retire in {63 - age} years.");
                    }
                }
                else
                {
                    if (age > 65)
                    {
                        Console.WriteLine("You are retired!");
                    }
                    else
                    {
                        Console.WriteLine($"You will retire in {65 - age} years.");
                    }
                }
            }
            else
            {
                Console.WriteLine("You did not enter your gender properly!");
            }
        }
    }
}

