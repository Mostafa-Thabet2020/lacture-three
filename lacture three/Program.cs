using System;
/// <summary>
/// contain many classes
/// </summary>
namespace lacture_three
{
    /// <summary>
    /// contain many functions and paramters 
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            respon respon = new respon();
            #region Check password
            //Console.WriteLine("write your password");
            //string userPassword = Console.ReadLine();



            //bool IsPasswordCorrect = respon.CheckPassword(userPassword);

            //if (IsPasswordCorrect)
            //{

            //    Console.WriteLine("logged in");
            //}
            //else
            //{
            //    Console.WriteLine("password is wrong");
            //}
            #endregion

            #region Confirm password
            ////output 
            //Console.WriteLine("enter you password");
            ////input 
            //string UserPassword =respon.ConvertoCapital( Console.ReadLine());
            ////output
            //Console.WriteLine("confirm your password again");
            ////input
            //string UserConfirmPassword =respon.ConvertoCapital( Console.ReadLine());

            //bool IsPasswordConfirmed = respon.ConfirmPassword(UserPassword, UserConfirmPassword);
            //if (IsPasswordConfirmed)
            //{
            //    Console.WriteLine("password confirmed");
            //}
            //else
            //{
            //    Console.WriteLine("password is wrong");
            //}

            #endregion
            #region math class
            //int biggest=Math.Max(2, 3);
            //Console.WriteLine("biggest value is "+biggest);

            //int smallest = Math.Min(2, 3);
            //Console.WriteLine("smallest value is " + smallest);

            Console.WriteLine("enter number");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("rounded number: " + Math.Round(number));
            #endregion
        }


    }
     class respon
    {
        /// <summary>
        /// function contain block of code and return value
        /// </summary>
        // shareable +//datetype that function will return or void function will not return data +//function name
        //+arrguments that function will handle 
        public bool CheckPassword(string password)
        {
            string MainPassword = "12345";

            if (password == MainPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConfirmPassword(string password,string confirmPassword)
        {
            if (password==confirmPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ConvertoCapital(string text)
        {
            //covert to capital by to upper function
            string Capital = text.ToUpper();
            return Capital;
        }
    }
}
