﻿using System;
namespace SelfTrainingProject.TechCompanion
{
    public class NewProfile
    {
        public static int UserCount;

        public static void addNewProfile()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter users first name : ");
            UserProfile.FirstName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users last name  : ");
            UserProfile.LastName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users date of birth  : ");
            UserProfile.DateOfBirth = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users E-Mail address  : ");
            UserProfile.EMailAddress = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users phone number  : ");
            UserProfile.PhoneNumber = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users address  : ");
            UserProfile.Address = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users user name  : ");
            UserProfile.UserName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users password   : ");
            UserProfile.Password = Console.ReadLine().Trim();

            UserCount++;
            Console.WriteLine("User count : " + UserCount);
            Console.WriteLine("");
        }
    }
}
