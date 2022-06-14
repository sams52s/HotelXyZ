using System;

namespace HostelXyZ.LoginRegistration.Security
{
    public class AuthSecurity
    {
        public bool LoginSecurity(string Email, string Password)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                return false;
            else
            {
                if (Equals(Email, "sams52tas@gmail.com") || Equals(Password, "123"))
                    return true;
                else
                    return false;
            }
        }
    }
}