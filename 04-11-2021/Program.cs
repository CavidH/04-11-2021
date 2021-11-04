using System;
using System.Threading;
using Validator;
using _04_11_2021.Model;


namespace _04_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name=string.Empty;
            string Surname = string.Empty;
            string Mail = string.Empty;
            string Password = string.Empty;
            string Data = string.Empty;
            Start:
            try
            {
                User user = new User();
                Name = PrintAndReturn("ad daxil edin");
                Validators.NameValiidator(Name);
                user.Name = Name;
                Surname = PrintAndReturn("soyad daxil edin");
                Validators.SurNameValiidator(Surname);
                user.Surname = Name;
                Mail = PrintAndReturn("Mail daxil edin");
                Validators.MailValidator(Mail);
                user.Mail = Mail;
                Password = PrintAndReturn("Password daxil edin  Minimum səkkiz simvol, ən azı bir böyük" +
                    " hərf, bir kiçik hərf və bir rəqəm olmalidi");
                Validators.PasswordValidator(Password);
                user.Password = Password;
                Data = PrintAndReturn("Data daxil edin   dd.mm.yyyy  formatinda");
                Validators.DataValidator(Data);
                user.Data = Data;
                Console.WriteLine(user.UserInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;

            }
          




         

        }

        public static string PrintAndReturn(string output)
        {
        Start:
            try
            {
                Console.WriteLine(output);
                return Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            goto Start;

        }
    }
}
