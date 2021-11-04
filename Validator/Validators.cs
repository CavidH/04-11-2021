using System;
using System.Text.RegularExpressions;
using InvalidFormatException;



namespace Validator
{
    public  class Validators
    {
        /// <summary>
        /// string tipinde qebul edir
        /// </summary>
        /// <param name="name"></param>
        /// <returns>bool</returns>
        public static bool NameValiidator(string name)
        {
            bool result = Regex.IsMatch(name.ToLower(), @"^[a-zA-Z]+$");

            if (result)
            {
                return result;

            }
            else
            {
                throw new InvalidFormatExceptions("Invalid name format");
            }
        }
        /// <summary>
        /// string tipinde qebul edir
        /// </summary>
        /// <param name="name"></param>
        /// <returns>bool</returns>
        public static bool SurNameValiidator(string name)
        {
            bool result = Regex.IsMatch(name.ToLower(), @"^[a-zA-Z]+$");

            if (result)
            {
                return result;

            }
            else
            {
                throw new InvalidFormatExceptions("Invalid Surname format");
            }
        }


        /// <summary>
        /// string tipinde mail qebul edir 
        /// ve mail olub olmadigin yoxlayir
        /// </summary>
        /// <param name="mail"></param>
        /// <returns>bool</returns>
        public static bool MailValidator(string mail)
        {
            string Pattern = @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$";
            bool Result = Regex.IsMatch(mail, Pattern);
            if (Result)
            {
                return Result;
            }
            else
            {
                throw new InvalidFormatExceptions("Invalid Mail format");
            }
        }
        /// <summary>
        /// Minimum səkkiz simvol, ən azı bir böyük hərf, bir kiçik hərf və bir rəqəm olmalidi
        /// </summary>
        /// <param name="password"></param>
        /// <returns>bool </returns>
        public static bool PasswordValidator(string password)
        {
            string Pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            bool Result = Regex.IsMatch(password, Pattern);
            if (Result)
            {
                return Result;
            }
            else
            {
                throw new InvalidFormatExceptions("Invalid Password format");
            }
        }
        /// <summary>
        /// string tipinde data qebul edir 
        /// dd.mm.yyyy  formatinda
        /// </summary>
        /// <param name="data"></param>
        /// <returns>bool</returns>
        public static bool DataValidator(string data)
        {
            string Pattern = @"^([0][1-9]|[1-2][0-9]|[3][0-1])[.]([0][1-9]|[1][0-2])[.][1-9][0-9]{3}$";
            bool Result = Regex.IsMatch(data, Pattern);
            if (Result)
            {
                return Result;
            }
            else
            {
                throw new InvalidFormatExceptions("Invalid Data format");
            }
        }
        

    }
}
